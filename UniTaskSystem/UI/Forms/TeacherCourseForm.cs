using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniTaskSystem.Services;
using System.IO;
using System.Diagnostics;
using UniTaskSystem.UI.UI_Theme;


namespace UniTaskSystem.UI.Forms
{
    public partial class TeacherCourseForm : Form
    {
        private readonly string _teacherId;
        private readonly int _offeringId;
        private DataTable _gradesDt;
        private readonly TeacherService _svc = new TeacherService();

        private List<string> _pickedFiles =
            new List<string>();

        private DataTable _subsDt;

        // إدارة درجات الطلاب
        private BindingSource _gradesBs;

        public TeacherCourseForm(string teacherId, int offeringId)
        {
            InitializeComponent();
            _teacherId = teacherId;
            _offeringId = offeringId;
        }

        private void TeacherCourseForm_Load(object sender, EventArgs e)
        {
            Theme.ApplyForm(this);
            Theme.StyleGrid(dgvGrades);
            Theme.StyleGrid(dgvPlan);
            Theme.StyleGrid(dgvSubs);
            LoadHeader();
            cmbPostType.Items.Clear();
            cmbPostType.Items.Add("مهمة");
            cmbPostType.Items.Add("مقرر");
            cmbPostType.Items.Add("نماذج");
            cmbPostType.SelectedIndex = 0;
            chkDeadline.Checked = true;
            LoadTasksCombo();
            LoadGrades();
            EnsureStudentWorkButtonColumn();
            LoadPlan();

            // عناصر إدارة المنشورات والبحث صارت Design-Time داخل الـ Designer
            InitializeTeacherDesignerDefaults();
            LoadPosts();
        }


        private void LoadHeader()
        {
            DataTable dt = _svc.GetOfferingHeader(_offeringId);
            if (dt.Rows.Count == 0) return;

            var r = dt.Rows[0];
            lblHeader.Text = $"{r["CourseName"]} ({r["Code"]}) - {r["OfferingType"]}";
        }

        private void btnAddAttach_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true;
            if (ofd.ShowDialog() != DialogResult.OK) return;

            foreach (string f in ofd.FileNames)
            {
                _pickedFiles.Add(f);
                lstAttach.Items.Add(Path.GetFileName(f));
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string type = cmbPostType.SelectedItem.ToString();
                string title = txtTitle.Text.Trim();
                string body = rtbBody.Text;

                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("اكتب عنوان الرسالة");
                    return;
                }

                DateTime? dl = null;
                if (chkDeadline.Checked) dl = dtpDeadline.Value;

                int postId = _svc.CreatePost(_offeringId, type, title, body, dl, _teacherId);

                // حفظ المرفقات (نسخها لمجلد ثابت + إدخالها في DB)
                string destDir = Path.Combine(@"C:\UniTaskSystem\PostAttachments", postId.ToString());
                Directory.CreateDirectory(destDir);

                foreach (string src in _pickedFiles)
                {
                    string fileName = Path.GetFileName(src);
                    string destPath = Path.Combine(destDir, fileName);
                    destPath = MakeUniquePath(destPath);

                    File.Copy(src, destPath, true);

                    var fi = new FileInfo(destPath);
                    _svc.AddPostAttachment(postId, fi.Name, destPath, null, fi.Length);
                }

                MessageBox.Show("تم الإرسال ✅");
                txtTitle.Clear();
                rtbBody.Clear();
                lstAttach.Items.Clear();
                _pickedFiles.Clear();

                // تحديث قائمة المهام في تبويب الاستقبال إذا كانت مهمة
                if (type == "مهمة")
                    LoadTasksCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string MakeUniquePath(string path)
        {
            if (!File.Exists(path)) return path;

            string dir = Path.GetDirectoryName(path);
            string name = Path.GetFileNameWithoutExtension(path);
            string ext = Path.GetExtension(path);

            int i = 1;
            while (true)
            {
                string p = Path.Combine(dir, name + "_" + i + ext);
                if (!File.Exists(p)) return p;
                i++;
            }
        }

        private void LoadTasksCombo()
        {
            var dt = _svc.GetCourseTasks(_offeringId);
            cmbTasks.DisplayMember = "Title";
            cmbTasks.ValueMember = "PostId";
            cmbTasks.DataSource = dt;

            if (dt.Rows.Count > 0)
                cmbTasks.SelectedIndex = 0;
        }

        private void cmbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubmissions();
        }

        private void LoadSubmissions()
        {
            if (cmbTasks.SelectedValue == null) return;

            int postId = Convert.ToInt32(cmbTasks.SelectedValue);
            _subsDt = _svc.GetSubmissionsForPost(postId);

            dgvSubs.DataSource = _subsDt;
            dgvSubs.ReadOnly = true;
            dgvSubs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubs.AllowUserToAddRows = false;

            if (dgvSubs.Columns["SubmissionId"] != null)
                dgvSubs.Columns["SubmissionId"].Visible = false;
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            if (dgvSubs.CurrentRow == null) return;

            int submissionId = Convert.ToInt32(dgvSubs.CurrentRow.Cells["SubmissionId"].Value);
            var f = new GradeSubmissionForm(_teacherId, submissionId);
            f.ShowDialog();
            LoadGrades();
            // بعد التصحيح لا يلزم تحديث هنا، لكن ممكن
            LoadSubmissions();
        }
        private void LoadGrades()
        {
            _gradesDt = _svc.GetGradeSheet(_offeringId);
            _gradesBs = new BindingSource { DataSource = _gradesDt };
            dgvGrades.DataSource = _gradesBs;
            EnsureStudentWorkButtonColumn();
            dgvGrades.Columns["السقف"].DisplayIndex = 2;
            dgvGrades.Columns["السقف"].ReadOnly = true;
            dgvGrades.AllowUserToAddRows = false;
            dgvGrades.RowHeadersVisible = false;
            dgvGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // أعمدة قراءة فقط
            dgvGrades.Columns["الرقم_الجامعي"].ReadOnly = true;
            dgvGrades.Columns["اسم_الطالب"].ReadOnly = true;
            dgvGrades.Columns["التكاليف"].ReadOnly = true; // محسوبة من تصحيح المهام
            dgvGrades.Columns["المجموع"].ReadOnly = true;  // محسوب

            // أعمدة قابلة للتعديل
            dgvGrades.Columns["الحضور"].ReadOnly = false;
            dgvGrades.Columns["النصفي"].ReadOnly = false;
            dgvGrades.Columns["النهائي"].ReadOnly = false;

            // تنسيق بسيط
            dgvGrades.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvGrades.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

private void InitializeTeacherDesignerDefaults()
{
    if (cmbPostTypeFilter != null && cmbPostTypeFilter.Items.Count > 0 && cmbPostTypeFilter.SelectedIndex < 0)
        cmbPostTypeFilter.SelectedIndex = 0;

    if (cmbEditType != null && cmbEditType.Items.Count > 0 && cmbEditType.SelectedIndex < 0)
        cmbEditType.SelectedIndex = 0;

    if (chkEditDeadline != null)
        dtpEditDeadline.Enabled = chkEditDeadline.Checked;

    if (dgvPosts != null)
    {
        Theme.StyleGrid(dgvPosts);
        dgvPosts.ReadOnly = true;
        dgvPosts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPosts.MultiSelect = false;
        dgvPosts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPosts.AllowUserToAddRows = false;
        dgvPosts.AllowUserToDeleteRows = false;
    }

    ClearPostEditor();
}

// ====== أحداث المصمم (Designer) ======
private void txtGradeSearch_TextChanged(object sender, EventArgs e)
{
    if (_gradesBs == null) return;

    string q = (txtGradeSearch.Text ?? "").Replace("'", "''").Trim();
    if (q == "")
        _gradesBs.RemoveFilter();
    else
        _gradesBs.Filter = $"Convert([الرقم_الجامعي], 'System.String') LIKE '%{q}%' OR [اسم_الطالب] LIKE '%{q}%'";
}

private void PostFilters_Changed(object sender, EventArgs e) => LoadPosts();
private void btnRefreshPosts_Click(object sender, EventArgs e) => LoadPosts();
private void dgvPosts_SelectionChanged(object sender, EventArgs e) => LoadSelectedPostToEditor();

private void chkEditDeadline_CheckedChanged(object sender, EventArgs e)
{
    dtpEditDeadline.Enabled = chkEditDeadline.Checked;
}

private void btnUpdatePost_Click(object sender, EventArgs e) => UpdateSelectedPost();
private void btnDeletePost_Click(object sender, EventArgs e) => DeleteSelectedPost();
private void btnViewPostAttachments_Click(object sender, EventArgs e) => ViewSelectedPostAttachments();
private void btnClearPost_Click(object sender, EventArgs e) => ClearPostEditor();















        private void UpdateSelectedPost()
        {
            try
            {
                int postId = GetEditorPostId();
                if (postId == 0)
                {
                    MessageBox.Show("اختر منشوراً من القائمة أولاً.");
                    return;
                }

                string type = cmbEditType.SelectedItem.ToString();
                string title = (txtEditTitle.Text ?? "").Trim();
                string body = rtbEditBody.Text;
                DateTime? dl = chkEditDeadline.Checked ? (DateTime?)dtpEditDeadline.Value : null;

                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("اكتب عنواناً.");
                    return;
                }

                _svc.UpdatePost(postId, _teacherId, _offeringId, type, title, body, dl);
                MessageBox.Show("تم تحديث المنشور ✅");
                LoadPosts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteSelectedPost()
        {
            try
            {
                int postId = GetEditorPostId();
                if (postId == 0)
                {
                    MessageBox.Show("اختر منشوراً من القائمة أولاً.");
                    return;
                }

                if (MessageBox.Show("هل أنت متأكد من حذف هذا المنشور؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                _svc.DeletePost(postId, _teacherId, _offeringId);
                MessageBox.Show("تم الحذف ✅");
                ClearPostEditor();
                LoadPosts();
                LoadTasksCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewSelectedPostAttachments()
        {
            try
            {
                int postId = GetEditorPostId();
                if (postId == 0)
                {
                    MessageBox.Show("اختر منشوراً أولاً.");
                    return;
                }

                var dt = _svc.GetPostAttachments(postId);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد مرفقات.");
                    return;
                }

                var f = new AttachmentsViewerForm(dt);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        
private void LoadPosts()
{
    if (dgvPosts == null) return;

    string q = (txtPostSearch?.Text ?? "").Trim();
    string type = (cmbPostTypeFilter?.SelectedItem ?? "الكل").ToString();
    if (type == "الكل") type = null;

    dgvPosts.DataSource = _svc.GetOfferingPosts(_offeringId, _teacherId, q, type);

    if (dgvPosts.Columns["PostId"] != null) dgvPosts.Columns["PostId"].Visible = false;
    if (dgvPosts.Columns["CreatedAt"] != null) dgvPosts.Columns["CreatedAt"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
    if (dgvPosts.Columns["Deadline"] != null) dgvPosts.Columns["Deadline"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
}

        private void LoadSelectedPostToEditor()
        {
            if (dgvPosts == null || dgvPosts.CurrentRow == null) return;
            if (dgvPosts.CurrentRow.Cells["PostId"]?.Value == null) return;

            int postId = Convert.ToInt32(dgvPosts.CurrentRow.Cells["PostId"].Value);
            var dt = _svc.GetPostDetails(postId);
            if (dt.Rows.Count == 0) return;

            var r = dt.Rows[0];

            lblPostId.Tag = postId;
            lblPostId.Text = postId.ToString();

            string t = r["PostType"].ToString();
            int idx = cmbEditType.Items.IndexOf(t);
            cmbEditType.SelectedIndex = idx >= 0 ? idx : 0;

            txtEditTitle.Text = r["Title"].ToString();
            rtbEditBody.Text = r["Body"] == DBNull.Value ? "" : r["Body"].ToString();

            if (r["Deadline"] == DBNull.Value)
            {
                chkEditDeadline.Checked = false;
                dtpEditDeadline.Enabled = false;
            }
            else
            {
                chkEditDeadline.Checked = true;
                dtpEditDeadline.Enabled = true;
                dtpEditDeadline.Value = Convert.ToDateTime(r["Deadline"]);
            }
        }

        private int GetEditorPostId()
        {
            if (lblPostId?.Tag == null) return 0;
            int id;
            return int.TryParse(lblPostId.Tag.ToString(), out id) ? id : 0;
        }

        private void ClearPostEditor()
        {
            if (lblPostId != null)
            {
                lblPostId.Tag = null;
                lblPostId.Text = "-";
            }

            if (cmbEditType != null && cmbEditType.Items.Count > 0) cmbEditType.SelectedIndex = 0;
            txtEditTitle?.Clear();
            rtbEditBody?.Clear();

            if (chkEditDeadline != null)
            {
                chkEditDeadline.Checked = true;
                dtpEditDeadline.Enabled = true;
            }
        }

        private void dgvGrades_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // فقط لو تغيّر حضور/نصفي/نهائي
            string col = dgvGrades.Columns[e.ColumnIndex].Name;
            if (col != "الحضور" && col != "النصفي" && col != "النهائي") return;

            var row = dgvGrades.Rows[e.RowIndex];

            int att = ToInt(row.Cells["الحضور"].Value);
            int tasks = ToInt(row.Cells["التكاليف"].Value);
            int mid = ToInt(row.Cells["النصفي"].Value);
            int fin = ToInt(row.Cells["النهائي"].Value);

            row.Cells["المجموع"].Value = att + tasks + mid + fin;
        }

        private int ToInt(object v)
        {
            if (v == null || v == DBNull.Value) return 0;
            int x;
            return int.TryParse(v.ToString(), out x) ? x : 0;
        }
        private decimal? ToNullableDecimal(object v)
        {
            if (v == null || v == DBNull.Value) return null;
            var s = v.ToString().Trim();
            if (s == "") return null;
            decimal d;
            return decimal.TryParse(s, out d) ? d : (decimal?)null;
        }
        private void dgvGrades_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvGrades.IsCurrentCellDirty)
                dgvGrades.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnSaveGrades_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvGrades.Rows)
                {
                    string studentId = row.Cells["الرقم_الجامعي"].Value.ToString();

                    decimal? att = ToNullableDecimal(row.Cells["الحضور"].Value);
                    decimal? mid = ToNullableDecimal(row.Cells["النصفي"].Value);
                    decimal? fin = ToNullableDecimal(row.Cells["النهائي"].Value);

                    // تحقق بسيط: لا سالب
                    if ((att.HasValue && att.Value < 0) || (mid.HasValue && mid.Value < 0) || (fin.HasValue && fin.Value < 0))
                    {
                        MessageBox.Show("لا يمكن إدخال قيم سالبة.");
                        return;
                    }

                    _svc.UpsertTermScores(studentId, _offeringId, att, mid, fin);
                }

                MessageBox.Show("تم حفظ الدرجات ✅");

                // إعادة تحميل للتأكد من التحديث
                LoadGrades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvGrades_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string col = dgvGrades.Columns[e.ColumnIndex].Name;
            if (col != "الحضور" && col != "النصفي" && col != "النهائي") return;

            // السماح بالفراغ -> يعتبر 0
            string txt = (e.FormattedValue ?? "").ToString().Trim();
            if (txt == "")
                return;

            int value;
            if (!int.TryParse(txt, out value) || value < 0)
            {
                MessageBox.Show("أدخل رقم صحيح (0 أو أكثر).");
                e.Cancel = true;
                return;
            }
            // التحقق من السقف بعد إدخال القيمة
            var row = dgvGrades.Rows[e.RowIndex];

            int att = (col == "الحضور") ? value : ToInt(row.Cells["الحضور"].Value);
            int tasks = ToInt(row.Cells["التكاليف"].Value);
            int mid = (col == "النصفي") ? value : ToInt(row.Cells["النصفي"].Value);
            int fin = (col == "النهائي") ? value : ToInt(row.Cells["النهائي"].Value);

            int total = att + tasks + mid + fin;
            int maxTotal = ToInt(row.Cells["السقف"].Value);

            if (maxTotal > 0 && total > maxTotal)
            {
                MessageBox.Show("المجموع تجاوز سقف المادة (" + maxTotal + ").");
                e.Cancel = true;
                return;
            }
        }

        private void dgvGrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvGrades.Columns[e.ColumnIndex].Name == "btnWork")
            {
                string studentId = dgvGrades.Rows[e.RowIndex].Cells["الرقم_الجامعي"].Value.ToString();

                var f = new TeacherStudentWorkForm(_teacherId, _offeringId, studentId);
                f.ShowDialog();

                // بعد ما يرجع من التصحيح، حدث الجدول (التكاليف قد تتغير)
                LoadGrades();
                EnsureStudentWorkButtonColumn();
            }
        }

        private void EnsureStudentWorkButtonColumn()
        {
            if (dgvGrades.Columns["btnWork"] != null) return;

            var col = new DataGridViewButtonColumn();
            col.Name = "btnWork";
            col.HeaderText = "أعمال";
            col.Text = "عرض";
            col.UseColumnTextForButtonValue = true;
            col.Width = 70;

            dgvGrades.Columns.Insert(0, col);
        }
        private void LoadPlan()
        {
            dgvPlan.DataSource = _svc.GetLecturePlan(_offeringId);

            // إخفاء PlanLectureId (تقني)
            if (dgvPlan.Columns["PlanLectureId"] != null)
                dgvPlan.Columns["PlanLectureId"].Visible = false;

            // تنسيق التاريخ
            if (dgvPlan.Columns["وقت_الشرح"] != null)
                dgvPlan.Columns["وقت_الشرح"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            dgvPlan.ReadOnly = true;
            dgvPlan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlan.AllowUserToAddRows = false;

            LoadPlanStatsUI();
        }
        private void LoadPlanStatsUI()
        {
            var dt = _svc.GetPlanStats(_offeringId);
            if (dt.Rows.Count == 0) return;

            int plannedTotal = ToInt(dt.Rows[0]["PlannedTotal"]);
            int plannedCovered = ToInt(dt.Rows[0]["PlannedCovered"]);
            int extraTotal = ToInt(dt.Rows[0]["ExtraTotal"]);

            int remaining = plannedTotal - plannedCovered;
            if (remaining < 0) remaining = 0;

            lblPlanStats.Text = $"     عدد المحاضرات المقررة:{plannedTotal}              تم شرح :{plannedCovered}             المتبقي: {remaining}                   إضافية: {extraTotal}";

            prgPlan.Minimum = 0;
            prgPlan.Maximum = plannedTotal > 0 ? plannedTotal : 1;
            prgPlan.Value = plannedTotal > 0 ? Math.Min(plannedCovered, plannedTotal) : 0;
        }

        private void btnMarkCovered_Click(object sender, EventArgs e)
        {
            if (dgvPlan.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvPlan.CurrentRow.Cells["PlanLectureId"].Value);
            _svc.SetLectureCovered(id, true, _teacherId);

            LoadPlan();
        }

        private void btnUnmarkCovered_Click(object sender, EventArgs e)
        {
            if (dgvPlan.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvPlan.CurrentRow.Cells["PlanLectureId"].Value);
            _svc.SetLectureCovered(id, false, _teacherId);

            LoadPlan();
        }

        private void btnRefreshPlan_Click(object sender, EventArgs e)
        {
            LoadPlan();
        }
        private void btnAddExtraLecture_Click(object sender, EventArgs e)
        {
            var f = new AddLectureForm();
            if (f.ShowDialog() != DialogResult.OK) return;

            _svc.AddExtraLecture(_offeringId, f.LectureTitle, f.LectureContent, _teacherId);

            LoadPlan();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

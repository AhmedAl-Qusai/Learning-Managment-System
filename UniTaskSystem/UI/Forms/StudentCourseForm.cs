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
using System.Diagnostics;
using System.IO;
using UniTaskSystem.UI.UI_Theme;


namespace UniTaskSystem.UI.Forms
{
    public partial class StudentCourseForm : Form
    {
        private readonly string _studentId;
        private readonly int _offeringId;
        private int _openPostId = 0;
        private readonly StudentService _svc = new StudentService();

        private DataTable _dtTasks;
        private DataTable _dtSyllabus;
        private DataTable _dtModels;

        private BindingSource _bsTasks;
        private BindingSource _bsSyllabus;
        private BindingSource _bsModels;

        public StudentCourseForm(string studentId, int offeringId)
        {
            InitializeComponent();
            _studentId = studentId;
            _offeringId = offeringId;
        }
        public StudentCourseForm(string studentId, int offeringId, int openPostId)
        {
            InitializeComponent();
            _studentId = studentId;
            _offeringId = offeringId;
            _openPostId = openPostId;
        }

        private void StudentCourseForm_Load(object sender, EventArgs e)
        {
            Theme.ApplyForm(this);
            Theme.StyleGrid(dgvModels);
            Theme.StyleGrid(dgvPlanStudent);
            Theme.StyleGrid(dgvSyllabus);
            Theme.StyleGrid(dgvTasks);
            LoadHeader();
            InitSearchUI();
            LoadTasks();
            OpenTaskIfNeeded();
            LoadPlanStudent();
            LoadMaterialContent();

        }

        private void InitSearchUI()
        {
            // إضافة شريط بحث بسيط لكل تبويب دون لمس المصمم
            AddSearchBar(tabTasks, dgvTasks, () => _bsTasks);
            AddSearchBar(tabSyllabus, dgvSyllabus, () => _bsSyllabus);
            AddSearchBar(tabModels, dgvModels, () => _bsModels);
        }

        private void AddSearchBar(TabPage tab, DataGridView grid, Func<BindingSource> getBs)
        {
            if (tab == null || grid == null) return;

            // إن تمت الإضافة مسبقاً
            if (tab.Controls.OfType<Panel>().Any(p => (p.Tag as string) == "searchbar"))
                return;

            var pnl = new Panel();
            pnl.Tag = "searchbar";
            pnl.Height = 38;
            pnl.Dock = DockStyle.Top;
            pnl.Padding = new Padding(8, 6, 8, 6);
            pnl.BackColor = Color.FromArgb(245, 247, 250);

            var lbl = new Label();
            lbl.AutoSize = true;
            lbl.Text = "بحث:";
            lbl.Dock = DockStyle.Right;
            lbl.TextAlign = ContentAlignment.MiddleRight;

            var txt = new TextBox();
            txt.Width = 260;
            txt.Dock = DockStyle.Right;
            txt.Margin = new Padding(8, 0, 8, 0);

            var btnClear = new Button();
            btnClear.Text = "مسح";
            btnClear.Width = 80;
            btnClear.Dock = DockStyle.Right;

            pnl.Controls.Add(btnClear);
            pnl.Controls.Add(txt);
            pnl.Controls.Add(lbl);

            // تحريك الجدول للأسفل بدون تغيير المصمم
            grid.Top += pnl.Height;
            grid.Height = Math.Max(50, grid.Height - pnl.Height);

            tab.Controls.Add(pnl);
            pnl.BringToFront();

            txt.TextChanged += (s, e) => ApplyGridFilter(tab, grid, getBs == null ? null : getBs(), txt.Text);
            btnClear.Click += (s, e) => txt.Clear();
        }

        private void ApplyGridFilter(TabPage tab, DataGridView grid, BindingSource bs, string q)
        {
            if (bs == null) return;
            string safe = (q ?? "").Replace("'", "''").Trim();

            // الأعمدة المشتركة هنا اسمها "العنوان" في كل جداول هذا الفورم
            if (string.IsNullOrWhiteSpace(safe))
            {
                bs.RemoveFilter();
                return;
            }

            // استخدام LIKE على العنوان
            bs.Filter = $"[العنوان] LIKE '%{safe}%'";
        }
        private void OpenTaskIfNeeded()
        {
            if (_openPostId == 0) return;

            // انقل المستخدم لتبويب المهام
            tabCourse.SelectedTab = tabTasks;

            // افتح المهمة مباشرة
            var f = new StudentTaskDetailsForm(_studentId, _openPostId);
            f.ShowDialog();

            _openPostId = 0;
        }

        private void LoadHeader()
        {
            DataTable dt = _svc.GetCourseHeader(_offeringId);
            if (dt.Rows.Count == 0) return;

            var r = dt.Rows[0];
            string courseName = r["CourseName"].ToString();
            string code = r["Code"].ToString();
            string type = r["OfferingType"].ToString();
            string teacher = r["TeacherName"].ToString();

            lblHeader.Text = $"{courseName} ({code}) - {type}\nالمدرس: {teacher}";
        }

        private void LoadTasks()
        {
            _dtTasks = _svc.GetCourseTasks(_offeringId);
            _bsTasks = new BindingSource { DataSource = _dtTasks };
            dgvTasks.DataSource = _bsTasks;
            if (dgvTasks.Columns["PostId"] != null)
                dgvTasks.Columns["PostId"].Visible = false;
        }

        private void LoadMaterials()
        {
            dgvSyllabus.DataSource = _svc.GetCourseMaterials(_offeringId);
            if (dgvSyllabus.Columns["PostId"] != null)
                dgvSyllabus.Columns["PostId"].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int postId = Convert.ToInt32(dgvTasks.Rows[e.RowIndex].Cells["PostId"].Value);

            var f = new StudentTaskDetailsForm(_studentId, postId);
            f.ShowDialog();

            // بعد الرجوع يمكن تحديث عرض المهام لو رغبت
        }
        private void LoadPlanStudent()
        {
            dgvPlanStudent.DataSource = _svc.GetLecturePlanForStudent(_offeringId);

            dgvPlanStudent.ReadOnly = true;
            dgvPlanStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlanStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlanStudent.AllowUserToAddRows = false;
            dgvPlanStudent.RowHeadersVisible = false;

            if (dgvPlanStudent.Columns["وقت_الشرح"] != null)
                dgvPlanStudent.Columns["وقت_الشرح"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            // تلوين الصفوف: المشروح أخضر / غير المشروح أحمر خفيف
            foreach (DataGridViewRow row in dgvPlanStudent.Rows)
            {
                bool covered = false;
                object v = row.Cells["تم_شرحها"].Value;
                if (v != null && v != DBNull.Value)
                    covered = Convert.ToBoolean(v);

                row.DefaultCellStyle.BackColor = covered
                    ? Color.Honeydew
                    : Color.MistyRose;
            }

            LoadPlanStatsStudentUI();
        }
        private void LoadPlanStatsStudentUI()
        {
            var dt = _svc.GetPlanStatsForStudent(_offeringId);
            if (dt.Rows.Count == 0) return;

            int plannedTotal = ToInt(dt.Rows[0]["PlannedTotal"]);
            int plannedCovered = ToInt(dt.Rows[0]["PlannedCovered"]);
            int extraTotal = ToInt(dt.Rows[0]["ExtraTotal"]);

            int remaining = plannedTotal - plannedCovered;
            if (remaining < 0) remaining = 0;


            lblPlanStatsStudent.Text = $"     عدد المحاضرات المقررة:{plannedTotal}              تم شرح :{plannedCovered}             المتبقي: {remaining}                   إضافية: {extraTotal}";
            
            prgPlanStudent.Minimum = 0;
            prgPlanStudent.Maximum = plannedTotal > 0 ? plannedTotal : 1;
            prgPlanStudent.Value = plannedTotal > 0 ? Math.Min(plannedCovered, plannedTotal) : 0;
        }
        private int ToInt(object v)
        {
            if (v == null || v == DBNull.Value) return 0;
            int x;
            return int.TryParse(v.ToString(), out x) ? x : 0;
        }

        private void dgvPlanStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string title = dgvPlanStudent.Rows[e.RowIndex].Cells["عنوان"].Value.ToString();
            string content = dgvPlanStudent.Rows[e.RowIndex].Cells["محتوى"].Value.ToString();
            string covered = dgvPlanStudent.Rows[e.RowIndex].Cells["تم_شرحها"].Value.ToString();

            MessageBox.Show(content, title);
        }
        private void LoadMaterialContent()
        {
            _dtSyllabus = _svc.GetSyllabusPosts(_offeringId);
            _dtModels = _svc.GetModelPosts(_offeringId);

            _bsSyllabus = new BindingSource { DataSource = _dtSyllabus };
            _bsModels = new BindingSource { DataSource = _dtModels };

            dgvSyllabus.DataSource = _bsSyllabus;
            dgvModels.DataSource = _bsModels;

            // إخفاء PostId
            if (dgvSyllabus.Columns["PostId"] != null) dgvSyllabus.Columns["PostId"].Visible = false;
            if (dgvModels.Columns["PostId"] != null) dgvModels.Columns["PostId"].Visible = false;

            // تنسيق تاريخ
            if (dgvSyllabus.Columns["التاريخ"] != null)
                dgvSyllabus.Columns["التاريخ"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            if (dgvModels.Columns["التاريخ"] != null)
                dgvModels.Columns["التاريخ"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
        }
        private void btnOpenSyllabus_Click(object sender, EventArgs e)
        {
            if (dgvSyllabus.CurrentRow == null) return;

            string title = dgvSyllabus.CurrentRow.Cells["العنوان"].Value.ToString();
            string body = dgvSyllabus.CurrentRow.Cells["المحتوى"].Value.ToString();

            MessageBox.Show(body, title);
        }
        private void btnOpenModel_Click(object sender, EventArgs e)
        {
            if (dgvModels.CurrentRow == null) return;

            string title = dgvModels.CurrentRow.Cells["العنوان"].Value.ToString();
            string body = dgvModels.CurrentRow.Cells["المحتوى"].Value.ToString();

            MessageBox.Show(body, title);
        }
        private void btnOpenSyllabusAttachments_Click(object sender, EventArgs e)
        {
            if (dgvSyllabus.CurrentRow == null) return;

            int postId = Convert.ToInt32(dgvSyllabus.CurrentRow.Cells["PostId"].Value);
            var dt = _svc.GetPostAttachments(postId);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد مرفقات.");
                return;
            }

            var f = new AttachmentsViewerForm(dt);
            f.ShowDialog();
        }
        private void btnOpenModelAttachments_Click(object sender, EventArgs e)
        {
            if (dgvModels.CurrentRow == null) return;

            int postId = Convert.ToInt32(dgvModels.CurrentRow.Cells["PostId"].Value);
            var dt = _svc.GetPostAttachments(postId);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد مرفقات.");
                return;
            }

            var f = new AttachmentsViewerForm(dt);
            f.ShowDialog();
        }
    }
}

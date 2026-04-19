
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
using UniTaskSystem.UI.UI_Theme;
namespace UniTaskSystem.UI.Forms
{
    public partial class StudentMainForm : Form
    {
        private readonly int _userId;
        private readonly string _studentId;
        public StudentMainForm(int userId, string studentId)
        {
            InitializeComponent();
            _userId = userId;
            _studentId = studentId;
        }

        private bool _infoOpen = false;

        private void btnInfo_Click(object sender, EventArgs e)
        {
            _infoOpen = !_infoOpen;
            tmrSlide.Start();
        }

        private void tmrSlide_Tick(object sender, EventArgs e)
        {
            int targetWidth = 320; // عرض اللوحة عند الفتح
            int step = 20;

            if (_infoOpen)
            {
                if (pnlInfo.Width < targetWidth)
                    pnlInfo.Width += step;
                else
                    tmrSlide.Stop();
            }
            else
            {
                if (pnlInfo.Width > 0)
                    pnlInfo.Width -= step;
                else
                    tmrSlide.Stop();
            }
        }

        private StudentService _svc = new StudentService();

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            Theme.ApplyForm(this);
            Theme.StyleGrid(dgvDaily);
            Theme.StyleGrid(dgvTermWork);
            Theme.StyleGrid(dgvAch);
            Theme.StyleGrid(dgvStudentNotifs);
            LoadStudentInfo();
            StyleDailyGrid();
            LoadDailyTasks();
            LoadCourses();
            StyleTermWorkGrid();
            LoadTermWork();
            StyleAchGrid();
            LoadAchievements();
            LoadStudentNotifications();


        }

        private void LoadStudentInfo()
        {
            DataTable dt = _svc.GetStudentInfo(_studentId);
            if (dt.Rows.Count == 0) return;

            var r = dt.Rows[0];

            lblNameValue.Text = r["FullName"].ToString();
            // أضف Labels حسب اللي سميتها:
            // مثال:
             lblIdValue.Text = r["UniversityStudentId"].ToString();
             lblMajorValue.Text = r["MajorName"].ToString();
             lblDeptValue.Text = r["DepartmentName"].ToString();
             lblLevelValue.Text = r["LevelNo"].ToString();
             lblTermValue.Text = r["TermName"].ToString();
        }

        private void LoadDailyTasks()
        {
            dgvDaily.DataSource = _svc.GetUnreadDailyTasks(_studentId);

            // إخفاء الأعمدة التقنية
            if (dgvDaily.Columns["PostId"] != null)
                dgvDaily.Columns["PostId"].Visible = false;

            if (dgvDaily.Columns["OfferingId"] != null)
                dgvDaily.Columns["OfferingId"].Visible = false;

            // إعادة تسمية رؤوس الأعمدة (إذا احتجت)
            if (dgvDaily.Columns["المادة"] != null) dgvDaily.Columns["المادة"].HeaderText = "المادة";
            if (dgvDaily.Columns["النوع"] != null) dgvDaily.Columns["النوع"].HeaderText = "نظري/عملي";
            if (dgvDaily.Columns["الأستاذ"] != null) dgvDaily.Columns["الأستاذ"].HeaderText = "الأستاذ";
            if (dgvDaily.Columns["العنوان"] != null) dgvDaily.Columns["العنوان"].HeaderText = "عنوان المهمة";
            if (dgvDaily.Columns["الموعد"] != null) dgvDaily.Columns["الموعد"].HeaderText = "Deadline";
            if (dgvDaily.Columns["تاريخ_الإرسال"] != null) dgvDaily.Columns["تاريخ_الإرسال"].HeaderText = "تاريخ الإرسال";

            // تنسيق التاريخ (لو كان موجود)
            if (dgvDaily.Columns["الموعد"] != null)
                dgvDaily.Columns["الموعد"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            if (dgvDaily.Columns["تاريخ_الإرسال"] != null)
                dgvDaily.Columns["تاريخ_الإرسال"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            // ترتيب عرض الأعمدة (اختياري)
            // الهدف: المادة - النوع - عنوان المهمة - الأستاذ - الموعد - تاريخ الإرسال
            if (dgvDaily.Columns["المادة"] != null) dgvDaily.Columns["المادة"].DisplayIndex = 0;
            if (dgvDaily.Columns["النوع"] != null) dgvDaily.Columns["النوع"].DisplayIndex = 1;
            if (dgvDaily.Columns["العنوان"] != null) dgvDaily.Columns["العنوان"].DisplayIndex = 2;
            if (dgvDaily.Columns["الأستاذ"] != null) dgvDaily.Columns["الأستاذ"].DisplayIndex = 3;
            if (dgvDaily.Columns["الموعد"] != null) dgvDaily.Columns["الموعد"].DisplayIndex = 4;
            if (dgvDaily.Columns["تاريخ_الإرسال"] != null) dgvDaily.Columns["تاريخ_الإرسال"].DisplayIndex = 5;

            // لو ما فيه بيانات: رسالة بسيطة
            if (dgvDaily.Rows.Count == 0)
            {
                // اختياري: تظهر رسالة أو تتركه فاضي
                 //MessageBox.Show("لا توجد مهام جديدة");
            }
            if (dgvDaily.Columns["الموعد"] != null)
            {
                foreach (DataGridViewRow row in dgvDaily.Rows)
                {
                    if (row.Cells["الموعد"].Value != null && row.Cells["الموعد"].Value != DBNull.Value)
                    {
                        DateTime dl = Convert.ToDateTime(row.Cells["الموعد"].Value);
                        if (DateTime.Now > dl)
                            row.DefaultCellStyle.BackColor =Color.MistyRose;
                    }
                }
            }

        }
        private void dgvDaily_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int postId = Convert.ToInt32(dgvDaily.Rows[e.RowIndex].Cells["PostId"].Value);
            int offeringId = Convert.ToInt32(dgvDaily.Rows[e.RowIndex].Cells["OfferingId"].Value);

            // 1) نعلّمها مقروءة (فتختفي من هنا)
            _svc.MarkDailyTaskAsRead(postId, _studentId);

            // 2) نفتح واجهة المادة الخاصة بهذه المهمة ثم تفتح المهمة داخلها
            var f = new StudentCourseForm(_studentId, offeringId, postId);
            f.ShowDialog();

            // 3) نعيد تحميل قائمة المهام اليومية العامة
            LoadDailyTasks();
        }

        private void LoadCourses()
        {
            flpTheo.Controls.Clear();
            flpPrac.Controls.Clear();

            var theo = _svc.GetStudentCoursesByType(_studentId, "نظري");
            var prac = _svc.GetStudentCoursesByType(_studentId, "عملي");

            AddCourseCards(flpTheo, theo);
            AddCourseCards(flpPrac, prac);
        }

        private void AddCourseCards(FlowLayoutPanel flp, DataTable dt)
        {
            foreach (DataRow r in dt.Rows)
            {
                int offeringId = Convert.ToInt32(r["OfferingId"]);
                string courseName = r["CourseName"].ToString();
                string teacher = r["TeacherName"].ToString();
                string code = r["Code"].ToString();

                var card = CreateCourseCard(offeringId, code, courseName, teacher);
                flp.Controls.Add(card);
            }
        }
        private Control CreateCourseCard(int offeringId, string code, string courseName, string teacherName)
        {
            var pnl = new Panel();
            pnl.Width = 500;
            pnl.Height = 60;
            pnl.BackColor = Theme.Surface;
            pnl.Margin = new Padding(8);
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Cursor = Cursors.Hand;
            pnl.MouseEnter += (s, e) => pnl.BackColor = Color.FromArgb(235, 240, 255);
            pnl.MouseLeave += (s, e) => pnl.BackColor = Theme.Surface;

            var lbl1 = new Label();
            lbl1.AutoSize = false;
            lbl1.RightToLeft = RightToLeft.No;
            lbl1.Dock = DockStyle.Top;
            lbl1.Height = 33;
            pnl.BackColor = Color.MidnightBlue;
            lbl1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lbl1.TextAlign = ContentAlignment.MiddleRight;
            lbl1.Text = $"{courseName}  ({code})";

            var lbl2 = new Label();
            lbl2.AutoSize = false;
            lbl2.Dock = DockStyle.Fill;
            pnl.BackColor = Color.White;
            lbl2.Font = new Font("Segoe UI", 12);
            lbl2.TextAlign =ContentAlignment.MiddleRight;
            lbl2.Text = $"المدرس: {teacherName}";

            pnl.Controls.Add(lbl2);
            pnl.Controls.Add(lbl1);

            // نخزن OfferingId داخل Tag
            pnl.Tag = offeringId;

            // فتح المادة عند الضغط
            pnl.Click += CourseCard_Click;
            lbl1.Click += CourseCard_Click;
            lbl2.Click += CourseCard_Click;

            return pnl;
        }
        private void CourseCard_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;
            if (c == null) return;

            int offeringId = 0;
            if (c.Tag != null) offeringId = (int)c.Tag;
            else if (c.Parent != null && c.Parent.Tag != null) offeringId = (int)c.Parent.Tag;

            if (offeringId == 0) return;

            // فتح صفحة المادة
            var f = new StudentCourseForm(_studentId, offeringId);
            f.ShowDialog();

            // بعد الرجوع يمكن تحديث شيء لو احتجت
        }
        private void StyleDailyGrid()
        {
            dgvDaily.Cursor = Cursors.Hand;
            dgvDaily.ReadOnly = true;
            dgvDaily.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDaily.MultiSelect = false;
            dgvDaily.AllowUserToAddRows = false;
            dgvDaily.AllowUserToDeleteRows = false;
            dgvDaily.AllowUserToResizeRows = false;

            dgvDaily.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDaily.RowHeadersVisible = false;

            dgvDaily.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvDaily.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvDaily.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDaily.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvDaily.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }
        private void StyleTermWorkGrid()
        {
            dgvTermWork.ReadOnly = true;
            dgvTermWork.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTermWork.MultiSelect = false;
            dgvTermWork.AllowUserToAddRows = false;
            dgvTermWork.AllowUserToDeleteRows = false;
            dgvTermWork.AllowUserToResizeRows = false;
            dgvTermWork.RowHeadersVisible = false;
            dgvTermWork.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTermWork.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTermWork.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTermWork.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTermWork.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13,FontStyle.Bold);
        }
        private void LoadTermWork()
        {
            dgvTermWork.DataSource = _svc.GetTermWork(_studentId);

            // إخفاء OfferingId لأنه تقني
            if (dgvTermWork.Columns["OfferingId"] != null)
                dgvTermWork.Columns["OfferingId"].Visible = false;

            // ترتيب أعمدة العرض
            if (dgvTermWork.Columns["المادة"] != null)  dgvTermWork.Columns["المادة"].DisplayIndex = 0; 
                
            if (dgvTermWork.Columns["النوع"] != null) dgvTermWork.Columns["النوع"].DisplayIndex = 1;
            if (dgvTermWork.Columns["الحضور"] != null) dgvTermWork.Columns["الحضور"].DisplayIndex = 2;
            if (dgvTermWork.Columns["التكاليف"] != null) dgvTermWork.Columns["التكاليف"].DisplayIndex = 3;
            if (dgvTermWork.Columns["النصفي"] != null) dgvTermWork.Columns["النصفي"].DisplayIndex = 4;
            if (dgvTermWork.Columns["النهائي"] != null) dgvTermWork.Columns["النهائي"].DisplayIndex = 5;
            if (dgvTermWork.Columns["المجموع"] != null) dgvTermWork.Columns["المجموع"].DisplayIndex = 6;
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabTermWork)
                LoadTermWork();
            if (tabMain.SelectedTab == tabAch)
                LoadAchievements();
            if (tabMain.SelectedTab == tabNotifs)
                LoadStudentNotifications();

        }
        private void StyleAchGrid()
        {
            dgvAch.ReadOnly = true;
            dgvAch.AllowUserToAddRows = false;
            dgvAch.RowHeadersVisible = false;
            dgvAch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAch.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAch.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvAch.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dgvAch.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
        }
        private void LoadAchievements()
        {
            var dt = _svc.GetWeeklyAchievements(_studentId);
            dgvAch.DataSource = dt;

            // إخفاء الأعمدة التقنية
            if (dgvAch.Columns["PostId"] != null) dgvAch.Columns["PostId"].Visible = false;
            if (dgvAch.Columns["OfferingId"] != null) dgvAch.Columns["OfferingId"].Visible = false;
            if (dgvAch.Columns["SubmissionId"] != null) dgvAch.Columns["SubmissionId"].Visible = false;

            // تنسيق تواريخ
            if (dgvAch.Columns["تاريخ_الإرسال"] != null)
                dgvAch.Columns["تاريخ_الإرسال"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            if (dgvAch.Columns["الموعد"] != null)
                dgvAch.Columns["الموعد"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            if (dgvAch.Columns["وقت_التسليم"] != null)
                dgvAch.Columns["وقت_التسليم"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            // حساب النسبة (مكتملة = مصححة ولها درجة)
            int total = dt.Rows.Count;
            int completed = 0;

            foreach (DataRow r in dt.Rows)
                if (Convert.ToInt32(r["مكتملة_رقم"]) == 1) completed++;

            int percent = (total == 0) ? 0 : (int)Math.Round((completed * 100.0) / total);

            prgAchWeek.Minimum = 0;
            prgAchWeek.Maximum = 100;
            prgAchWeek.Value = percent;

            lblAchSummary.Text = $"المكتمل (بعد التصحيح): {completed}/{total}  ({percent}%)";

            // تلوين الصفوف حسب الحالة
            foreach (DataGridViewRow row in dgvAch.Rows)
            {
                string state = row.Cells["الحالة"].Value?.ToString() ?? "";

                if (state == "مكتملة")
                    row.DefaultCellStyle.BackColor = Color.Honeydew;       // أخضر
                else if (state == "بانتظار التصحيح")
                    row.DefaultCellStyle.BackColor = Color.LemonChiffon;  // أصفر
                else
                    row.DefaultCellStyle.BackColor = Color.MistyRose;     // أحمر
            }
        }
        private void LoadStudentNotifications()
        {
            dgvStudentNotifs.DataSource = _svc.GetAdminNotifications();

            dgvStudentNotifs.ReadOnly = true;
            dgvStudentNotifs.AllowUserToAddRows = false;
            dgvStudentNotifs.RowHeadersVisible = false;
            dgvStudentNotifs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentNotifs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvStudentNotifs.Columns["التاريخ"] != null)
                dgvStudentNotifs.Columns["التاريخ"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
        }
        private void dgvStudentNotifs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string title = dgvStudentNotifs.Rows[e.RowIndex].Cells["العنوان"].Value.ToString();
            string body = dgvStudentNotifs.Rows[e.RowIndex].Cells["المحتوى"].Value.ToString();

            MessageBox.Show(body, title);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var f = new ChangePasswordForm(_userId);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

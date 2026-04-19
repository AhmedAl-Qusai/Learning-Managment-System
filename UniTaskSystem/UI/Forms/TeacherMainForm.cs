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
    public partial class TeacherMainForm : Form
    {
        private readonly int _userId;
        private readonly string _teacherId;
        private readonly TeacherService _svc = new TeacherService();
        private bool _infoOpen = false;

        public TeacherMainForm(int userId, string teacherId)
        {
            InitializeComponent();
            _userId = userId;
            _teacherId = teacherId;
        }

        private void TeacherMainForm_Load(object sender, EventArgs e)
        {
            Theme.ApplyForm(this);
            Theme.StyleGrid(dgvNotifs);
            LoadTeacherInfo();
            LoadCourses();
            LoadNotifications();
        }

        private void LoadTeacherInfo()
        {
            DataTable dt = _svc.GetTeacherInfo(_teacherId);
            if (dt.Rows.Count == 0) return;

            lblTeacherId.Text = "المعرف: " + dt.Rows[0]["UniversityTeacherId"].ToString();
            lblTeacherName.Text = "الاسم: " + dt.Rows[0]["FullName"].ToString();
        }

        private void LoadCourses()
        {
            flpCourses.Controls.Clear();
            DataTable dt = _svc.GetTeacherOfferings(_teacherId);

            foreach (DataRow r in dt.Rows)
            {
                int offeringId = Convert.ToInt32(r["OfferingId"]);
                string name = r["CourseName"].ToString();
                string code = r["Code"].ToString();
                string type = r["OfferingType"].ToString();

                var card = CreateCourseCard(offeringId, $"{name} ({code}) - {type}");
                flpCourses.Controls.Add(card);
            }
        }

        private Control CreateCourseCard(int offeringId, string text)
        {
            var pnl = new Panel();
            pnl.Width = 741;
            pnl.Height = 40;
            pnl.BackColor = Color.SteelBlue;
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Margin = new Padding(10);
            pnl.Cursor = Cursors.Hand;
            pnl.Tag = offeringId;

            var lbl = new Label();
            lbl.Dock = DockStyle.Fill;
            lbl.RightToLeft = RightToLeft.No;
            lbl.TextAlign = ContentAlignment.MiddleRight;
            lbl.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lbl.Text = text;
            lbl.Cursor = Cursors.Hand;

            pnl.Controls.Add(lbl);

            pnl.Click += CourseCard_Click;
            lbl.Click += CourseCard_Click;

            return pnl;
        }

        private void CourseCard_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;
            int offeringId = 0;

            if (c.Tag != null) offeringId = (int)c.Tag;
            else if (c.Parent != null && c.Parent.Tag != null) offeringId = (int)c.Parent.Tag;

            if (offeringId == 0) return;

            var f = new TeacherCourseForm(_teacherId, offeringId);
            f.ShowDialog();
        }

        private void LoadNotifications()
        {
            dgvNotifs.DataSource = _svc.GetAdminNotifications();

            dgvNotifs.ReadOnly = true;
            dgvNotifs.AllowUserToAddRows = false;
            dgvNotifs.RowHeadersVisible = false;
            dgvNotifs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotifs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvNotifs.Columns["التاريخ"] != null)
                dgvNotifs.Columns["التاريخ"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
        }
        private void dgvNotifs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string title = dgvNotifs.Rows[e.RowIndex].Cells["العنوان"].Value.ToString();
            string body = dgvNotifs.Rows[e.RowIndex].Cells["المحتوى"].Value.ToString();

            MessageBox.Show(body, title);
        }
        private void tabTeacherMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabNotifs)
                LoadNotifications();
        }


        private void btnInfo_Click(object sender, EventArgs e)
        {
            _infoOpen = !_infoOpen;
            tmrSlide.Start();
        }

        private void tmrSlide_Tick(object sender, EventArgs e)
        {
            int targetWidth = 320;
            int step = 20;

            if (_infoOpen)
            {
                if (pnlInfo.Width < targetWidth) pnlInfo.Width += step;
                else tmrSlide.Stop();
            }
            else
            {
                if (pnlInfo.Width > 0) pnlInfo.Width -= step;
                else tmrSlide.Stop();
            }
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

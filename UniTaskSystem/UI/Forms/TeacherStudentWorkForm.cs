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
    public partial class TeacherStudentWorkForm : Form
    {
        private readonly string _teacherId;
        private readonly int _offeringId;
        private readonly string _studentId;


        private readonly TeacherService _svc = new TeacherService();
        private DataTable _dt;

        public TeacherStudentWorkForm(string teacherId, int offeringId, string studentId)
        {
            InitializeComponent();
            _teacherId = teacherId;
            _offeringId = offeringId;
            _studentId = studentId;
        }

        private void TeacherStudentWorkForm_Load(object sender, EventArgs e)
        {
            Theme.ApplyForm(this);
            Theme.StyleGrid(dgvStudentTasks);
            lblHeader.Text = "أعمال الطالب: " + _studentId;
            LoadGrid();
        }
        private void ColorRowsByStatus()
        {
            foreach (DataGridViewRow row in dgvStudentTasks.Rows)
            {
                object subObj = row.Cells["SubmissionId"].Value;
                object scoreObj = row.Cells["الدرجة"].Value;

                bool hasSubmission = !(subObj == null || subObj == DBNull.Value);

                if (!hasSubmission)
                {
                    // لم يسلّم
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Red; // أحمر خفيف
                }
                else
                {
                    // سلّم
                    bool hasScore = !(scoreObj == null || scoreObj == DBNull.Value);

                    if (!hasScore)
                    {
                        // سلّم ولم تُرصد درجة
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow; // أصفر خفيف
                    }
                    else
                    {
                        // سلّم وتم رصد درجة
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Lime; // أخضر خفيف
                    }
                }
            }
        }

        private void LoadGrid()
        {
            _dt = _svc.GetStudentTasksInOffering(_offeringId, _studentId);
            dgvStudentTasks.DataSource = _dt;

            ColorRowsByStatus();

            // إخفاء الأعمدة التقنية
            if (dgvStudentTasks.Columns["PostId"] != null) dgvStudentTasks.Columns["PostId"].Visible = false;
            if (dgvStudentTasks.Columns["SubmissionId"] != null) dgvStudentTasks.Columns["SubmissionId"].Visible = false;

            // تنسيق تاريخ الموعد
            if (dgvStudentTasks.Columns["الموعد"] != null)
                dgvStudentTasks.Columns["الموعد"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

            if (dgvStudentTasks.Columns["وقت_الإرسال"] != null)
                dgvStudentTasks.Columns["وقت_الإرسال"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
        }

        private void btnGradeSelected_Click(object sender, EventArgs e)
        {
            if (dgvStudentTasks.CurrentRow == null) return;

            object subObj = dgvStudentTasks.CurrentRow.Cells["SubmissionId"].Value;

            if (subObj == null || subObj == DBNull.Value)
            {
                MessageBox.Show("هذا الطالب لم يسلّم هذه المهمة بعد.");
                return;
            }

            int submissionId = Convert.ToInt32(subObj);

            var f = new GradeSubmissionForm(_teacherId, submissionId);
            f.ShowDialog();

            // بعد التصحيح حدث القائمة (لتظهر الدرجة)
            LoadGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

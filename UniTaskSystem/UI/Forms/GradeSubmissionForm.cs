using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using UniTaskSystem.Services;

namespace UniTaskSystem.UI.Forms
{
    public partial class GradeSubmissionForm : Form
    {
        private readonly string _teacherId;
        private readonly int _submissionId;
        private readonly TeacherService _svc = new TeacherService();

        private DataTable _filesDt;

        public GradeSubmissionForm(string teacherId, int submissionId)
        {
            InitializeComponent();
            _teacherId = teacherId;
            _submissionId = submissionId;
        }

        private void GradeSubmissionForm_Load(object sender, EventArgs e)
        {
            LoadSubmission();
            LoadAttachments();
            LoadExistingGrade();
        }

        private void LoadSubmission()
        {
            DataTable dt = _svc.GetSubmissionDetails(_submissionId);
            if (dt.Rows.Count == 0) return;

            var r = dt.Rows[0];
            lblStudent.Text = $"الطالب: {r["FullName"]} ({r["UniversityStudentId"]})";
            lblSubmittedAt.Text = "وقت الإرسال: " + Convert.ToDateTime(r["SubmittedAt"]).ToString("yyyy-MM-dd HH:mm");
            rtbAnswer.Text = r["TextAnswer"].ToString();
        }

        private void LoadAttachments()
        {
            _filesDt = _svc.GetSubmissionAttachments(_submissionId);
            lstFiles.Items.Clear();

            foreach (DataRow r in _filesDt.Rows)
                lstFiles.Items.Add(r["FileName"].ToString());
        }

        private void LoadExistingGrade()
        {
            DataTable g = _svc.GetExistingGrade(_submissionId);
            if (g.Rows.Count == 0) return;

            numScore.Value = Convert.ToInt32(g.Rows[0]["Score"]);
            rtbFeedback.Text = g.Rows[0]["Feedback"].ToString();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectedIndex < 0) return;

            string path = _filesDt.Rows[lstFiles.SelectedIndex]["FilePath"].ToString();
            if (!File.Exists(path))
            {
                MessageBox.Show("الملف غير موجود:\n" + path);
                return;
            }

            var psi = new ProcessStartInfo(path);
            psi.UseShellExecute = true;
            Process.Start(psi);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _svc.UpsertGrade(_submissionId, (int)numScore.Value, rtbFeedback.Text, _teacherId);
            MessageBox.Show("تم حفظ الدرجة ✅");
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

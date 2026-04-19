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
using UniTaskSystem.Services;
using System.Diagnostics;

namespace UniTaskSystem.UI.Forms
{
    public partial class StudentTaskDetailsForm : Form
    {
        private int _submissionId = 0;
        private DataTable _dbAnswerAttachments; // مرفقات محفوظة في DB

        private List<string> _selectedFiles = new List<string>();

        private readonly string _studentId;
        private readonly int _postId;
        private readonly StudentService _svc = new StudentService();

        private DateTime? _deadline;
        private DataTable _taskAtt;

        private Button _btnDeleteSubmission;

        public StudentTaskDetailsForm(string studentId, int postId)
        {
            InitializeComponent();
            _studentId = studentId;
            _postId = postId;
            AddDeleteButton();
        }

        private void AddDeleteButton()
        {
            // زر حذف الحل يُضاف برمجياً دون تعديل المصمم
            _btnDeleteSubmission = new Button();
            _btnDeleteSubmission.Text = "حذف الحل";
            _btnDeleteSubmission.BackColor = Color.FromArgb(192, 0, 0);
            _btnDeleteSubmission.ForeColor = SystemColors.ControlLightLight;
            _btnDeleteSubmission.Font = btnSubmit.Font;
            _btnDeleteSubmission.Size = new Size(149, 54);
            _btnDeleteSubmission.Location = new Point(btnSubmit.Left + btnSubmit.Width + 10, btnSubmit.Top);
            _btnDeleteSubmission.Click += (s, e) => DeleteSubmission();
            Controls.Add(_btnDeleteSubmission);
            _btnDeleteSubmission.BringToFront();
        }

        private void StudentTaskDetailsForm_Load(object sender, EventArgs e)
        {
            LoadTask();
            LoadTaskAttachments();
            LoadExistingSubmission();
        }
        private void LoadExistingSubmission()
        {
            var sub = _svc.GetStudentSubmission(_postId, _studentId);

            // لا يوجد تسليم سابق
            if (sub.Rows.Count == 0)
            {
                _submissionId = 0;
                if (_btnDeleteSubmission != null) _btnDeleteSubmission.Enabled = false;
                return;
            }

            _submissionId = Convert.ToInt32(sub.Rows[0]["SubmissionId"]);
            rtbAnswer.Text = sub.Rows[0]["TextAnswer"].ToString();

            if (_btnDeleteSubmission != null) _btnDeleteSubmission.Enabled = true;

            // جلب مرفقات الحل من DB وعرضها
            _dbAnswerAttachments = _svc.GetSubmissionAttachments(_submissionId);
            lstAnswerAttachments.Items.Clear();

            foreach (System.Data.DataRow r in _dbAnswerAttachments.Rows)
            {
                // نعرض اسم الملف فقط
                lstAnswerAttachments.Items.Add(r["FileName"].ToString());
            }
        }

        private void DeleteSubmission()
        {
            try
            {
                if (_submissionId == 0)
                {
                    MessageBox.Show("لا يوجد حل مُرسل لحذفه.");
                    return;
                }

                if (MessageBox.Show("هل أنت متأكد من حذف الحل؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                _svc.DeleteSubmission(_submissionId, _studentId);
                _submissionId = 0;
                rtbAnswer.Clear();
                lstAnswerAttachments.Items.Clear();
                _selectedFiles.Clear();
                _dbAnswerAttachments = null;
                if (_btnDeleteSubmission != null) _btnDeleteSubmission.Enabled = false;

                MessageBox.Show("تم حذف الحل ✅");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadTask()
        {
            DataTable dt = _svc.GetTaskDetails(_postId);
            if (dt.Rows.Count == 0) return;

            var r = dt.Rows[0];
            lblTitle.Text = r["Title"].ToString();
            rtbBody.Text = r["Body"].ToString();

            if (r["Deadline"] == DBNull.Value)
            {
                _deadline = null;
                lblDeadline.Text = "لا يوجد موعد نهائي";
            }
            else
            {
                _deadline = Convert.ToDateTime(r["Deadline"]);
                lblDeadline.Text = "الموعد النهائي: " + _deadline.Value.ToString("yyyy-MM-dd HH:mm");
            }
        }

        private void LoadTaskAttachments()
        {
            _taskAtt = _svc.GetTaskAttachments(_postId);
            lstTaskAttachments.Items.Clear();

            foreach (DataRow r in _taskAtt.Rows)
                lstTaskAttachments.Items.Add(r["FileName"].ToString());
        }

        private void btnOpenTaskAttachment_Click(object sender, EventArgs e)
        {
            if (lstTaskAttachments.SelectedIndex < 0) return;

            string path = _taskAtt.Rows[lstTaskAttachments.SelectedIndex]["FilePath"].ToString();
            if (!File.Exists(path))
            {
                MessageBox.Show("الملف غير موجود في المسار:\n" + path);
                return;
            }

            Process.Start(path);
        }

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true;

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            foreach (string filePath in ofd.FileNames)
            {
                _selectedFiles.Add(filePath);
                lstAnswerAttachments.Items.Add(Path.GetFileName(filePath));
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) إنشاء/تحديث التسليم في قاعدة البيانات
                int submissionId = _svc.SubmitAnswer(_postId, _studentId, rtbAnswer.Text);

                // 2) نسخ الملفات المختارة إلى مجلد ثابت
                string destDir = Path.Combine(@"C:\UniTaskSystem\Submissions",
                    _studentId,
                    _postId.ToString()
                );
                Directory.CreateDirectory(destDir);

                foreach (string srcPath in _selectedFiles)
                {
                    string fileName = Path.GetFileName(srcPath);
                    string destPath = Path.Combine(destDir, fileName);

                    // إذا نفس الاسم موجود، نضيف رقم
                    destPath = MakeUniquePath(destPath);

                    File.Copy(srcPath, destPath, true);

                    // 3) حفظ معلومات المرفق في DB
                    var fi = new FileInfo(destPath);
                    _svc.AddSubmissionAttachment(submissionId, fi.Name, destPath, null, fi.Length);
                }

                MessageBox.Show("تم إرسال الحل مع المرفقات بنجاح ✅");
                this.Close();
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
                string newPath = Path.Combine(dir, name + "_" + i + ext);
                if (!File.Exists(newPath)) return newPath;
                i++;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenAnswerAttachment_Click(object sender, EventArgs e)
        {
            if (_submissionId == 0 || _dbAnswerAttachments == null || _dbAnswerAttachments.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد مرفقات محفوظة لهذا الحل.");
                return;
            }

            if (lstAnswerAttachments.SelectedIndex < 0)
            {
                MessageBox.Show("اختر مرفقًا من القائمة.");
                return;
            }

            string path = _dbAnswerAttachments.Rows[lstAnswerAttachments.SelectedIndex]["FilePath"].ToString();

            if (!File.Exists(path))
            {
                MessageBox.Show("الملف غير موجود في المسار:\n" + path);
                return;
            }

            var psi = new ProcessStartInfo(path);
            psi.UseShellExecute = true;
            Process.Start(psi);
        }
    }
}

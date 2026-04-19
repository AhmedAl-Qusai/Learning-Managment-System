using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniTaskSystem.UI.Forms
{
    public partial class AddLectureForm : Form
    {
        public string LectureTitle { get; private set; }
        public string LectureContent { get; private set; }

        public AddLectureForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("اكتب عنوان المحاضرة");
                return;
            }

            LectureTitle = txtTitle.Text.Trim();
            LectureContent = rtbContent.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

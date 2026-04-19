using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using UniTaskSystem.UI.UI_Theme;

namespace UniTaskSystem.UI.Forms
{
    public partial class AttachmentsViewerForm : Form
    {
        private readonly DataTable _dt;

        public AttachmentsViewerForm(DataTable dt)
        {
            InitializeComponent();
            _dt = dt;
        }
        private void AttachmentsViewerForm_Load(object sender, EventArgs e)
        {
            Theme.ApplyForm(this);
            Theme.StyleGrid(dgvAtt);
            dgvAtt.DataSource = _dt;
            if (dgvAtt.Columns["AttachmentId"] != null) dgvAtt.Columns["AttachmentId"].Visible = false;
            if (dgvAtt.Columns["FilePath"] != null) dgvAtt.Columns["FilePath"].Visible = false;

            dgvAtt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAtt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAtt.ReadOnly = true;
            dgvAtt.AllowUserToAddRows = false;
            dgvAtt.RowHeadersVisible = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dgvAtt.CurrentRow == null) return;

            string path = dgvAtt.CurrentRow.Cells["FilePath"].Value.ToString();
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show("الملف غير موجود:\n" + path);
                return;
            }

            var psi = new ProcessStartInfo(path);
            psi.UseShellExecute = true;
            Process.Start(psi);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

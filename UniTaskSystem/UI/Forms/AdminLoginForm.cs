using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using UniTaskSystem.UI.UI_Theme;

namespace UniTaskSystem.UI.Forms
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
            btnLogin.BackColor = Theme.Primary;
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e) => DoLogin();

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                DoLogin();
            }
        }
        private void DoLogin()
        {
            string configured = ConfigurationManager.AppSettings["AdminPassword"];
            if (string.IsNullOrWhiteSpace(configured)) configured = "admin";

            if (txtPassword.Text == configured)
            {
                var main = new AdminMainForm();
                main.FormClosed += (s, e) =>
                this.Close();
                this.Hide();
                main.Show();
                return;
            }

            MessageBox.Show("كلمة المرور غير صحيحة.");
            txtPassword.SelectAll();
            txtPassword.Focus();
        }
    }
}

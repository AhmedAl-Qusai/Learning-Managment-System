using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniTaskSystem.UI.Forms;
using UniTaskSystem.Services;

namespace UniTaskSystem.UI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtIdentifier.Text.Trim();
                string pass = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("أدخل المعرف وكلمة المرور");
                    return;
                }

                var _auth = new AuthService();
                var res = _auth.Login(txtIdentifier.Text.Trim(), txtPassword.Text);

                if (!res.Ok)
                {
                    MessageBox.Show("بيانات الدخول غير صحيحة");
                    return;
                }

                if (res.Role == "طالب")
                {
                    var f = new StudentMainForm(res.UserId, res.Identifier);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    var f = new TeacherMainForm(res.UserId, res.Identifier);
                    f.Show();
                    this.Hide();
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool passVisible = false;

        private void picEye_Click(object sender, EventArgs e)
        {
            passVisible = !passVisible;
            txtPassword.UseSystemPasswordChar = !passVisible;

            picEye.Image = passVisible
                ? Properties.Resources.ic_eye
                : Properties.Resources.ic_eye_off;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new ForgotPasswordForm();
            f.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                new AuthService().CleanupResetCodes();
            }
            catch { /* تجاهل */ }

        }
    }
}

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

namespace UniTaskSystem.UI.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string code = txtCode.Text.Trim();
                string pass = txtPass.Text;
                string confirm = txtConfirm.Text;
                
                if (string.IsNullOrWhiteSpace(code))
                {
                    MessageBox.Show("أدخل رمز التفعيل");
                    return;
                }

                if (string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("أدخل كلمة المرور");
                    return;
                }

                if (pass != confirm)
                {
                    MessageBox.Show("كلمتا المرور غير متطابقتين");
                    return;
                }

                var auth = new AuthService();
                auth.RegisterByActivationCode(code, pass);

                MessageBox.Show("تم إنشاء الحساب بنجاح ✅");

                // الانتقال لتسجيل الدخول
                var f = new LoginForm();
                f.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new LoginForm();
            f.FormClosed += (s, args) =>
            this.Show();
            f.Show();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

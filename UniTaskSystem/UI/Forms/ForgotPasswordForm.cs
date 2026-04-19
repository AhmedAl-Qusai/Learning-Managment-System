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
    public partial class ForgotPasswordForm : Form
    {
        private readonly AuthService _auth = new AuthService();

        public ForgotPasswordForm()
        {
            InitializeComponent();
            this.AcceptButton = btnReset;   // Enter = إعادة تعيين
            this.CancelButton = btnCancel;  // Esc = إلغاء

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            try
            {
                string id = txtIdentifier.Text.Trim();
                string code = txtResetCode.Text.Trim();
                string p1 = txtNewPassword.Text;
                string p2 = txtConfirmPassword.Text;

                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("أدخل المعرف.");
                    txtIdentifier.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(code))
                {
                    MessageBox.Show("أدخل رمز إعادة التعيين.");
                    txtResetCode.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(p1) || p1.Length < 4)
                {
                    MessageBox.Show("كلمة المرور قصيرة جدًا (على الأقل 4 أحرف).");
                    txtNewPassword.Focus();
                    return;
                }

                if (p1 != p2)
                {
                    MessageBox.Show("كلمتا المرور غير متطابقتين.");
                    txtConfirmPassword.Focus();
                    return;
                }

                _auth.ResetPassword(id, code, p1);

                MessageBox.Show("تم تغيير كلمة المرور بنجاح ✅");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnReset.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

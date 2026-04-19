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
    public partial class ChangePasswordForm : Form
    {
        private readonly int _userId;
        private readonly AuthService _auth = new AuthService();

        public ChangePasswordForm(int userId)
        {
            InitializeComponent();
            _userId = userId;

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string oldP = txtOld.Text;
                string newP = txtNew.Text;
                string conf = txtConfirm.Text;

                if (string.IsNullOrWhiteSpace(oldP) || string.IsNullOrWhiteSpace(newP))
                {
                    MessageBox.Show("أدخل كلمة المرور الحالية والجديدة.");
                    return;
                }

                if (newP.Length < 4)
                {
                    MessageBox.Show("كلمة المرور قصيرة جدًا.");
                    return;
                }

                if (newP != conf)
                {
                    MessageBox.Show("تأكيد كلمة المرور غير مطابق.");
                    return;
                }

                _auth.ChangePassword(_userId, oldP, newP);

                MessageBox.Show("تم تغيير كلمة المرور بنجاح ✅");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

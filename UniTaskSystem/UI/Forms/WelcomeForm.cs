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
    public partial class WelcomeForm : Form
    {
        private Button btnAdmin;

        public WelcomeForm()
        {
            InitializeComponent();
            AddAdminButton();
        }

        private void AddAdminButton()
        {

            btnAdmin = new Button();
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Text = " الإدارة";
            btnAdmin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btnAdmin.Size = btnExit.Size;
            btnAdmin.Location = btnExit.Location;
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;

            // نزّل زر الخروج للأسفل
            btnExit.Location = new Point(btnExit.Location.X, btnExit.Location.Y + btnExit.Height + 25);

            // تكبير الفورم إن لزم
            int neededBottom = btnExit.Bottom + 30;
            if (this.ClientSize.Height < neededBottom)
                this.ClientSize = new Size(this.ClientSize.Width, neededBottom);

            this.Controls.Add(btnAdmin);
            btnAdmin.BringToFront();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var f = new AdminLoginForm();
            f.FormClosed += (s, args) =>
            this.Show();
            this.Hide();
            f.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var f = new LoginForm();
            f.FormClosed += (s, args) =>
            this.Show();
            f.Show();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var f = new RegisterForm();
            f.FormClosed += (s, args) =>
            this.Show();
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

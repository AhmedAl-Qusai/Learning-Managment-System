namespace UniTaskSystem.UI.Forms
{
    partial class TeacherMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.flpCourses = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTeacherId = new System.Windows.Forms.Label();
            this.tmrSlide = new System.Windows.Forms.Timer(this.components);
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabNotifs = new System.Windows.Forms.TabPage();
            this.dgvNotifs = new System.Windows.Forms.DataGridView();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabCourses.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabNotifs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCourses
            // 
            this.tabCourses.BackColor = System.Drawing.Color.SteelBlue;
            this.tabCourses.Controls.Add(this.label2);
            this.tabCourses.Controls.Add(this.flpCourses);
            this.tabCourses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabCourses.Location = new System.Drawing.Point(4, 46);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourses.Size = new System.Drawing.Size(906, 512);
            this.tabCourses.TabIndex = 0;
            this.tabCourses.Tag = "1";
            this.tabCourses.Text = "             المقـــــــررات  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(778, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "المواد  :";
            // 
            // flpCourses
            // 
            this.flpCourses.AutoScroll = true;
            this.flpCourses.AutoSize = true;
            this.flpCourses.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpCourses.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCourses.ForeColor = System.Drawing.Color.Black;
            this.flpCourses.Location = new System.Drawing.Point(122, 59);
            this.flpCourses.Name = "flpCourses";
            this.flpCourses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpCourses.Size = new System.Drawing.Size(741, 383);
            this.flpCourses.TabIndex = 0;
            this.flpCourses.WrapContents = false;
            // 
            // lblTeacherId
            // 
            this.lblTeacherId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherId.Location = new System.Drawing.Point(12, 217);
            this.lblTeacherId.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTeacherId.Name = "lblTeacherId";
            this.lblTeacherId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTeacherId.Size = new System.Drawing.Size(293, 23);
            this.lblTeacherId.TabIndex = 5;
            this.lblTeacherId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrSlide
            // 
            this.tmrSlide.Interval = 10;
            this.tmrSlide.Tick += new System.EventHandler(this.tmrSlide_Tick);
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.Location = new System.Drawing.Point(14, 172);
            this.lblTeacherName.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTeacherName.Size = new System.Drawing.Size(291, 25);
            this.lblTeacherName.TabIndex = 2;
            this.lblTeacherName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlInfo.Controls.Add(this.button2);
            this.pnlInfo.Controls.Add(this.btnChangePassword);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.lblTeacherId);
            this.pnlInfo.Controls.Add(this.lblTeacherName);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(914, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(0, 562);
            this.pnlInfo.TabIndex = 4;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabCourses);
            this.tabMain.Controls.Add(this.tabNotifs);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabMain.RightToLeftLayout = true;
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(914, 562);
            this.tabMain.TabIndex = 5;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabTeacherMain_SelectedIndexChanged);
            // 
            // tabNotifs
            // 
            this.tabNotifs.BackColor = System.Drawing.Color.SteelBlue;
            this.tabNotifs.Controls.Add(this.dgvNotifs);
            this.tabNotifs.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabNotifs.Location = new System.Drawing.Point(4, 46);
            this.tabNotifs.Name = "tabNotifs";
            this.tabNotifs.Size = new System.Drawing.Size(906, 512);
            this.tabNotifs.TabIndex = 3;
            this.tabNotifs.Tag = "4";
            this.tabNotifs.Text = "   الإشعـــــارات   ";
            // 
            // dgvNotifs
            // 
            this.dgvNotifs.AllowUserToAddRows = false;
            this.dgvNotifs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotifs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotifs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvNotifs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotifs.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvNotifs.Location = new System.Drawing.Point(60, 58);
            this.dgvNotifs.Name = "dgvNotifs";
            this.dgvNotifs.ReadOnly = true;
            this.dgvNotifs.RowHeadersWidth = 51;
            this.dgvNotifs.RowTemplate.Height = 26;
            this.dgvNotifs.Size = new System.Drawing.Size(778, 383);
            this.dgvNotifs.TabIndex = 1;
            this.dgvNotifs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotifs_CellDoubleClick);
            // 
            // btnInfo
            // 
            this.btnInfo.AutoSize = true;
            this.btnInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInfo.BackgroundImage = global::UniTaskSystem.Properties.Resources.ic_user;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInfo.Location = new System.Drawing.Point(834, -4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(93, 44);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "☰         ";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Image = global::UniTaskSystem.Properties.Resources.ic_user;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(300, 93);
            this.label1.TabIndex = 22;
            this.label1.Text = "الـمـلف الشــخصي :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(160, 296);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(148, 38);
            this.btnChangePassword.TabIndex = 23;
            this.btnChangePassword.Text = "تغيير كلمة المرور";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 42);
            this.button2.TabIndex = 24;
            this.button2.Text = "تسجيل خروج ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TeacherMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherMainForm";
            this.Load += new System.EventHandler(this.TeacherMainForm_Load);
            this.tabCourses.ResumeLayout(false);
            this.tabCourses.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabNotifs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabCourses;
        private System.Windows.Forms.Label lblTeacherId;
        private System.Windows.Forms.Timer tmrSlide;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabNotifs;
        private System.Windows.Forms.FlowLayoutPanel flpCourses;
        private System.Windows.Forms.DataGridView dgvNotifs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button button2;
    }
}
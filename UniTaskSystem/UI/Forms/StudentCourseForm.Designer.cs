namespace UniTaskSystem.UI.Forms
{
    partial class StudentCourseForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabCourse = new System.Windows.Forms.TabControl();
            this.tabTasks = new System.Windows.Forms.TabPage();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.tabSyllabus = new System.Windows.Forms.TabPage();
            this.btnOpenSyllabusAttachments = new System.Windows.Forms.Button();
            this.btnOpenSyllabus = new System.Windows.Forms.Button();
            this.dgvSyllabus = new System.Windows.Forms.DataGridView();
            this.tabModels = new System.Windows.Forms.TabPage();
            this.btnOpenModelAttachments = new System.Windows.Forms.Button();
            this.btnOpenModel = new System.Windows.Forms.Button();
            this.dgvModels = new System.Windows.Forms.DataGridView();
            this.tabPlan = new System.Windows.Forms.TabPage();
            this.dgvPlanStudent = new System.Windows.Forms.DataGridView();
            this.prgPlanStudent = new System.Windows.Forms.ProgressBar();
            this.lblPlanStatsStudent = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabCourse.SuspendLayout();
            this.tabTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.tabSyllabus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyllabus)).BeginInit();
            this.tabModels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).BeginInit();
            this.tabPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(914, 81);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabCourse
            // 
            this.tabCourse.Controls.Add(this.tabTasks);
            this.tabCourse.Controls.Add(this.tabSyllabus);
            this.tabCourse.Controls.Add(this.tabModels);
            this.tabCourse.Controls.Add(this.tabPlan);
            this.tabCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCourse.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabCourse.Location = new System.Drawing.Point(0, 81);
            this.tabCourse.Name = "tabCourse";
            this.tabCourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabCourse.RightToLeftLayout = true;
            this.tabCourse.SelectedIndex = 0;
            this.tabCourse.Size = new System.Drawing.Size(914, 481);
            this.tabCourse.TabIndex = 1;
            // 
            // tabTasks
            // 
            this.tabTasks.BackColor = System.Drawing.Color.SteelBlue;
            this.tabTasks.Controls.Add(this.dgvTasks);
            this.tabTasks.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabTasks.Location = new System.Drawing.Point(4, 40);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabTasks.Size = new System.Drawing.Size(906, 437);
            this.tabTasks.TabIndex = 0;
            this.tabTasks.Text = "  المهـــــــــــــــام   ";
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTasks.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(3, 38);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 26;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(900, 399);
            this.dgvTasks.TabIndex = 1;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            // 
            // tabSyllabus
            // 
            this.tabSyllabus.BackColor = System.Drawing.Color.SteelBlue;
            this.tabSyllabus.Controls.Add(this.btnOpenSyllabusAttachments);
            this.tabSyllabus.Controls.Add(this.btnOpenSyllabus);
            this.tabSyllabus.Controls.Add(this.dgvSyllabus);
            this.tabSyllabus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabSyllabus.Location = new System.Drawing.Point(4, 40);
            this.tabSyllabus.Name = "tabSyllabus";
            this.tabSyllabus.Padding = new System.Windows.Forms.Padding(3);
            this.tabSyllabus.Size = new System.Drawing.Size(906, 437);
            this.tabSyllabus.TabIndex = 1;
            this.tabSyllabus.Text = "  المقــــــــــــــرر  ";
            // 
            // btnOpenSyllabusAttachments
            // 
            this.btnOpenSyllabusAttachments.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpenSyllabusAttachments.Location = new System.Drawing.Point(7, 37);
            this.btnOpenSyllabusAttachments.Name = "btnOpenSyllabusAttachments";
            this.btnOpenSyllabusAttachments.Size = new System.Drawing.Size(140, 45);
            this.btnOpenSyllabusAttachments.TabIndex = 2;
            this.btnOpenSyllabusAttachments.Text = "مرفقات 📚";
            this.btnOpenSyllabusAttachments.UseVisualStyleBackColor = false;
            this.btnOpenSyllabusAttachments.Click += new System.EventHandler(this.btnOpenSyllabusAttachments_Click);
            // 
            // btnOpenSyllabus
            // 
            this.btnOpenSyllabus.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnOpenSyllabus.Location = new System.Drawing.Point(153, 37);
            this.btnOpenSyllabus.Name = "btnOpenSyllabus";
            this.btnOpenSyllabus.Size = new System.Drawing.Size(121, 45);
            this.btnOpenSyllabus.TabIndex = 1;
            this.btnOpenSyllabus.Text = "فتح 🧾";
            this.btnOpenSyllabus.UseVisualStyleBackColor = false;
            this.btnOpenSyllabus.Click += new System.EventHandler(this.btnOpenSyllabus_Click);
            // 
            // dgvSyllabus
            // 
            this.dgvSyllabus.AllowUserToAddRows = false;
            this.dgvSyllabus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSyllabus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSyllabus.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSyllabus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyllabus.Location = new System.Drawing.Point(8, 52);
            this.dgvSyllabus.Name = "dgvSyllabus";
            this.dgvSyllabus.ReadOnly = true;
            this.dgvSyllabus.RowHeadersWidth = 51;
            this.dgvSyllabus.RowTemplate.Height = 26;
            this.dgvSyllabus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSyllabus.Size = new System.Drawing.Size(890, 389);
            this.dgvSyllabus.TabIndex = 0;
            // 
            // tabModels
            // 
            this.tabModels.BackColor = System.Drawing.Color.SteelBlue;
            this.tabModels.Controls.Add(this.btnOpenModelAttachments);
            this.tabModels.Controls.Add(this.btnOpenModel);
            this.tabModels.Controls.Add(this.dgvModels);
            this.tabModels.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabModels.Location = new System.Drawing.Point(4, 40);
            this.tabModels.Name = "tabModels";
            this.tabModels.Size = new System.Drawing.Size(906, 437);
            this.tabModels.TabIndex = 3;
            this.tabModels.Text = "  نماذج";
            // 
            // btnOpenModelAttachments
            // 
            this.btnOpenModelAttachments.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpenModelAttachments.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOpenModelAttachments.Location = new System.Drawing.Point(7, 37);
            this.btnOpenModelAttachments.Name = "btnOpenModelAttachments";
            this.btnOpenModelAttachments.Size = new System.Drawing.Size(140, 45);
            this.btnOpenModelAttachments.TabIndex = 5;
            this.btnOpenModelAttachments.Text = "مرفقات 📚";
            this.btnOpenModelAttachments.UseVisualStyleBackColor = false;
            this.btnOpenModelAttachments.Click += new System.EventHandler(this.btnOpenModelAttachments_Click);
            // 
            // btnOpenModel
            // 
            this.btnOpenModel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOpenModel.Location = new System.Drawing.Point(153, 37);
            this.btnOpenModel.Name = "btnOpenModel";
            this.btnOpenModel.Size = new System.Drawing.Size(122, 45);
            this.btnOpenModel.TabIndex = 4;
            this.btnOpenModel.Text = "فتح 🧾";
            this.btnOpenModel.UseVisualStyleBackColor = true;
            this.btnOpenModel.Click += new System.EventHandler(this.btnOpenModel_Click);
            // 
            // dgvModels
            // 
            this.dgvModels.AllowUserToAddRows = false;
            this.dgvModels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModels.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvModels.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModels.Location = new System.Drawing.Point(8, 52);
            this.dgvModels.Name = "dgvModels";
            this.dgvModels.ReadOnly = true;
            this.dgvModels.RowHeadersWidth = 51;
            this.dgvModels.RowTemplate.Height = 26;
            this.dgvModels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModels.Size = new System.Drawing.Size(890, 389);
            this.dgvModels.TabIndex = 3;
            // 
            // tabPlan
            // 
            this.tabPlan.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPlan.Controls.Add(this.dgvPlanStudent);
            this.tabPlan.Controls.Add(this.prgPlanStudent);
            this.tabPlan.Controls.Add(this.lblPlanStatsStudent);
            this.tabPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabPlan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPlan.Location = new System.Drawing.Point(4, 40);
            this.tabPlan.Name = "tabPlan";
            this.tabPlan.Size = new System.Drawing.Size(906, 437);
            this.tabPlan.TabIndex = 2;
            this.tabPlan.Text = " الخطة والمحاضرات";
            // 
            // dgvPlanStudent
            // 
            this.dgvPlanStudent.AllowUserToAddRows = false;
            this.dgvPlanStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlanStudent.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvPlanStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanStudent.Location = new System.Drawing.Point(112, 77);
            this.dgvPlanStudent.Name = "dgvPlanStudent";
            this.dgvPlanStudent.ReadOnly = true;
            this.dgvPlanStudent.RowHeadersWidth = 51;
            this.dgvPlanStudent.RowTemplate.Height = 26;
            this.dgvPlanStudent.Size = new System.Drawing.Size(721, 320);
            this.dgvPlanStudent.TabIndex = 2;
            this.dgvPlanStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanStudent_CellDoubleClick);
            // 
            // prgPlanStudent
            // 
            this.prgPlanStudent.Location = new System.Drawing.Point(187, 48);
            this.prgPlanStudent.Name = "prgPlanStudent";
            this.prgPlanStudent.Size = new System.Drawing.Size(573, 23);
            this.prgPlanStudent.TabIndex = 1;
            // 
            // lblPlanStatsStudent
            // 
            this.lblPlanStatsStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPlanStatsStudent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlanStatsStudent.ForeColor = System.Drawing.Color.Maroon;
            this.lblPlanStatsStudent.Location = new System.Drawing.Point(0, 0);
            this.lblPlanStatsStudent.Name = "lblPlanStatsStudent";
            this.lblPlanStatsStudent.Size = new System.Drawing.Size(906, 45);
            this.lblPlanStatsStudent.TabIndex = 0;
            this.lblPlanStatsStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 46);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "↩ رجوع";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StudentCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabCourse);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StudentCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentCourseForm";
            this.Load += new System.EventHandler(this.StudentCourseForm_Load);
            this.tabCourse.ResumeLayout(false);
            this.tabTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.tabSyllabus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyllabus)).EndInit();
            this.tabModels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModels)).EndInit();
            this.tabPlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tabCourse;
        private System.Windows.Forms.TabPage tabTasks;
        private System.Windows.Forms.TabPage tabSyllabus;
        private System.Windows.Forms.DataGridView dgvSyllabus;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tabPlan;
        private System.Windows.Forms.Label lblPlanStatsStudent;
        private System.Windows.Forms.DataGridView dgvPlanStudent;
        private System.Windows.Forms.ProgressBar prgPlanStudent;
        private System.Windows.Forms.TabPage tabModels;
        private System.Windows.Forms.Button btnOpenSyllabusAttachments;
        private System.Windows.Forms.Button btnOpenSyllabus;
        private System.Windows.Forms.Button btnOpenModelAttachments;
        private System.Windows.Forms.Button btnOpenModel;
        private System.Windows.Forms.DataGridView dgvModels;
    }
}
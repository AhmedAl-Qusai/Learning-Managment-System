namespace UniTaskSystem.UI.Forms
{
    partial class StudentMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmrSlide = new System.Windows.Forms.Timer(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.dgvDaily = new System.Windows.Forms.DataGridView();
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.tabCoursesType = new System.Windows.Forms.TabControl();
            this.tabTheo = new System.Windows.Forms.TabPage();
            this.flpTheo = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPrac = new System.Windows.Forms.TabPage();
            this.flpPrac = new System.Windows.Forms.FlowLayoutPanel();
            this.tabAch = new System.Windows.Forms.TabPage();
            this.lblAchSummary = new System.Windows.Forms.Label();
            this.prgAchWeek = new System.Windows.Forms.ProgressBar();
            this.lblAchTitle = new System.Windows.Forms.Label();
            this.dgvAch = new System.Windows.Forms.DataGridView();
            this.tabTermWork = new System.Windows.Forms.TabPage();
            this.dgvTermWork = new System.Windows.Forms.DataGridView();
            this.tabNotifs = new System.Windows.Forms.TabPage();
            this.dgvStudentNotifs = new System.Windows.Forms.DataGridView();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblMajorValue = new System.Windows.Forms.Label();
            this.lblLevelValue = new System.Windows.Forms.Label();
            this.lblDeptValue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTermValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).BeginInit();
            this.tabCourses.SuspendLayout();
            this.tabCoursesType.SuspendLayout();
            this.tabTheo.SuspendLayout();
            this.tabPrac.SuspendLayout();
            this.tabAch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAch)).BeginInit();
            this.tabTermWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermWork)).BeginInit();
            this.tabNotifs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentNotifs)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrSlide
            // 
            this.tmrSlide.Interval = 10;
            this.tmrSlide.Tick += new System.EventHandler(this.tmrSlide_Tick);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabDaily);
            this.tabMain.Controls.Add(this.tabCourses);
            this.tabMain.Controls.Add(this.tabAch);
            this.tabMain.Controls.Add(this.tabTermWork);
            this.tabMain.Controls.Add(this.tabNotifs);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabMain.RightToLeftLayout = true;
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(914, 562);
            this.tabMain.TabIndex = 2;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabDaily
            // 
            this.tabDaily.BackColor = System.Drawing.Color.SteelBlue;
            this.tabDaily.Controls.Add(this.dgvDaily);
            this.tabDaily.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabDaily.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabDaily.Location = new System.Drawing.Point(4, 46);
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaily.Size = new System.Drawing.Size(906, 512);
            this.tabDaily.TabIndex = 0;
            this.tabDaily.Tag = "1";
            this.tabDaily.Text = "            المهام اليومية  ";
            // 
            // dgvDaily
            // 
            this.dgvDaily.AllowUserToAddRows = false;
            this.dgvDaily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDaily.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDaily.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaily.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDaily.Location = new System.Drawing.Point(122, 67);
            this.dgvDaily.Name = "dgvDaily";
            this.dgvDaily.ReadOnly = true;
            this.dgvDaily.RowHeadersWidth = 51;
            this.dgvDaily.RowTemplate.Height = 26;
            this.dgvDaily.Size = new System.Drawing.Size(685, 350);
            this.dgvDaily.TabIndex = 0;
            this.dgvDaily.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaily_CellDoubleClick);
            // 
            // tabCourses
            // 
            this.tabCourses.Controls.Add(this.tabCoursesType);
            this.tabCourses.Location = new System.Drawing.Point(4, 46);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourses.Size = new System.Drawing.Size(906, 512);
            this.tabCourses.TabIndex = 1;
            this.tabCourses.Tag = "2";
            this.tabCourses.Text = " المقررات الدراسية ";
            this.tabCourses.UseVisualStyleBackColor = true;
            // 
            // tabCoursesType
            // 
            this.tabCoursesType.Controls.Add(this.tabTheo);
            this.tabCoursesType.Controls.Add(this.tabPrac);
            this.tabCoursesType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCoursesType.Location = new System.Drawing.Point(3, 3);
            this.tabCoursesType.Name = "tabCoursesType";
            this.tabCoursesType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabCoursesType.RightToLeftLayout = true;
            this.tabCoursesType.SelectedIndex = 0;
            this.tabCoursesType.Size = new System.Drawing.Size(900, 506);
            this.tabCoursesType.TabIndex = 0;
            // 
            // tabTheo
            // 
            this.tabTheo.BackColor = System.Drawing.Color.SteelBlue;
            this.tabTheo.Controls.Add(this.flpTheo);
            this.tabTheo.Location = new System.Drawing.Point(4, 46);
            this.tabTheo.Name = "tabTheo";
            this.tabTheo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheo.Size = new System.Drawing.Size(892, 456);
            this.tabTheo.TabIndex = 0;
            this.tabTheo.Tag = "1";
            this.tabTheo.Text = "نظـــــــــــــــــــــــــــــــري";
            // 
            // flpTheo
            // 
            this.flpTheo.AutoScroll = true;
            this.flpTheo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpTheo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTheo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTheo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.flpTheo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flpTheo.Location = new System.Drawing.Point(164, 19);
            this.flpTheo.Name = "flpTheo";
            this.flpTheo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpTheo.Size = new System.Drawing.Size(710, 393);
            this.flpTheo.TabIndex = 1;
            this.flpTheo.WrapContents = false;
            // 
            // tabPrac
            // 
            this.tabPrac.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPrac.Controls.Add(this.flpPrac);
            this.tabPrac.Location = new System.Drawing.Point(4, 46);
            this.tabPrac.Name = "tabPrac";
            this.tabPrac.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrac.Size = new System.Drawing.Size(892, 456);
            this.tabPrac.TabIndex = 1;
            this.tabPrac.Text = "  عمــــــــــــــــــــــــــــــلي";
            // 
            // flpPrac
            // 
            this.flpPrac.AutoScroll = true;
            this.flpPrac.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpPrac.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPrac.Location = new System.Drawing.Point(164, 19);
            this.flpPrac.Name = "flpPrac";
            this.flpPrac.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpPrac.Size = new System.Drawing.Size(710, 393);
            this.flpPrac.TabIndex = 0;
            this.flpPrac.WrapContents = false;
            // 
            // tabAch
            // 
            this.tabAch.BackColor = System.Drawing.Color.SteelBlue;
            this.tabAch.Controls.Add(this.lblAchSummary);
            this.tabAch.Controls.Add(this.prgAchWeek);
            this.tabAch.Controls.Add(this.lblAchTitle);
            this.tabAch.Controls.Add(this.dgvAch);
            this.tabAch.Location = new System.Drawing.Point(4, 46);
            this.tabAch.Name = "tabAch";
            this.tabAch.Size = new System.Drawing.Size(906, 512);
            this.tabAch.TabIndex = 2;
            this.tabAch.Tag = "3";
            this.tabAch.Text = " الإنجازات ";
            // 
            // lblAchSummary
            // 
            this.lblAchSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAchSummary.Location = new System.Drawing.Point(0, 54);
            this.lblAchSummary.Name = "lblAchSummary";
            this.lblAchSummary.Size = new System.Drawing.Size(906, 41);
            this.lblAchSummary.TabIndex = 4;
            this.lblAchSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgAchWeek
            // 
            this.prgAchWeek.Location = new System.Drawing.Point(155, 98);
            this.prgAchWeek.Name = "prgAchWeek";
            this.prgAchWeek.Size = new System.Drawing.Size(594, 25);
            this.prgAchWeek.TabIndex = 3;
            // 
            // lblAchTitle
            // 
            this.lblAchTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAchTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAchTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAchTitle.Name = "lblAchTitle";
            this.lblAchTitle.Size = new System.Drawing.Size(906, 54);
            this.lblAchTitle.TabIndex = 0;
            this.lblAchTitle.Text = " إنجاز الأسبوع";
            this.lblAchTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAch
            // 
            this.dgvAch.AllowUserToAddRows = false;
            this.dgvAch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAch.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvAch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAch.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAch.Location = new System.Drawing.Point(12, 127);
            this.dgvAch.Margin = new System.Windows.Forms.Padding(7);
            this.dgvAch.Name = "dgvAch";
            this.dgvAch.ReadOnly = true;
            this.dgvAch.RowHeadersWidth = 51;
            this.dgvAch.RowTemplate.Height = 26;
            this.dgvAch.Size = new System.Drawing.Size(882, 369);
            this.dgvAch.TabIndex = 5;
            // 
            // tabTermWork
            // 
            this.tabTermWork.BackColor = System.Drawing.Color.SteelBlue;
            this.tabTermWork.Controls.Add(this.dgvTermWork);
            this.tabTermWork.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabTermWork.Location = new System.Drawing.Point(4, 46);
            this.tabTermWork.Name = "tabTermWork";
            this.tabTermWork.Size = new System.Drawing.Size(906, 512);
            this.tabTermWork.TabIndex = 3;
            this.tabTermWork.Tag = "4";
            this.tabTermWork.Text = "أعمال الفصل";
            // 
            // dgvTermWork
            // 
            this.dgvTermWork.AllowUserToAddRows = false;
            this.dgvTermWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTermWork.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTermWork.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTermWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermWork.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTermWork.Location = new System.Drawing.Point(95, 57);
            this.dgvTermWork.Name = "dgvTermWork";
            this.dgvTermWork.ReadOnly = true;
            this.dgvTermWork.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvTermWork.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTermWork.RowTemplate.Height = 26;
            this.dgvTermWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermWork.Size = new System.Drawing.Size(719, 382);
            this.dgvTermWork.TabIndex = 1;
            // 
            // tabNotifs
            // 
            this.tabNotifs.BackColor = System.Drawing.Color.SteelBlue;
            this.tabNotifs.Controls.Add(this.dgvStudentNotifs);
            this.tabNotifs.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabNotifs.Location = new System.Drawing.Point(4, 46);
            this.tabNotifs.Name = "tabNotifs";
            this.tabNotifs.Size = new System.Drawing.Size(906, 512);
            this.tabNotifs.TabIndex = 4;
            this.tabNotifs.Text = "الإشعارات";
            // 
            // dgvStudentNotifs
            // 
            this.dgvStudentNotifs.AllowUserToAddRows = false;
            this.dgvStudentNotifs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentNotifs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudentNotifs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudentNotifs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentNotifs.Location = new System.Drawing.Point(94, 71);
            this.dgvStudentNotifs.Name = "dgvStudentNotifs";
            this.dgvStudentNotifs.RowHeadersWidth = 51;
            this.dgvStudentNotifs.RowTemplate.Height = 26;
            this.dgvStudentNotifs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentNotifs.Size = new System.Drawing.Size(698, 388);
            this.dgvStudentNotifs.TabIndex = 0;
            this.dgvStudentNotifs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentNotifs_CellDoubleClick);
            // 
            // btnInfo
            // 
            this.btnInfo.AutoSize = true;
            this.btnInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInfo.BackgroundImage = global::UniTaskSystem.Properties.Resources.ic_user;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInfo.Location = new System.Drawing.Point(837, -2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(88, 42);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "☰          ";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTitle.Location = new System.Drawing.Point(211, 139);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNameTitle.Size = new System.Drawing.Size(86, 28);
            this.lblNameTitle.TabIndex = 1;
            this.lblNameTitle.Text = "الاسم :";
            this.lblNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameValue
            // 
            this.lblNameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameValue.Location = new System.Drawing.Point(5, 142);
            this.lblNameValue.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNameValue.Size = new System.Drawing.Size(220, 25);
            this.lblNameValue.TabIndex = 2;
            this.lblNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 181);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = " الرقم الجامعي :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 223);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(118, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = " التخصص :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdValue
            // 
            this.lblIdValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdValue.Location = new System.Drawing.Point(3, 186);
            this.lblIdValue.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdValue.Size = new System.Drawing.Size(144, 23);
            this.lblIdValue.TabIndex = 5;
            this.lblIdValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMajorValue
            // 
            this.lblMajorValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajorValue.Location = new System.Drawing.Point(14, 227);
            this.lblMajorValue.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblMajorValue.Name = "lblMajorValue";
            this.lblMajorValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMajorValue.Size = new System.Drawing.Size(157, 23);
            this.lblMajorValue.TabIndex = 7;
            this.lblMajorValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLevelValue
            // 
            this.lblLevelValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelValue.Location = new System.Drawing.Point(19, 309);
            this.lblLevelValue.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblLevelValue.Name = "lblLevelValue";
            this.lblLevelValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLevelValue.Size = new System.Drawing.Size(166, 23);
            this.lblLevelValue.TabIndex = 8;
            this.lblLevelValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDeptValue
            // 
            this.lblDeptValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptValue.Location = new System.Drawing.Point(29, 267);
            this.lblDeptValue.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblDeptValue.Name = "lblDeptValue";
            this.lblDeptValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeptValue.Size = new System.Drawing.Size(167, 23);
            this.lblDeptValue.TabIndex = 10;
            this.lblDeptValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(207, 263);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(91, 28);
            this.label11.TabIndex = 11;
            this.label11.Text = " القسم :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(184, 305);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(113, 28);
            this.label12.TabIndex = 12;
            this.label12.Text = "المستوى :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTermValue
            // 
            this.lblTermValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermValue.Location = new System.Drawing.Point(6, 351);
            this.lblTermValue.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTermValue.Name = "lblTermValue";
            this.lblTermValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTermValue.Size = new System.Drawing.Size(206, 23);
            this.lblTermValue.TabIndex = 13;
            this.lblTermValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 346);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "الترم :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Image = global::UniTaskSystem.Properties.Resources.ic_user;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(300, 93);
            this.label1.TabIndex = 21;
            this.label1.Text = "الـمـلف الشــخصي :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlInfo.Controls.Add(this.button2);
            this.pnlInfo.Controls.Add(this.btnChangePassword);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.lblTermValue);
            this.pnlInfo.Controls.Add(this.label12);
            this.pnlInfo.Controls.Add(this.label11);
            this.pnlInfo.Controls.Add(this.lblDeptValue);
            this.pnlInfo.Controls.Add(this.lblLevelValue);
            this.pnlInfo.Controls.Add(this.lblMajorValue);
            this.pnlInfo.Controls.Add(this.lblIdValue);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.lblNameValue);
            this.pnlInfo.Controls.Add(this.lblNameTitle);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(914, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(0, 562);
            this.pnlInfo.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(18, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 42);
            this.button2.TabIndex = 23;
            this.button2.Text = "تسجيل خروج ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(141, 397);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(148, 38);
            this.btnChangePassword.TabIndex = 22;
            this.btnChangePassword.Text = "تغيير كلمة المرور";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // StudentMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StudentMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMain";
            this.Load += new System.EventHandler(this.StudentMainForm_Load);
            this.tabMain.ResumeLayout(false);
            this.tabDaily.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).EndInit();
            this.tabCourses.ResumeLayout(false);
            this.tabCoursesType.ResumeLayout(false);
            this.tabTheo.ResumeLayout(false);
            this.tabPrac.ResumeLayout(false);
            this.tabAch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAch)).EndInit();
            this.tabTermWork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermWork)).EndInit();
            this.tabNotifs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentNotifs)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Timer tmrSlide;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.DataGridView dgvDaily;
        private System.Windows.Forms.TabPage tabCourses;
        private System.Windows.Forms.TabPage tabAch;
        private System.Windows.Forms.TabPage tabTermWork;
        private System.Windows.Forms.TabControl tabCoursesType;
        private System.Windows.Forms.TabPage tabTheo;
        private System.Windows.Forms.FlowLayoutPanel flpTheo;
        private System.Windows.Forms.TabPage tabPrac;
        private System.Windows.Forms.FlowLayoutPanel flpPrac;
        private System.Windows.Forms.DataGridView dgvTermWork;
        private System.Windows.Forms.Label lblAchTitle;
        private System.Windows.Forms.Label lblAchSummary;
        private System.Windows.Forms.ProgressBar prgAchWeek;
        private System.Windows.Forms.DataGridView dgvAch;
        private System.Windows.Forms.TabPage tabNotifs;
        private System.Windows.Forms.DataGridView dgvStudentNotifs;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblMajorValue;
        private System.Windows.Forms.Label lblLevelValue;
        private System.Windows.Forms.Label lblDeptValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTermValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnChangePassword;
    }
}
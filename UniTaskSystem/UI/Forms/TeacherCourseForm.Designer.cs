namespace UniTaskSystem.UI.Forms
{
    partial class TeacherCourseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabCourse = new System.Windows.Forms.TabControl();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAddAttach = new System.Windows.Forms.Button();
            this.lstAttach = new System.Windows.Forms.ListBox();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.chkDeadline = new System.Windows.Forms.CheckBox();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbPostType = new System.Windows.Forms.ComboBox();
            this.tabSubmissions = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrade = new System.Windows.Forms.Button();
            this.dgvSubs = new System.Windows.Forms.DataGridView();
            this.cmbTasks = new System.Windows.Forms.ComboBox();
            this.tabGrades = new System.Windows.Forms.TabPage();
            this.txtGradeSearch = new System.Windows.Forms.TextBox();
            this.lblGradeSearch = new System.Windows.Forms.Label();
            this.btnSaveGrades = new System.Windows.Forms.Button();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.tabPlan = new System.Windows.Forms.TabPage();
            this.pnlPlanButtons = new System.Windows.Forms.Panel();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.btnRefreshPlan = new System.Windows.Forms.Button();
            this.prgPlan = new System.Windows.Forms.ProgressBar();
            this.btnAddExtraLecture = new System.Windows.Forms.Button();
            this.btnUnmarkCovered = new System.Windows.Forms.Button();
            this.btnMarkCovered = new System.Windows.Forms.Button();
            this.lblPlanStats = new System.Windows.Forms.Label();
            this.tabManagePosts = new System.Windows.Forms.TabPage();
            this.tlpPostsRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPostSearch = new System.Windows.Forms.Panel();
            this.flpPostSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefreshPosts = new System.Windows.Forms.Button();
            this.cmbPostTypeFilter = new System.Windows.Forms.ComboBox();
            this.txtPostSearch = new System.Windows.Forms.TextBox();
            this.lblPostSearch = new System.Windows.Forms.Label();
            this.splitPosts = new System.Windows.Forms.SplitContainer();
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.pnlPostEditor = new System.Windows.Forms.Panel();
            this.tlpPostEditor = new System.Windows.Forms.TableLayoutPanel();
            this.lblPostIdCaption = new System.Windows.Forms.Label();
            this.lblPostId = new System.Windows.Forms.Label();
            this.lblEditTypeCaption = new System.Windows.Forms.Label();
            this.cmbEditType = new System.Windows.Forms.ComboBox();
            this.lblEditTitleCaption = new System.Windows.Forms.Label();
            this.txtEditTitle = new System.Windows.Forms.TextBox();
            this.lblEditDeadlineCaption = new System.Windows.Forms.Label();
            this.flpEditDeadline = new System.Windows.Forms.FlowLayoutPanel();
            this.dtpEditDeadline = new System.Windows.Forms.DateTimePicker();
            this.chkEditDeadline = new System.Windows.Forms.CheckBox();
            this.lblEditBodyCaption = new System.Windows.Forms.Label();
            this.rtbEditBody = new System.Windows.Forms.RichTextBox();
            this.lblPostButtonsCaption = new System.Windows.Forms.Label();
            this.flpPostButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeletePost = new System.Windows.Forms.Button();
            this.btnUpdatePost = new System.Windows.Forms.Button();
            this.btnViewPostAttachments = new System.Windows.Forms.Button();
            this.btnClearPost = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabCourse.SuspendLayout();
            this.tabSend.SuspendLayout();
            this.tabSubmissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubs)).BeginInit();
            this.tabGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.tabPlan.SuspendLayout();
            this.pnlPlanButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.tabManagePosts.SuspendLayout();
            this.tlpPostsRoot.SuspendLayout();
            this.pnlPostSearch.SuspendLayout();
            this.flpPostSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPosts)).BeginInit();
            this.splitPosts.Panel1.SuspendLayout();
            this.splitPosts.Panel2.SuspendLayout();
            this.splitPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.pnlPostEditor.SuspendLayout();
            this.tlpPostEditor.SuspendLayout();
            this.flpEditDeadline.SuspendLayout();
            this.flpPostButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(914, 52);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabCourse
            // 
            this.tabCourse.Controls.Add(this.tabSend);
            this.tabCourse.Controls.Add(this.tabSubmissions);
            this.tabCourse.Controls.Add(this.tabGrades);
            this.tabCourse.Controls.Add(this.tabPlan);
            this.tabCourse.Controls.Add(this.tabManagePosts);
            this.tabCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabCourse.Location = new System.Drawing.Point(0, 52);
            this.tabCourse.Name = "tabCourse";
            this.tabCourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabCourse.RightToLeftLayout = true;
            this.tabCourse.SelectedIndex = 0;
            this.tabCourse.Size = new System.Drawing.Size(914, 510);
            this.tabCourse.TabIndex = 3;
            // 
            // tabSend
            // 
            this.tabSend.BackColor = System.Drawing.Color.SteelBlue;
            this.tabSend.Controls.Add(this.btnSend);
            this.tabSend.Controls.Add(this.btnAddAttach);
            this.tabSend.Controls.Add(this.lstAttach);
            this.tabSend.Controls.Add(this.dtpDeadline);
            this.tabSend.Controls.Add(this.chkDeadline);
            this.tabSend.Controls.Add(this.rtbBody);
            this.tabSend.Controls.Add(this.txtTitle);
            this.tabSend.Controls.Add(this.cmbPostType);
            this.tabSend.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabSend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabSend.Location = new System.Drawing.Point(4, 37);
            this.tabSend.Name = "tabSend";
            this.tabSend.Padding = new System.Windows.Forms.Padding(3);
            this.tabSend.Size = new System.Drawing.Size(906, 469);
            this.tabSend.TabIndex = 0;
            this.tabSend.Tag = "1";
            this.tabSend.Text = "         إرسال مهمة   ";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Navy;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSend.Location = new System.Drawing.Point(204, 306);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(137, 60);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "إرسال";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnAddAttach
            // 
            this.btnAddAttach.BackColor = System.Drawing.Color.Blue;
            this.btnAddAttach.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddAttach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddAttach.Location = new System.Drawing.Point(614, 306);
            this.btnAddAttach.Name = "btnAddAttach";
            this.btnAddAttach.Size = new System.Drawing.Size(137, 60);
            this.btnAddAttach.TabIndex = 7;
            this.btnAddAttach.Text = "إضافة مرفق";
            this.btnAddAttach.UseVisualStyleBackColor = false;
            this.btnAddAttach.Click += new System.EventHandler(this.btnAddAttach_Click);
            // 
            // lstAttach
            // 
            this.lstAttach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lstAttach.FormattingEnabled = true;
            this.lstAttach.ItemHeight = 28;
            this.lstAttach.Location = new System.Drawing.Point(347, 306);
            this.lstAttach.Name = "lstAttach";
            this.lstAttach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstAttach.Size = new System.Drawing.Size(276, 60);
            this.lstAttach.TabIndex = 6;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Location = new System.Drawing.Point(411, 372);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(340, 43);
            this.dtpDeadline.TabIndex = 5;
            // 
            // chkDeadline
            // 
            this.chkDeadline.BackColor = System.Drawing.Color.CornflowerBlue;
            this.chkDeadline.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkDeadline.Location = new System.Drawing.Point(204, 372);
            this.chkDeadline.Name = "chkDeadline";
            this.chkDeadline.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDeadline.Size = new System.Drawing.Size(201, 43);
            this.chkDeadline.TabIndex = 4;
            this.chkDeadline.Text = "يوجد موعد نهائي";
            this.chkDeadline.UseVisualStyleBackColor = false;
            // 
            // rtbBody
            // 
            this.rtbBody.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rtbBody.Location = new System.Drawing.Point(204, 82);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(547, 218);
            this.rtbBody.TabIndex = 3;
            this.rtbBody.Text = "";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTitle.Location = new System.Drawing.Point(204, 29);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(338, 47);
            this.txtTitle.TabIndex = 2;
            // 
            // cmbPostType
            // 
            this.cmbPostType.FormattingEnabled = true;
            this.cmbPostType.Items.AddRange(new object[] {
            "مقرر",
            "مهمة ",
            "نماذج"});
            this.cmbPostType.Location = new System.Drawing.Point(548, 27);
            this.cmbPostType.Name = "cmbPostType";
            this.cmbPostType.Size = new System.Drawing.Size(203, 45);
            this.cmbPostType.TabIndex = 1;
            // 
            // tabSubmissions
            // 
            this.tabSubmissions.BackColor = System.Drawing.Color.SteelBlue;
            this.tabSubmissions.Controls.Add(this.label1);
            this.tabSubmissions.Controls.Add(this.btnGrade);
            this.tabSubmissions.Controls.Add(this.dgvSubs);
            this.tabSubmissions.Controls.Add(this.cmbTasks);
            this.tabSubmissions.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabSubmissions.Location = new System.Drawing.Point(4, 37);
            this.tabSubmissions.Name = "tabSubmissions";
            this.tabSubmissions.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubmissions.Size = new System.Drawing.Size(906, 469);
            this.tabSubmissions.TabIndex = 1;
            this.tabSubmissions.Tag = "2";
            this.tabSubmissions.Text = "   تصحيح المهام   ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(651, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "عنوان المهمة :";
            // 
            // btnGrade
            // 
            this.btnGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGrade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGrade.Location = new System.Drawing.Point(733, 383);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(118, 55);
            this.btnGrade.TabIndex = 2;
            this.btnGrade.Text = "تصحيح";
            this.btnGrade.UseVisualStyleBackColor = false;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // dgvSubs
            // 
            this.dgvSubs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSubs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubs.Location = new System.Drawing.Point(111, 80);
            this.dgvSubs.Name = "dgvSubs";
            this.dgvSubs.RowHeadersWidth = 51;
            this.dgvSubs.RowTemplate.Height = 26;
            this.dgvSubs.Size = new System.Drawing.Size(739, 297);
            this.dgvSubs.TabIndex = 1;
            // 
            // cmbTasks
            // 
            this.cmbTasks.FormattingEnabled = true;
            this.cmbTasks.Location = new System.Drawing.Point(299, 25);
            this.cmbTasks.Name = "cmbTasks";
            this.cmbTasks.Size = new System.Drawing.Size(346, 39);
            this.cmbTasks.TabIndex = 0;
            this.cmbTasks.SelectedIndexChanged += new System.EventHandler(this.cmbTasks_SelectedIndexChanged);
            // 
            // tabGrades
            // 
            this.tabGrades.BackColor = System.Drawing.Color.SteelBlue;
            this.tabGrades.Controls.Add(this.txtGradeSearch);
            this.tabGrades.Controls.Add(this.lblGradeSearch);
            this.tabGrades.Controls.Add(this.btnSaveGrades);
            this.tabGrades.Controls.Add(this.dgvGrades);
            this.tabGrades.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabGrades.Location = new System.Drawing.Point(4, 37);
            this.tabGrades.Name = "tabGrades";
            this.tabGrades.Size = new System.Drawing.Size(906, 469);
            this.tabGrades.TabIndex = 2;
            this.tabGrades.Tag = "3";
            this.tabGrades.Text = "  درجة الطلاب  ";
            // 
            // txtGradeSearch
            // 
            this.txtGradeSearch.Location = new System.Drawing.Point(411, 8);
            this.txtGradeSearch.Name = "txtGradeSearch";
            this.txtGradeSearch.Size = new System.Drawing.Size(379, 34);
            this.txtGradeSearch.TabIndex = 5;
            this.txtGradeSearch.TextChanged += new System.EventHandler(this.txtGradeSearch_TextChanged);
            // 
            // lblGradeSearch
            // 
            this.lblGradeSearch.AutoSize = true;
            this.lblGradeSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblGradeSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblGradeSearch.ForeColor = System.Drawing.Color.White;
            this.lblGradeSearch.Location = new System.Drawing.Point(796, 11);
            this.lblGradeSearch.Name = "lblGradeSearch";
            this.lblGradeSearch.Size = new System.Drawing.Size(107, 28);
            this.lblGradeSearch.TabIndex = 4;
            this.lblGradeSearch.Text = "بحث طالب:";
            // 
            // btnSaveGrades
            // 
            this.btnSaveGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveGrades.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveGrades.Location = new System.Drawing.Point(0, -1);
            this.btnSaveGrades.Name = "btnSaveGrades";
            this.btnSaveGrades.Size = new System.Drawing.Size(144, 47);
            this.btnSaveGrades.TabIndex = 3;
            this.btnSaveGrades.Text = "حفظ 💾";
            this.btnSaveGrades.UseVisualStyleBackColor = false;
            this.btnSaveGrades.Click += new System.EventHandler(this.btnSaveGrades_Click);
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrades.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvGrades.Location = new System.Drawing.Point(0, 48);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvGrades.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrades.RowTemplate.Height = 26;
            this.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrades.Size = new System.Drawing.Size(906, 412);
            this.dgvGrades.TabIndex = 2;
            this.dgvGrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrades_CellContentClick);
            this.dgvGrades.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvGrades_CellValidating);
            this.dgvGrades.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrades_CellValueChanged);
            this.dgvGrades.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvGrades_CurrentCellDirtyStateChanged);
            // 
            // tabPlan
            // 
            this.tabPlan.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPlan.Controls.Add(this.pnlPlanButtons);
            this.tabPlan.Controls.Add(this.lblPlanStats);
            this.tabPlan.Location = new System.Drawing.Point(4, 37);
            this.tabPlan.Name = "tabPlan";
            this.tabPlan.Size = new System.Drawing.Size(906, 469);
            this.tabPlan.TabIndex = 3;
            this.tabPlan.Tag = "4";
            this.tabPlan.Text = "  الخطة والتقدم ";
            // 
            // pnlPlanButtons
            // 
            this.pnlPlanButtons.BackColor = System.Drawing.Color.Azure;
            this.pnlPlanButtons.Controls.Add(this.dgvPlan);
            this.pnlPlanButtons.Controls.Add(this.btnRefreshPlan);
            this.pnlPlanButtons.Controls.Add(this.prgPlan);
            this.pnlPlanButtons.Controls.Add(this.btnAddExtraLecture);
            this.pnlPlanButtons.Controls.Add(this.btnUnmarkCovered);
            this.pnlPlanButtons.Controls.Add(this.btnMarkCovered);
            this.pnlPlanButtons.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnlPlanButtons.Location = new System.Drawing.Point(26, 38);
            this.pnlPlanButtons.Name = "pnlPlanButtons";
            this.pnlPlanButtons.Size = new System.Drawing.Size(854, 422);
            this.pnlPlanButtons.TabIndex = 2;
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Location = new System.Drawing.Point(12, 90);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowHeadersWidth = 51;
            this.dgvPlan.RowTemplate.Height = 26;
            this.dgvPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlan.Size = new System.Drawing.Size(828, 320);
            this.dgvPlan.TabIndex = 4;
            // 
            // btnRefreshPlan
            // 
            this.btnRefreshPlan.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshPlan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefreshPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRefreshPlan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRefreshPlan.Location = new System.Drawing.Point(742, 3);
            this.btnRefreshPlan.Name = "btnRefreshPlan";
            this.btnRefreshPlan.Size = new System.Drawing.Size(109, 41);
            this.btnRefreshPlan.TabIndex = 3;
            this.btnRefreshPlan.Text = "تحديث 🔃";
            this.btnRefreshPlan.UseVisualStyleBackColor = false;
            this.btnRefreshPlan.Click += new System.EventHandler(this.btnRefreshPlan_Click);
            // 
            // prgPlan
            // 
            this.prgPlan.Location = new System.Drawing.Point(172, 20);
            this.prgPlan.Name = "prgPlan";
            this.prgPlan.Size = new System.Drawing.Size(524, 24);
            this.prgPlan.TabIndex = 1;
            // 
            // btnAddExtraLecture
            // 
            this.btnAddExtraLecture.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddExtraLecture.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddExtraLecture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddExtraLecture.ForeColor = System.Drawing.Color.White;
            this.btnAddExtraLecture.Location = new System.Drawing.Point(515, 50);
            this.btnAddExtraLecture.Name = "btnAddExtraLecture";
            this.btnAddExtraLecture.Size = new System.Drawing.Size(200, 41);
            this.btnAddExtraLecture.TabIndex = 2;
            this.btnAddExtraLecture.Text = "إضافة محاضرة ➕";
            this.btnAddExtraLecture.UseVisualStyleBackColor = false;
            this.btnAddExtraLecture.Click += new System.EventHandler(this.btnAddExtraLecture_Click);
            // 
            // btnUnmarkCovered
            // 
            this.btnUnmarkCovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUnmarkCovered.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnUnmarkCovered.FlatAppearance.BorderSize = 2;
            this.btnUnmarkCovered.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUnmarkCovered.ForeColor = System.Drawing.Color.Blue;
            this.btnUnmarkCovered.Location = new System.Drawing.Point(12, 50);
            this.btnUnmarkCovered.Name = "btnUnmarkCovered";
            this.btnUnmarkCovered.Size = new System.Drawing.Size(117, 41);
            this.btnUnmarkCovered.TabIndex = 1;
            this.btnUnmarkCovered.Text = "إلـغاء  ✖️";
            this.btnUnmarkCovered.UseVisualStyleBackColor = false;
            this.btnUnmarkCovered.Click += new System.EventHandler(this.btnUnmarkCovered_Click);
            // 
            // btnMarkCovered
            // 
            this.btnMarkCovered.BackColor = System.Drawing.Color.Blue;
            this.btnMarkCovered.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMarkCovered.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMarkCovered.ForeColor = System.Drawing.Color.White;
            this.btnMarkCovered.Location = new System.Drawing.Point(135, 50);
            this.btnMarkCovered.Name = "btnMarkCovered";
            this.btnMarkCovered.Size = new System.Drawing.Size(114, 41);
            this.btnMarkCovered.TabIndex = 0;
            this.btnMarkCovered.Text = "مشروحة✔️";
            this.btnMarkCovered.UseVisualStyleBackColor = false;
            this.btnMarkCovered.Click += new System.EventHandler(this.btnMarkCovered_Click);
            // 
            // lblPlanStats
            // 
            this.lblPlanStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPlanStats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlanStats.Location = new System.Drawing.Point(0, 0);
            this.lblPlanStats.Name = "lblPlanStats";
            this.lblPlanStats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlanStats.Size = new System.Drawing.Size(906, 35);
            this.lblPlanStats.TabIndex = 0;
            this.lblPlanStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabManagePosts
            // 
            this.tabManagePosts.BackColor = System.Drawing.Color.SteelBlue;
            this.tabManagePosts.Controls.Add(this.tlpPostsRoot);
            this.tabManagePosts.Location = new System.Drawing.Point(4, 37);
            this.tabManagePosts.Name = "tabManagePosts";
            this.tabManagePosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabManagePosts.Size = new System.Drawing.Size(906, 469);
            this.tabManagePosts.TabIndex = 4;
            this.tabManagePosts.Text = "إدارة المنشورات";
            // 
            // tlpPostsRoot
            // 
            this.tlpPostsRoot.ColumnCount = 1;
            this.tlpPostsRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPostsRoot.Controls.Add(this.pnlPostSearch, 0, 0);
            this.tlpPostsRoot.Controls.Add(this.splitPosts, 0, 1);
            this.tlpPostsRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPostsRoot.Location = new System.Drawing.Point(3, 3);
            this.tlpPostsRoot.Name = "tlpPostsRoot";
            this.tlpPostsRoot.RowCount = 2;
            this.tlpPostsRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpPostsRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPostsRoot.Size = new System.Drawing.Size(900, 463);
            this.tlpPostsRoot.TabIndex = 0;
            // 
            // pnlPostSearch
            // 
            this.pnlPostSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlPostSearch.Controls.Add(this.flpPostSearch);
            this.pnlPostSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPostSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlPostSearch.Name = "pnlPostSearch";
            this.pnlPostSearch.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pnlPostSearch.Size = new System.Drawing.Size(894, 52);
            this.pnlPostSearch.TabIndex = 0;
            // 
            // flpPostSearch
            // 
            this.flpPostSearch.Controls.Add(this.btnRefreshPosts);
            this.flpPostSearch.Controls.Add(this.cmbPostTypeFilter);
            this.flpPostSearch.Controls.Add(this.txtPostSearch);
            this.flpPostSearch.Controls.Add(this.lblPostSearch);
            this.flpPostSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPostSearch.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPostSearch.Location = new System.Drawing.Point(8, 6);
            this.flpPostSearch.Name = "flpPostSearch";
            this.flpPostSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpPostSearch.Size = new System.Drawing.Size(878, 40);
            this.flpPostSearch.TabIndex = 0;
            this.flpPostSearch.WrapContents = false;
            // 
            // btnRefreshPosts
            // 
            this.btnRefreshPosts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshPosts.Location = new System.Drawing.Point(6, 2);
            this.btnRefreshPosts.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.btnRefreshPosts.Name = "btnRefreshPosts";
            this.btnRefreshPosts.Size = new System.Drawing.Size(96, 33);
            this.btnRefreshPosts.TabIndex = 3;
            this.btnRefreshPosts.Text = "تحديث";
            this.btnRefreshPosts.UseVisualStyleBackColor = true;
            this.btnRefreshPosts.Click += new System.EventHandler(this.btnRefreshPosts_Click);
            // 
            // cmbPostTypeFilter
            // 
            this.cmbPostTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPostTypeFilter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPostTypeFilter.FormattingEnabled = true;
            this.cmbPostTypeFilter.Items.AddRange(new object[] {
            "الكل",
            "مهمة",
            "مقرر",
            "نماذج"});
            this.cmbPostTypeFilter.Location = new System.Drawing.Point(114, 2);
            this.cmbPostTypeFilter.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.cmbPostTypeFilter.Name = "cmbPostTypeFilter";
            this.cmbPostTypeFilter.Size = new System.Drawing.Size(257, 33);
            this.cmbPostTypeFilter.TabIndex = 2;
            this.cmbPostTypeFilter.SelectedIndexChanged += new System.EventHandler(this.PostFilters_Changed);
            // 
            // txtPostSearch
            // 
            this.txtPostSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostSearch.Location = new System.Drawing.Point(383, 2);
            this.txtPostSearch.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.txtPostSearch.Name = "txtPostSearch";
            this.txtPostSearch.Size = new System.Drawing.Size(369, 32);
            this.txtPostSearch.TabIndex = 1;
            this.txtPostSearch.TextChanged += new System.EventHandler(this.PostFilters_Changed);
            // 
            // lblPostSearch
            // 
            this.lblPostSearch.AutoSize = true;
            this.lblPostSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostSearch.Location = new System.Drawing.Point(764, 2);
            this.lblPostSearch.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblPostSearch.Name = "lblPostSearch";
            this.lblPostSearch.Size = new System.Drawing.Size(51, 25);
            this.lblPostSearch.TabIndex = 0;
            this.lblPostSearch.Text = "بحث:";
            this.lblPostSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitPosts
            // 
            this.splitPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPosts.Location = new System.Drawing.Point(3, 61);
            this.splitPosts.Name = "splitPosts";
            // 
            // splitPosts.Panel1
            // 
            this.splitPosts.Panel1.Controls.Add(this.dgvPosts);
            this.splitPosts.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitPosts.Panel2
            // 
            this.splitPosts.Panel2.Controls.Add(this.pnlPostEditor);
            this.splitPosts.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitPosts.Size = new System.Drawing.Size(894, 399);
            this.splitPosts.SplitterDistance = 403;
            this.splitPosts.TabIndex = 1;
            // 
            // dgvPosts
            // 
            this.dgvPosts.AllowUserToAddRows = false;
            this.dgvPosts.AllowUserToDeleteRows = false;
            this.dgvPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPosts.Location = new System.Drawing.Point(0, 0);
            this.dgvPosts.MultiSelect = false;
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.ReadOnly = true;
            this.dgvPosts.RowHeadersWidth = 51;
            this.dgvPosts.RowTemplate.Height = 26;
            this.dgvPosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosts.Size = new System.Drawing.Size(403, 399);
            this.dgvPosts.TabIndex = 0;
            this.dgvPosts.SelectionChanged += new System.EventHandler(this.dgvPosts_SelectionChanged);
            // 
            // pnlPostEditor
            // 
            this.pnlPostEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlPostEditor.Controls.Add(this.tlpPostEditor);
            this.pnlPostEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPostEditor.Location = new System.Drawing.Point(0, 0);
            this.pnlPostEditor.Name = "pnlPostEditor";
            this.pnlPostEditor.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPostEditor.Size = new System.Drawing.Size(487, 399);
            this.pnlPostEditor.TabIndex = 0;
            // 
            // tlpPostEditor
            // 
            this.tlpPostEditor.ColumnCount = 2;
            this.tlpPostEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.34261F));
            this.tlpPostEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.65739F));
            this.tlpPostEditor.Controls.Add(this.lblPostIdCaption, 0, 0);
            this.tlpPostEditor.Controls.Add(this.lblPostId, 1, 0);
            this.tlpPostEditor.Controls.Add(this.lblEditTypeCaption, 0, 1);
            this.tlpPostEditor.Controls.Add(this.lblEditTitleCaption, 0, 2);
            this.tlpPostEditor.Controls.Add(this.txtEditTitle, 1, 2);
            this.tlpPostEditor.Controls.Add(this.lblEditDeadlineCaption, 0, 3);
            this.tlpPostEditor.Controls.Add(this.flpEditDeadline, 1, 3);
            this.tlpPostEditor.Controls.Add(this.lblEditBodyCaption, 0, 4);
            this.tlpPostEditor.Controls.Add(this.rtbEditBody, 1, 4);
            this.tlpPostEditor.Controls.Add(this.lblPostButtonsCaption, 0, 5);
            this.tlpPostEditor.Controls.Add(this.flpPostButtons, 1, 5);
            this.tlpPostEditor.Controls.Add(this.cmbEditType, 1, 1);
            this.tlpPostEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPostEditor.Location = new System.Drawing.Point(10, 10);
            this.tlpPostEditor.Name = "tlpPostEditor";
            this.tlpPostEditor.RowCount = 6;
            this.tlpPostEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpPostEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpPostEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpPostEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpPostEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPostEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpPostEditor.Size = new System.Drawing.Size(467, 379);
            this.tlpPostEditor.TabIndex = 0;
            // 
            // lblPostIdCaption
            // 
            this.lblPostIdCaption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPostIdCaption.AutoSize = true;
            this.lblPostIdCaption.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblPostIdCaption.Location = new System.Drawing.Point(375, 3);
            this.lblPostIdCaption.Name = "lblPostIdCaption";
            this.lblPostIdCaption.Size = new System.Drawing.Size(74, 25);
            this.lblPostIdCaption.TabIndex = 0;
            this.lblPostIdCaption.Text = "المعرف:";
            // 
            // lblPostId
            // 
            this.lblPostId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPostId.AutoSize = true;
            this.lblPostId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblPostId.Location = new System.Drawing.Point(350, 3);
            this.lblPostId.Name = "lblPostId";
            this.lblPostId.Size = new System.Drawing.Size(19, 25);
            this.lblPostId.TabIndex = 1;
            this.lblPostId.Text = "-";
            // 
            // lblEditTypeCaption
            // 
            this.lblEditTypeCaption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEditTypeCaption.AutoSize = true;
            this.lblEditTypeCaption.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblEditTypeCaption.Location = new System.Drawing.Point(375, 37);
            this.lblEditTypeCaption.Name = "lblEditTypeCaption";
            this.lblEditTypeCaption.Size = new System.Drawing.Size(54, 25);
            this.lblEditTypeCaption.TabIndex = 2;
            this.lblEditTypeCaption.Text = "النوع:";
            // 
            // cmbEditType
            // 
            this.cmbEditType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditType.FormattingEnabled = true;
            this.cmbEditType.Items.AddRange(new object[] {
            "مهمة",
            "مقرر",
            "نماذج"});
            this.cmbEditType.Location = new System.Drawing.Point(158, 35);
            this.cmbEditType.Name = "cmbEditType";
            this.cmbEditType.Size = new System.Drawing.Size(211, 36);
            this.cmbEditType.TabIndex = 3;
            // 
            // lblEditTitleCaption
            // 
            this.lblEditTitleCaption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEditTitleCaption.AutoSize = true;
            this.lblEditTitleCaption.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblEditTitleCaption.Location = new System.Drawing.Point(375, 73);
            this.lblEditTitleCaption.Name = "lblEditTitleCaption";
            this.lblEditTitleCaption.Size = new System.Drawing.Size(71, 25);
            this.lblEditTitleCaption.TabIndex = 4;
            this.lblEditTitleCaption.Text = "العنوان:";
            // 
            // txtEditTitle
            // 
            this.txtEditTitle.Location = new System.Drawing.Point(65, 71);
            this.txtEditTitle.Name = "txtEditTitle";
            this.txtEditTitle.Size = new System.Drawing.Size(304, 34);
            this.txtEditTitle.TabIndex = 5;
            // 
            // lblEditDeadlineCaption
            // 
            this.lblEditDeadlineCaption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEditDeadlineCaption.AutoSize = true;
            this.lblEditDeadlineCaption.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblEditDeadlineCaption.Location = new System.Drawing.Point(375, 110);
            this.lblEditDeadlineCaption.Name = "lblEditDeadlineCaption";
            this.lblEditDeadlineCaption.Size = new System.Drawing.Size(68, 25);
            this.lblEditDeadlineCaption.TabIndex = 6;
            this.lblEditDeadlineCaption.Text = "الموعد:";
            // 
            // flpEditDeadline
            // 
            this.flpEditDeadline.Controls.Add(this.dtpEditDeadline);
            this.flpEditDeadline.Controls.Add(this.chkEditDeadline);
            this.flpEditDeadline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEditDeadline.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpEditDeadline.Location = new System.Drawing.Point(3, 107);
            this.flpEditDeadline.Name = "flpEditDeadline";
            this.flpEditDeadline.Size = new System.Drawing.Size(366, 32);
            this.flpEditDeadline.TabIndex = 7;
            this.flpEditDeadline.WrapContents = false;
            // 
            // dtpEditDeadline
            // 
            this.dtpEditDeadline.CustomFormat = "yyyy-MM-dd    hh-mm";
            this.dtpEditDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEditDeadline.Location = new System.Drawing.Point(3, 3);
            this.dtpEditDeadline.Name = "dtpEditDeadline";
            this.dtpEditDeadline.Size = new System.Drawing.Size(235, 34);
            this.dtpEditDeadline.TabIndex = 1;
            // 
            // chkEditDeadline
            // 
            this.chkEditDeadline.AutoSize = true;
            this.chkEditDeadline.Location = new System.Drawing.Point(244, 3);
            this.chkEditDeadline.Name = "chkEditDeadline";
            this.chkEditDeadline.Size = new System.Drawing.Size(130, 32);
            this.chkEditDeadline.TabIndex = 0;
            this.chkEditDeadline.Text = "موعد نهائي";
            this.chkEditDeadline.UseVisualStyleBackColor = true;
            this.chkEditDeadline.CheckedChanged += new System.EventHandler(this.chkEditDeadline_CheckedChanged);
            // 
            // lblEditBodyCaption
            // 
            this.lblEditBodyCaption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEditBodyCaption.AutoSize = true;
            this.lblEditBodyCaption.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblEditBodyCaption.Location = new System.Drawing.Point(375, 220);
            this.lblEditBodyCaption.Name = "lblEditBodyCaption";
            this.lblEditBodyCaption.Size = new System.Drawing.Size(79, 25);
            this.lblEditBodyCaption.TabIndex = 8;
            this.lblEditBodyCaption.Text = "المحتوى:";
            // 
            // rtbEditBody
            // 
            this.rtbEditBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEditBody.Location = new System.Drawing.Point(3, 145);
            this.rtbEditBody.Name = "rtbEditBody";
            this.rtbEditBody.Size = new System.Drawing.Size(366, 176);
            this.rtbEditBody.TabIndex = 9;
            this.rtbEditBody.Text = "";
            // 
            // lblPostButtonsCaption
            // 
            this.lblPostButtonsCaption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPostButtonsCaption.AutoSize = true;
            this.lblPostButtonsCaption.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblPostButtonsCaption.Location = new System.Drawing.Point(375, 339);
            this.lblPostButtonsCaption.Name = "lblPostButtonsCaption";
            this.lblPostButtonsCaption.Size = new System.Drawing.Size(55, 25);
            this.lblPostButtonsCaption.TabIndex = 10;
            this.lblPostButtonsCaption.Text = "أوامر:";
            // 
            // flpPostButtons
            // 
            this.flpPostButtons.Controls.Add(this.btnDeletePost);
            this.flpPostButtons.Controls.Add(this.btnUpdatePost);
            this.flpPostButtons.Controls.Add(this.btnViewPostAttachments);
            this.flpPostButtons.Controls.Add(this.btnClearPost);
            this.flpPostButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPostButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPostButtons.Location = new System.Drawing.Point(3, 327);
            this.flpPostButtons.Name = "flpPostButtons";
            this.flpPostButtons.Size = new System.Drawing.Size(366, 49);
            this.flpPostButtons.TabIndex = 11;
            this.flpPostButtons.WrapContents = false;
            // 
            // btnDeletePost
            // 
            this.btnDeletePost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeletePost.ForeColor = System.Drawing.Color.White;
            this.btnDeletePost.Location = new System.Drawing.Point(3, 3);
            this.btnDeletePost.Name = "btnDeletePost";
            this.btnDeletePost.Size = new System.Drawing.Size(79, 44);
            this.btnDeletePost.TabIndex = 1;
            this.btnDeletePost.Text = "حذف";
            this.btnDeletePost.UseVisualStyleBackColor = false;
            this.btnDeletePost.Click += new System.EventHandler(this.btnDeletePost_Click);
            // 
            // btnUpdatePost
            // 
            this.btnUpdatePost.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdatePost.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePost.Location = new System.Drawing.Point(88, 3);
            this.btnUpdatePost.Name = "btnUpdatePost";
            this.btnUpdatePost.Size = new System.Drawing.Size(92, 44);
            this.btnUpdatePost.TabIndex = 0;
            this.btnUpdatePost.Text = "حفظ";
            this.btnUpdatePost.UseVisualStyleBackColor = false;
            this.btnUpdatePost.Click += new System.EventHandler(this.btnUpdatePost_Click);
            // 
            // btnViewPostAttachments
            // 
            this.btnViewPostAttachments.Location = new System.Drawing.Point(186, 3);
            this.btnViewPostAttachments.Name = "btnViewPostAttachments";
            this.btnViewPostAttachments.Size = new System.Drawing.Size(90, 44);
            this.btnViewPostAttachments.TabIndex = 2;
            this.btnViewPostAttachments.Text = "مرفقات";
            this.btnViewPostAttachments.UseVisualStyleBackColor = true;
            this.btnViewPostAttachments.Click += new System.EventHandler(this.btnViewPostAttachments_Click);
            // 
            // btnClearPost
            // 
            this.btnClearPost.Location = new System.Drawing.Point(282, 3);
            this.btnClearPost.Name = "btnClearPost";
            this.btnClearPost.Size = new System.Drawing.Size(82, 44);
            this.btnClearPost.TabIndex = 3;
            this.btnClearPost.Text = "تفريغ";
            this.btnClearPost.UseVisualStyleBackColor = true;
            this.btnClearPost.Click += new System.EventHandler(this.btnClearPost_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBack.Location = new System.Drawing.Point(818, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "↩ رجوع";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TeacherCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabCourse);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TeacherCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherCourseForm";
            this.Load += new System.EventHandler(this.TeacherCourseForm_Load);
            this.tabCourse.ResumeLayout(false);
            this.tabSend.ResumeLayout(false);
            this.tabSend.PerformLayout();
            this.tabSubmissions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubs)).EndInit();
            this.tabGrades.ResumeLayout(false);
            this.tabGrades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.tabPlan.ResumeLayout(false);
            this.pnlPlanButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.tabManagePosts.ResumeLayout(false);
            this.tlpPostsRoot.ResumeLayout(false);
            this.pnlPostSearch.ResumeLayout(false);
            this.flpPostSearch.ResumeLayout(false);
            this.flpPostSearch.PerformLayout();
            this.splitPosts.Panel1.ResumeLayout(false);
            this.splitPosts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPosts)).EndInit();
            this.splitPosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            this.pnlPostEditor.ResumeLayout(false);
            this.tlpPostEditor.ResumeLayout(false);
            this.tlpPostEditor.PerformLayout();
            this.flpEditDeadline.ResumeLayout(false);
            this.flpEditDeadline.PerformLayout();
            this.flpPostButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tabCourse;
        private System.Windows.Forms.TabPage tabSend;
        private System.Windows.Forms.TabPage tabSubmissions;
        private System.Windows.Forms.TabPage tabGrades;
        private System.Windows.Forms.TabPage tabPlan;
        private System.Windows.Forms.ComboBox cmbPostType;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAddAttach;
        private System.Windows.Forms.ListBox lstAttach;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.CheckBox chkDeadline;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.DataGridView dgvSubs;
        private System.Windows.Forms.ComboBox cmbTasks;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveGrades;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Panel pnlPlanButtons;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.Button btnRefreshPlan;
        private System.Windows.Forms.ProgressBar prgPlan;
        private System.Windows.Forms.Button btnAddExtraLecture;
        private System.Windows.Forms.Button btnUnmarkCovered;
        private System.Windows.Forms.Button btnMarkCovered;
        private System.Windows.Forms.TabPage tabManagePosts;
        private System.Windows.Forms.TableLayoutPanel tlpPostsRoot;
        private System.Windows.Forms.Panel pnlPostSearch;
        private System.Windows.Forms.FlowLayoutPanel flpPostSearch;
        private System.Windows.Forms.Label lblPostSearch;
        private System.Windows.Forms.TextBox txtPostSearch;
        private System.Windows.Forms.ComboBox cmbPostTypeFilter;
        private System.Windows.Forms.Button btnRefreshPosts;
        private System.Windows.Forms.SplitContainer splitPosts;
        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.Panel pnlPostEditor;
        private System.Windows.Forms.TableLayoutPanel tlpPostEditor;
        private System.Windows.Forms.Label lblPostIdCaption;
        private System.Windows.Forms.Label lblPostId;
        private System.Windows.Forms.Label lblEditTypeCaption;
        private System.Windows.Forms.ComboBox cmbEditType;
        private System.Windows.Forms.Label lblEditTitleCaption;
        private System.Windows.Forms.TextBox txtEditTitle;
        private System.Windows.Forms.Label lblEditDeadlineCaption;
        private System.Windows.Forms.FlowLayoutPanel flpEditDeadline;
        private System.Windows.Forms.CheckBox chkEditDeadline;
        private System.Windows.Forms.DateTimePicker dtpEditDeadline;
        private System.Windows.Forms.Label lblEditBodyCaption;
        private System.Windows.Forms.RichTextBox rtbEditBody;
        private System.Windows.Forms.Label lblPostButtonsCaption;
        private System.Windows.Forms.FlowLayoutPanel flpPostButtons;
        private System.Windows.Forms.Button btnUpdatePost;
        private System.Windows.Forms.Button btnDeletePost;
        private System.Windows.Forms.Button btnViewPostAttachments;
        private System.Windows.Forms.Button btnClearPost;
        private System.Windows.Forms.Label lblGradeSearch;
        private System.Windows.Forms.TextBox txtGradeSearch;
        private System.Windows.Forms.Label lblPlanStats;
        private System.Windows.Forms.Button btnBack;
    }
}
namespace UniTaskSystem.UI.Forms
{
    partial class AdminMainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tpDepartments = new System.Windows.Forms.TabPage();
            this.splitDepartments = new System.Windows.Forms.SplitContainer();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.grpDepartments = new System.Windows.Forms.GroupBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.flpDepartmentsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDepartmentsAdd = new System.Windows.Forms.Button();
            this.btnDepartmentsUpdate = new System.Windows.Forms.Button();
            this.btnDepartmentsDelete = new System.Windows.Forms.Button();
            this.btnDepartmentsClear = new System.Windows.Forms.Button();
            this.pnlDepartmentsSearch = new System.Windows.Forms.Panel();
            this.btnDepartmentsRefresh = new System.Windows.Forms.Button();
            this.btnDepartmentsSearch = new System.Windows.Forms.Button();
            this.txtDepartmentsSearch = new System.Windows.Forms.TextBox();
            this.lblDepartmentsSearch = new System.Windows.Forms.Label();
            this.tpMajors = new System.Windows.Forms.TabPage();
            this.splitMajors = new System.Windows.Forms.SplitContainer();
            this.dgvMajors = new System.Windows.Forms.DataGridView();
            this.grpMajors = new System.Windows.Forms.GroupBox();
            this.lblMajorDept = new System.Windows.Forms.Label();
            this.cmbMajorDept = new System.Windows.Forms.ComboBox();
            this.lblMajorName = new System.Windows.Forms.Label();
            this.txtMajorName = new System.Windows.Forms.TextBox();
            this.flpMajorsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMajorsAdd = new System.Windows.Forms.Button();
            this.btnMajorsUpdate = new System.Windows.Forms.Button();
            this.btnMajorsDelete = new System.Windows.Forms.Button();
            this.btnMajorsClear = new System.Windows.Forms.Button();
            this.pnlMajorsSearch = new System.Windows.Forms.Panel();
            this.btnMajorsRefresh = new System.Windows.Forms.Button();
            this.btnMajorsSearch = new System.Windows.Forms.Button();
            this.txtMajorsSearch = new System.Windows.Forms.TextBox();
            this.lblMajorsSearch = new System.Windows.Forms.Label();
            this.tpTerms = new System.Windows.Forms.TabPage();
            this.splitTerms = new System.Windows.Forms.SplitContainer();
            this.dgvTerms = new System.Windows.Forms.DataGridView();
            this.grpTerms = new System.Windows.Forms.GroupBox();
            this.lblTermName = new System.Windows.Forms.Label();
            this.txtTermName = new System.Windows.Forms.TextBox();
            this.lblTermYear = new System.Windows.Forms.Label();
            this.nudTermYear = new System.Windows.Forms.NumericUpDown();
            this.chkTermActive = new System.Windows.Forms.CheckBox();
            this.flpTermsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTermsAdd = new System.Windows.Forms.Button();
            this.btnTermsUpdate = new System.Windows.Forms.Button();
            this.btnTermsDelete = new System.Windows.Forms.Button();
            this.btnTermsClear = new System.Windows.Forms.Button();
            this.pnlTermsSearch = new System.Windows.Forms.Panel();
            this.btnTermsRefresh = new System.Windows.Forms.Button();
            this.btnTermsSearch = new System.Windows.Forms.Button();
            this.txtTermsSearch = new System.Windows.Forms.TextBox();
            this.lblTermsSearch = new System.Windows.Forms.Label();
            this.tpStudents = new System.Windows.Forms.TabPage();
            this.splitStudents = new System.Windows.Forms.SplitContainer();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.grpStudents = new System.Windows.Forms.GroupBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentMajor = new System.Windows.Forms.Label();
            this.cmbStudentMajor = new System.Windows.Forms.ComboBox();
            this.lblStudentLevel = new System.Windows.Forms.Label();
            this.nudStudentLevel = new System.Windows.Forms.NumericUpDown();
            this.lblStudentTerm = new System.Windows.Forms.Label();
            this.cmbStudentTerm = new System.Windows.Forms.ComboBox();
            this.chkStudentActive = new System.Windows.Forms.CheckBox();
            this.flpStudentsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStudentsAdd = new System.Windows.Forms.Button();
            this.btnStudentsUpdate = new System.Windows.Forms.Button();
            this.btnStudentsDelete = new System.Windows.Forms.Button();
            this.btnStudentsClear = new System.Windows.Forms.Button();
            this.pnlStudentsSearch = new System.Windows.Forms.Panel();
            this.btnStudentsRefresh = new System.Windows.Forms.Button();
            this.btnStudentsSearch = new System.Windows.Forms.Button();
            this.txtStudentsSearch = new System.Windows.Forms.TextBox();
            this.lblStudentsSearch = new System.Windows.Forms.Label();
            this.tpTeachers = new System.Windows.Forms.TabPage();
            this.splitTeachers = new System.Windows.Forms.SplitContainer();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.grpTeachers = new System.Windows.Forms.GroupBox();
            this.lblTeacherId = new System.Windows.Forms.Label();
            this.txtTeacherId = new System.Windows.Forms.TextBox();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.chkTeacherActive = new System.Windows.Forms.CheckBox();
            this.flpTeachersButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTeachersAdd = new System.Windows.Forms.Button();
            this.btnTeachersUpdate = new System.Windows.Forms.Button();
            this.btnTeachersDelete = new System.Windows.Forms.Button();
            this.btnTeachersClear = new System.Windows.Forms.Button();
            this.pnlTeachersSearch = new System.Windows.Forms.Panel();
            this.btnTeachersRefresh = new System.Windows.Forms.Button();
            this.btnTeachersSearch = new System.Windows.Forms.Button();
            this.txtTeachersSearch = new System.Windows.Forms.TextBox();
            this.lblTeachersSearch = new System.Windows.Forms.Label();
            this.tpCourses = new System.Windows.Forms.TabPage();
            this.splitCourses = new System.Windows.Forms.SplitContainer();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.grpCourses = new System.Windows.Forms.GroupBox();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.chkCoursePractical = new System.Windows.Forms.CheckBox();
            this.flpCoursesButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCoursesAdd = new System.Windows.Forms.Button();
            this.btnCoursesUpdate = new System.Windows.Forms.Button();
            this.btnCoursesDelete = new System.Windows.Forms.Button();
            this.btnCoursesClear = new System.Windows.Forms.Button();
            this.pnlCoursesSearch = new System.Windows.Forms.Panel();
            this.btnCoursesRefresh = new System.Windows.Forms.Button();
            this.btnCoursesSearch = new System.Windows.Forms.Button();
            this.txtCoursesSearch = new System.Windows.Forms.TextBox();
            this.lblCoursesSearch = new System.Windows.Forms.Label();
            this.tpOfferings = new System.Windows.Forms.TabPage();
            this.splitOfferings = new System.Windows.Forms.SplitContainer();
            this.dgvOfferings = new System.Windows.Forms.DataGridView();
            this.grpOfferings = new System.Windows.Forms.GroupBox();
            this.lblOfferingTerm = new System.Windows.Forms.Label();
            this.cmbOfferingTerm = new System.Windows.Forms.ComboBox();
            this.lblOfferingCourse = new System.Windows.Forms.Label();
            this.cmbOfferingCourse = new System.Windows.Forms.ComboBox();
            this.lblOfferingType = new System.Windows.Forms.Label();
            this.cmbOfferingType = new System.Windows.Forms.ComboBox();
            this.lblOfferingMax = new System.Windows.Forms.Label();
            this.nudOfferingMax = new System.Windows.Forms.NumericUpDown();
            this.flpOfferingsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOfferingsAdd = new System.Windows.Forms.Button();
            this.btnOfferingsUpdate = new System.Windows.Forms.Button();
            this.btnOfferingsDelete = new System.Windows.Forms.Button();
            this.btnOfferingsClear = new System.Windows.Forms.Button();
            this.pnlOfferingsSearch = new System.Windows.Forms.Panel();
            this.btnOfferingsRefresh = new System.Windows.Forms.Button();
            this.btnOfferingsSearch = new System.Windows.Forms.Button();
            this.txtOfferingsSearch = new System.Windows.Forms.TextBox();
            this.lblOfferingsSearch = new System.Windows.Forms.Label();
            this.tpAssignments = new System.Windows.Forms.TabPage();
            this.splitAssignments = new System.Windows.Forms.SplitContainer();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.grpAssignments = new System.Windows.Forms.GroupBox();
            this.lblAssignOffering = new System.Windows.Forms.Label();
            this.cmbAssignOffering = new System.Windows.Forms.ComboBox();
            this.lblAssignTeacher = new System.Windows.Forms.Label();
            this.cmbAssignTeacher = new System.Windows.Forms.ComboBox();
            this.flpAssignmentsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAssignmentsAdd = new System.Windows.Forms.Button();
            this.btnAssignmentsUpdate = new System.Windows.Forms.Button();
            this.btnAssignmentsDelete = new System.Windows.Forms.Button();
            this.btnAssignmentsClear = new System.Windows.Forms.Button();
            this.pnlAssignmentsSearch = new System.Windows.Forms.Panel();
            this.btnAssignmentsRefresh = new System.Windows.Forms.Button();
            this.btnAssignmentsSearch = new System.Windows.Forms.Button();
            this.txtAssignmentsSearch = new System.Windows.Forms.TextBox();
            this.lblAssignmentsSearch = new System.Windows.Forms.Label();
            this.tpEnrollments = new System.Windows.Forms.TabPage();
            this.splitEnrollments = new System.Windows.Forms.SplitContainer();
            this.dgvEnrollments = new System.Windows.Forms.DataGridView();
            this.grpEnrollments = new System.Windows.Forms.GroupBox();
            this.lblEnrollStudent = new System.Windows.Forms.Label();
            this.cmbEnrollStudent = new System.Windows.Forms.ComboBox();
            this.lblEnrollOffering = new System.Windows.Forms.Label();
            this.cmbEnrollOffering = new System.Windows.Forms.ComboBox();
            this.flpEnrollmentsButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEnrollmentsAdd = new System.Windows.Forms.Button();
            this.btnEnrollmentsUpdate = new System.Windows.Forms.Button();
            this.btnEnrollmentsDelete = new System.Windows.Forms.Button();
            this.btnEnrollmentsClear = new System.Windows.Forms.Button();
            this.pnlEnrollmentsSearch = new System.Windows.Forms.Panel();
            this.btnEnrollmentsRefresh = new System.Windows.Forms.Button();
            this.btnEnrollmentsSearch = new System.Windows.Forms.Button();
            this.txtEnrollmentsSearch = new System.Windows.Forms.TextBox();
            this.lblEnrollmentsSearch = new System.Windows.Forms.Label();
            this.tpLecturePlan = new System.Windows.Forms.TabPage();
            this.splitLecturePlan = new System.Windows.Forms.SplitContainer();
            this.dgvLecturePlan = new System.Windows.Forms.DataGridView();
            this.grpLecturePlan = new System.Windows.Forms.GroupBox();
            this.lblPlanOffering = new System.Windows.Forms.Label();
            this.cmbPlanOffering = new System.Windows.Forms.ComboBox();
            this.lblPlanNo = new System.Windows.Forms.Label();
            this.nudPlanNo = new System.Windows.Forms.NumericUpDown();
            this.lblPlanTitle = new System.Windows.Forms.Label();
            this.txtPlanTitle = new System.Windows.Forms.TextBox();
            this.lblPlanContent = new System.Windows.Forms.Label();
            this.txtPlanContent = new System.Windows.Forms.TextBox();
            this.chkPlanExtra = new System.Windows.Forms.CheckBox();
            this.flpLecturePlanButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLecturePlanAdd = new System.Windows.Forms.Button();
            this.btnLecturePlanUpdate = new System.Windows.Forms.Button();
            this.btnLecturePlanDelete = new System.Windows.Forms.Button();
            this.btnLecturePlanClear = new System.Windows.Forms.Button();
            this.pnlLecturePlanSearch = new System.Windows.Forms.Panel();
            this.btnLecturePlanRefresh = new System.Windows.Forms.Button();
            this.btnLecturePlanSearch = new System.Windows.Forms.Button();
            this.txtLecturePlanSearch = new System.Windows.Forms.TextBox();
            this.lblLecturePlanSearch = new System.Windows.Forms.Label();
            this.tpActivationCodes = new System.Windows.Forms.TabPage();
            this.splitAct = new System.Windows.Forms.SplitContainer();
            this.dgvActivationCodes = new System.Windows.Forms.DataGridView();
            this.grpAct = new System.Windows.Forms.GroupBox();
            this.lblActCode = new System.Windows.Forms.Label();
            this.txtActCode = new System.Windows.Forms.TextBox();
            this.btnActGenerate = new System.Windows.Forms.Button();
            this.lblActRole = new System.Windows.Forms.Label();
            this.cmbActRole = new System.Windows.Forms.ComboBox();
            this.lblActStudent = new System.Windows.Forms.Label();
            this.cmbActStudent = new System.Windows.Forms.ComboBox();
            this.lblActTeacher = new System.Windows.Forms.Label();
            this.cmbActTeacher = new System.Windows.Forms.ComboBox();
            this.chkActUsed = new System.Windows.Forms.CheckBox();
            this.flpActButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnActAdd = new System.Windows.Forms.Button();
            this.btnActUpdate = new System.Windows.Forms.Button();
            this.btnActDelete = new System.Windows.Forms.Button();
            this.btnActClear = new System.Windows.Forms.Button();
            this.pnlActSearch = new System.Windows.Forms.Panel();
            this.btnActRefresh = new System.Windows.Forms.Button();
            this.btnActSearch = new System.Windows.Forms.Button();
            this.txtActSearch = new System.Windows.Forms.TextBox();
            this.lblActSearch = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tpDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDepartments)).BeginInit();
            this.splitDepartments.Panel1.SuspendLayout();
            this.splitDepartments.Panel2.SuspendLayout();
            this.splitDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.grpDepartments.SuspendLayout();
            this.flpDepartmentsButtons.SuspendLayout();
            this.pnlDepartmentsSearch.SuspendLayout();
            this.tpMajors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMajors)).BeginInit();
            this.splitMajors.Panel1.SuspendLayout();
            this.splitMajors.Panel2.SuspendLayout();
            this.splitMajors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajors)).BeginInit();
            this.grpMajors.SuspendLayout();
            this.flpMajorsButtons.SuspendLayout();
            this.pnlMajorsSearch.SuspendLayout();
            this.tpTerms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTerms)).BeginInit();
            this.splitTerms.Panel1.SuspendLayout();
            this.splitTerms.Panel2.SuspendLayout();
            this.splitTerms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerms)).BeginInit();
            this.grpTerms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTermYear)).BeginInit();
            this.flpTermsButtons.SuspendLayout();
            this.pnlTermsSearch.SuspendLayout();
            this.tpStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitStudents)).BeginInit();
            this.splitStudents.Panel1.SuspendLayout();
            this.splitStudents.Panel2.SuspendLayout();
            this.splitStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStudentLevel)).BeginInit();
            this.flpStudentsButtons.SuspendLayout();
            this.pnlStudentsSearch.SuspendLayout();
            this.tpTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTeachers)).BeginInit();
            this.splitTeachers.Panel1.SuspendLayout();
            this.splitTeachers.Panel2.SuspendLayout();
            this.splitTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.grpTeachers.SuspendLayout();
            this.flpTeachersButtons.SuspendLayout();
            this.pnlTeachersSearch.SuspendLayout();
            this.tpCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCourses)).BeginInit();
            this.splitCourses.Panel1.SuspendLayout();
            this.splitCourses.Panel2.SuspendLayout();
            this.splitCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.grpCourses.SuspendLayout();
            this.flpCoursesButtons.SuspendLayout();
            this.pnlCoursesSearch.SuspendLayout();
            this.tpOfferings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitOfferings)).BeginInit();
            this.splitOfferings.Panel1.SuspendLayout();
            this.splitOfferings.Panel2.SuspendLayout();
            this.splitOfferings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfferings)).BeginInit();
            this.grpOfferings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOfferingMax)).BeginInit();
            this.flpOfferingsButtons.SuspendLayout();
            this.pnlOfferingsSearch.SuspendLayout();
            this.tpAssignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAssignments)).BeginInit();
            this.splitAssignments.Panel1.SuspendLayout();
            this.splitAssignments.Panel2.SuspendLayout();
            this.splitAssignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.grpAssignments.SuspendLayout();
            this.flpAssignmentsButtons.SuspendLayout();
            this.pnlAssignmentsSearch.SuspendLayout();
            this.tpEnrollments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitEnrollments)).BeginInit();
            this.splitEnrollments.Panel1.SuspendLayout();
            this.splitEnrollments.Panel2.SuspendLayout();
            this.splitEnrollments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).BeginInit();
            this.grpEnrollments.SuspendLayout();
            this.flpEnrollmentsButtons.SuspendLayout();
            this.pnlEnrollmentsSearch.SuspendLayout();
            this.tpLecturePlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLecturePlan)).BeginInit();
            this.splitLecturePlan.Panel1.SuspendLayout();
            this.splitLecturePlan.Panel2.SuspendLayout();
            this.splitLecturePlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturePlan)).BeginInit();
            this.grpLecturePlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlanNo)).BeginInit();
            this.flpLecturePlanButtons.SuspendLayout();
            this.pnlLecturePlanSearch.SuspendLayout();
            this.tpActivationCodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAct)).BeginInit();
            this.splitAct.Panel1.SuspendLayout();
            this.splitAct.Panel2.SuspendLayout();
            this.splitAct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivationCodes)).BeginInit();
            this.grpAct.SuspendLayout();
            this.flpActButtons.SuspendLayout();
            this.pnlActSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTop.Size = new System.Drawing.Size(1200, 67);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(130, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1060, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إدارة بيانات الجامعة (Uni_TasksSystem)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Location = new System.Drawing.Point(10, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 47);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tpDepartments);
            this.tabAdmin.Controls.Add(this.tpMajors);
            this.tabAdmin.Controls.Add(this.tpTerms);
            this.tabAdmin.Controls.Add(this.tpStudents);
            this.tabAdmin.Controls.Add(this.tpTeachers);
            this.tabAdmin.Controls.Add(this.tpCourses);
            this.tabAdmin.Controls.Add(this.tpOfferings);
            this.tabAdmin.Controls.Add(this.tpAssignments);
            this.tabAdmin.Controls.Add(this.tpEnrollments);
            this.tabAdmin.Controls.Add(this.tpLecturePlan);
            this.tabAdmin.Controls.Add(this.tpActivationCodes);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Location = new System.Drawing.Point(0, 67);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabAdmin.RightToLeftLayout = true;
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1200, 653);
            this.tabAdmin.TabIndex = 1;
            this.tabAdmin.SelectedIndexChanged += new System.EventHandler(this.tabAdmin_SelectedIndexChanged);
            // 
            // tpDepartments
            // 
            this.tpDepartments.Controls.Add(this.splitDepartments);
            this.tpDepartments.Controls.Add(this.flpDepartmentsButtons);
            this.tpDepartments.Controls.Add(this.pnlDepartmentsSearch);
            this.tpDepartments.Location = new System.Drawing.Point(4, 37);
            this.tpDepartments.Name = "tpDepartments";
            this.tpDepartments.Padding = new System.Windows.Forms.Padding(6);
            this.tpDepartments.Size = new System.Drawing.Size(1192, 612);
            this.tpDepartments.TabIndex = 0;
            this.tpDepartments.Text = "الأقسام";
            this.tpDepartments.UseVisualStyleBackColor = true;
            // 
            // splitDepartments
            // 
            this.splitDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDepartments.Location = new System.Drawing.Point(6, 59);
            this.splitDepartments.Name = "splitDepartments";
            // 
            // splitDepartments.Panel1
            // 
            this.splitDepartments.Panel1.Controls.Add(this.dgvDepartments);
            this.splitDepartments.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitDepartments.Panel2
            // 
            this.splitDepartments.Panel2.Controls.Add(this.grpDepartments);
            this.splitDepartments.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitDepartments.Size = new System.Drawing.Size(1180, 489);
            this.splitDepartments.SplitterDistance = 760;
            this.splitDepartments.TabIndex = 1;
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDepartments.ColumnHeadersHeight = 29;
            this.dgvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartments.Location = new System.Drawing.Point(0, 0);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.RowHeadersWidth = 51;
            this.dgvDepartments.RowTemplate.Height = 28;
            this.dgvDepartments.Size = new System.Drawing.Size(760, 489);
            this.dgvDepartments.TabIndex = 0;
            this.dgvDepartments.SelectionChanged += new System.EventHandler(this.dgvDepartments_SelectionChanged);
            // 
            // grpDepartments
            // 
            this.grpDepartments.Controls.Add(this.lblDeptName);
            this.grpDepartments.Controls.Add(this.txtDeptName);
            this.grpDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDepartments.Location = new System.Drawing.Point(0, 0);
            this.grpDepartments.Name = "grpDepartments";
            this.grpDepartments.Padding = new System.Windows.Forms.Padding(10);
            this.grpDepartments.Size = new System.Drawing.Size(416, 489);
            this.grpDepartments.TabIndex = 0;
            this.grpDepartments.TabStop = false;
            this.grpDepartments.Text = "تفاصيل";
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(300, 40);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(102, 28);
            this.lblDeptName.TabIndex = 0;
            this.lblDeptName.Text = "اسم القسم";
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(20, 36);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(260, 34);
            this.txtDeptName.TabIndex = 1;
            this.txtDeptName.TextChanged += new System.EventHandler(this.txtDeptName_TextChanged);
            // 
            // flpDepartmentsButtons
            // 
            this.flpDepartmentsButtons.Controls.Add(this.btnDepartmentsAdd);
            this.flpDepartmentsButtons.Controls.Add(this.btnDepartmentsUpdate);
            this.flpDepartmentsButtons.Controls.Add(this.btnDepartmentsDelete);
            this.flpDepartmentsButtons.Controls.Add(this.btnDepartmentsClear);
            this.flpDepartmentsButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpDepartmentsButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpDepartmentsButtons.Location = new System.Drawing.Point(6, 548);
            this.flpDepartmentsButtons.Name = "flpDepartmentsButtons";
            this.flpDepartmentsButtons.Padding = new System.Windows.Forms.Padding(6);
            this.flpDepartmentsButtons.Size = new System.Drawing.Size(1180, 58);
            this.flpDepartmentsButtons.TabIndex = 2;
            this.flpDepartmentsButtons.WrapContents = false;
            // 
            // btnDepartmentsAdd
            // 
            this.btnDepartmentsAdd.Location = new System.Drawing.Point(12, 12);
            this.btnDepartmentsAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnDepartmentsAdd.Name = "btnDepartmentsAdd";
            this.btnDepartmentsAdd.Size = new System.Drawing.Size(110, 36);
            this.btnDepartmentsAdd.TabIndex = 0;
            this.btnDepartmentsAdd.Text = "إضافة";
            this.btnDepartmentsAdd.UseVisualStyleBackColor = true;
            this.btnDepartmentsAdd.Click += new System.EventHandler(this.btnDepartmentsAdd_Click);
            // 
            // btnDepartmentsUpdate
            // 
            this.btnDepartmentsUpdate.Location = new System.Drawing.Point(134, 12);
            this.btnDepartmentsUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnDepartmentsUpdate.Name = "btnDepartmentsUpdate";
            this.btnDepartmentsUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnDepartmentsUpdate.TabIndex = 1;
            this.btnDepartmentsUpdate.Text = "تعديل";
            this.btnDepartmentsUpdate.UseVisualStyleBackColor = true;
            this.btnDepartmentsUpdate.Click += new System.EventHandler(this.btnDepartmentsUpdate_Click);
            // 
            // btnDepartmentsDelete
            // 
            this.btnDepartmentsDelete.Location = new System.Drawing.Point(256, 12);
            this.btnDepartmentsDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDepartmentsDelete.Name = "btnDepartmentsDelete";
            this.btnDepartmentsDelete.Size = new System.Drawing.Size(110, 36);
            this.btnDepartmentsDelete.TabIndex = 2;
            this.btnDepartmentsDelete.Text = "حذف";
            this.btnDepartmentsDelete.UseVisualStyleBackColor = true;
            this.btnDepartmentsDelete.Click += new System.EventHandler(this.btnDepartmentsDelete_Click);
            // 
            // btnDepartmentsClear
            // 
            this.btnDepartmentsClear.Location = new System.Drawing.Point(378, 12);
            this.btnDepartmentsClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnDepartmentsClear.Name = "btnDepartmentsClear";
            this.btnDepartmentsClear.Size = new System.Drawing.Size(110, 36);
            this.btnDepartmentsClear.TabIndex = 3;
            this.btnDepartmentsClear.Text = "تفريغ";
            this.btnDepartmentsClear.UseVisualStyleBackColor = true;
            this.btnDepartmentsClear.Click += new System.EventHandler(this.btnDepartmentsClear_Click);
            // 
            // pnlDepartmentsSearch
            // 
            this.pnlDepartmentsSearch.Controls.Add(this.btnDepartmentsRefresh);
            this.pnlDepartmentsSearch.Controls.Add(this.btnDepartmentsSearch);
            this.pnlDepartmentsSearch.Controls.Add(this.txtDepartmentsSearch);
            this.pnlDepartmentsSearch.Controls.Add(this.lblDepartmentsSearch);
            this.pnlDepartmentsSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDepartmentsSearch.Location = new System.Drawing.Point(6, 6);
            this.pnlDepartmentsSearch.Name = "pnlDepartmentsSearch";
            this.pnlDepartmentsSearch.Padding = new System.Windows.Forms.Padding(8);
            this.pnlDepartmentsSearch.Size = new System.Drawing.Size(1180, 53);
            this.pnlDepartmentsSearch.TabIndex = 0;
            // 
            // btnDepartmentsRefresh
            // 
            this.btnDepartmentsRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDepartmentsRefresh.Location = new System.Drawing.Point(639, 8);
            this.btnDepartmentsRefresh.Name = "btnDepartmentsRefresh";
            this.btnDepartmentsRefresh.Size = new System.Drawing.Size(100, 37);
            this.btnDepartmentsRefresh.TabIndex = 3;
            this.btnDepartmentsRefresh.Text = "تحديث";
            this.btnDepartmentsRefresh.UseVisualStyleBackColor = true;
            this.btnDepartmentsRefresh.Click += new System.EventHandler(this.btnDepartmentsRefresh_Click);
            // 
            // btnDepartmentsSearch
            // 
            this.btnDepartmentsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDepartmentsSearch.Location = new System.Drawing.Point(739, 8);
            this.btnDepartmentsSearch.Name = "btnDepartmentsSearch";
            this.btnDepartmentsSearch.Size = new System.Drawing.Size(100, 37);
            this.btnDepartmentsSearch.TabIndex = 2;
            this.btnDepartmentsSearch.Text = "بحث";
            this.btnDepartmentsSearch.UseVisualStyleBackColor = true;
            this.btnDepartmentsSearch.Click += new System.EventHandler(this.btnDepartmentsSearch_Click);
            // 
            // txtDepartmentsSearch
            // 
            this.txtDepartmentsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDepartmentsSearch.Location = new System.Drawing.Point(839, 8);
            this.txtDepartmentsSearch.Name = "txtDepartmentsSearch";
            this.txtDepartmentsSearch.Size = new System.Drawing.Size(280, 34);
            this.txtDepartmentsSearch.TabIndex = 1;
            this.txtDepartmentsSearch.TextChanged += new System.EventHandler(this.txtDepartmentsSearch_TextChanged);
            // 
            // lblDepartmentsSearch
            // 
            this.lblDepartmentsSearch.AutoSize = true;
            this.lblDepartmentsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDepartmentsSearch.Location = new System.Drawing.Point(1119, 8);
            this.lblDepartmentsSearch.Name = "lblDepartmentsSearch";
            this.lblDepartmentsSearch.Size = new System.Drawing.Size(53, 28);
            this.lblDepartmentsSearch.TabIndex = 0;
            this.lblDepartmentsSearch.Text = "بحث:";
            // 
            // tpMajors
            // 
            this.tpMajors.Controls.Add(this.splitMajors);
            this.tpMajors.Controls.Add(this.flpMajorsButtons);
            this.tpMajors.Controls.Add(this.pnlMajorsSearch);
            this.tpMajors.Location = new System.Drawing.Point(4, 37);
            this.tpMajors.Name = "tpMajors";
            this.tpMajors.Padding = new System.Windows.Forms.Padding(6);
            this.tpMajors.Size = new System.Drawing.Size(1192, 612);
            this.tpMajors.TabIndex = 0;
            this.tpMajors.Text = "التخصصات";
            this.tpMajors.UseVisualStyleBackColor = true;
            // 
            // splitMajors
            // 
            this.splitMajors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMajors.Location = new System.Drawing.Point(6, 60);
            this.splitMajors.Name = "splitMajors";
            // 
            // splitMajors.Panel1
            // 
            this.splitMajors.Panel1.Controls.Add(this.dgvMajors);
            this.splitMajors.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitMajors.Panel2
            // 
            this.splitMajors.Panel2.Controls.Add(this.grpMajors);
            this.splitMajors.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitMajors.Size = new System.Drawing.Size(1180, 487);
            this.splitMajors.SplitterDistance = 760;
            this.splitMajors.TabIndex = 1;
            // 
            // dgvMajors
            // 
            this.dgvMajors.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMajors.ColumnHeadersHeight = 29;
            this.dgvMajors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMajors.Location = new System.Drawing.Point(0, 0);
            this.dgvMajors.Name = "dgvMajors";
            this.dgvMajors.RowHeadersWidth = 51;
            this.dgvMajors.RowTemplate.Height = 28;
            this.dgvMajors.Size = new System.Drawing.Size(760, 487);
            this.dgvMajors.TabIndex = 0;
            this.dgvMajors.SelectionChanged += new System.EventHandler(this.dgvMajors_SelectionChanged);
            // 
            // grpMajors
            // 
            this.grpMajors.Controls.Add(this.lblMajorDept);
            this.grpMajors.Controls.Add(this.cmbMajorDept);
            this.grpMajors.Controls.Add(this.lblMajorName);
            this.grpMajors.Controls.Add(this.txtMajorName);
            this.grpMajors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMajors.Location = new System.Drawing.Point(0, 0);
            this.grpMajors.Name = "grpMajors";
            this.grpMajors.Padding = new System.Windows.Forms.Padding(10);
            this.grpMajors.Size = new System.Drawing.Size(416, 487);
            this.grpMajors.TabIndex = 0;
            this.grpMajors.TabStop = false;
            this.grpMajors.Text = "تفاصيل";
            // 
            // lblMajorDept
            // 
            this.lblMajorDept.AutoSize = true;
            this.lblMajorDept.Location = new System.Drawing.Point(300, 40);
            this.lblMajorDept.Name = "lblMajorDept";
            this.lblMajorDept.Size = new System.Drawing.Size(63, 28);
            this.lblMajorDept.TabIndex = 0;
            this.lblMajorDept.Text = "القسم";
            // 
            // cmbMajorDept
            // 
            this.cmbMajorDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMajorDept.FormattingEnabled = true;
            this.cmbMajorDept.Location = new System.Drawing.Point(20, 36);
            this.cmbMajorDept.Name = "cmbMajorDept";
            this.cmbMajorDept.Size = new System.Drawing.Size(260, 36);
            this.cmbMajorDept.TabIndex = 2;
            // 
            // lblMajorName
            // 
            this.lblMajorName.AutoSize = true;
            this.lblMajorName.Location = new System.Drawing.Point(288, 90);
            this.lblMajorName.Name = "lblMajorName";
            this.lblMajorName.Size = new System.Drawing.Size(129, 28);
            this.lblMajorName.TabIndex = 0;
            this.lblMajorName.Text = "اسم التخصص";
            // 
            // txtMajorName
            // 
            this.txtMajorName.Location = new System.Drawing.Point(20, 86);
            this.txtMajorName.Name = "txtMajorName";
            this.txtMajorName.Size = new System.Drawing.Size(260, 34);
            this.txtMajorName.TabIndex = 1;
            // 
            // flpMajorsButtons
            // 
            this.flpMajorsButtons.Controls.Add(this.btnMajorsAdd);
            this.flpMajorsButtons.Controls.Add(this.btnMajorsUpdate);
            this.flpMajorsButtons.Controls.Add(this.btnMajorsDelete);
            this.flpMajorsButtons.Controls.Add(this.btnMajorsClear);
            this.flpMajorsButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpMajorsButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpMajorsButtons.Location = new System.Drawing.Point(6, 547);
            this.flpMajorsButtons.Name = "flpMajorsButtons";
            this.flpMajorsButtons.Padding = new System.Windows.Forms.Padding(6);
            this.flpMajorsButtons.Size = new System.Drawing.Size(1180, 59);
            this.flpMajorsButtons.TabIndex = 2;
            this.flpMajorsButtons.WrapContents = false;
            // 
            // btnMajorsAdd
            // 
            this.btnMajorsAdd.Location = new System.Drawing.Point(12, 12);
            this.btnMajorsAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnMajorsAdd.Name = "btnMajorsAdd";
            this.btnMajorsAdd.Size = new System.Drawing.Size(110, 36);
            this.btnMajorsAdd.TabIndex = 0;
            this.btnMajorsAdd.Text = "إضافة";
            this.btnMajorsAdd.UseVisualStyleBackColor = true;
            this.btnMajorsAdd.Click += new System.EventHandler(this.btnMajorsAdd_Click);
            // 
            // btnMajorsUpdate
            // 
            this.btnMajorsUpdate.Location = new System.Drawing.Point(134, 12);
            this.btnMajorsUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnMajorsUpdate.Name = "btnMajorsUpdate";
            this.btnMajorsUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnMajorsUpdate.TabIndex = 1;
            this.btnMajorsUpdate.Text = "تعديل";
            this.btnMajorsUpdate.UseVisualStyleBackColor = true;
            this.btnMajorsUpdate.Click += new System.EventHandler(this.btnMajorsUpdate_Click);
            // 
            // btnMajorsDelete
            // 
            this.btnMajorsDelete.Location = new System.Drawing.Point(256, 12);
            this.btnMajorsDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnMajorsDelete.Name = "btnMajorsDelete";
            this.btnMajorsDelete.Size = new System.Drawing.Size(110, 36);
            this.btnMajorsDelete.TabIndex = 2;
            this.btnMajorsDelete.Text = "حذف";
            this.btnMajorsDelete.UseVisualStyleBackColor = true;
            this.btnMajorsDelete.Click += new System.EventHandler(this.btnMajorsDelete_Click);
            // 
            // btnMajorsClear
            // 
            this.btnMajorsClear.Location = new System.Drawing.Point(378, 12);
            this.btnMajorsClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnMajorsClear.Name = "btnMajorsClear";
            this.btnMajorsClear.Size = new System.Drawing.Size(110, 36);
            this.btnMajorsClear.TabIndex = 3;
            this.btnMajorsClear.Text = "تفريغ";
            this.btnMajorsClear.UseVisualStyleBackColor = true;
            this.btnMajorsClear.Click += new System.EventHandler(this.btnMajorsClear_Click);
            // 
            // pnlMajorsSearch
            // 
            this.pnlMajorsSearch.Controls.Add(this.btnMajorsRefresh);
            this.pnlMajorsSearch.Controls.Add(this.btnMajorsSearch);
            this.pnlMajorsSearch.Controls.Add(this.txtMajorsSearch);
            this.pnlMajorsSearch.Controls.Add(this.lblMajorsSearch);
            this.pnlMajorsSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMajorsSearch.Location = new System.Drawing.Point(6, 6);
            this.pnlMajorsSearch.Name = "pnlMajorsSearch";
            this.pnlMajorsSearch.Padding = new System.Windows.Forms.Padding(8);
            this.pnlMajorsSearch.Size = new System.Drawing.Size(1180, 54);
            this.pnlMajorsSearch.TabIndex = 0;
            // 
            // btnMajorsRefresh
            // 
            this.btnMajorsRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMajorsRefresh.Location = new System.Drawing.Point(639, 8);
            this.btnMajorsRefresh.Name = "btnMajorsRefresh";
            this.btnMajorsRefresh.Size = new System.Drawing.Size(100, 38);
            this.btnMajorsRefresh.TabIndex = 3;
            this.btnMajorsRefresh.Text = "تحديث";
            this.btnMajorsRefresh.UseVisualStyleBackColor = true;
            this.btnMajorsRefresh.Click += new System.EventHandler(this.btnMajorsRefresh_Click);
            // 
            // btnMajorsSearch
            // 
            this.btnMajorsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMajorsSearch.Location = new System.Drawing.Point(739, 8);
            this.btnMajorsSearch.Name = "btnMajorsSearch";
            this.btnMajorsSearch.Size = new System.Drawing.Size(100, 38);
            this.btnMajorsSearch.TabIndex = 2;
            this.btnMajorsSearch.Text = "بحث";
            this.btnMajorsSearch.UseVisualStyleBackColor = true;
            this.btnMajorsSearch.Click += new System.EventHandler(this.btnMajorsSearch_Click);
            // 
            // txtMajorsSearch
            // 
            this.txtMajorsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtMajorsSearch.Location = new System.Drawing.Point(839, 8);
            this.txtMajorsSearch.Name = "txtMajorsSearch";
            this.txtMajorsSearch.Size = new System.Drawing.Size(280, 34);
            this.txtMajorsSearch.TabIndex = 1;
            this.txtMajorsSearch.TextChanged += new System.EventHandler(this.txtMajorsSearch_TextChanged);
            // 
            // lblMajorsSearch
            // 
            this.lblMajorsSearch.AutoSize = true;
            this.lblMajorsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMajorsSearch.Location = new System.Drawing.Point(1119, 8);
            this.lblMajorsSearch.Name = "lblMajorsSearch";
            this.lblMajorsSearch.Size = new System.Drawing.Size(53, 28);
            this.lblMajorsSearch.TabIndex = 0;
            this.lblMajorsSearch.Text = "بحث:";
            // 
            // tpTerms
            // 
            this.tpTerms.Controls.Add(this.splitTerms);
            this.tpTerms.Controls.Add(this.flpTermsButtons);
            this.tpTerms.Controls.Add(this.pnlTermsSearch);
            this.tpTerms.Location = new System.Drawing.Point(4, 37);
            this.tpTerms.Name = "tpTerms";
            this.tpTerms.Padding = new System.Windows.Forms.Padding(6);
            this.tpTerms.Size = new System.Drawing.Size(1192, 612);
            this.tpTerms.TabIndex = 0;
            this.tpTerms.Text = "الترم";
            this.tpTerms.UseVisualStyleBackColor = true;
            // 
            // splitTerms
            // 
            this.splitTerms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTerms.Location = new System.Drawing.Point(6, 60);
            this.splitTerms.Name = "splitTerms";
            // 
            // splitTerms.Panel1
            // 
            this.splitTerms.Panel1.Controls.Add(this.dgvTerms);
            this.splitTerms.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitTerms.Panel2
            // 
            this.splitTerms.Panel2.Controls.Add(this.grpTerms);
            this.splitTerms.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitTerms.Size = new System.Drawing.Size(1180, 488);
            this.splitTerms.SplitterDistance = 760;
            this.splitTerms.TabIndex = 1;
            // 
            // dgvTerms
            // 
            this.dgvTerms.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTerms.ColumnHeadersHeight = 29;
            this.dgvTerms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTerms.Location = new System.Drawing.Point(0, 0);
            this.dgvTerms.Name = "dgvTerms";
            this.dgvTerms.RowHeadersWidth = 51;
            this.dgvTerms.RowTemplate.Height = 28;
            this.dgvTerms.Size = new System.Drawing.Size(760, 488);
            this.dgvTerms.TabIndex = 0;
            this.dgvTerms.SelectionChanged += new System.EventHandler(this.dgvTerms_SelectionChanged);
            // 
            // grpTerms
            // 
            this.grpTerms.Controls.Add(this.lblTermName);
            this.grpTerms.Controls.Add(this.txtTermName);
            this.grpTerms.Controls.Add(this.lblTermYear);
            this.grpTerms.Controls.Add(this.nudTermYear);
            this.grpTerms.Controls.Add(this.chkTermActive);
            this.grpTerms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTerms.Location = new System.Drawing.Point(0, 0);
            this.grpTerms.Name = "grpTerms";
            this.grpTerms.Padding = new System.Windows.Forms.Padding(10);
            this.grpTerms.Size = new System.Drawing.Size(416, 488);
            this.grpTerms.TabIndex = 0;
            this.grpTerms.TabStop = false;
            this.grpTerms.Text = "تفاصيل";
            // 
            // lblTermName
            // 
            this.lblTermName.AutoSize = true;
            this.lblTermName.Location = new System.Drawing.Point(300, 40);
            this.lblTermName.Name = "lblTermName";
            this.lblTermName.Size = new System.Drawing.Size(88, 28);
            this.lblTermName.TabIndex = 0;
            this.lblTermName.Text = "اسم الترم";
            // 
            // txtTermName
            // 
            this.txtTermName.Location = new System.Drawing.Point(20, 36);
            this.txtTermName.Name = "txtTermName";
            this.txtTermName.Size = new System.Drawing.Size(260, 34);
            this.txtTermName.TabIndex = 1;
            // 
            // lblTermYear
            // 
            this.lblTermYear.AutoSize = true;
            this.lblTermYear.Location = new System.Drawing.Point(300, 90);
            this.lblTermYear.Name = "lblTermYear";
            this.lblTermYear.Size = new System.Drawing.Size(58, 28);
            this.lblTermYear.TabIndex = 0;
            this.lblTermYear.Text = "السنة";
            // 
            // nudTermYear
            // 
            this.nudTermYear.Location = new System.Drawing.Point(20, 86);
            this.nudTermYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudTermYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudTermYear.Name = "nudTermYear";
            this.nudTermYear.Size = new System.Drawing.Size(140, 34);
            this.nudTermYear.TabIndex = 3;
            this.nudTermYear.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // chkTermActive
            // 
            this.chkTermActive.AutoSize = true;
            this.chkTermActive.Location = new System.Drawing.Point(20, 140);
            this.chkTermActive.Name = "chkTermActive";
            this.chkTermActive.Size = new System.Drawing.Size(75, 32);
            this.chkTermActive.TabIndex = 10;
            this.chkTermActive.Text = "نشط";
            this.chkTermActive.UseVisualStyleBackColor = true;
            // 
            // flpTermsButtons
            // 
            this.flpTermsButtons.Controls.Add(this.btnTermsAdd);
            this.flpTermsButtons.Controls.Add(this.btnTermsUpdate);
            this.flpTermsButtons.Controls.Add(this.btnTermsDelete);
            this.flpTermsButtons.Controls.Add(this.btnTermsClear);
            this.flpTermsButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpTermsButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpTermsButtons.Location = new System.Drawing.Point(6, 548);
            this.flpTermsButtons.Name = "flpTermsButtons";
            this.flpTermsButtons.Padding = new System.Windows.Forms.Padding(6);
            this.flpTermsButtons.Size = new System.Drawing.Size(1180, 58);
            this.flpTermsButtons.TabIndex = 2;
            this.flpTermsButtons.WrapContents = false;
            // 
            // btnTermsAdd
            // 
            this.btnTermsAdd.Location = new System.Drawing.Point(12, 12);
            this.btnTermsAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnTermsAdd.Name = "btnTermsAdd";
            this.btnTermsAdd.Size = new System.Drawing.Size(110, 36);
            this.btnTermsAdd.TabIndex = 0;
            this.btnTermsAdd.Text = "إضافة";
            this.btnTermsAdd.UseVisualStyleBackColor = true;
            this.btnTermsAdd.Click += new System.EventHandler(this.btnTermsAdd_Click);
            // 
            // btnTermsUpdate
            // 
            this.btnTermsUpdate.Location = new System.Drawing.Point(134, 12);
            this.btnTermsUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnTermsUpdate.Name = "btnTermsUpdate";
            this.btnTermsUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnTermsUpdate.TabIndex = 1;
            this.btnTermsUpdate.Text = "تعديل";
            this.btnTermsUpdate.UseVisualStyleBackColor = true;
            this.btnTermsUpdate.Click += new System.EventHandler(this.btnTermsUpdate_Click);
            // 
            // btnTermsDelete
            // 
            this.btnTermsDelete.Location = new System.Drawing.Point(256, 12);
            this.btnTermsDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnTermsDelete.Name = "btnTermsDelete";
            this.btnTermsDelete.Size = new System.Drawing.Size(110, 36);
            this.btnTermsDelete.TabIndex = 2;
            this.btnTermsDelete.Text = "حذف";
            this.btnTermsDelete.UseVisualStyleBackColor = true;
            this.btnTermsDelete.Click += new System.EventHandler(this.btnTermsDelete_Click);
            // 
            // btnTermsClear
            // 
            this.btnTermsClear.Location = new System.Drawing.Point(378, 12);
            this.btnTermsClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnTermsClear.Name = "btnTermsClear";
            this.btnTermsClear.Size = new System.Drawing.Size(110, 36);
            this.btnTermsClear.TabIndex = 3;
            this.btnTermsClear.Text = "تفريغ";
            this.btnTermsClear.UseVisualStyleBackColor = true;
            this.btnTermsClear.Click += new System.EventHandler(this.btnTermsClear_Click);
            // 
            // pnlTermsSearch
            // 
            this.pnlTermsSearch.Controls.Add(this.btnTermsRefresh);
            this.pnlTermsSearch.Controls.Add(this.btnTermsSearch);
            this.pnlTermsSearch.Controls.Add(this.txtTermsSearch);
            this.pnlTermsSearch.Controls.Add(this.lblTermsSearch);
            this.pnlTermsSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTermsSearch.Location = new System.Drawing.Point(6, 6);
            this.pnlTermsSearch.Name = "pnlTermsSearch";
            this.pnlTermsSearch.Padding = new System.Windows.Forms.Padding(8);
            this.pnlTermsSearch.Size = new System.Drawing.Size(1180, 54);
            this.pnlTermsSearch.TabIndex = 0;
            // 
            // btnTermsRefresh
            // 
            this.btnTermsRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTermsRefresh.Location = new System.Drawing.Point(639, 8);
            this.btnTermsRefresh.Name = "btnTermsRefresh";
            this.btnTermsRefresh.Size = new System.Drawing.Size(100, 38);
            this.btnTermsRefresh.TabIndex = 3;
            this.btnTermsRefresh.Text = "تحديث";
            this.btnTermsRefresh.UseVisualStyleBackColor = true;
            this.btnTermsRefresh.Click += new System.EventHandler(this.btnTermsRefresh_Click);
            // 
            // btnTermsSearch
            // 
            this.btnTermsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTermsSearch.Location = new System.Drawing.Point(739, 8);
            this.btnTermsSearch.Name = "btnTermsSearch";
            this.btnTermsSearch.Size = new System.Drawing.Size(100, 38);
            this.btnTermsSearch.TabIndex = 2;
            this.btnTermsSearch.Text = "بحث";
            this.btnTermsSearch.UseVisualStyleBackColor = true;
            this.btnTermsSearch.Click += new System.EventHandler(this.btnTermsSearch_Click);
            // 
            // txtTermsSearch
            // 
            this.txtTermsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtTermsSearch.Location = new System.Drawing.Point(839, 8);
            this.txtTermsSearch.Name = "txtTermsSearch";
            this.txtTermsSearch.Size = new System.Drawing.Size(280, 34);
            this.txtTermsSearch.TabIndex = 1;
            this.txtTermsSearch.TextChanged += new System.EventHandler(this.txtTermsSearch_TextChanged);
            // 
            // lblTermsSearch
            // 
            this.lblTermsSearch.AutoSize = true;
            this.lblTermsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTermsSearch.Location = new System.Drawing.Point(1119, 8);
            this.lblTermsSearch.Name = "lblTermsSearch";
            this.lblTermsSearch.Size = new System.Drawing.Size(53, 28);
            this.lblTermsSearch.TabIndex = 0;
            this.lblTermsSearch.Text = "بحث:";
            // 
            // tpStudents
            // 
            this.tpStudents.Controls.Add(this.splitStudents);
            this.tpStudents.Controls.Add(this.flpStudentsButtons);
            this.tpStudents.Controls.Add(this.pnlStudentsSearch);
            this.tpStudents.Location = new System.Drawing.Point(4, 37);
            this.tpStudents.Name = "tpStudents";
            this.tpStudents.Padding = new System.Windows.Forms.Padding(6);
            this.tpStudents.Size = new System.Drawing.Size(1192, 612);
            this.tpStudents.TabIndex = 0;
            this.tpStudents.Text = "الطلاب";
            this.tpStudents.UseVisualStyleBackColor = true;
            // 
            // splitStudents
            // 
            this.splitStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitStudents.Location = new System.Drawing.Point(6, 58);
            this.splitStudents.Name = "splitStudents";
            // 
            // splitStudents.Panel1
            // 
            this.splitStudents.Panel1.Controls.Add(this.dgvStudents);
            this.splitStudents.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitStudents.Panel2
            // 
            this.splitStudents.Panel2.Controls.Add(this.grpStudents);
            this.splitStudents.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitStudents.Size = new System.Drawing.Size(1180, 490);
            this.splitStudents.SplitterDistance = 760;
            this.splitStudents.TabIndex = 1;
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudents.ColumnHeadersHeight = 29;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(0, 0);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 28;
            this.dgvStudents.Size = new System.Drawing.Size(760, 490);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.SelectionChanged += new System.EventHandler(this.dgvStudents_SelectionChanged);
            // 
            // grpStudents
            // 
            this.grpStudents.Controls.Add(this.lblStudentId);
            this.grpStudents.Controls.Add(this.txtStudentId);
            this.grpStudents.Controls.Add(this.lblStudentName);
            this.grpStudents.Controls.Add(this.txtStudentName);
            this.grpStudents.Controls.Add(this.lblStudentMajor);
            this.grpStudents.Controls.Add(this.cmbStudentMajor);
            this.grpStudents.Controls.Add(this.lblStudentLevel);
            this.grpStudents.Controls.Add(this.nudStudentLevel);
            this.grpStudents.Controls.Add(this.lblStudentTerm);
            this.grpStudents.Controls.Add(this.cmbStudentTerm);
            this.grpStudents.Controls.Add(this.chkStudentActive);
            this.grpStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStudents.Location = new System.Drawing.Point(0, 0);
            this.grpStudents.Name = "grpStudents";
            this.grpStudents.Padding = new System.Windows.Forms.Padding(10);
            this.grpStudents.Size = new System.Drawing.Size(416, 490);
            this.grpStudents.TabIndex = 0;
            this.grpStudents.TabStop = false;
            this.grpStudents.Text = "تفاصيل";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(294, 40);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(127, 28);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "الرقم الجامعي";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(20, 36);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(260, 34);
            this.txtStudentId.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(300, 90);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(58, 28);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "الاسم";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(20, 86);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(260, 34);
            this.txtStudentName.TabIndex = 1;
            // 
            // lblStudentMajor
            // 
            this.lblStudentMajor.AutoSize = true;
            this.lblStudentMajor.Location = new System.Drawing.Point(300, 140);
            this.lblStudentMajor.Name = "lblStudentMajor";
            this.lblStudentMajor.Size = new System.Drawing.Size(90, 28);
            this.lblStudentMajor.TabIndex = 0;
            this.lblStudentMajor.Text = "التخصص";
            // 
            // cmbStudentMajor
            // 
            this.cmbStudentMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentMajor.FormattingEnabled = true;
            this.cmbStudentMajor.Location = new System.Drawing.Point(20, 136);
            this.cmbStudentMajor.Name = "cmbStudentMajor";
            this.cmbStudentMajor.Size = new System.Drawing.Size(260, 36);
            this.cmbStudentMajor.TabIndex = 2;
            // 
            // lblStudentLevel
            // 
            this.lblStudentLevel.AutoSize = true;
            this.lblStudentLevel.Location = new System.Drawing.Point(300, 190);
            this.lblStudentLevel.Name = "lblStudentLevel";
            this.lblStudentLevel.Size = new System.Drawing.Size(85, 28);
            this.lblStudentLevel.TabIndex = 0;
            this.lblStudentLevel.Text = "المستوى";
            // 
            // nudStudentLevel
            // 
            this.nudStudentLevel.Location = new System.Drawing.Point(20, 186);
            this.nudStudentLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudStudentLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStudentLevel.Name = "nudStudentLevel";
            this.nudStudentLevel.Size = new System.Drawing.Size(140, 34);
            this.nudStudentLevel.TabIndex = 3;
            this.nudStudentLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStudentTerm
            // 
            this.lblStudentTerm.AutoSize = true;
            this.lblStudentTerm.Location = new System.Drawing.Point(300, 240);
            this.lblStudentTerm.Name = "lblStudentTerm";
            this.lblStudentTerm.Size = new System.Drawing.Size(107, 28);
            this.lblStudentTerm.TabIndex = 0;
            this.lblStudentTerm.Text = "الترم الحالي";
            // 
            // cmbStudentTerm
            // 
            this.cmbStudentTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentTerm.FormattingEnabled = true;
            this.cmbStudentTerm.Location = new System.Drawing.Point(20, 236);
            this.cmbStudentTerm.Name = "cmbStudentTerm";
            this.cmbStudentTerm.Size = new System.Drawing.Size(260, 36);
            this.cmbStudentTerm.TabIndex = 2;
            // 
            // chkStudentActive
            // 
            this.chkStudentActive.AutoSize = true;
            this.chkStudentActive.Location = new System.Drawing.Point(20, 290);
            this.chkStudentActive.Name = "chkStudentActive";
            this.chkStudentActive.Size = new System.Drawing.Size(75, 32);
            this.chkStudentActive.TabIndex = 10;
            this.chkStudentActive.Text = "نشط";
            this.chkStudentActive.UseVisualStyleBackColor = true;
            // 
            // flpStudentsButtons
            // 
            this.flpStudentsButtons.Controls.Add(this.btnStudentsAdd);
            this.flpStudentsButtons.Controls.Add(this.btnStudentsUpdate);
            this.flpStudentsButtons.Controls.Add(this.btnStudentsDelete);
            this.flpStudentsButtons.Controls.Add(this.btnStudentsClear);
            this.flpStudentsButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpStudentsButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpStudentsButtons.Location = new System.Drawing.Point(6, 548);
            this.flpStudentsButtons.Name = "flpStudentsButtons";
            this.flpStudentsButtons.Padding = new System.Windows.Forms.Padding(6);
            this.flpStudentsButtons.Size = new System.Drawing.Size(1180, 58);
            this.flpStudentsButtons.TabIndex = 2;
            this.flpStudentsButtons.WrapContents = false;
            // 
            // btnStudentsAdd
            // 
            this.btnStudentsAdd.Location = new System.Drawing.Point(12, 12);
            this.btnStudentsAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnStudentsAdd.Name = "btnStudentsAdd";
            this.btnStudentsAdd.Size = new System.Drawing.Size(110, 36);
            this.btnStudentsAdd.TabIndex = 0;
            this.btnStudentsAdd.Text = "إضافة";
            this.btnStudentsAdd.UseVisualStyleBackColor = true;
            this.btnStudentsAdd.Click += new System.EventHandler(this.btnStudentsAdd_Click);
            // 
            // btnStudentsUpdate
            // 
            this.btnStudentsUpdate.Location = new System.Drawing.Point(134, 12);
            this.btnStudentsUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnStudentsUpdate.Name = "btnStudentsUpdate";
            this.btnStudentsUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnStudentsUpdate.TabIndex = 1;
            this.btnStudentsUpdate.Text = "تعديل";
            this.btnStudentsUpdate.UseVisualStyleBackColor = true;
            this.btnStudentsUpdate.Click += new System.EventHandler(this.btnStudentsUpdate_Click);
            // 
            // btnStudentsDelete
            // 
            this.btnStudentsDelete.Location = new System.Drawing.Point(256, 12);
            this.btnStudentsDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnStudentsDelete.Name = "btnStudentsDelete";
            this.btnStudentsDelete.Size = new System.Drawing.Size(110, 36);
            this.btnStudentsDelete.TabIndex = 2;
            this.btnStudentsDelete.Text = "حذف";
            this.btnStudentsDelete.UseVisualStyleBackColor = true;
            this.btnStudentsDelete.Click += new System.EventHandler(this.btnStudentsDelete_Click);
            // 
            // btnStudentsClear
            // 
            this.btnStudentsClear.Location = new System.Drawing.Point(378, 12);
            this.btnStudentsClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnStudentsClear.Name = "btnStudentsClear";
            this.btnStudentsClear.Size = new System.Drawing.Size(110, 36);
            this.btnStudentsClear.TabIndex = 3;
            this.btnStudentsClear.Text = "تفريغ";
            this.btnStudentsClear.UseVisualStyleBackColor = true;
            this.btnStudentsClear.Click += new System.EventHandler(this.btnStudentsClear_Click);
            // 
            // pnlStudentsSearch
            // 
            this.pnlStudentsSearch.Controls.Add(this.btnStudentsRefresh);
            this.pnlStudentsSearch.Controls.Add(this.btnStudentsSearch);
            this.pnlStudentsSearch.Controls.Add(this.txtStudentsSearch);
            this.pnlStudentsSearch.Controls.Add(this.lblStudentsSearch);
            this.pnlStudentsSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentsSearch.Location = new System.Drawing.Point(6, 6);
            this.pnlStudentsSearch.Name = "pnlStudentsSearch";
            this.pnlStudentsSearch.Padding = new System.Windows.Forms.Padding(8);
            this.pnlStudentsSearch.Size = new System.Drawing.Size(1180, 52);
            this.pnlStudentsSearch.TabIndex = 0;
            // 
            // btnStudentsRefresh
            // 
            this.btnStudentsRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStudentsRefresh.Location = new System.Drawing.Point(639, 8);
            this.btnStudentsRefresh.Name = "btnStudentsRefresh";
            this.btnStudentsRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnStudentsRefresh.TabIndex = 3;
            this.btnStudentsRefresh.Text = "تحديث";
            this.btnStudentsRefresh.UseVisualStyleBackColor = true;
            this.btnStudentsRefresh.Click += new System.EventHandler(this.btnStudentsRefresh_Click);
            // 
            // btnStudentsSearch
            // 
            this.btnStudentsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStudentsSearch.Location = new System.Drawing.Point(739, 8);
            this.btnStudentsSearch.Name = "btnStudentsSearch";
            this.btnStudentsSearch.Size = new System.Drawing.Size(100, 36);
            this.btnStudentsSearch.TabIndex = 2;
            this.btnStudentsSearch.Text = "بحث";
            this.btnStudentsSearch.UseVisualStyleBackColor = true;
            this.btnStudentsSearch.Click += new System.EventHandler(this.btnStudentsSearch_Click);
            // 
            // txtStudentsSearch
            // 
            this.txtStudentsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtStudentsSearch.Location = new System.Drawing.Point(839, 8);
            this.txtStudentsSearch.Name = "txtStudentsSearch";
            this.txtStudentsSearch.Size = new System.Drawing.Size(280, 34);
            this.txtStudentsSearch.TabIndex = 1;
            this.txtStudentsSearch.TextChanged += new System.EventHandler(this.txtStudentsSearch_TextChanged);
            // 
            // lblStudentsSearch
            // 
            this.lblStudentsSearch.AutoSize = true;
            this.lblStudentsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStudentsSearch.Location = new System.Drawing.Point(1119, 8);
            this.lblStudentsSearch.Name = "lblStudentsSearch";
            this.lblStudentsSearch.Size = new System.Drawing.Size(53, 28);
            this.lblStudentsSearch.TabIndex = 0;
            this.lblStudentsSearch.Text = "بحث:";
            // 
            // tpTeachers
            // 
            this.tpTeachers.Controls.Add(this.splitTeachers);
            this.tpTeachers.Controls.Add(this.flpTeachersButtons);
            this.tpTeachers.Controls.Add(this.pnlTeachersSearch);
            this.tpTeachers.Location = new System.Drawing.Point(4, 37);
            this.tpTeachers.Name = "tpTeachers";
            this.tpTeachers.Padding = new System.Windows.Forms.Padding(6);
            this.tpTeachers.Size = new System.Drawing.Size(1192, 612);
            this.tpTeachers.TabIndex = 0;
            this.tpTeachers.Text = "الأساتذة";
            this.tpTeachers.UseVisualStyleBackColor = true;
            // 
            // splitTeachers
            // 
            this.splitTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTeachers.Location = new System.Drawing.Point(6, 58);
            this.splitTeachers.Name = "splitTeachers";
            // 
            // splitTeachers.Panel1
            // 
            this.splitTeachers.Panel1.Controls.Add(this.dgvTeachers);
            this.splitTeachers.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitTeachers.Panel2
            // 
            this.splitTeachers.Panel2.Controls.Add(this.grpTeachers);
            this.splitTeachers.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitTeachers.Size = new System.Drawing.Size(1180, 489);
            this.splitTeachers.SplitterDistance = 760;
            this.splitTeachers.TabIndex = 1;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTeachers.ColumnHeadersHeight = 29;
            this.dgvTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeachers.Location = new System.Drawing.Point(0, 0);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RowHeadersWidth = 51;
            this.dgvTeachers.RowTemplate.Height = 28;
            this.dgvTeachers.Size = new System.Drawing.Size(760, 489);
            this.dgvTeachers.TabIndex = 0;
            this.dgvTeachers.SelectionChanged += new System.EventHandler(this.dgvTeachers_SelectionChanged);
            // 
            // grpTeachers
            // 
            this.grpTeachers.Controls.Add(this.lblTeacherId);
            this.grpTeachers.Controls.Add(this.txtTeacherId);
            this.grpTeachers.Controls.Add(this.lblTeacherName);
            this.grpTeachers.Controls.Add(this.txtTeacherName);
            this.grpTeachers.Controls.Add(this.chkTeacherActive);
            this.grpTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTeachers.Location = new System.Drawing.Point(0, 0);
            this.grpTeachers.Name = "grpTeachers";
            this.grpTeachers.Padding = new System.Windows.Forms.Padding(10);
            this.grpTeachers.Size = new System.Drawing.Size(416, 489);
            this.grpTeachers.TabIndex = 0;
            this.grpTeachers.TabStop = false;
            this.grpTeachers.Text = "تفاصيل";
            // 
            // lblTeacherId
            // 
            this.lblTeacherId.AutoSize = true;
            this.lblTeacherId.Location = new System.Drawing.Point(300, 40);
            this.lblTeacherId.Name = "lblTeacherId";
            this.lblTeacherId.Size = new System.Drawing.Size(101, 28);
            this.lblTeacherId.TabIndex = 0;
            this.lblTeacherId.Text = "رقم الأستاذ";
            // 
            // txtTeacherId
            // 
            this.txtTeacherId.Location = new System.Drawing.Point(20, 36);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.Size = new System.Drawing.Size(260, 34);
            this.txtTeacherId.TabIndex = 1;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(300, 90);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(58, 28);
            this.lblTeacherName.TabIndex = 0;
            this.lblTeacherName.Text = "الاسم";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(20, 86);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(260, 34);
            this.txtTeacherName.TabIndex = 1;
            // 
            // chkTeacherActive
            // 
            this.chkTeacherActive.AutoSize = true;
            this.chkTeacherActive.Location = new System.Drawing.Point(20, 140);
            this.chkTeacherActive.Name = "chkTeacherActive";
            this.chkTeacherActive.Size = new System.Drawing.Size(75, 32);
            this.chkTeacherActive.TabIndex = 10;
            this.chkTeacherActive.Text = "نشط";
            this.chkTeacherActive.UseVisualStyleBackColor = true;
            // 
            // flpTeachersButtons
            // 
            this.flpTeachersButtons.Controls.Add(this.btnTeachersAdd);
            this.flpTeachersButtons.Controls.Add(this.btnTeachersUpdate);
            this.flpTeachersButtons.Controls.Add(this.btnTeachersDelete);
            this.flpTeachersButtons.Controls.Add(this.btnTeachersClear);
            this.flpTeachersButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpTeachersButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpTeachersButtons.Location = new System.Drawing.Point(6, 547);
            this.flpTeachersButtons.Name = "flpTeachersButtons";
            this.flpTeachersButtons.Padding = new System.Windows.Forms.Padding(6);
            this.flpTeachersButtons.Size = new System.Drawing.Size(1180, 59);
            this.flpTeachersButtons.TabIndex = 2;
            this.flpTeachersButtons.WrapContents = false;
            // 
            // btnTeachersAdd
            // 
            this.btnTeachersAdd.Location = new System.Drawing.Point(12, 12);
            this.btnTeachersAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnTeachersAdd.Name = "btnTeachersAdd";
            this.btnTeachersAdd.Size = new System.Drawing.Size(110, 36);
            this.btnTeachersAdd.TabIndex = 0;
            this.btnTeachersAdd.Text = "إضافة";
            this.btnTeachersAdd.UseVisualStyleBackColor = true;
            this.btnTeachersAdd.Click += new System.EventHandler(this.btnTeachersAdd_Click);
            // 
            // btnTeachersUpdate
            // 
            this.btnTeachersUpdate.Location = new System.Drawing.Point(134, 12);
            this.btnTeachersUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnTeachersUpdate.Name = "btnTeachersUpdate";
            this.btnTeachersUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnTeachersUpdate.TabIndex = 1;
            this.btnTeachersUpdate.Text = "تعديل";
            this.btnTeachersUpdate.UseVisualStyleBackColor = true;
            this.btnTeachersUpdate.Click += new System.EventHandler(this.btnTeachersUpdate_Click);
            // 
            // btnTeachersDelete
            // 
            this.btnTeachersDelete.Location = new System.Drawing.Point(256, 12);
            this.btnTeachersDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnTeachersDelete.Name = "btnTeachersDelete";
            this.btnTeachersDelete.Size = new System.Drawing.Size(110, 36);
            this.btnTeachersDelete.TabIndex = 2;
            this.btnTeachersDelete.Text = "حذف";
            this.btnTeachersDelete.UseVisualStyleBackColor = true;
            this.btnTeachersDelete.Click += new System.EventHandler(this.btnTeachersDelete_Click);
            // 
            // btnTeachersClear
            // 
            this.btnTeachersClear.Location = new System.Drawing.Point(378, 12);
            this.btnTeachersClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnTeachersClear.Name = "btnTeachersClear";
            this.btnTeachersClear.Size = new System.Drawing.Size(110, 36);
            this.btnTeachersClear.TabIndex = 3;
            this.btnTeachersClear.Text = "تفريغ";
            this.btnTeachersClear.UseVisualStyleBackColor = true;
            this.btnTeachersClear.Click += new System.EventHandler(this.btnTeachersClear_Click);
            // 
            // pnlTeachersSearch
            // 
            this.pnlTeachersSearch.Controls.Add(this.btnTeachersRefresh);
            this.pnlTeachersSearch.Controls.Add(this.btnTeachersSearch);
            this.pnlTeachersSearch.Controls.Add(this.txtTeachersSearch);
            this.pnlTeachersSearch.Controls.Add(this.lblTeachersSearch);
            this.pnlTeachersSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTeachersSearch.Location = new System.Drawing.Point(6, 6);
            this.pnlTeachersSearch.Name = "pnlTeachersSearch";
            this.pnlTeachersSearch.Padding = new System.Windows.Forms.Padding(8);
            this.pnlTeachersSearch.Size = new System.Drawing.Size(1180, 52);
            this.pnlTeachersSearch.TabIndex = 0;
            // 
            // btnTeachersRefresh
            // 
            this.btnTeachersRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTeachersRefresh.Location = new System.Drawing.Point(639, 8);
            this.btnTeachersRefresh.Name = "btnTeachersRefresh";
            this.btnTeachersRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnTeachersRefresh.TabIndex = 3;
            this.btnTeachersRefresh.Text = "تحديث";
            this.btnTeachersRefresh.UseVisualStyleBackColor = true;
            this.btnTeachersRefresh.Click += new System.EventHandler(this.btnTeachersRefresh_Click);
            // 
            // btnTeachersSearch
            // 
            this.btnTeachersSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTeachersSearch.Location = new System.Drawing.Point(739, 8);
            this.btnTeachersSearch.Name = "btnTeachersSearch";
            this.btnTeachersSearch.Size = new System.Drawing.Size(100, 36);
            this.btnTeachersSearch.TabIndex = 2;
            this.btnTeachersSearch.Text = "بحث";
            this.btnTeachersSearch.UseVisualStyleBackColor = true;
            this.btnTeachersSearch.Click += new System.EventHandler(this.btnTeachersSearch_Click);
            // 
            // txtTeachersSearch
            // 
            this.txtTeachersSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtTeachersSearch.Location = new System.Drawing.Point(839, 8);
            this.txtTeachersSearch.Name = "txtTeachersSearch";
            this.txtTeachersSearch.Size = new System.Drawing.Size(280, 34);
            this.txtTeachersSearch.TabIndex = 1;
            this.txtTeachersSearch.TextChanged += new System.EventHandler(this.txtTeachersSearch_TextChanged);
            // 
            // lblTeachersSearch
            // 
            this.lblTeachersSearch.AutoSize = true;
            this.lblTeachersSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTeachersSearch.Location = new System.Drawing.Point(1119, 8);
            this.lblTeachersSearch.Name = "lblTeachersSearch";
            this.lblTeachersSearch.Size = new System.Drawing.Size(53, 28);
            this.lblTeachersSearch.TabIndex = 0;
            this.lblTeachersSearch.Text = "بحث:";
            // 
            // tpCourses
            // 
            this.tpCourses.Controls.Add(this.splitCourses);
            this.tpCourses.Controls.Add(this.flpCoursesButtons);
            this.tpCourses.Controls.Add(this.pnlCoursesSearch);
            this.tpCourses.Location = new System.Drawing.Point(4, 37);
            this.tpCourses.Name = "tpCourses";
            this.tpCourses.Padding = new System.Windows.Forms.Padding(6);
            this.tpCourses.Size = new System.Drawing.Size(1192, 612);
            this.tpCourses.TabIndex = 0;
            this.tpCourses.Text = "المقررات";
            this.tpCourses.UseVisualStyleBackColor = true;
            // 
            // splitCourses
            // 
            this.splitCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCourses.Location = new System.Drawing.Point(6, 59);
            this.splitCourses.Name = "splitCourses";
            // 
            // splitCourses.Panel1
            // 
            this.splitCourses.Panel1.Controls.Add(this.dgvCourses);
            this.splitCourses.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitCourses.Panel2
            // 
            this.splitCourses.Panel2.Controls.Add(this.grpCourses);
            this.splitCourses.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitCourses.Size = new System.Drawing.Size(1180, 487);
            this.splitCourses.SplitterDistance = 760;
            this.splitCourses.TabIndex = 1;
            // 
            // dgvCourses
            // 
            this.dgvCourses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCourses.ColumnHeadersHeight = 29;
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourses.Location = new System.Drawing.Point(0, 0);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 28;
            this.dgvCourses.Size = new System.Drawing.Size(760, 487);
            this.dgvCourses.TabIndex = 0;
            this.dgvCourses.SelectionChanged += new System.EventHandler(this.dgvCourses_SelectionChanged);
            // 
            // grpCourses
            // 
            this.grpCourses.Controls.Add(this.lblCourseCode);
            this.grpCourses.Controls.Add(this.txtCourseCode);
            this.grpCourses.Controls.Add(this.lblCourseName);
            this.grpCourses.Controls.Add(this.txtCourseName);
            this.grpCourses.Controls.Add(this.chkCoursePractical);
            this.grpCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCourses.Location = new System.Drawing.Point(0, 0);
            this.grpCourses.Name = "grpCourses";
            this.grpCourses.Padding = new System.Windows.Forms.Padding(10);
            this.grpCourses.Size = new System.Drawing.Size(416, 487);
            this.grpCourses.TabIndex = 0;
            this.grpCourses.TabStop = false;
            this.grpCourses.Text = "تفاصيل";
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(300, 40);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(96, 28);
            this.lblCourseCode.TabIndex = 0;
            this.lblCourseCode.Text = "كود المادة";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(20, 36);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(260, 34);
            this.txtCourseCode.TabIndex = 1;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(300, 90);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(100, 28);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "اسم المادة";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(20, 86);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(260, 34);
            this.txtCourseName.TabIndex = 1;
            // 
            // chkCoursePractical
            // 
            this.chkCoursePractical.AutoSize = true;
            this.chkCoursePractical.Location = new System.Drawing.Point(20, 140);
            this.chkCoursePractical.Name = "chkCoursePractical";
            this.chkCoursePractical.Size = new System.Drawing.Size(109, 32);
            this.chkCoursePractical.TabIndex = 10;
            this.chkCoursePractical.Text = "لها عملي";
            this.chkCoursePractical.UseVisualStyleBackColor = true;
            // 
            // flpCoursesButtons
            // 
            this.flpCoursesButtons.Controls.Add(this.btnCoursesAdd);
            this.flpCoursesButtons.Controls.Add(this.btnCoursesUpdate);
            this.flpCoursesButtons.Controls.Add(this.btnCoursesDelete);
            this.flpCoursesButtons.Controls.Add(this.btnCoursesClear);
            this.flpCoursesButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpCoursesButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpCoursesButtons.Location = new System.Drawing.Point(6, 546);
            this.flpCoursesButtons.Name = "flpCoursesButtons";
            this.flpCoursesButtons.Padding = new System.Windows.Forms.Padding(6);
            this.flpCoursesButtons.Size = new System.Drawing.Size(1180, 60);
            this.flpCoursesButtons.TabIndex = 2;
            this.flpCoursesButtons.WrapContents = false;
            // 
            // btnCoursesAdd
            // 
            this.btnCoursesAdd.Location = new System.Drawing.Point(12, 12);
            this.btnCoursesAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnCoursesAdd.Name = "btnCoursesAdd";
            this.btnCoursesAdd.Size = new System.Drawing.Size(110, 36);
            this.btnCoursesAdd.TabIndex = 0;
            this.btnCoursesAdd.Text = "إضافة";
            this.btnCoursesAdd.UseVisualStyleBackColor = true;
            this.btnCoursesAdd.Click += new System.EventHandler(this.btnCoursesAdd_Click);
            // 
            // btnCoursesUpdate
            // 
            this.btnCoursesUpdate.Location = new System.Drawing.Point(134, 12);
            this.btnCoursesUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnCoursesUpdate.Name = "btnCoursesUpdate";
            this.btnCoursesUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnCoursesUpdate.TabIndex = 1;
            this.btnCoursesUpdate.Text = "تعديل";
            this.btnCoursesUpdate.UseVisualStyleBackColor = true;
            this.btnCoursesUpdate.Click += new System.EventHandler(this.btnCoursesUpdate_Click);
            // 
            // btnCoursesDelete
            // 
            this.btnCoursesDelete.Location = new System.Drawing.Point(256, 12);
            this.btnCoursesDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnCoursesDelete.Name = "btnCoursesDelete";
            this.btnCoursesDelete.Size = new System.Drawing.Size(110, 36);
            this.btnCoursesDelete.TabIndex = 2;
            this.btnCoursesDelete.Text = "حذف";
            this.btnCoursesDelete.UseVisualStyleBackColor = true;
            this.btnCoursesDelete.Click += new System.EventHandler(this.btnCoursesDelete_Click);
            // 
            // btnCoursesClear
            // 
            this.btnCoursesClear.Location = new System.Drawing.Point(378, 12);
            this.btnCoursesClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnCoursesClear.Name = "btnCoursesClear";
            this.btnCoursesClear.Size = new System.Drawing.Size(110, 36);
            this.btnCoursesClear.TabIndex = 3;
            this.btnCoursesClear.Text = "تفريغ";
            this.btnCoursesClear.UseVisualStyleBackColor = true;
            this.btnCoursesClear.Click += new System.EventHandler(this.btnCoursesClear_Click);
            // 
            // pnlCoursesSearch
            // 
            this.pnlCoursesSearch.Controls.Add(this.btnCoursesRefresh);
            this.pnlCoursesSearch.Controls.Add(this.btnCoursesSearch);
            this.pnlCoursesSearch.Controls.Add(this.txtCoursesSearch);
            this.pnlCoursesSearch.Controls.Add(this.lblCoursesSearch);
            this.pnlCoursesSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCoursesSearch.Location = new System.Drawing.Point(6, 6);
            this.pnlCoursesSearch.Name = "pnlCoursesSearch";
            this.pnlCoursesSearch.Padding = new System.Windows.Forms.Padding(8);
            this.pnlCoursesSearch.Size = new System.Drawing.Size(1180, 53);
            this.pnlCoursesSearch.TabIndex = 0;
            // 
            // btnCoursesRefresh
            // 
            this.btnCoursesRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCoursesRefresh.Location = new System.Drawing.Point(639, 8);
            this.btnCoursesRefresh.Name = "btnCoursesRefresh";
            this.btnCoursesRefresh.Size = new System.Drawing.Size(100, 37);
            this.btnCoursesRefresh.TabIndex = 3;
            this.btnCoursesRefresh.Text = "تحديث";
            this.btnCoursesRefresh.UseVisualStyleBackColor = true;
            this.btnCoursesRefresh.Click += new System.EventHandler(this.btnCoursesRefresh_Click);
            // 
            // btnCoursesSearch
            // 
            this.btnCoursesSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCoursesSearch.Location = new System.Drawing.Point(739, 8);
            this.btnCoursesSearch.Name = "btnCoursesSearch";
            this.btnCoursesSearch.Size = new System.Drawing.Size(100, 37);
            this.btnCoursesSearch.TabIndex = 2;
            this.btnCoursesSearch.Text = "بحث";
            this.btnCoursesSearch.UseVisualStyleBackColor = true;
            this.btnCoursesSearch.Click += new System.EventHandler(this.btnCoursesSearch_Click);
            // 
            // txtCoursesSearch
            // 
            this.txtCoursesSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtCoursesSearch.Location = new System.Drawing.Point(839, 8);
            this.txtCoursesSearch.Name = "txtCoursesSearch";
            this.txtCoursesSearch.Size = new System.Drawing.Size(280, 34);
            this.txtCoursesSearch.TabIndex = 1;
            this.txtCoursesSearch.TextChanged += new System.EventHandler(this.txtCoursesSearch_TextChanged);
            // 
            // lblCoursesSearch
            // 
            this.lblCoursesSearch.AutoSize = true;
            this.lblCoursesSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCoursesSearch.Location = new System.Drawing.Point(1119, 8);
            this.lblCoursesSearch.Name = "lblCoursesSearch";
            this.lblCoursesSearch.Size = new System.Drawing.Size(53, 28);
            this.lblCoursesSearch.TabIndex = 0;
            this.lblCoursesSearch.Text = "بحث:";
            // 
            // tpOfferings
            // 
            this.tpOfferings.Controls.Add(this.splitOfferings);
            this.tpOfferings.Controls.Add(this.flpOfferingsButtons);
            this.tpOfferings.Controls.Add(this.pnlOfferingsSearch);
            this.tpOfferings.Location = new System.Drawing.Point(4, 37);
            this.tpOfferings.Name = "tpOfferings";
            this.tpOfferings.Padding = new System.Windows.Forms.Padding(6);
            this.tpOfferings.Size = new System.Drawing.Size(1192, 612);
            this.tpOfferings.TabIndex = 0;
            this.tpOfferings.Text = "طرح المقررات";
            this.tpOfferings.UseVisualStyleBackColor = true;
            // 
            // splitOfferings
            // 
            this.splitOfferings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitOfferings.Location = new System.Drawing.Point(6, 57);
            this.splitOfferings.Name = "splitOfferings";
            // 
            // splitOfferings.Panel1
            // 
            this.splitOfferings.Panel1.Controls.Add(this.dgvOfferings);
            this.splitOfferings.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitOfferings.Panel2
            // 
            this.splitOfferings.Panel2.Controls.Add(this.grpOfferings);
            this.splitOfferings.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitOfferings.Size = new System.Drawing.Size(1180, 490);
            this.splitOfferings.SplitterDistance = 760;
            this.splitOfferings.TabIndex = 1;
            // 
            // dgvOfferings
            // 
            this.dgvOfferings.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOfferings.ColumnHeadersHeight = 29;
            this.dgvOfferings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOfferings.Location = new System.Drawing.Point(0, 0);
            this.dgvOfferings.Name = "dgvOfferings";
            this.dgvOfferings.RowHeadersWidth = 51;
            this.dgvOfferings.RowTemplate.Height = 28;
            this.dgvOfferings.Size = new System.Drawing.Size(760, 490);
            this.dgvOfferings.TabIndex = 0;
            this.dgvOfferings.SelectionChanged += new System.EventHandler(this.dgvOfferings_SelectionChanged);
            // 
            // grpOfferings
            // 
            this.grpOfferings.Controls.Add(this.lblOfferingTerm);
            this.grpOfferings.Controls.Add(this.cmbOfferingTerm);
            this.grpOfferings.Controls.Add(this.lblOfferingCourse);
            this.grpOfferings.Controls.Add(this.cmbOfferingCourse);
            this.grpOfferings.Controls.Add(this.lblOfferingType);
            this.grpOfferings.Controls.Add(this.cmbOfferingType);
            this.grpOfferings.Controls.Add(this.lblOfferingMax);
            this.grpOfferings.Controls.Add(this.nudOfferingMax);
            this.grpOfferings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOfferings.Location = new System.Drawing.Point(0, 0);
            this.grpOfferings.Name = "grpOfferings";
            this.grpOfferings.Padding = new System.Windows.Forms.Padding(10);
            this.grpOfferings.Size = new System.Drawing.Size(416, 490);
            this.grpOfferings.TabIndex = 0;
            this.grpOfferings.TabStop = false;
            this.grpOfferings.Text = "تفاصيل";
            // 
            // lblOfferingTerm
            // 
            this.lblOfferingTerm.AutoSize = true;
            this.lblOfferingTerm.Location = new System.Drawing.Point(300, 40);
            this.lblOfferingTerm.Name = "lblOfferingTerm";
            this.lblOfferingTerm.Size = new System.Drawing.Size(49, 28);
            this.lblOfferingTerm.TabIndex = 0;
            this.lblOfferingTerm.Text = "الترم";
            // 
            // cmbOfferingTerm
            // 
            this.cmbOfferingTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOfferingTerm.FormattingEnabled = true;
            this.cmbOfferingTerm.Location = new System.Drawing.Point(20, 36);
            this.cmbOfferingTerm.Name = "cmbOfferingTerm";
            this.cmbOfferingTerm.Size = new System.Drawing.Size(260, 36);
            this.cmbOfferingTerm.TabIndex = 2;
            // 
            // lblOfferingCourse
            // 
            this.lblOfferingCourse.AutoSize = true;
            this.lblOfferingCourse.Location = new System.Drawing.Point(300, 90);
            this.lblOfferingCourse.Name = "lblOfferingCourse";
            this.lblOfferingCourse.Size = new System.Drawing.Size(60, 28);
            this.lblOfferingCourse.TabIndex = 0;
            this.lblOfferingCourse.Text = "المقرر";
            // 
            // cmbOfferingCourse
            // 
            this.cmbOfferingCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOfferingCourse.FormattingEnabled = true;
            this.cmbOfferingCourse.Location = new System.Drawing.Point(20, 86);
            this.cmbOfferingCourse.Name = "cmbOfferingCourse";
            this.cmbOfferingCourse.Size = new System.Drawing.Size(260, 36);
            this.cmbOfferingCourse.TabIndex = 2;
            // 
            // lblOfferingType
            // 
            this.lblOfferingType.AutoSize = true;
            this.lblOfferingType.Location = new System.Drawing.Point(300, 140);
            this.lblOfferingType.Name = "lblOfferingType";
            this.lblOfferingType.Size = new System.Drawing.Size(53, 28);
            this.lblOfferingType.TabIndex = 0;
            this.lblOfferingType.Text = "النوع";
            // 
            // cmbOfferingType
            // 
            this.cmbOfferingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOfferingType.FormattingEnabled = true;
            this.cmbOfferingType.Items.AddRange(new object[] {
            "نظري",
            "عملي"});
            this.cmbOfferingType.Location = new System.Drawing.Point(20, 136);
            this.cmbOfferingType.Name = "cmbOfferingType";
            this.cmbOfferingType.Size = new System.Drawing.Size(140, 36);
            this.cmbOfferingType.TabIndex = 2;
            // 
            // lblOfferingMax
            // 
            this.lblOfferingMax.AutoSize = true;
            this.lblOfferingMax.Location = new System.Drawing.Point(275, 190);
            this.lblOfferingMax.Name = "lblOfferingMax";
            this.lblOfferingMax.Size = new System.Drawing.Size(136, 28);
            this.lblOfferingMax.TabIndex = 0;
            this.lblOfferingMax.Text = "الدرجة القصوى";
            // 
            // nudOfferingMax
            // 
            this.nudOfferingMax.Location = new System.Drawing.Point(20, 186);
            this.nudOfferingMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOfferingMax.Name = "nudOfferingMax";
            this.nudOfferingMax.Size = new System.Drawing.Size(140, 34);
            this.nudOfferingMax.TabIndex = 3;
            this.nudOfferingMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // flpOfferingsButtons
            // 
            this.flpOfferingsButtons.Controls.Add(this.btnOfferingsAdd);
            this.flpOfferingsButtons.Controls.Add(this.btnOfferingsUpdate);
            this.flpOfferingsButtons.Controls.Add(this.btnOfferingsDelete);
            this.flpOfferingsButtons.Controls.Add(this.btnOfferingsClear);
            this.flpOfferingsButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpOfferingsButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpOfferingsButtons.Location = new System.Drawing.Point(6, 547);
            this.flpOfferingsButtons.Name = "flpOfferingsButtons";
            this.flpOfferingsButtons.Padding = new System.Windows.Forms.Padding(6);
            this.flpOfferingsButtons.Size = new System.Drawing.Size(1180, 59);
            this.flpOfferingsButtons.TabIndex = 2;
            this.flpOfferingsButtons.WrapContents = false;
            // 
            // btnOfferingsAdd
            // 
            this.btnOfferingsAdd.Location = new System.Drawing.Point(12, 12);
            this.btnOfferingsAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnOfferingsAdd.Name = "btnOfferingsAdd";
            this.btnOfferingsAdd.Size = new System.Drawing.Size(110, 36);
            this.btnOfferingsAdd.TabIndex = 0;
            this.btnOfferingsAdd.Text = "إضافة";
            this.btnOfferingsAdd.UseVisualStyleBackColor = true;
            this.btnOfferingsAdd.Click += new System.EventHandler(this.btnOfferingsAdd_Click);
            // 
            // btnOfferingsUpdate
            // 
            this.btnOfferingsUpdate.Location = new System.Drawing.Point(134, 12);
            this.btnOfferingsUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnOfferingsUpdate.Name = "btnOfferingsUpdate";
            this.btnOfferingsUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnOfferingsUpdate.TabIndex = 1;
            this.btnOfferingsUpdate.Text = "تعديل";
            this.btnOfferingsUpdate.UseVisualStyleBackColor = true;
            this.btnOfferingsUpdate.Click += new System.EventHandler(this.btnOfferingsUpdate_Click);
            // 
            // btnOfferingsDelete
            // 
            this.btnOfferingsDelete.Location = new System.Drawing.Point(256, 12);
            this.btnOfferingsDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnOfferingsDelete.Name = "btnOfferingsDelete";
            this.btnOfferingsDelete.Size = new System.Drawing.Size(110, 36);
            this.btnOfferingsDelete.TabIndex = 2;
            this.btnOfferingsDelete.Text = "حذف";
            this.btnOfferingsDelete.UseVisualStyleBackColor = true;
            this.btnOfferingsDelete.Click += new System.EventHandler(this.btnOfferingsDelete_Click);
            // 
            // btnOfferingsClear
            // 
            this.btnOfferingsClear.Location = new System.Drawing.Point(378, 12);
            this.btnOfferingsClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnOfferingsClear.Name = "btnOfferingsClear";
            this.btnOfferingsClear.Size = new System.Drawing.Size(110, 36);
            this.btnOfferingsClear.TabIndex = 3;
            this.btnOfferingsClear.Text = "تفريغ";
            this.btnOfferingsClear.UseVisualStyleBackColor = true;
            this.btnOfferingsClear.Click += new System.EventHandler(this.btnOfferingsClear_Click);
            // 
            // pnlOfferingsSearch
            // 
            this.pnlOfferingsSearch.Controls.Add(this.btnOfferingsRefresh);
            this.pnlOfferingsSearch.Controls.Add(this.btnOfferingsSearch);
            this.pnlOfferingsSearch.Controls.Add(this.txtOfferingsSearch);
            this.pnlOfferingsSearch.Controls.Add(this.lblOfferingsSearch);
            this.pnlOfferingsSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOfferingsSearch.Location = new System.Drawing.Point(6, 6);
            this.pnlOfferingsSearch.Name = "pnlOfferingsSearch";
            this.pnlOfferingsSearch.Padding = new System.Windows.Forms.Padding(8);
            this.pnlOfferingsSearch.Size = new System.Drawing.Size(1180, 51);
            this.pnlOfferingsSearch.TabIndex = 0;
            // 
            // btnOfferingsRefresh
            // 
            this.btnOfferingsRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOfferingsRefresh.Location = new System.Drawing.Point(639, 8);
            this.btnOfferingsRefresh.Name = "btnOfferingsRefresh";
            this.btnOfferingsRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnOfferingsRefresh.TabIndex = 3;
            this.btnOfferingsRefresh.Text = "تحديث";
            this.btnOfferingsRefresh.UseVisualStyleBackColor = true;
            this.btnOfferingsRefresh.Click += new System.EventHandler(this.btnOfferingsRefresh_Click);
            // 
            // btnOfferingsSearch
            // 
            this.btnOfferingsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOfferingsSearch.Location = new System.Drawing.Point(739, 8);
            this.btnOfferingsSearch.Name = "btnOfferingsSearch";
            this.btnOfferingsSearch.Size = new System.Drawing.Size(100, 35);
            this.btnOfferingsSearch.TabIndex = 2;
            this.btnOfferingsSearch.Text = "بحث";
            this.btnOfferingsSearch.UseVisualStyleBackColor = true;
            this.btnOfferingsSearch.Click += new System.EventHandler(this.btnOfferingsSearch_Click);
            // 
            // txtOfferingsSearch
            // 
            this.txtOfferingsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtOfferingsSearch.Location = new System.Drawing.Point(839, 8);
            this.txtOfferingsSearch.Name = "txtOfferingsSearch";
            this.txtOfferingsSearch.Size = new System.Drawing.Size(280, 34);
            this.txtOfferingsSearch.TabIndex = 1;
            this.txtOfferingsSearch.TextChanged += new System.EventHandler(this.txtOfferingsSearch_TextChanged);
            // 
            // lblOfferingsSearch
            // 
            this.lblOfferingsSearch.AutoSize = true;
            this.lblOfferingsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblOfferingsSearch.Location = new System.Drawing.Point(1119, 8);
            this.lblOfferingsSearch.Name = "lblOfferingsSearch";
            this.lblOfferingsSearch.Size = new System.Drawing.Size(53, 28);
            this.lblOfferingsSearch.TabIndex = 0;
            this.lblOfferingsSearch.Text = "بحث:";
            // 
            // tpAssignments
            // 
            this.tpAssignments.Controls.Add(this.splitAssignments);
            this.tpAssignments.Controls.Add(this.flpAssignmentsButtons);
            this.tpAssignments.Controls.Add(this.pnlAssignmentsSearch);
            this.tpAssignments.Location = new System.Drawing.Point(4, 37);
            this.tpAssignments.Name = "tpAssignments";
            this.tpAssignments.Padding = new System.Windows.Forms.Padding(6);
            this.tpAssignments.Size = new System.Drawing.Size(1192, 612);
            this.tpAssignments.TabIndex = 0;
            this.tpAssignments.Text = "توزيع المدرسين";
            this.tpAssignments.UseVisualStyleBackColor = true;
            // 
            // splitAssignments
            // 
            this.splitAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitAssignments.Location = new System.Drawing.Point(6, 58);
            this.splitAssignments.Name = "splitAssignments";
            // 
            // splitAssignments.Panel1
            // 
            this.splitAssignments.Panel1.Controls.Add(this.dgvAssignments);
            this.splitAssignments.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitAssignments.Panel2
            // 
            this.splitAssignments.Panel2.Controls.Add(this.grpAssignments);
            this.splitAssignments.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitAssignments.Size = new System.Drawing.Size(1180, 490);
            this.splitAssignments.SplitterDistance = 760;
            this.splitAssignments.TabIndex = 1;
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAssignments.ColumnHeadersHeight = 29;
            this.dgvAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignments.Location = new System.Drawing.Point(0, 0);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.RowHeadersWidth = 51;
            this.dgvAssignments.RowTemplate.Height = 28;
            this.dgvAssignments.Size = new System.Drawing.Size(760, 490);
            this.dgvAssignments.TabIndex = 0;
            this.dgvAssignments.SelectionChanged += new System.EventHandler(this.dgvAssignments_SelectionChanged);
            // 
            // grpAssignments
            // 
            this.grpAssignments.Controls.Add(this.lblAssignOffering);
            this.grpAssignments.Controls.Add(this.cmbAssignOffering);
            this.grpAssignments.Controls.Add(this.lblAssignTeacher);
            this.grpAssignments.Controls.Add(this.cmbAssignTeacher);
            this.grpAssignments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAssignments.Location = new System.Drawing.Point(0, 0);
            this.grpAssignments.Name = "grpAssignments";
            this.grpAssignments.Padding = new System.Windows.Forms.Padding(10);
            this.grpAssignments.Size = new System.Drawing.Size(416, 490);
            this.grpAssignments.TabIndex = 0;
            this.grpAssignments.TabStop = false;
            this.grpAssignments.Text = "تفاصيل";
            // 
            // lblAssignOffering
            // 
            this.lblAssignOffering.AutoSize = true;
            this.lblAssignOffering.Location = new System.Drawing.Point(276, 44);
            this.lblAssignOffering.Name = "lblAssignOffering";
            this.lblAssignOffering.Size = new System.Drawing.Size(145, 28);
            this.lblAssignOffering.TabIndex = 0;
            this.lblAssignOffering.Text = "المادة المطروحة";
            // 
            // cmbAssignOffering
            // 
            this.cmbAssignOffering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignOffering.FormattingEnabled = true;
            this.cmbAssignOffering.Location = new System.Drawing.Point(8, 36);
            this.cmbAssignOffering.Name = "cmbAssignOffering";
            this.cmbAssignOffering.Size = new System.Drawing.Size(260, 36);
            this.cmbAssignOffering.TabIndex = 2;
            // 
            // lblAssignTeacher
            // 
            this.lblAssignTeacher.AutoSize = true;
            this.lblAssignTeacher.Location = new System.Drawing.Point(294, 90);
            this.lblAssignTeacher.Name = "lblAssignTeacher";
            this.lblAssignTeacher.Size = new System.Drawing.Size(68, 28);
            this.lblAssignTeacher.TabIndex = 0;
            this.lblAssignTeacher.Text = "الأستاذ";
            // 
            // cmbAssignTeacher
            // 
            this.cmbAssignTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignTeacher.FormattingEnabled = true;
            this.cmbAssignTeacher.Location = new System.Drawing.Point(8, 86);
            this.cmbAssignTeacher.Name = "cmbAssignTeacher";
            this.cmbAssignTeacher.Size = new System.Drawing.Size(260, 36);
            this.cmbAssignTeacher.TabIndex = 2;
            // 
            // flpAssignmentsButtons
            // 
            this.flpAssignmentsButtons.Controls.Add(this.btnAssignmentsAdd);
            this.flpAssignmentsButtons.Controls.Add(this.btnAssignmentsUpdate);
            this.flpAssignmentsButtons.Controls.Add(this.btnAssignmentsDelete);
            this.flpAssignmentsButtons.Controls.Add(this.btnAssignmentsClear);
            this.flpAssignmentsButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpAssignmentsButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAssignmentsButtons.Location = new System.Drawing.Point(6, 548);
            this.flpAssignmentsButtons.Name = "flpAssignmentsButtons";
            this.flpAssignmentsButtons.Padding = new System.Windows.Forms.Padding(6);
            this.flpAssignmentsButtons.Size = new System.Drawing.Size(1180, 58);
            this.flpAssignmentsButtons.TabIndex = 2;
            this.flpAssignmentsButtons.WrapContents = false;
            // 
            // btnAssignmentsAdd
            // 
            this.btnAssignmentsAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAssignmentsAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAssignmentsAdd.Name = "btnAssignmentsAdd";
            this.btnAssignmentsAdd.Size = new System.Drawing.Size(110, 36);
            this.btnAssignmentsAdd.TabIndex = 0;
            this.btnAssignmentsAdd.Text = "إضافة";
            this.btnAssignmentsAdd.UseVisualStyleBackColor = true;
            this.btnAssignmentsAdd.Click += new System.EventHandler(this.btnAssignmentsAdd_Click);
            // 
            // btnAssignmentsUpdate
            // 
            this.btnAssignmentsUpdate.Location = new System.Drawing.Point(134, 12);
            this.btnAssignmentsUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnAssignmentsUpdate.Name = "btnAssignmentsUpdate";
            this.btnAssignmentsUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnAssignmentsUpdate.TabIndex = 1;
            this.btnAssignmentsUpdate.Text = "تعديل";
            this.btnAssignmentsUpdate.UseVisualStyleBackColor = true;
            this.btnAssignmentsUpdate.Click += new System.EventHandler(this.btnAssignmentsUpdate_Click);
            // 
            // btnAssignmentsDelete
            // 
            this.btnAssignmentsDelete.Location = new System.Drawing.Point(256, 12);
            this.btnAssignmentsDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnAssignmentsDelete.Name = "btnAssignmentsDelete";
            this.btnAssignmentsDelete.Size = new System.Drawing.Size(110, 36);
            this.btnAssignmentsDelete.TabIndex = 2;
            this.btnAssignmentsDelete.Text = "حذف";
            this.btnAssignmentsDelete.UseVisualStyleBackColor = true;
            this.btnAssignmentsDelete.Click += new System.EventHandler(this.btnAssignmentsDelete_Click);
            // 
            // btnAssignmentsClear
            // 
            this.btnAssignmentsClear.Location = new System.Drawing.Point(378, 12);
            this.btnAssignmentsClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnAssignmentsClear.Name = "btnAssignmentsClear";
            this.btnAssignmentsClear.Size = new System.Drawing.Size(110, 36);
            this.btnAssignmentsClear.TabIndex = 3;
            this.btnAssignmentsClear.Text = "تفريغ";
            this.btnAssignmentsClear.UseVisualStyleBackColor = true;
            this.btnAssignmentsClear.Click += new System.EventHandler(this.btnAssignmentsClear_Click);
            // 
            // pnlAssignmentsSearch
            // 
            this.pnlAssignmentsSearch.Controls.Add(this.btnAssignmentsRefresh);
            this.pnlAssignmentsSearch.Controls.Add(this.btnAssignmentsSearch);
            this.pnlAssignmentsSearch.Controls.Add(this.txtAssignmentsSearch);
            this.pnlAssignmentsSearch.Controls.Add(this.lblAssignmentsSearch);
            this.pnlAssignmentsSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAssignmentsSearch.Location = new System.Drawing.Point(6, 6);
            this.pnlAssignmentsSearch.Name = "pnlAssignmentsSearch";
            this.pnlAssignmentsSearch.Padding = new System.Windows.Forms.Padding(8);
            this.pnlAssignmentsSearch.Size = new System.Drawing.Size(1180, 52);
            this.pnlAssignmentsSearch.TabIndex = 0;
            // 
            // btnAssignmentsRefresh
            // 
            this.btnAssignmentsRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAssignmentsRefresh.Location = new System.Drawing.Point(639, 8);
            this.btnAssignmentsRefresh.Name = "btnAssignmentsRefresh";
            this.btnAssignmentsRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnAssignmentsRefresh.TabIndex = 3;
            this.btnAssignmentsRefresh.Text = "تحديث";
            this.btnAssignmentsRefresh.UseVisualStyleBackColor = true;
            this.btnAssignmentsRefresh.Click += new System.EventHandler(this.btnAssignmentsRefresh_Click);
            // 
            // btnAssignmentsSearch
            // 
            this.btnAssignmentsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAssignmentsSearch.Location = new System.Drawing.Point(739, 8);
            this.btnAssignmentsSearch.Name = "btnAssignmentsSearch";
            this.btnAssignmentsSearch.Size = new System.Drawing.Size(100, 36);
            this.btnAssignmentsSearch.TabIndex = 2;
            this.btnAssignmentsSearch.Text = "بحث";
            this.btnAssignmentsSearch.UseVisualStyleBackColor = true;
            this.btnAssignmentsSearch.Click += new System.EventHandler(this.btnAssignmentsSearch_Click);
            // 
            // txtAssignmentsSearch
            // 
            this.txtAssignmentsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtAssignmentsSearch.Location = new System.Drawing.Point(839, 8);
            this.txtAssignmentsSearch.Name = "txtAssignmentsSearch";
            this.txtAssignmentsSearch.Size = new System.Drawing.Size(280, 34);
            this.txtAssignmentsSearch.TabIndex = 1;
            this.txtAssignmentsSearch.TextChanged += new System.EventHandler(this.txtAssignmentsSearch_TextChanged);
            // 
            // lblAssignmentsSearch
            // 
            this.lblAssignmentsSearch.AutoSize = true;
            this.lblAssignmentsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAssignmentsSearch.Location = new System.Drawing.Point(1119, 8);
            this.lblAssignmentsSearch.Name = "lblAssignmentsSearch";
            this.lblAssignmentsSearch.Size = new System.Drawing.Size(53, 28);
            this.lblAssignmentsSearch.TabIndex = 0;
            this.lblAssignmentsSearch.Text = "بحث:";
            // 
            // tpEnrollments
            // 
            this.tpEnrollments.Controls.Add(this.splitEnrollments);
            this.tpEnrollments.Controls.Add(this.flpEnrollmentsButtons);
            this.tpEnrollments.Controls.Add(this.pnlEnrollmentsSearch);
            this.tpEnrollments.Location = new System.Drawing.Point(4, 37);
            this.tpEnrollments.Name = "tpEnrollments";
            this.tpEnrollments.Padding = new System.Windows.Forms.Padding(6);
            this.tpEnrollments.Size = new System.Drawing.Size(1192, 612);
            this.tpEnrollments.TabIndex = 0;
            this.tpEnrollments.Text = "تسجيل الطلاب";
            this.tpEnrollments.UseVisualStyleBackColor = true;
            // 
            // splitEnrollments
            // 
            this.splitEnrollments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitEnrollments.Location = new System.Drawing.Point(6, 59);
            this.splitEnrollments.Name = "splitEnrollments";
            // 
            // splitEnrollments.Panel1
            // 
            this.splitEnrollments.Panel1.Controls.Add(this.dgvEnrollments);
            this.splitEnrollments.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitEnrollments.Panel2
            // 
            this.splitEnrollments.Panel2.Controls.Add(this.grpEnrollments);
            this.splitEnrollments.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitEnrollments.Size = new System.Drawing.Size(1180, 488);
            this.splitEnrollments.SplitterDistance = 760;
            this.splitEnrollments.TabIndex = 1;
            // 
            // dgvEnrollments
            // 
            this.dgvEnrollments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEnrollments.ColumnHeadersHeight = 29;
            this.dgvEnrollments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnrollments.Location = new System.Drawing.Point(0, 0);
            this.dgvEnrollments.Name = "dgvEnrollments";
            this.dgvEnrollments.RowHeadersWidth = 51;
            this.dgvEnrollments.RowTemplate.Height = 28;
            this.dgvEnrollments.Size = new System.Drawing.Size(760, 488);
            this.dgvEnrollments.TabIndex = 0;
            this.dgvEnrollments.SelectionChanged += new System.EventHandler(this.dgvEnrollments_SelectionChanged);
            // 
            // grpEnrollments
            // 
            this.grpEnrollments.Controls.Add(this.lblEnrollStudent);
            this.grpEnrollments.Controls.Add(this.cmbEnrollStudent);
            this.grpEnrollments.Controls.Add(this.lblEnrollOffering);
            this.grpEnrollments.Controls.Add(this.cmbEnrollOffering);
            this.grpEnrollments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEnrollments.Location = new System.Drawing.Point(0, 0);
            this.grpEnrollments.Name = "grpEnrollments";
            this.grpEnrollments.Padding = new System.Windows.Forms.Padding(10);
            this.grpEnrollments.Size = new System.Drawing.Size(416, 488);
            this.grpEnrollments.TabIndex = 0;
            this.grpEnrollments.TabStop = false;
            this.grpEnrollments.Text = "تفاصيل";
            // 
            // lblEnrollStudent
            // 
            this.lblEnrollStudent.AutoSize = true;
            this.lblEnrollStudent.Location = new System.Drawing.Point(288, 40);
            this.lblEnrollStudent.Name = "lblEnrollStudent";
            this.lblEnrollStudent.Size = new System.Drawing.Size(71, 28);
            this.lblEnrollStudent.TabIndex = 0;
            this.lblEnrollStudent.Text = "الطالب";
            // 
            // cmbEnrollStudent
            // 
            this.cmbEnrollStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnrollStudent.FormattingEnabled = true;
            this.cmbEnrollStudent.Location = new System.Drawing.Point(5, 36);
            this.cmbEnrollStudent.Name = "cmbEnrollStudent";
            this.cmbEnrollStudent.Size = new System.Drawing.Size(260, 36);
            this.cmbEnrollStudent.TabIndex = 2;
            // 
            // lblEnrollOffering
            // 
            this.lblEnrollOffering.AutoSize = true;
            this.lblEnrollOffering.Location = new System.Drawing.Point(276, 90);
            this.lblEnrollOffering.Name = "lblEnrollOffering";
            this.lblEnrollOffering.Size = new System.Drawing.Size(145, 28);
            this.lblEnrollOffering.TabIndex = 0;
            this.lblEnrollOffering.Text = "المادة المطروحة";
            // 
            // cmbEnrollOffering
            // 
            this.cmbEnrollOffering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnrollOffering.FormattingEnabled = true;
            this.cmbEnrollOffering.Location = new System.Drawing.Point(5, 86);
            this.cmbEnrollOffering.Name = "cmbEnrollOffering";
            this.cmbEnrollOffering.Size = new System.Drawing.Size(260, 36);
            this.cmbEnrollOffering.TabIndex = 2;
            // 
            // flpEnrollmentsButtons
            // 
            this.flpEnrollmentsButtons.Controls.Add(this.btnEnrollmentsAdd);
            this.flpEnrollmentsButtons.Controls.Add(this.btnEnrollmentsUpdate);
            this.flpEnrollmentsButtons.Controls.Add(this.btnEnrollmentsDelete);
            this.flpEnrollmentsButtons.Controls.Add(this.btnEnrollmentsClear);
            this.flpEnrollmentsButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpEnrollmentsButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpEnrollmentsButtons.Location = new System.Drawing.Point(6, 547);
            this.flpEnrollmentsButtons.Name = "flpEnrollmentsButtons";
            this.flpEnrollmentsButtons.Padding = new System.Windows.Forms.Padding(6);
            this.flpEnrollmentsButtons.Size = new System.Drawing.Size(1180, 59);
            this.flpEnrollmentsButtons.TabIndex = 2;
            this.flpEnrollmentsButtons.WrapContents = false;
            // 
            // btnEnrollmentsAdd
            // 
            this.btnEnrollmentsAdd.Location = new System.Drawing.Point(12, 12);
            this.btnEnrollmentsAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnrollmentsAdd.Name = "btnEnrollmentsAdd";
            this.btnEnrollmentsAdd.Size = new System.Drawing.Size(110, 36);
            this.btnEnrollmentsAdd.TabIndex = 0;
            this.btnEnrollmentsAdd.Text = "إضافة";
            this.btnEnrollmentsAdd.UseVisualStyleBackColor = true;
            this.btnEnrollmentsAdd.Click += new System.EventHandler(this.btnEnrollmentsAdd_Click);
            // 
            // btnEnrollmentsUpdate
            // 
            this.btnEnrollmentsUpdate.Location = new System.Drawing.Point(134, 12);
            this.btnEnrollmentsUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnrollmentsUpdate.Name = "btnEnrollmentsUpdate";
            this.btnEnrollmentsUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnEnrollmentsUpdate.TabIndex = 1;
            this.btnEnrollmentsUpdate.Text = "تعديل";
            this.btnEnrollmentsUpdate.UseVisualStyleBackColor = true;
            this.btnEnrollmentsUpdate.Click += new System.EventHandler(this.btnEnrollmentsUpdate_Click);
            // 
            // btnEnrollmentsDelete
            // 
            this.btnEnrollmentsDelete.Location = new System.Drawing.Point(256, 12);
            this.btnEnrollmentsDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnrollmentsDelete.Name = "btnEnrollmentsDelete";
            this.btnEnrollmentsDelete.Size = new System.Drawing.Size(110, 36);
            this.btnEnrollmentsDelete.TabIndex = 2;
            this.btnEnrollmentsDelete.Text = "حذف";
            this.btnEnrollmentsDelete.UseVisualStyleBackColor = true;
            this.btnEnrollmentsDelete.Click += new System.EventHandler(this.btnEnrollmentsDelete_Click);
            // 
            // btnEnrollmentsClear
            // 
            this.btnEnrollmentsClear.Location = new System.Drawing.Point(378, 12);
            this.btnEnrollmentsClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnrollmentsClear.Name = "btnEnrollmentsClear";
            this.btnEnrollmentsClear.Size = new System.Drawing.Size(110, 36);
            this.btnEnrollmentsClear.TabIndex = 3;
            this.btnEnrollmentsClear.Text = "تفريغ";
            this.btnEnrollmentsClear.UseVisualStyleBackColor = true;
            this.btnEnrollmentsClear.Click += new System.EventHandler(this.btnEnrollmentsClear_Click);
            // 
            // pnlEnrollmentsSearch
            // 
            this.pnlEnrollmentsSearch.Controls.Add(this.btnEnrollmentsRefresh);
            this.pnlEnrollmentsSearch.Controls.Add(this.btnEnrollmentsSearch);
            this.pnlEnrollmentsSearch.Controls.Add(this.txtEnrollmentsSearch);
            this.pnlEnrollmentsSearch.Controls.Add(this.lblEnrollmentsSearch);
            this.pnlEnrollmentsSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEnrollmentsSearch.Location = new System.Drawing.Point(6, 6);
            this.pnlEnrollmentsSearch.Name = "pnlEnrollmentsSearch";
            this.pnlEnrollmentsSearch.Padding = new System.Windows.Forms.Padding(8);
            this.pnlEnrollmentsSearch.Size = new System.Drawing.Size(1180, 53);
            this.pnlEnrollmentsSearch.TabIndex = 0;
            // 
            // btnEnrollmentsRefresh
            // 
            this.btnEnrollmentsRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnrollmentsRefresh.Location = new System.Drawing.Point(639, 8);
            this.btnEnrollmentsRefresh.Name = "btnEnrollmentsRefresh";
            this.btnEnrollmentsRefresh.Size = new System.Drawing.Size(100, 37);
            this.btnEnrollmentsRefresh.TabIndex = 3;
            this.btnEnrollmentsRefresh.Text = "تحديث";
            this.btnEnrollmentsRefresh.UseVisualStyleBackColor = true;
            this.btnEnrollmentsRefresh.Click += new System.EventHandler(this.btnEnrollmentsRefresh_Click);
            // 
            // btnEnrollmentsSearch
            // 
            this.btnEnrollmentsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnrollmentsSearch.Location = new System.Drawing.Point(739, 8);
            this.btnEnrollmentsSearch.Name = "btnEnrollmentsSearch";
            this.btnEnrollmentsSearch.Size = new System.Drawing.Size(100, 37);
            this.btnEnrollmentsSearch.TabIndex = 2;
            this.btnEnrollmentsSearch.Text = "بحث";
            this.btnEnrollmentsSearch.UseVisualStyleBackColor = true;
            this.btnEnrollmentsSearch.Click += new System.EventHandler(this.btnEnrollmentsSearch_Click);
            // 
            // txtEnrollmentsSearch
            // 
            this.txtEnrollmentsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtEnrollmentsSearch.Location = new System.Drawing.Point(839, 8);
            this.txtEnrollmentsSearch.Name = "txtEnrollmentsSearch";
            this.txtEnrollmentsSearch.Size = new System.Drawing.Size(280, 34);
            this.txtEnrollmentsSearch.TabIndex = 1;
            this.txtEnrollmentsSearch.TextChanged += new System.EventHandler(this.txtEnrollmentsSearch_TextChanged);
            // 
            // lblEnrollmentsSearch
            // 
            this.lblEnrollmentsSearch.AutoSize = true;
            this.lblEnrollmentsSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEnrollmentsSearch.Location = new System.Drawing.Point(1119, 8);
            this.lblEnrollmentsSearch.Name = "lblEnrollmentsSearch";
            this.lblEnrollmentsSearch.Size = new System.Drawing.Size(53, 28);
            this.lblEnrollmentsSearch.TabIndex = 0;
            this.lblEnrollmentsSearch.Text = "بحث:";
            // 
            // tpLecturePlan
            // 
            this.tpLecturePlan.Controls.Add(this.splitLecturePlan);
            this.tpLecturePlan.Controls.Add(this.flpLecturePlanButtons);
            this.tpLecturePlan.Controls.Add(this.pnlLecturePlanSearch);
            this.tpLecturePlan.Location = new System.Drawing.Point(4, 37);
            this.tpLecturePlan.Name = "tpLecturePlan";
            this.tpLecturePlan.Padding = new System.Windows.Forms.Padding(6);
            this.tpLecturePlan.Size = new System.Drawing.Size(1192, 612);
            this.tpLecturePlan.TabIndex = 0;
            this.tpLecturePlan.Text = "خطة المحاضرات";
            this.tpLecturePlan.UseVisualStyleBackColor = true;
            // 
            // splitLecturePlan
            // 
            this.splitLecturePlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLecturePlan.Location = new System.Drawing.Point(6, 59);
            this.splitLecturePlan.Name = "splitLecturePlan";
            // 
            // splitLecturePlan.Panel1
            // 
            this.splitLecturePlan.Panel1.Controls.Add(this.dgvLecturePlan);
            this.splitLecturePlan.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitLecturePlan.Panel2
            // 
            this.splitLecturePlan.Panel2.Controls.Add(this.grpLecturePlan);
            this.splitLecturePlan.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitLecturePlan.Size = new System.Drawing.Size(1180, 487);
            this.splitLecturePlan.SplitterDistance = 760;
            this.splitLecturePlan.TabIndex = 1;
            // 
            // dgvLecturePlan
            // 
            this.dgvLecturePlan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLecturePlan.ColumnHeadersHeight = 29;
            this.dgvLecturePlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLecturePlan.Location = new System.Drawing.Point(0, 0);
            this.dgvLecturePlan.Name = "dgvLecturePlan";
            this.dgvLecturePlan.RowHeadersWidth = 51;
            this.dgvLecturePlan.RowTemplate.Height = 28;
            this.dgvLecturePlan.Size = new System.Drawing.Size(760, 487);
            this.dgvLecturePlan.TabIndex = 0;
            this.dgvLecturePlan.SelectionChanged += new System.EventHandler(this.dgvLecturePlan_SelectionChanged);
            // 
            // grpLecturePlan
            // 
            this.grpLecturePlan.Controls.Add(this.lblPlanOffering);
            this.grpLecturePlan.Controls.Add(this.cmbPlanOffering);
            this.grpLecturePlan.Controls.Add(this.lblPlanNo);
            this.grpLecturePlan.Controls.Add(this.nudPlanNo);
            this.grpLecturePlan.Controls.Add(this.lblPlanTitle);
            this.grpLecturePlan.Controls.Add(this.txtPlanTitle);
            this.grpLecturePlan.Controls.Add(this.lblPlanContent);
            this.grpLecturePlan.Controls.Add(this.txtPlanContent);
            this.grpLecturePlan.Controls.Add(this.chkPlanExtra);
            this.grpLecturePlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLecturePlan.Location = new System.Drawing.Point(0, 0);
            this.grpLecturePlan.Name = "grpLecturePlan";
            this.grpLecturePlan.Padding = new System.Windows.Forms.Padding(10);
            this.grpLecturePlan.Size = new System.Drawing.Size(416, 487);
            this.grpLecturePlan.TabIndex = 0;
            this.grpLecturePlan.TabStop = false;
            this.grpLecturePlan.Text = "تفاصيل";
            // 
            // lblPlanOffering
            // 
            this.lblPlanOffering.AutoSize = true;
            this.lblPlanOffering.Location = new System.Drawing.Point(277, 40);
            this.lblPlanOffering.Name = "lblPlanOffering";
            this.lblPlanOffering.Size = new System.Drawing.Size(145, 28);
            this.lblPlanOffering.TabIndex = 0;
            this.lblPlanOffering.Text = "المادة المطروحة";
            // 
            // cmbPlanOffering
            // 
            this.cmbPlanOffering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanOffering.FormattingEnabled = true;
            this.cmbPlanOffering.Location = new System.Drawing.Point(6, 36);
            this.cmbPlanOffering.Name = "cmbPlanOffering";
            this.cmbPlanOffering.Size = new System.Drawing.Size(260, 36);
            this.cmbPlanOffering.TabIndex = 2;
            // 
            // lblPlanNo
            // 
            this.lblPlanNo.AutoSize = true;
            this.lblPlanNo.Location = new System.Drawing.Point(288, 90);
            this.lblPlanNo.Name = "lblPlanNo";
            this.lblPlanNo.Size = new System.Drawing.Size(120, 28);
            this.lblPlanNo.TabIndex = 0;
            this.lblPlanNo.Text = "رقم المحاضرة";
            // 
            // nudPlanNo
            // 
            this.nudPlanNo.Location = new System.Drawing.Point(20, 86);
            this.nudPlanNo.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudPlanNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlanNo.Name = "nudPlanNo";
            this.nudPlanNo.Size = new System.Drawing.Size(140, 34);
            this.nudPlanNo.TabIndex = 3;
            this.nudPlanNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPlanTitle
            // 
            this.lblPlanTitle.AutoSize = true;
            this.lblPlanTitle.Location = new System.Drawing.Point(300, 140);
            this.lblPlanTitle.Name = "lblPlanTitle";
            this.lblPlanTitle.Size = new System.Drawing.Size(71, 28);
            this.lblPlanTitle.TabIndex = 0;
            this.lblPlanTitle.Text = "العنوان";
            // 
            // txtPlanTitle
            // 
            this.txtPlanTitle.Location = new System.Drawing.Point(20, 136);
            this.txtPlanTitle.Name = "txtPlanTitle";
            this.txtPlanTitle.Size = new System.Drawing.Size(260, 34);
            this.txtPlanTitle.TabIndex = 1;
            // 
            // lblPlanContent
            // 
            this.lblPlanContent.AutoSize = true;
            this.lblPlanContent.Location = new System.Drawing.Point(300, 190);
            this.lblPlanContent.Name = "lblPlanContent";
            this.lblPlanContent.Size = new System.Drawing.Size(80, 28);
            this.lblPlanContent.TabIndex = 0;
            this.lblPlanContent.Text = "المحتوى";
            // 
            // txtPlanContent
            // 
            this.txtPlanContent.Location = new System.Drawing.Point(15, 228);
            this.txtPlanContent.Multiline = true;
            this.txtPlanContent.Name = "txtPlanContent";
            this.txtPlanContent.Size = new System.Drawing.Size(360, 257);
            this.txtPlanContent.TabIndex = 1;
            // 
            // chkPlanExtra
            // 
            this.chkPlanExtra.AutoSize = true;
            this.chkPlanExtra.Location = new System.Drawing.Point(20, 190);
            this.chkPlanExtra.Name = "chkPlanExtra";
            this.chkPlanExtra.Size = new System.Drawing.Size(159, 32);
            this.chkPlanExtra.TabIndex = 10;
            this.chkPlanExtra.Text = "محاضرة إضافية";
            this.chkPlanExtra.UseVisualStyleBackColor = true;
            // 
            // flpLecturePlanButtons
            // 
            this.flpLecturePlanButtons.Controls.Add(this.btnLecturePlanAdd);
            this.flpLecturePlanButtons.Controls.Add(this.btnLecturePlanUpdate);
            this.flpLecturePlanButtons.Controls.Add(this.btnLecturePlanDelete);
            this.flpLecturePlanButtons.Controls.Add(this.btnLecturePlanClear);
            this.flpLecturePlanButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpLecturePlanButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpLecturePlanButtons.Location = new System.Drawing.Point(6, 546);
            this.flpLecturePlanButtons.Name = "flpLecturePlanButtons";
            this.flpLecturePlanButtons.Padding = new System.Windows.Forms.Padding(6);
            this.flpLecturePlanButtons.Size = new System.Drawing.Size(1180, 60);
            this.flpLecturePlanButtons.TabIndex = 2;
            this.flpLecturePlanButtons.WrapContents = false;
            // 
            // btnLecturePlanAdd
            // 
            this.btnLecturePlanAdd.Location = new System.Drawing.Point(12, 12);
            this.btnLecturePlanAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnLecturePlanAdd.Name = "btnLecturePlanAdd";
            this.btnLecturePlanAdd.Size = new System.Drawing.Size(110, 36);
            this.btnLecturePlanAdd.TabIndex = 0;
            this.btnLecturePlanAdd.Text = "إضافة";
            this.btnLecturePlanAdd.UseVisualStyleBackColor = true;
            this.btnLecturePlanAdd.Click += new System.EventHandler(this.btnLecturePlanAdd_Click);
            // 
            // btnLecturePlanUpdate
            // 
            this.btnLecturePlanUpdate.Location = new System.Drawing.Point(134, 12);
            this.btnLecturePlanUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnLecturePlanUpdate.Name = "btnLecturePlanUpdate";
            this.btnLecturePlanUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnLecturePlanUpdate.TabIndex = 1;
            this.btnLecturePlanUpdate.Text = "تعديل";
            this.btnLecturePlanUpdate.UseVisualStyleBackColor = true;
            this.btnLecturePlanUpdate.Click += new System.EventHandler(this.btnLecturePlanUpdate_Click);
            // 
            // btnLecturePlanDelete
            // 
            this.btnLecturePlanDelete.Location = new System.Drawing.Point(256, 12);
            this.btnLecturePlanDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnLecturePlanDelete.Name = "btnLecturePlanDelete";
            this.btnLecturePlanDelete.Size = new System.Drawing.Size(110, 36);
            this.btnLecturePlanDelete.TabIndex = 2;
            this.btnLecturePlanDelete.Text = "حذف";
            this.btnLecturePlanDelete.UseVisualStyleBackColor = true;
            this.btnLecturePlanDelete.Click += new System.EventHandler(this.btnLecturePlanDelete_Click);
            // 
            // btnLecturePlanClear
            // 
            this.btnLecturePlanClear.Location = new System.Drawing.Point(378, 12);
            this.btnLecturePlanClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnLecturePlanClear.Name = "btnLecturePlanClear";
            this.btnLecturePlanClear.Size = new System.Drawing.Size(110, 36);
            this.btnLecturePlanClear.TabIndex = 3;
            this.btnLecturePlanClear.Text = "تفريغ";
            this.btnLecturePlanClear.UseVisualStyleBackColor = true;
            this.btnLecturePlanClear.Click += new System.EventHandler(this.btnLecturePlanClear_Click);
            // 
            // pnlLecturePlanSearch
            // 
            this.pnlLecturePlanSearch.Controls.Add(this.btnLecturePlanRefresh);
            this.pnlLecturePlanSearch.Controls.Add(this.btnLecturePlanSearch);
            this.pnlLecturePlanSearch.Controls.Add(this.txtLecturePlanSearch);
            this.pnlLecturePlanSearch.Controls.Add(this.lblLecturePlanSearch);
            this.pnlLecturePlanSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLecturePlanSearch.Location = new System.Drawing.Point(6, 6);
            this.pnlLecturePlanSearch.Name = "pnlLecturePlanSearch";
            this.pnlLecturePlanSearch.Padding = new System.Windows.Forms.Padding(8);
            this.pnlLecturePlanSearch.Size = new System.Drawing.Size(1180, 53);
            this.pnlLecturePlanSearch.TabIndex = 0;
            // 
            // btnLecturePlanRefresh
            // 
            this.btnLecturePlanRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLecturePlanRefresh.Location = new System.Drawing.Point(639, 8);
            this.btnLecturePlanRefresh.Name = "btnLecturePlanRefresh";
            this.btnLecturePlanRefresh.Size = new System.Drawing.Size(100, 37);
            this.btnLecturePlanRefresh.TabIndex = 3;
            this.btnLecturePlanRefresh.Text = "تحديث";
            this.btnLecturePlanRefresh.UseVisualStyleBackColor = true;
            this.btnLecturePlanRefresh.Click += new System.EventHandler(this.btnLecturePlanRefresh_Click);
            // 
            // btnLecturePlanSearch
            // 
            this.btnLecturePlanSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLecturePlanSearch.Location = new System.Drawing.Point(739, 8);
            this.btnLecturePlanSearch.Name = "btnLecturePlanSearch";
            this.btnLecturePlanSearch.Size = new System.Drawing.Size(100, 37);
            this.btnLecturePlanSearch.TabIndex = 2;
            this.btnLecturePlanSearch.Text = "بحث";
            this.btnLecturePlanSearch.UseVisualStyleBackColor = true;
            this.btnLecturePlanSearch.Click += new System.EventHandler(this.btnLecturePlanSearch_Click);
            // 
            // txtLecturePlanSearch
            // 
            this.txtLecturePlanSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtLecturePlanSearch.Location = new System.Drawing.Point(839, 8);
            this.txtLecturePlanSearch.Name = "txtLecturePlanSearch";
            this.txtLecturePlanSearch.Size = new System.Drawing.Size(280, 34);
            this.txtLecturePlanSearch.TabIndex = 1;
            this.txtLecturePlanSearch.TextChanged += new System.EventHandler(this.txtLecturePlanSearch_TextChanged);
            // 
            // lblLecturePlanSearch
            // 
            this.lblLecturePlanSearch.AutoSize = true;
            this.lblLecturePlanSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLecturePlanSearch.Location = new System.Drawing.Point(1119, 8);
            this.lblLecturePlanSearch.Name = "lblLecturePlanSearch";
            this.lblLecturePlanSearch.Size = new System.Drawing.Size(53, 28);
            this.lblLecturePlanSearch.TabIndex = 0;
            this.lblLecturePlanSearch.Text = "بحث:";
            // 
            // tpActivationCodes
            // 
            this.tpActivationCodes.Controls.Add(this.splitAct);
            this.tpActivationCodes.Controls.Add(this.flpActButtons);
            this.tpActivationCodes.Controls.Add(this.pnlActSearch);
            this.tpActivationCodes.Location = new System.Drawing.Point(4, 37);
            this.tpActivationCodes.Name = "tpActivationCodes";
            this.tpActivationCodes.Padding = new System.Windows.Forms.Padding(6);
            this.tpActivationCodes.Size = new System.Drawing.Size(1192, 612);
            this.tpActivationCodes.TabIndex = 0;
            this.tpActivationCodes.Text = "أكواد التفعيل";
            this.tpActivationCodes.UseVisualStyleBackColor = true;
            // 
            // splitAct
            // 
            this.splitAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitAct.Location = new System.Drawing.Point(6, 60);
            this.splitAct.Name = "splitAct";
            // 
            // splitAct.Panel1
            // 
            this.splitAct.Panel1.Controls.Add(this.dgvActivationCodes);
            this.splitAct.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitAct.Panel2
            // 
            this.splitAct.Panel2.Controls.Add(this.grpAct);
            this.splitAct.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitAct.Size = new System.Drawing.Size(1180, 490);
            this.splitAct.SplitterDistance = 760;
            this.splitAct.TabIndex = 1;
            // 
            // dgvActivationCodes
            // 
            this.dgvActivationCodes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvActivationCodes.ColumnHeadersHeight = 29;
            this.dgvActivationCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActivationCodes.Location = new System.Drawing.Point(0, 0);
            this.dgvActivationCodes.Name = "dgvActivationCodes";
            this.dgvActivationCodes.RowHeadersWidth = 51;
            this.dgvActivationCodes.RowTemplate.Height = 28;
            this.dgvActivationCodes.Size = new System.Drawing.Size(760, 490);
            this.dgvActivationCodes.TabIndex = 0;
            this.dgvActivationCodes.SelectionChanged += new System.EventHandler(this.dgvActivationCodes_SelectionChanged);
            // 
            // grpAct
            // 
            this.grpAct.Controls.Add(this.lblActCode);
            this.grpAct.Controls.Add(this.txtActCode);
            this.grpAct.Controls.Add(this.btnActGenerate);
            this.grpAct.Controls.Add(this.lblActRole);
            this.grpAct.Controls.Add(this.cmbActRole);
            this.grpAct.Controls.Add(this.lblActStudent);
            this.grpAct.Controls.Add(this.cmbActStudent);
            this.grpAct.Controls.Add(this.lblActTeacher);
            this.grpAct.Controls.Add(this.cmbActTeacher);
            this.grpAct.Controls.Add(this.chkActUsed);
            this.grpAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAct.Location = new System.Drawing.Point(0, 0);
            this.grpAct.Name = "grpAct";
            this.grpAct.Padding = new System.Windows.Forms.Padding(10);
            this.grpAct.Size = new System.Drawing.Size(416, 490);
            this.grpAct.TabIndex = 0;
            this.grpAct.TabStop = false;
            this.grpAct.Text = "إضافة / تعديل كود تفعيل";
            // 
            // lblActCode
            // 
            this.lblActCode.AutoSize = true;
            this.lblActCode.Location = new System.Drawing.Point(300, 40);
            this.lblActCode.Name = "lblActCode";
            this.lblActCode.Size = new System.Drawing.Size(108, 28);
            this.lblActCode.TabIndex = 0;
            this.lblActCode.Text = "كود التفعيل";
            // 
            // txtActCode
            // 
            this.txtActCode.Location = new System.Drawing.Point(20, 36);
            this.txtActCode.Name = "txtActCode";
            this.txtActCode.Size = new System.Drawing.Size(260, 34);
            this.txtActCode.TabIndex = 1;
            // 
            // btnActGenerate
            // 
            this.btnActGenerate.Location = new System.Drawing.Point(20, 72);
            this.btnActGenerate.Name = "btnActGenerate";
            this.btnActGenerate.Size = new System.Drawing.Size(260, 38);
            this.btnActGenerate.TabIndex = 2;
            this.btnActGenerate.Text = "توليد كود تلقائياً";
            this.btnActGenerate.UseVisualStyleBackColor = true;
            this.btnActGenerate.Click += new System.EventHandler(this.btnActGenerate_Click);
            // 
            // lblActRole
            // 
            this.lblActRole.AutoSize = true;
            this.lblActRole.Location = new System.Drawing.Point(300, 120);
            this.lblActRole.Name = "lblActRole";
            this.lblActRole.Size = new System.Drawing.Size(52, 28);
            this.lblActRole.TabIndex = 0;
            this.lblActRole.Text = "الدور";
            // 
            // cmbActRole
            // 
            this.cmbActRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActRole.FormattingEnabled = true;
            this.cmbActRole.Items.AddRange(new object[] {
            "طالب",
            "أستاذ"});
            this.cmbActRole.Location = new System.Drawing.Point(20, 116);
            this.cmbActRole.Name = "cmbActRole";
            this.cmbActRole.Size = new System.Drawing.Size(260, 36);
            this.cmbActRole.TabIndex = 3;
            this.cmbActRole.SelectedIndexChanged += new System.EventHandler(this.cmbActRole_SelectedIndexChanged);
            // 
            // lblActStudent
            // 
            this.lblActStudent.AutoSize = true;
            this.lblActStudent.Location = new System.Drawing.Point(300, 170);
            this.lblActStudent.Name = "lblActStudent";
            this.lblActStudent.Size = new System.Drawing.Size(71, 28);
            this.lblActStudent.TabIndex = 0;
            this.lblActStudent.Text = "الطالب";
            // 
            // cmbActStudent
            // 
            this.cmbActStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActStudent.FormattingEnabled = true;
            this.cmbActStudent.Location = new System.Drawing.Point(20, 166);
            this.cmbActStudent.Name = "cmbActStudent";
            this.cmbActStudent.Size = new System.Drawing.Size(260, 36);
            this.cmbActStudent.TabIndex = 4;
            // 
            // lblActTeacher
            // 
            this.lblActTeacher.AutoSize = true;
            this.lblActTeacher.Location = new System.Drawing.Point(300, 220);
            this.lblActTeacher.Name = "lblActTeacher";
            this.lblActTeacher.Size = new System.Drawing.Size(68, 28);
            this.lblActTeacher.TabIndex = 0;
            this.lblActTeacher.Text = "الأستاذ";
            // 
            // cmbActTeacher
            // 
            this.cmbActTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActTeacher.FormattingEnabled = true;
            this.cmbActTeacher.Location = new System.Drawing.Point(20, 216);
            this.cmbActTeacher.Name = "cmbActTeacher";
            this.cmbActTeacher.Size = new System.Drawing.Size(260, 36);
            this.cmbActTeacher.TabIndex = 5;
            // 
            // chkActUsed
            // 
            this.chkActUsed.AutoSize = true;
            this.chkActUsed.Enabled = false;
            this.chkActUsed.Location = new System.Drawing.Point(20, 260);
            this.chkActUsed.Name = "chkActUsed";
            this.chkActUsed.Size = new System.Drawing.Size(104, 32);
            this.chkActUsed.TabIndex = 6;
            this.chkActUsed.Text = "مستخدم";
            this.chkActUsed.UseVisualStyleBackColor = true;
            // 
            // flpActButtons
            // 
            this.flpActButtons.Controls.Add(this.btnActAdd);
            this.flpActButtons.Controls.Add(this.btnActUpdate);
            this.flpActButtons.Controls.Add(this.btnActDelete);
            this.flpActButtons.Controls.Add(this.btnActClear);
            this.flpActButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpActButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpActButtons.Location = new System.Drawing.Point(6, 550);
            this.flpActButtons.Name = "flpActButtons";
            this.flpActButtons.Padding = new System.Windows.Forms.Padding(6);
            this.flpActButtons.Size = new System.Drawing.Size(1180, 56);
            this.flpActButtons.TabIndex = 2;
            this.flpActButtons.WrapContents = false;
            // 
            // btnActAdd
            // 
            this.btnActAdd.Location = new System.Drawing.Point(12, 12);
            this.btnActAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnActAdd.Name = "btnActAdd";
            this.btnActAdd.Size = new System.Drawing.Size(110, 36);
            this.btnActAdd.TabIndex = 0;
            this.btnActAdd.Text = "إضافة";
            this.btnActAdd.UseVisualStyleBackColor = true;
            this.btnActAdd.Click += new System.EventHandler(this.btnActAdd_Click);
            // 
            // btnActUpdate
            // 
            this.btnActUpdate.Location = new System.Drawing.Point(134, 12);
            this.btnActUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnActUpdate.Name = "btnActUpdate";
            this.btnActUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnActUpdate.TabIndex = 1;
            this.btnActUpdate.Text = "تعديل";
            this.btnActUpdate.UseVisualStyleBackColor = true;
            this.btnActUpdate.Click += new System.EventHandler(this.btnActUpdate_Click);
            // 
            // btnActDelete
            // 
            this.btnActDelete.Location = new System.Drawing.Point(256, 12);
            this.btnActDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnActDelete.Name = "btnActDelete";
            this.btnActDelete.Size = new System.Drawing.Size(110, 36);
            this.btnActDelete.TabIndex = 2;
            this.btnActDelete.Text = "حذف";
            this.btnActDelete.UseVisualStyleBackColor = true;
            this.btnActDelete.Click += new System.EventHandler(this.btnActDelete_Click);
            // 
            // btnActClear
            // 
            this.btnActClear.Location = new System.Drawing.Point(378, 12);
            this.btnActClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnActClear.Name = "btnActClear";
            this.btnActClear.Size = new System.Drawing.Size(110, 36);
            this.btnActClear.TabIndex = 3;
            this.btnActClear.Text = "تفريغ";
            this.btnActClear.UseVisualStyleBackColor = true;
            this.btnActClear.Click += new System.EventHandler(this.btnActClear_Click);
            // 
            // pnlActSearch
            // 
            this.pnlActSearch.Controls.Add(this.btnActRefresh);
            this.pnlActSearch.Controls.Add(this.btnActSearch);
            this.pnlActSearch.Controls.Add(this.txtActSearch);
            this.pnlActSearch.Controls.Add(this.lblActSearch);
            this.pnlActSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActSearch.Location = new System.Drawing.Point(6, 6);
            this.pnlActSearch.Name = "pnlActSearch";
            this.pnlActSearch.Padding = new System.Windows.Forms.Padding(8);
            this.pnlActSearch.Size = new System.Drawing.Size(1180, 54);
            this.pnlActSearch.TabIndex = 0;
            // 
            // btnActRefresh
            // 
            this.btnActRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActRefresh.Location = new System.Drawing.Point(639, 8);
            this.btnActRefresh.Name = "btnActRefresh";
            this.btnActRefresh.Size = new System.Drawing.Size(100, 38);
            this.btnActRefresh.TabIndex = 3;
            this.btnActRefresh.Text = "تحديث";
            this.btnActRefresh.UseVisualStyleBackColor = true;
            this.btnActRefresh.Click += new System.EventHandler(this.btnActRefresh_Click);
            // 
            // btnActSearch
            // 
            this.btnActSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActSearch.Location = new System.Drawing.Point(739, 8);
            this.btnActSearch.Name = "btnActSearch";
            this.btnActSearch.Size = new System.Drawing.Size(100, 38);
            this.btnActSearch.TabIndex = 2;
            this.btnActSearch.Text = "بحث";
            this.btnActSearch.UseVisualStyleBackColor = true;
            this.btnActSearch.Click += new System.EventHandler(this.btnActSearch_Click);
            // 
            // txtActSearch
            // 
            this.txtActSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtActSearch.Location = new System.Drawing.Point(839, 8);
            this.txtActSearch.Name = "txtActSearch";
            this.txtActSearch.Size = new System.Drawing.Size(280, 34);
            this.txtActSearch.TabIndex = 1;
            this.txtActSearch.TextChanged += new System.EventHandler(this.txtActSearch_TextChanged);
            // 
            // lblActSearch
            // 
            this.lblActSearch.AutoSize = true;
            this.lblActSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblActSearch.Location = new System.Drawing.Point(1119, 8);
            this.lblActSearch.Name = "lblActSearch";
            this.lblActSearch.Size = new System.Drawing.Size(53, 28);
            this.lblActSearch.TabIndex = 0;
            this.lblActSearch.Text = "بحث:";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " الإدارة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.tpDepartments.ResumeLayout(false);
            this.splitDepartments.Panel1.ResumeLayout(false);
            this.splitDepartments.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDepartments)).EndInit();
            this.splitDepartments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.grpDepartments.ResumeLayout(false);
            this.grpDepartments.PerformLayout();
            this.flpDepartmentsButtons.ResumeLayout(false);
            this.pnlDepartmentsSearch.ResumeLayout(false);
            this.pnlDepartmentsSearch.PerformLayout();
            this.tpMajors.ResumeLayout(false);
            this.splitMajors.Panel1.ResumeLayout(false);
            this.splitMajors.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMajors)).EndInit();
            this.splitMajors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajors)).EndInit();
            this.grpMajors.ResumeLayout(false);
            this.grpMajors.PerformLayout();
            this.flpMajorsButtons.ResumeLayout(false);
            this.pnlMajorsSearch.ResumeLayout(false);
            this.pnlMajorsSearch.PerformLayout();
            this.tpTerms.ResumeLayout(false);
            this.splitTerms.Panel1.ResumeLayout(false);
            this.splitTerms.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTerms)).EndInit();
            this.splitTerms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerms)).EndInit();
            this.grpTerms.ResumeLayout(false);
            this.grpTerms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTermYear)).EndInit();
            this.flpTermsButtons.ResumeLayout(false);
            this.pnlTermsSearch.ResumeLayout(false);
            this.pnlTermsSearch.PerformLayout();
            this.tpStudents.ResumeLayout(false);
            this.splitStudents.Panel1.ResumeLayout(false);
            this.splitStudents.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitStudents)).EndInit();
            this.splitStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpStudents.ResumeLayout(false);
            this.grpStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStudentLevel)).EndInit();
            this.flpStudentsButtons.ResumeLayout(false);
            this.pnlStudentsSearch.ResumeLayout(false);
            this.pnlStudentsSearch.PerformLayout();
            this.tpTeachers.ResumeLayout(false);
            this.splitTeachers.Panel1.ResumeLayout(false);
            this.splitTeachers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTeachers)).EndInit();
            this.splitTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.grpTeachers.ResumeLayout(false);
            this.grpTeachers.PerformLayout();
            this.flpTeachersButtons.ResumeLayout(false);
            this.pnlTeachersSearch.ResumeLayout(false);
            this.pnlTeachersSearch.PerformLayout();
            this.tpCourses.ResumeLayout(false);
            this.splitCourses.Panel1.ResumeLayout(false);
            this.splitCourses.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCourses)).EndInit();
            this.splitCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.grpCourses.ResumeLayout(false);
            this.grpCourses.PerformLayout();
            this.flpCoursesButtons.ResumeLayout(false);
            this.pnlCoursesSearch.ResumeLayout(false);
            this.pnlCoursesSearch.PerformLayout();
            this.tpOfferings.ResumeLayout(false);
            this.splitOfferings.Panel1.ResumeLayout(false);
            this.splitOfferings.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitOfferings)).EndInit();
            this.splitOfferings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfferings)).EndInit();
            this.grpOfferings.ResumeLayout(false);
            this.grpOfferings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOfferingMax)).EndInit();
            this.flpOfferingsButtons.ResumeLayout(false);
            this.pnlOfferingsSearch.ResumeLayout(false);
            this.pnlOfferingsSearch.PerformLayout();
            this.tpAssignments.ResumeLayout(false);
            this.splitAssignments.Panel1.ResumeLayout(false);
            this.splitAssignments.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitAssignments)).EndInit();
            this.splitAssignments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.grpAssignments.ResumeLayout(false);
            this.grpAssignments.PerformLayout();
            this.flpAssignmentsButtons.ResumeLayout(false);
            this.pnlAssignmentsSearch.ResumeLayout(false);
            this.pnlAssignmentsSearch.PerformLayout();
            this.tpEnrollments.ResumeLayout(false);
            this.splitEnrollments.Panel1.ResumeLayout(false);
            this.splitEnrollments.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitEnrollments)).EndInit();
            this.splitEnrollments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).EndInit();
            this.grpEnrollments.ResumeLayout(false);
            this.grpEnrollments.PerformLayout();
            this.flpEnrollmentsButtons.ResumeLayout(false);
            this.pnlEnrollmentsSearch.ResumeLayout(false);
            this.pnlEnrollmentsSearch.PerformLayout();
            this.tpLecturePlan.ResumeLayout(false);
            this.splitLecturePlan.Panel1.ResumeLayout(false);
            this.splitLecturePlan.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLecturePlan)).EndInit();
            this.splitLecturePlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturePlan)).EndInit();
            this.grpLecturePlan.ResumeLayout(false);
            this.grpLecturePlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlanNo)).EndInit();
            this.flpLecturePlanButtons.ResumeLayout(false);
            this.pnlLecturePlanSearch.ResumeLayout(false);
            this.pnlLecturePlanSearch.PerformLayout();
            this.tpActivationCodes.ResumeLayout(false);
            this.splitAct.Panel1.ResumeLayout(false);
            this.splitAct.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitAct)).EndInit();
            this.splitAct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivationCodes)).EndInit();
            this.grpAct.ResumeLayout(false);
            this.grpAct.PerformLayout();
            this.flpActButtons.ResumeLayout(false);
            this.pnlActSearch.ResumeLayout(false);
            this.pnlActSearch.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tpDepartments;
        private System.Windows.Forms.TabPage tpMajors;
        private System.Windows.Forms.TabPage tpTerms;
        private System.Windows.Forms.TabPage tpStudents;
        private System.Windows.Forms.TabPage tpTeachers;
        private System.Windows.Forms.TabPage tpCourses;
        private System.Windows.Forms.TabPage tpOfferings;
        private System.Windows.Forms.TabPage tpAssignments;
        private System.Windows.Forms.TabPage tpEnrollments;
        private System.Windows.Forms.TabPage tpLecturePlan;
        private System.Windows.Forms.Panel pnlDepartmentsSearch;
        private System.Windows.Forms.Label lblDepartmentsSearch;
        private System.Windows.Forms.TextBox txtDepartmentsSearch;
        private System.Windows.Forms.Button btnDepartmentsSearch;
        private System.Windows.Forms.Button btnDepartmentsRefresh;
        private System.Windows.Forms.SplitContainer splitDepartments;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.GroupBox grpDepartments;
        private System.Windows.Forms.FlowLayoutPanel flpDepartmentsButtons;
        private System.Windows.Forms.Button btnDepartmentsAdd;
        private System.Windows.Forms.Button btnDepartmentsUpdate;
        private System.Windows.Forms.Button btnDepartmentsDelete;
        private System.Windows.Forms.Button btnDepartmentsClear;
        private System.Windows.Forms.Panel pnlMajorsSearch;
        private System.Windows.Forms.Label lblMajorsSearch;
        private System.Windows.Forms.TextBox txtMajorsSearch;
        private System.Windows.Forms.Button btnMajorsSearch;
        private System.Windows.Forms.Button btnMajorsRefresh;
        private System.Windows.Forms.SplitContainer splitMajors;
        private System.Windows.Forms.DataGridView dgvMajors;
        private System.Windows.Forms.GroupBox grpMajors;
        private System.Windows.Forms.FlowLayoutPanel flpMajorsButtons;
        private System.Windows.Forms.Button btnMajorsAdd;
        private System.Windows.Forms.Button btnMajorsUpdate;
        private System.Windows.Forms.Button btnMajorsDelete;
        private System.Windows.Forms.Button btnMajorsClear;
        private System.Windows.Forms.Panel pnlTermsSearch;
        private System.Windows.Forms.Label lblTermsSearch;
        private System.Windows.Forms.TextBox txtTermsSearch;
        private System.Windows.Forms.Button btnTermsSearch;
        private System.Windows.Forms.Button btnTermsRefresh;
        private System.Windows.Forms.SplitContainer splitTerms;
        private System.Windows.Forms.DataGridView dgvTerms;
        private System.Windows.Forms.GroupBox grpTerms;
        private System.Windows.Forms.FlowLayoutPanel flpTermsButtons;
        private System.Windows.Forms.Button btnTermsAdd;
        private System.Windows.Forms.Button btnTermsUpdate;
        private System.Windows.Forms.Button btnTermsDelete;
        private System.Windows.Forms.Button btnTermsClear;
        private System.Windows.Forms.Panel pnlStudentsSearch;
        private System.Windows.Forms.Label lblStudentsSearch;
        private System.Windows.Forms.TextBox txtStudentsSearch;
        private System.Windows.Forms.Button btnStudentsSearch;
        private System.Windows.Forms.Button btnStudentsRefresh;
        private System.Windows.Forms.SplitContainer splitStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox grpStudents;
        private System.Windows.Forms.FlowLayoutPanel flpStudentsButtons;
        private System.Windows.Forms.Button btnStudentsAdd;
        private System.Windows.Forms.Button btnStudentsUpdate;
        private System.Windows.Forms.Button btnStudentsDelete;
        private System.Windows.Forms.Button btnStudentsClear;
        private System.Windows.Forms.Panel pnlTeachersSearch;
        private System.Windows.Forms.Label lblTeachersSearch;
        private System.Windows.Forms.TextBox txtTeachersSearch;
        private System.Windows.Forms.Button btnTeachersSearch;
        private System.Windows.Forms.Button btnTeachersRefresh;
        private System.Windows.Forms.SplitContainer splitTeachers;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.GroupBox grpTeachers;
        private System.Windows.Forms.FlowLayoutPanel flpTeachersButtons;
        private System.Windows.Forms.Button btnTeachersAdd;
        private System.Windows.Forms.Button btnTeachersUpdate;
        private System.Windows.Forms.Button btnTeachersDelete;
        private System.Windows.Forms.Button btnTeachersClear;
        private System.Windows.Forms.Panel pnlCoursesSearch;
        private System.Windows.Forms.Label lblCoursesSearch;
        private System.Windows.Forms.TextBox txtCoursesSearch;
        private System.Windows.Forms.Button btnCoursesSearch;
        private System.Windows.Forms.Button btnCoursesRefresh;
        private System.Windows.Forms.SplitContainer splitCourses;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.GroupBox grpCourses;
        private System.Windows.Forms.FlowLayoutPanel flpCoursesButtons;
        private System.Windows.Forms.Button btnCoursesAdd;
        private System.Windows.Forms.Button btnCoursesUpdate;
        private System.Windows.Forms.Button btnCoursesDelete;
        private System.Windows.Forms.Button btnCoursesClear;
        private System.Windows.Forms.Panel pnlOfferingsSearch;
        private System.Windows.Forms.Label lblOfferingsSearch;
        private System.Windows.Forms.TextBox txtOfferingsSearch;
        private System.Windows.Forms.Button btnOfferingsSearch;
        private System.Windows.Forms.Button btnOfferingsRefresh;
        private System.Windows.Forms.SplitContainer splitOfferings;
        private System.Windows.Forms.DataGridView dgvOfferings;
        private System.Windows.Forms.GroupBox grpOfferings;
        private System.Windows.Forms.FlowLayoutPanel flpOfferingsButtons;
        private System.Windows.Forms.Button btnOfferingsAdd;
        private System.Windows.Forms.Button btnOfferingsUpdate;
        private System.Windows.Forms.Button btnOfferingsDelete;
        private System.Windows.Forms.Button btnOfferingsClear;
        private System.Windows.Forms.Panel pnlAssignmentsSearch;
        private System.Windows.Forms.Label lblAssignmentsSearch;
        private System.Windows.Forms.TextBox txtAssignmentsSearch;
        private System.Windows.Forms.Button btnAssignmentsSearch;
        private System.Windows.Forms.Button btnAssignmentsRefresh;
        private System.Windows.Forms.SplitContainer splitAssignments;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.GroupBox grpAssignments;
        private System.Windows.Forms.FlowLayoutPanel flpAssignmentsButtons;
        private System.Windows.Forms.Button btnAssignmentsAdd;
        private System.Windows.Forms.Button btnAssignmentsUpdate;
        private System.Windows.Forms.Button btnAssignmentsDelete;
        private System.Windows.Forms.Button btnAssignmentsClear;
        private System.Windows.Forms.Panel pnlEnrollmentsSearch;
        private System.Windows.Forms.Label lblEnrollmentsSearch;
        private System.Windows.Forms.TextBox txtEnrollmentsSearch;
        private System.Windows.Forms.Button btnEnrollmentsSearch;
        private System.Windows.Forms.Button btnEnrollmentsRefresh;
        private System.Windows.Forms.SplitContainer splitEnrollments;
        private System.Windows.Forms.DataGridView dgvEnrollments;
        private System.Windows.Forms.GroupBox grpEnrollments;
        private System.Windows.Forms.FlowLayoutPanel flpEnrollmentsButtons;
        private System.Windows.Forms.Button btnEnrollmentsAdd;
        private System.Windows.Forms.Button btnEnrollmentsUpdate;
        private System.Windows.Forms.Button btnEnrollmentsDelete;
        private System.Windows.Forms.Button btnEnrollmentsClear;
        private System.Windows.Forms.Panel pnlLecturePlanSearch;
        private System.Windows.Forms.Label lblLecturePlanSearch;
        private System.Windows.Forms.TextBox txtLecturePlanSearch;
        private System.Windows.Forms.Button btnLecturePlanSearch;
        private System.Windows.Forms.Button btnLecturePlanRefresh;
        private System.Windows.Forms.SplitContainer splitLecturePlan;
        private System.Windows.Forms.DataGridView dgvLecturePlan;
        private System.Windows.Forms.GroupBox grpLecturePlan;
        private System.Windows.Forms.FlowLayoutPanel flpLecturePlanButtons;
        private System.Windows.Forms.Button btnLecturePlanAdd;
        private System.Windows.Forms.Button btnLecturePlanUpdate;
        private System.Windows.Forms.Button btnLecturePlanDelete;
        private System.Windows.Forms.Button btnLecturePlanClear;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label lblMajorDept;
        private System.Windows.Forms.ComboBox cmbMajorDept;
        private System.Windows.Forms.Label lblMajorName;
        private System.Windows.Forms.TextBox txtMajorName;
        private System.Windows.Forms.Label lblTermName;
        private System.Windows.Forms.TextBox txtTermName;
        private System.Windows.Forms.Label lblTermYear;
        private System.Windows.Forms.NumericUpDown nudTermYear;
        private System.Windows.Forms.CheckBox chkTermActive;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentMajor;
        private System.Windows.Forms.ComboBox cmbStudentMajor;
        private System.Windows.Forms.Label lblStudentLevel;
        private System.Windows.Forms.NumericUpDown nudStudentLevel;
        private System.Windows.Forms.Label lblStudentTerm;
        private System.Windows.Forms.ComboBox cmbStudentTerm;
        private System.Windows.Forms.CheckBox chkStudentActive;
        private System.Windows.Forms.Label lblTeacherId;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.CheckBox chkTeacherActive;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.CheckBox chkCoursePractical;
        private System.Windows.Forms.Label lblOfferingTerm;
        private System.Windows.Forms.ComboBox cmbOfferingTerm;
        private System.Windows.Forms.Label lblOfferingCourse;
        private System.Windows.Forms.ComboBox cmbOfferingCourse;
        private System.Windows.Forms.Label lblOfferingType;
        private System.Windows.Forms.ComboBox cmbOfferingType;
        private System.Windows.Forms.Label lblOfferingMax;
        private System.Windows.Forms.NumericUpDown nudOfferingMax;
        private System.Windows.Forms.Label lblAssignOffering;
        private System.Windows.Forms.ComboBox cmbAssignOffering;
        private System.Windows.Forms.Label lblAssignTeacher;
        private System.Windows.Forms.ComboBox cmbAssignTeacher;
        private System.Windows.Forms.Label lblEnrollStudent;
        private System.Windows.Forms.ComboBox cmbEnrollStudent;
        private System.Windows.Forms.Label lblEnrollOffering;
        private System.Windows.Forms.ComboBox cmbEnrollOffering;
        private System.Windows.Forms.Label lblPlanOffering;
        private System.Windows.Forms.ComboBox cmbPlanOffering;
        private System.Windows.Forms.Label lblPlanNo;
        private System.Windows.Forms.NumericUpDown nudPlanNo;
        private System.Windows.Forms.Label lblPlanTitle;
        private System.Windows.Forms.TextBox txtPlanTitle;
        private System.Windows.Forms.Label lblPlanContent;
        private System.Windows.Forms.TextBox txtPlanContent;
        private System.Windows.Forms.CheckBox chkPlanExtra;
        private System.Windows.Forms.TabPage tpActivationCodes;
        private System.Windows.Forms.Panel pnlActSearch;
        private System.Windows.Forms.Label lblActSearch;
        private System.Windows.Forms.TextBox txtActSearch;
        private System.Windows.Forms.Button btnActSearch;
        private System.Windows.Forms.Button btnActRefresh;
        private System.Windows.Forms.SplitContainer splitAct;
        private System.Windows.Forms.DataGridView dgvActivationCodes;
        private System.Windows.Forms.GroupBox grpAct;
        private System.Windows.Forms.Label lblActCode;
        private System.Windows.Forms.TextBox txtActCode;
        private System.Windows.Forms.Button btnActGenerate;
        private System.Windows.Forms.Label lblActRole;
        private System.Windows.Forms.ComboBox cmbActRole;
        private System.Windows.Forms.Label lblActStudent;
        private System.Windows.Forms.ComboBox cmbActStudent;
        private System.Windows.Forms.Label lblActTeacher;
        private System.Windows.Forms.ComboBox cmbActTeacher;
        private System.Windows.Forms.CheckBox chkActUsed;
        private System.Windows.Forms.FlowLayoutPanel flpActButtons;
        private System.Windows.Forms.Button btnActAdd;
        private System.Windows.Forms.Button btnActUpdate;
        private System.Windows.Forms.Button btnActDelete;
        private System.Windows.Forms.Button btnActClear;

    }
}
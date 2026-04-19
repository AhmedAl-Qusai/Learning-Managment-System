using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using UniTaskSystem.Services;
using UniTaskSystem.UI.UI_Theme;

namespace UniTaskSystem.UI.Forms
{
    public partial class AdminMainForm : Form
    {
        private readonly AdminService _svc = new AdminService();

        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            Theme.ApplyForm(this);
            pnlTop.BackColor = Theme.Primary;
            lblTitle.ForeColor = Color.White;
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.ForeColor = Color.White;

            SetupGrid(dgvDepartments);
            SetupGrid(dgvMajors);
            SetupGrid(dgvTerms);
            SetupGrid(dgvStudents);
            SetupGrid(dgvTeachers);
            SetupGrid(dgvCourses);
            SetupGrid(dgvOfferings);
            SetupGrid(dgvAssignments);
            SetupGrid(dgvEnrollments);
            SetupGrid(dgvLecturePlan);
            SetupGrid(dgvActivationCodes);

            RefreshLookups();
            LoadAll();
            ClearActivationCodes();
        }

        private void SetupGrid(DataGridView g)
        {
            if (g == null) return;
            Theme.StyleGrid(g);
            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.AutoGenerateColumns = true;
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void tabAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLookups();
        }

        private void RefreshLookups()
        {
            try
            {
                var dtDepts = _svc.GetDepartmentsLookup();
                var dtMajors = _svc.GetMajorsLookup();
                var dtTerms = _svc.GetTermsLookup();
                var dtCourses = _svc.GetCoursesLookup();
                var dtTeachers = _svc.GetTeachersLookup();
                var dtStudents = _svc.GetStudentsLookup();
                var dtOfferings = _svc.GetOfferingsLookup();

                BindCombo(cmbMajorDept, dtDepts, "DepartmentId", "Name");
                BindCombo(cmbStudentMajor, dtMajors, "MajorId", "MajorName");
                BindCombo(cmbStudentTerm, dtTerms, "TermId", "TermName");
                BindCombo(cmbOfferingTerm, dtTerms, "TermId", "TermName");
                BindCombo(cmbOfferingCourse, dtCourses, "CourseId", "CourseName");
                BindCombo(cmbAssignTeacher, dtTeachers, "UniversityTeacherId", "TeacherName");
                BindCombo(cmbAssignOffering, dtOfferings, "OfferingId", "OfferingName");
                BindCombo(cmbEnrollStudent, dtStudents, "UniversityStudentId", "StudentName");
                BindCombo(cmbEnrollOffering, dtOfferings, "OfferingId", "OfferingName");
                BindCombo(cmbPlanOffering, dtOfferings, "OfferingId", "OfferingName");
                BindCombo(cmbActStudent, dtStudents, "UniversityStudentId", "StudentName");
                BindCombo(cmbActTeacher, dtTeachers, "UniversityTeacherId", "TeacherName");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء تحديث القوائم: " + ex.Message);
            }
        }

        private void BindCombo(ComboBox cmb, DataTable dt, string valueMember, string displayMember)
        {
            if (cmb == null) return;
            cmb.DataSource = dt;
            cmb.ValueMember = valueMember;
            cmb.DisplayMember = displayMember;
        }

        private void LoadAll()
        {
            LoadDepartments();
            LoadMajors();
            LoadTerms();
            LoadStudents();
            LoadTeachers();
            LoadCourses();
            LoadOfferings();
            LoadAssignments();
            LoadEnrollments();
            LoadLecturePlan();
            LoadActivationCodes();
        }

        private int? GetSelectedInt(DataGridView g, string col)
        {
            if (g?.CurrentRow == null) return null;
            var v = g.CurrentRow.Cells[col]?.Value;
            if (v == null || v == DBNull.Value) return null;
            if (int.TryParse(v.ToString(), out var id)) return id;
            return null;
        }

        private string GetSelectedString(DataGridView g, string col)
        {
            if (g?.CurrentRow == null) return null;
            var v = g.CurrentRow.Cells[col]?.Value;
            if (v == null || v == DBNull.Value) return null;
            return v.ToString();
        }

        private void SafeSql(Action action)
        {
            try { action(); }
            catch (SqlException ex) { MessageBox.Show("خطأ قاعدة البيانات: " + ex.Message); }
            catch (Exception ex) { MessageBox.Show("خطأ: " + ex.Message); }
        }

        private void LoadDepartments() => dgvDepartments.DataSource = _svc.GetDepartments(txtDepartmentsSearch.Text);
        private void dgvDepartments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDepartments.CurrentRow == null) return;
            txtDeptName.Text = dgvDepartments.CurrentRow.Cells["Name"]?.Value?.ToString() ?? "";
        }
        private void ClearDepartments() { txtDeptName.Clear(); }

        private void LoadMajors() => dgvMajors.DataSource = _svc.GetMajors(txtMajorsSearch.Text);
        private void dgvMajors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMajors.CurrentRow == null) return;
            txtMajorName.Text = dgvMajors.CurrentRow.Cells["MajorName"]?.Value?.ToString() ?? "";
            var deptIdObj = dgvMajors.CurrentRow.Cells["DepartmentId"]?.Value;
            if (deptIdObj != null && deptIdObj != DBNull.Value) cmbMajorDept.SelectedValue = Convert.ToInt32(deptIdObj);
        }
        private void ClearMajors() { txtMajorName.Clear(); }

        private void LoadTerms() => dgvTerms.DataSource = _svc.GetTerms(txtTermsSearch.Text);
        private void dgvTerms_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTerms.CurrentRow == null) return;
            txtTermName.Text = dgvTerms.CurrentRow.Cells["Name"]?.Value?.ToString() ?? "";
            var yearObj = dgvTerms.CurrentRow.Cells["Year"]?.Value;
            if (yearObj != null && yearObj != DBNull.Value) nudTermYear.Value = Convert.ToDecimal(yearObj);
            var actObj = dgvTerms.CurrentRow.Cells["IsActive"]?.Value;
            if (actObj != null && actObj != DBNull.Value) chkTermActive.Checked = Convert.ToBoolean(actObj);
        }
        private void ClearTerms() { txtTermName.Clear(); chkTermActive.Checked = true; }

        private void LoadStudents() => dgvStudents.DataSource = _svc.GetStudents(txtStudentsSearch.Text);
        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;
            txtStudentId.Text = dgvStudents.CurrentRow.Cells["UniversityStudentId"]?.Value?.ToString() ?? "";
            txtStudentName.Text = dgvStudents.CurrentRow.Cells["FullName"]?.Value?.ToString() ?? "";
            var majorObj = dgvStudents.CurrentRow.Cells["MajorId"]?.Value;
            if (majorObj != null && majorObj != DBNull.Value) cmbStudentMajor.SelectedValue = Convert.ToInt32(majorObj);
            var levelObj = dgvStudents.CurrentRow.Cells["LevelNo"]?.Value;
            if (levelObj != null && levelObj != DBNull.Value) nudStudentLevel.Value = Convert.ToDecimal(levelObj);
            var termObj = dgvStudents.CurrentRow.Cells["CurrentTermId"]?.Value;
            if (termObj != null && termObj != DBNull.Value) cmbStudentTerm.SelectedValue = Convert.ToInt32(termObj);
            var actObj = dgvStudents.CurrentRow.Cells["IsActive"]?.Value;
            if (actObj != null && actObj != DBNull.Value) chkStudentActive.Checked = Convert.ToBoolean(actObj);
        }
        private void ClearStudents() { txtStudentId.Clear(); txtStudentName.Clear(); nudStudentLevel.Value = 1; chkStudentActive.Checked = true; }

        private void LoadTeachers() => dgvTeachers.DataSource = _svc.GetTeachers(txtTeachersSearch.Text);
        private void dgvTeachers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeachers.CurrentRow == null) return;
            txtTeacherId.Text = dgvTeachers.CurrentRow.Cells["UniversityTeacherId"]?.Value?.ToString() ?? "";
            txtTeacherName.Text = dgvTeachers.CurrentRow.Cells["FullName"]?.Value?.ToString() ?? "";
            var actObj = dgvTeachers.CurrentRow.Cells["IsActive"]?.Value;
            if (actObj != null && actObj != DBNull.Value) chkTeacherActive.Checked = Convert.ToBoolean(actObj);
        }
        private void ClearTeachers() { txtTeacherId.Clear(); txtTeacherName.Clear(); chkTeacherActive.Checked = true; }

        private void LoadCourses() => dgvCourses.DataSource = _svc.GetCourses(txtCoursesSearch.Text);
        private void dgvCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourses.CurrentRow == null) return;
            txtCourseCode.Text = dgvCourses.CurrentRow.Cells["Code"]?.Value?.ToString() ?? "";
            txtCourseName.Text = dgvCourses.CurrentRow.Cells["Name"]?.Value?.ToString() ?? "";
            var pObj = dgvCourses.CurrentRow.Cells["HasPractical"]?.Value;
            if (pObj != null && pObj != DBNull.Value) chkCoursePractical.Checked = Convert.ToBoolean(pObj);
        }
        private void ClearCourses() { txtCourseCode.Clear(); txtCourseName.Clear(); chkCoursePractical.Checked = false; }

        private void LoadOfferings() => dgvOfferings.DataSource = _svc.GetOfferings(txtOfferingsSearch.Text);
        private void dgvOfferings_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOfferings.CurrentRow == null) return;
            var termObj = dgvOfferings.CurrentRow.Cells["TermId"]?.Value;
            if (termObj != null && termObj != DBNull.Value) cmbOfferingTerm.SelectedValue = Convert.ToInt32(termObj);
            var courseObj = dgvOfferings.CurrentRow.Cells["CourseId"]?.Value;
            if (courseObj != null && courseObj != DBNull.Value) cmbOfferingCourse.SelectedValue = Convert.ToInt32(courseObj);
            cmbOfferingType.SelectedItem = dgvOfferings.CurrentRow.Cells["OfferingType"]?.Value?.ToString();
            var maxObj = dgvOfferings.CurrentRow.Cells["MaxTotalScore"]?.Value;
            if (maxObj != null && maxObj != DBNull.Value) nudOfferingMax.Value = Convert.ToDecimal(maxObj);
        }
        private void ClearOfferings() { cmbOfferingType.SelectedIndex = -1; nudOfferingMax.Value = 100; }

        private void LoadAssignments() => dgvAssignments.DataSource = _svc.GetTeacherAssignments(txtAssignmentsSearch.Text);
        private void dgvAssignments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAssignments.CurrentRow == null) return;
            var offObj = dgvAssignments.CurrentRow.Cells["OfferingId"]?.Value;
            if (offObj != null && offObj != DBNull.Value) cmbAssignOffering.SelectedValue = Convert.ToInt32(offObj);
            var tObj = dgvAssignments.CurrentRow.Cells["UniversityTeacherId"]?.Value;
            if (tObj != null && tObj != DBNull.Value) cmbAssignTeacher.SelectedValue = tObj.ToString();
        }
        private void ClearAssignments() { }

        private void LoadEnrollments() => dgvEnrollments.DataSource = _svc.GetEnrollments(txtEnrollmentsSearch.Text);
        private void dgvEnrollments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEnrollments.CurrentRow == null) return;
            var sObj = dgvEnrollments.CurrentRow.Cells["UniversityStudentId"]?.Value;
            if (sObj != null && sObj != DBNull.Value) cmbEnrollStudent.SelectedValue = sObj.ToString();
            var oObj = dgvEnrollments.CurrentRow.Cells["OfferingId"]?.Value;
            if (oObj != null && oObj != DBNull.Value) cmbEnrollOffering.SelectedValue = Convert.ToInt32(oObj);
        }
        private void ClearEnrollments() { }

        private void LoadLecturePlan() => dgvLecturePlan.DataSource = _svc.GetLecturePlan(txtLecturePlanSearch.Text);
        private void dgvLecturePlan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLecturePlan.CurrentRow == null) return;
            var oObj = dgvLecturePlan.CurrentRow.Cells["OfferingId"]?.Value;
            if (oObj != null && oObj != DBNull.Value) cmbPlanOffering.SelectedValue = Convert.ToInt32(oObj);
            var nObj = dgvLecturePlan.CurrentRow.Cells["LectureNo"]?.Value;
            if (nObj != null && nObj != DBNull.Value) nudPlanNo.Value = Convert.ToDecimal(nObj);
            txtPlanTitle.Text = dgvLecturePlan.CurrentRow.Cells["Title"]?.Value?.ToString() ?? "";
            txtPlanContent.Text = dgvLecturePlan.CurrentRow.Cells["Content"]?.Value?.ToString() ?? "";
            var xObj = dgvLecturePlan.CurrentRow.Cells["IsExtra"]?.Value;
            if (xObj != null && xObj != DBNull.Value) chkPlanExtra.Checked = Convert.ToBoolean(xObj);
        }
        private void ClearLecturePlan() { nudPlanNo.Value = 1; txtPlanTitle.Clear(); txtPlanContent.Clear(); chkPlanExtra.Checked = false; }



        // ========= Activation Codes (App_ActivationCodes) =========
        private void LoadActivationCodes() => dgvActivationCodes.DataSource = _svc.GetActivationCodes(txtActSearch.Text);

        private void dgvActivationCodes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvActivationCodes.CurrentRow == null) return;

            txtActCode.Text = dgvActivationCodes.CurrentRow.Cells["Code"]?.Value?.ToString() ?? "";
            var role = dgvActivationCodes.CurrentRow.Cells["Role"]?.Value?.ToString() ?? "";
            if (!string.IsNullOrWhiteSpace(role)) cmbActRole.SelectedItem = role;

            var sObj = dgvActivationCodes.CurrentRow.Cells["UniversityStudentId"]?.Value;
            var tObj = dgvActivationCodes.CurrentRow.Cells["UniversityTeacherId"]?.Value;

            if (sObj != null && sObj != DBNull.Value) cmbActStudent.SelectedValue = sObj.ToString();
            if (tObj != null && tObj != DBNull.Value) cmbActTeacher.SelectedValue = tObj.ToString();

            var usedObj = dgvActivationCodes.CurrentRow.Cells["IsUsed"]?.Value;
            if (usedObj != null && usedObj != DBNull.Value) chkActUsed.Checked = Convert.ToBoolean(usedObj);
        }

        private void ClearActivationCodes()
        {
            txtActCode.Clear();
            cmbActRole.SelectedIndex = -1;
            chkActUsed.Checked = false;
            if (cmbActStudent.DataSource != null) cmbActStudent.SelectedIndex = -1;
            if (cmbActTeacher.DataSource != null) cmbActTeacher.SelectedIndex = -1;
            cmbActStudent.Enabled = false;
            cmbActTeacher.Enabled = false;
        }

        private void cmbActRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            var role = cmbActRole.SelectedItem?.ToString();
            if (role == "طالب")
            {
                cmbActStudent.Enabled = true;
                cmbActTeacher.Enabled = false;
                if (cmbActTeacher.DataSource != null) cmbActTeacher.SelectedIndex = -1;
            }
            else if (role == "أستاذ")
            {
                cmbActTeacher.Enabled = true;
                cmbActStudent.Enabled = false;
                if (cmbActStudent.DataSource != null) cmbActStudent.SelectedIndex = -1;
            }
            else
            {
                cmbActStudent.Enabled = false;
                cmbActTeacher.Enabled = false;
            }
        }

        private void btnActGenerate_Click(object sender, EventArgs e)
        {
            // Generate a readable code (10 chars: A-Z0-9)
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            var rnd = new Random();
            var arr = new char[10];
            for (int i = 0; i < arr.Length; i++) arr[i] = chars[rnd.Next(chars.Length)];
            txtActCode.Text = new string(arr);
        }

        private void btnActSearch_Click(object sender, EventArgs e) => LoadActivationCodes();
        private void btnActRefresh_Click(object sender, EventArgs e) { txtActSearch.Clear(); RefreshLookups(); LoadActivationCodes(); }
        private void txtActSearch_TextChanged(object sender, EventArgs e) => LoadActivationCodes();
        private void btnActClear_Click(object sender, EventArgs e) => ClearActivationCodes();

        private void btnActAdd_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                var codeVal = txtActCode.Text?.Trim();
                if (string.IsNullOrWhiteSpace(codeVal)) { btnActGenerate_Click(null, EventArgs.Empty); codeVal = txtActCode.Text.Trim(); }

                var role = cmbActRole.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(role)) { MessageBox.Show("اختر الدور"); return; }

                string studentId = null, teacherId = null;
                if (role == "طالب")
                {
                    if (cmbActStudent.SelectedValue == null) { MessageBox.Show("اختر الطالب"); return; }
                    studentId = cmbActStudent.SelectedValue.ToString();
                }
                else if (role == "أستاذ")
                {
                    if (cmbActTeacher.SelectedValue == null) { MessageBox.Show("اختر الأستاذ"); return; }
                    teacherId = cmbActTeacher.SelectedValue.ToString();
                }

                _svc.AddActivationCode(codeVal, role, studentId, teacherId);
                LoadActivationCodes(); ClearActivationCodes();
            });
        }

        private void btnActUpdate_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                var codeVal = txtActCode.Text?.Trim();
                if (string.IsNullOrWhiteSpace(codeVal)) { MessageBox.Show("اختر كوداً"); return; }
                if (chkActUsed.Checked) { MessageBox.Show("لا يمكن تعديل كود مستخدم."); return; }

                var role = cmbActRole.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(role)) { MessageBox.Show("اختر الدور"); return; }

                string studentId = null, teacherId = null;
                if (role == "طالب")
                {
                    if (cmbActStudent.SelectedValue == null) { MessageBox.Show("اختر الطالب"); return; }
                    studentId = cmbActStudent.SelectedValue.ToString();
                }
                else if (role == "أستاذ")
                {
                    if (cmbActTeacher.SelectedValue == null) { MessageBox.Show("اختر الأستاذ"); return; }
                    teacherId = cmbActTeacher.SelectedValue.ToString();
                }

                _svc.UpdateActivationCode(codeVal, role, studentId, teacherId);
                LoadActivationCodes();
            });
        }

        private void btnActDelete_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                var codeVal = txtActCode.Text?.Trim();
                if (string.IsNullOrWhiteSpace(codeVal)) { MessageBox.Show("اختر كوداً"); return; }
                if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                _svc.DeleteActivationCode(codeVal);
                LoadActivationCodes(); ClearActivationCodes();
            });
        }
        private void btnDepartmentsSearch_Click(object sender, EventArgs e) => LoadDepartments();
        private void btnDepartmentsRefresh_Click(object sender, EventArgs e) { txtDepartmentsSearch.Clear(); RefreshLookups(); LoadDepartments(); }
        private void txtDepartmentsSearch_TextChanged(object sender, EventArgs e) => LoadDepartments();
        private void btnDepartmentsClear_Click(object sender, EventArgs e) => ClearDepartments();
        private void btnDepartmentsAdd_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (string.IsNullOrWhiteSpace(txtDeptName.Text)) { MessageBox.Show("أدخل اسم القسم"); return; }
                _svc.AddDepartment(txtDeptName.Text.Trim());
                LoadDepartments(); RefreshLookups(); ClearDepartments();
            });
        }
        private void btnDepartmentsUpdate_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                var id = GetSelectedInt(dgvDepartments, "DepartmentId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.UpdateDepartment(id.Value, txtDeptName.Text.Trim());
                LoadDepartments(); RefreshLookups();
            });
        }
        private void btnDepartmentsDelete_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                var id = GetSelectedInt(dgvDepartments, "DepartmentId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.DeleteDepartment(id.Value); LoadDepartments(); RefreshLookups(); ClearDepartments();
            });
        }

        private void btnMajorsSearch_Click(object sender, EventArgs e) => LoadMajors();
        private void btnMajorsRefresh_Click(object sender, EventArgs e) { txtMajorsSearch.Clear(); RefreshLookups(); LoadMajors(); }
        private void txtMajorsSearch_TextChanged(object sender, EventArgs e) => LoadMajors();
        private void btnMajorsClear_Click(object sender, EventArgs e) => ClearMajors();
        private void btnMajorsAdd_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (cmbMajorDept.SelectedValue == null) { MessageBox.Show("اختر القسم"); return; }
                if (string.IsNullOrWhiteSpace(txtMajorName.Text)) { MessageBox.Show("أدخل اسم التخصص"); return; }
                _svc.AddMajor(Convert.ToInt32(cmbMajorDept.SelectedValue), txtMajorName.Text.Trim());
                LoadMajors(); RefreshLookups(); ClearMajors();
            });
        }
        private void btnMajorsUpdate_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                var id = GetSelectedInt(dgvMajors, "MajorId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.UpdateMajor(id.Value, Convert.ToInt32(cmbMajorDept.SelectedValue), txtMajorName.Text.Trim());
                LoadMajors(); RefreshLookups();
            });
        }
        private void btnMajorsDelete_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                var id = GetSelectedInt(dgvMajors, "MajorId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.DeleteMajor(id.Value); LoadMajors(); RefreshLookups(); ClearMajors();
            });
        }

        private void btnTermsSearch_Click(object sender, EventArgs e) => LoadTerms();
        private void btnTermsRefresh_Click(object sender, EventArgs e) { txtTermsSearch.Clear(); RefreshLookups(); LoadTerms(); }
        private void txtTermsSearch_TextChanged(object sender, EventArgs e) => LoadTerms();
        private void btnTermsClear_Click(object sender, EventArgs e) => ClearTerms();
        private void btnTermsAdd_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (string.IsNullOrWhiteSpace(txtTermName.Text)) { MessageBox.Show("أدخل اسم الترم"); return; }
                _svc.AddTerm(txtTermName.Text.Trim(), Convert.ToInt32(nudTermYear.Value), chkTermActive.Checked);
                LoadTerms(); RefreshLookups(); ClearTerms();
            });
        }
        private void btnTermsUpdate_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                var id = GetSelectedInt(dgvTerms, "TermId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.UpdateTerm(id.Value, txtTermName.Text.Trim(), Convert.ToInt32(nudTermYear.Value), chkTermActive.Checked);
                LoadTerms(); RefreshLookups();
            });
        }
        private void btnTermsDelete_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                var id = GetSelectedInt(dgvTerms, "TermId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.DeleteTerm(id.Value); LoadTerms(); RefreshLookups(); ClearTerms();
            });
        }

        private void btnStudentsSearch_Click(object sender, EventArgs e) => LoadStudents();
        private void btnStudentsRefresh_Click(object sender, EventArgs e) { txtStudentsSearch.Clear(); RefreshLookups(); LoadStudents(); }
        private void txtStudentsSearch_TextChanged(object sender, EventArgs e) => LoadStudents();
        private void btnStudentsClear_Click(object sender, EventArgs e) => ClearStudents();
        private void btnStudentsAdd_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (string.IsNullOrWhiteSpace(txtStudentId.Text)) { MessageBox.Show("أدخل الرقم الجامعي"); return; }
                if (string.IsNullOrWhiteSpace(txtStudentName.Text)) { MessageBox.Show("أدخل اسم الطالب"); return; }
                if (cmbStudentMajor.SelectedValue == null || cmbStudentTerm.SelectedValue == null) { MessageBox.Show("اختر التخصص والترم"); return; }
                _svc.AddStudent(txtStudentId.Text.Trim(), txtStudentName.Text.Trim(), Convert.ToInt32(cmbStudentMajor.SelectedValue), Convert.ToInt32(nudStudentLevel.Value), Convert.ToInt32(cmbStudentTerm.SelectedValue), chkStudentActive.Checked);
                LoadStudents(); RefreshLookups(); ClearStudents();
            });
        }
        private void btnStudentsUpdate_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                var id = GetSelectedString(dgvStudents, "UniversityStudentId"); if (string.IsNullOrWhiteSpace(id)) { MessageBox.Show("اختر طالباً"); return; }
                _svc.UpdateStudent(id, txtStudentName.Text.Trim(), Convert.ToInt32(cmbStudentMajor.SelectedValue), Convert.ToInt32(nudStudentLevel.Value), Convert.ToInt32(cmbStudentTerm.SelectedValue), chkStudentActive.Checked);
                LoadStudents(); RefreshLookups();
            });
        }
        private void btnStudentsDelete_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                var id = GetSelectedString(dgvStudents, "UniversityStudentId"); if (string.IsNullOrWhiteSpace(id)) { MessageBox.Show("اختر طالباً"); return; }
                _svc.DeleteStudent(id); LoadStudents(); RefreshLookups(); ClearStudents();
            });
        }

        private void btnTeachersSearch_Click(object sender, EventArgs e) => LoadTeachers();
        private void btnTeachersRefresh_Click(object sender, EventArgs e) { txtTeachersSearch.Clear(); RefreshLookups(); LoadTeachers(); }
        private void txtTeachersSearch_TextChanged(object sender, EventArgs e) => LoadTeachers();
        private void btnTeachersClear_Click(object sender, EventArgs e) => ClearTeachers();
        private void btnTeachersAdd_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (string.IsNullOrWhiteSpace(txtTeacherId.Text)) { MessageBox.Show("أدخل رقم الأستاذ"); return; }
                if (string.IsNullOrWhiteSpace(txtTeacherName.Text)) { MessageBox.Show("أدخل الاسم"); return; }
                _svc.AddTeacher(txtTeacherId.Text.Trim(), txtTeacherName.Text.Trim(), chkTeacherActive.Checked);
                LoadTeachers(); RefreshLookups(); ClearTeachers();
            });
        }
        private void btnTeachersUpdate_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                var id = GetSelectedString(dgvTeachers, "UniversityTeacherId"); if (string.IsNullOrWhiteSpace(id)) { MessageBox.Show("اختر أستاذاً"); return; }
                _svc.UpdateTeacher(id, txtTeacherName.Text.Trim(), chkTeacherActive.Checked);
                LoadTeachers(); RefreshLookups();
            });
        }
        private void btnTeachersDelete_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                var id = GetSelectedString(dgvTeachers, "UniversityTeacherId"); if (string.IsNullOrWhiteSpace(id)) { MessageBox.Show("اختر أستاذاً"); return; }
                _svc.DeleteTeacher(id); LoadTeachers(); RefreshLookups(); ClearTeachers();
            });
        }

        private void btnCoursesSearch_Click(object sender, EventArgs e) => LoadCourses();
        private void btnCoursesRefresh_Click(object sender, EventArgs e) { txtCoursesSearch.Clear(); RefreshLookups(); LoadCourses(); }
        private void txtCoursesSearch_TextChanged(object sender, EventArgs e) => LoadCourses();
        private void btnCoursesClear_Click(object sender, EventArgs e) => ClearCourses();
        private void btnCoursesAdd_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (string.IsNullOrWhiteSpace(txtCourseCode.Text)) { MessageBox.Show("أدخل كود المادة"); return; }
                if (string.IsNullOrWhiteSpace(txtCourseName.Text)) { MessageBox.Show("أدخل اسم المادة"); return; }
                _svc.AddCourse(txtCourseCode.Text.Trim(), txtCourseName.Text.Trim(), chkCoursePractical.Checked);
                LoadCourses(); RefreshLookups(); ClearCourses();
            });
        }
        private void btnCoursesUpdate_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                var id = GetSelectedInt(dgvCourses, "CourseId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.UpdateCourse(id.Value, txtCourseCode.Text.Trim(), txtCourseName.Text.Trim(), chkCoursePractical.Checked);
                LoadCourses(); RefreshLookups();
            });
        }
        private void btnCoursesDelete_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                var id = GetSelectedInt(dgvCourses, "CourseId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.DeleteCourse(id.Value); LoadCourses(); RefreshLookups(); ClearCourses();
            });
        }

        private void btnOfferingsSearch_Click(object sender, EventArgs e) => LoadOfferings();
        private void btnOfferingsRefresh_Click(object sender, EventArgs e) { txtOfferingsSearch.Clear(); RefreshLookups(); LoadOfferings(); }
        private void txtOfferingsSearch_TextChanged(object sender, EventArgs e) => LoadOfferings();
        private void btnOfferingsClear_Click(object sender, EventArgs e) => ClearOfferings();
        private void btnOfferingsAdd_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (cmbOfferingTerm.SelectedValue == null || cmbOfferingCourse.SelectedValue == null) { MessageBox.Show("اختر الترم والمقرر"); return; }
                if (cmbOfferingType.SelectedItem == null) { MessageBox.Show("اختر النوع"); return; }
                _svc.AddOffering(Convert.ToInt32(cmbOfferingTerm.SelectedValue), Convert.ToInt32(cmbOfferingCourse.SelectedValue), cmbOfferingType.SelectedItem.ToString(), Convert.ToInt32(nudOfferingMax.Value));
                LoadOfferings(); RefreshLookups(); ClearOfferings();
            });
        }
        private void btnOfferingsUpdate_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                var id = GetSelectedInt(dgvOfferings, "OfferingId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.UpdateOffering(id.Value, Convert.ToInt32(cmbOfferingTerm.SelectedValue), Convert.ToInt32(cmbOfferingCourse.SelectedValue), cmbOfferingType.SelectedItem?.ToString(), Convert.ToInt32(nudOfferingMax.Value));
                LoadOfferings(); RefreshLookups();
            });
        }
        private void btnOfferingsDelete_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                var id = GetSelectedInt(dgvOfferings, "OfferingId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.DeleteOffering(id.Value); LoadOfferings(); RefreshLookups(); ClearOfferings();
            });
        }

        private void btnAssignmentsSearch_Click(object sender, EventArgs e) => LoadAssignments();
        private void btnAssignmentsRefresh_Click(object sender, EventArgs e) { txtAssignmentsSearch.Clear(); RefreshLookups(); LoadAssignments(); }
        private void txtAssignmentsSearch_TextChanged(object sender, EventArgs e) => LoadAssignments();
        private void btnAssignmentsClear_Click(object sender, EventArgs e) => ClearAssignments();
        private void btnAssignmentsAdd_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (cmbAssignOffering.SelectedValue == null || cmbAssignTeacher.SelectedValue == null) { MessageBox.Show("اختر المادة والأستاذ"); return; }
                _svc.AddTeacherAssignment(Convert.ToInt32(cmbAssignOffering.SelectedValue), cmbAssignTeacher.SelectedValue.ToString());
                LoadAssignments(); RefreshLookups();
            });
        }
        private void btnAssignmentsUpdate_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                var id = GetSelectedInt(dgvAssignments, "AssignmentId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.UpdateTeacherAssignment(id.Value, Convert.ToInt32(cmbAssignOffering.SelectedValue), cmbAssignTeacher.SelectedValue.ToString());
                LoadAssignments(); RefreshLookups();
            });
        }
        private void btnAssignmentsDelete_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                var id = GetSelectedInt(dgvAssignments, "AssignmentId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.DeleteTeacherAssignment(id.Value); LoadAssignments(); RefreshLookups();
            });
        }

        private void btnEnrollmentsSearch_Click(object sender, EventArgs e) => LoadEnrollments();
        private void btnEnrollmentsRefresh_Click(object sender, EventArgs e) { txtEnrollmentsSearch.Clear(); RefreshLookups(); LoadEnrollments(); }
        private void txtEnrollmentsSearch_TextChanged(object sender, EventArgs e) => LoadEnrollments();
        private void btnEnrollmentsClear_Click(object sender, EventArgs e) => ClearEnrollments();
        private void btnEnrollmentsAdd_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (cmbEnrollStudent.SelectedValue == null || cmbEnrollOffering.SelectedValue == null) { MessageBox.Show("اختر الطالب والمادة"); return; }
                _svc.AddEnrollment(cmbEnrollStudent.SelectedValue.ToString(), Convert.ToInt32(cmbEnrollOffering.SelectedValue));
                LoadEnrollments(); RefreshLookups();
            });
        }
        private void btnEnrollmentsUpdate_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                var id = GetSelectedInt(dgvEnrollments, "EnrollmentId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.UpdateEnrollment(id.Value, cmbEnrollStudent.SelectedValue.ToString(), Convert.ToInt32(cmbEnrollOffering.SelectedValue));
                LoadEnrollments(); RefreshLookups();
            });
        }
        private void btnEnrollmentsDelete_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                var id = GetSelectedInt(dgvEnrollments, "EnrollmentId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.DeleteEnrollment(id.Value); LoadEnrollments(); RefreshLookups();
            });
        }

        private void btnLecturePlanSearch_Click(object sender, EventArgs e) { LoadLecturePlan(); }
        private void btnLecturePlanRefresh_Click(object sender, EventArgs e) { txtLecturePlanSearch.Clear(); RefreshLookups(); LoadLecturePlan(); }
        private void txtLecturePlanSearch_TextChanged(object sender, EventArgs e) { LoadLecturePlan(); }
        private void btnLecturePlanClear_Click(object sender, EventArgs e) { ClearLecturePlan(); }
        private void btnLecturePlanAdd_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (cmbPlanOffering.SelectedValue == null) { MessageBox.Show("اختر المادة المطروحة"); return; }
                if (string.IsNullOrWhiteSpace(txtPlanTitle.Text)) { MessageBox.Show("أدخل عنوان المحاضرة"); return; }
                _svc.AddLecturePlan(Convert.ToInt32(cmbPlanOffering.SelectedValue), Convert.ToInt32(nudPlanNo.Value), txtPlanTitle.Text.Trim(), txtPlanContent.Text, chkPlanExtra.Checked);
                LoadLecturePlan(); RefreshLookups(); ClearLecturePlan();
            });
        }
        private void btnLecturePlanUpdate_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                var id = GetSelectedInt(dgvLecturePlan, "PlanLectureId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.UpdateLecturePlan(id.Value, Convert.ToInt32(cmbPlanOffering.SelectedValue), Convert.ToInt32(nudPlanNo.Value), txtPlanTitle.Text.Trim(), txtPlanContent.Text, chkPlanExtra.Checked);
                LoadLecturePlan(); RefreshLookups();
            });
        }
        private void btnLecturePlanDelete_Click(object sender, EventArgs e)
        {
            SafeSql(() =>
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                var id = GetSelectedInt(dgvLecturePlan, "PlanLectureId"); if (id == null) { MessageBox.Show("اختر صفاً"); return; }
                _svc.DeleteLecturePlan(id.Value); LoadLecturePlan(); RefreshLookups(); ClearLecturePlan();
            });
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtDeptName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
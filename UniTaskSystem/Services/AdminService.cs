using System;
using System.Data;
using System.Data.SqlClient;
using UniTaskSystem.Data;

namespace UniTaskSystem.Services
{
    public class AdminService
    {
        // ========= Departments =========
        public DataTable GetDepartments(string q)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Departments_Get", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : q.Trim());

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddDepartment(string name)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Departments_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDepartment(int departmentId, string name)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Departments_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DepartmentId", departmentId);
                cmd.Parameters.AddWithValue("@Name", name);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDepartment(int departmentId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Departments_Delete", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DepartmentId", departmentId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ========= Majors =========
        public DataTable GetMajors(string q)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Majors_Get", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : q.Trim());

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddMajor(int departmentId, string name)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Majors_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DepartmentId", departmentId);
                cmd.Parameters.AddWithValue("@Name", name);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMajor(int majorId, int departmentId, string name)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Majors_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MajorId", majorId);
                cmd.Parameters.AddWithValue("@DepartmentId", departmentId);
                cmd.Parameters.AddWithValue("@Name", name);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMajor(int majorId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Majors_Delete", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MajorId", majorId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ========= Terms =========
        public DataTable GetTerms(string q)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Terms_Get", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : q.Trim());

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddTerm(string name, int year, bool isActive)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Terms_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@IsActive", isActive);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTerm(int termId, string name, int year, bool isActive)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Terms_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TermId", termId);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@IsActive", isActive);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTerm(int termId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Terms_Delete", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TermId", termId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ========= Students =========
        public DataTable GetStudents(string q)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Students_Get", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : q.Trim());

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddStudent(string studentId, string fullName, int majorId, int levelNo, int currentTermId, bool isActive)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Students_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UniversityStudentId", studentId);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@MajorId", majorId);
                cmd.Parameters.AddWithValue("@LevelNo", levelNo);
                cmd.Parameters.AddWithValue("@CurrentTermId", currentTermId);
                cmd.Parameters.AddWithValue("@IsActive", isActive);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStudent(string studentId, string fullName, int majorId, int levelNo, int currentTermId, bool isActive)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Students_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UniversityStudentId", studentId);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@MajorId", majorId);
                cmd.Parameters.AddWithValue("@LevelNo", levelNo);
                cmd.Parameters.AddWithValue("@CurrentTermId", currentTermId);
                cmd.Parameters.AddWithValue("@IsActive", isActive);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(string studentId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Students_Delete", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UniversityStudentId", studentId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ========= Teachers =========
        public DataTable GetTeachers(string q)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Teachers_Get", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : q.Trim());

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddTeacher(string teacherId, string fullName, bool isActive)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Teachers_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UniversityTeacherId", teacherId);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@IsActive", isActive);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTeacher(string teacherId, string fullName, bool isActive)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Teachers_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UniversityTeacherId", teacherId);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@IsActive", isActive);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTeacher(string teacherId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Teachers_Delete", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UniversityTeacherId", teacherId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ========= Courses =========
        public DataTable GetCourses(string q)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Courses_Get", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : q.Trim());

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddCourse(string code, string name, bool hasPractical)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Courses_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@HasPractical", hasPractical);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCourse(int courseId, string code, string name, bool hasPractical)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Courses_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CourseId", courseId);
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@HasPractical", hasPractical);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCourse(int courseId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Courses_Delete", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CourseId", courseId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ========= Offerings =========
        public DataTable GetOfferings(string q)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Offerings_Get", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : q.Trim());

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddOffering(int termId, int courseId, string offeringType, int maxTotalScore)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Offerings_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TermId", termId);
                cmd.Parameters.AddWithValue("@CourseId", courseId);
                cmd.Parameters.AddWithValue("@OfferingType", offeringType);
                cmd.Parameters.AddWithValue("@MaxTotalScore", maxTotalScore);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOffering(int offeringId, int termId, int courseId, string offeringType, int maxTotalScore)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Offerings_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);
                cmd.Parameters.AddWithValue("@TermId", termId);
                cmd.Parameters.AddWithValue("@CourseId", courseId);
                cmd.Parameters.AddWithValue("@OfferingType", offeringType);
                cmd.Parameters.AddWithValue("@MaxTotalScore", maxTotalScore);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteOffering(int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Offerings_Delete", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ========= TeacherAssignments =========
        public DataTable GetTeacherAssignments(string q)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_TeacherAssignments_Get", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : q.Trim());

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddTeacherAssignment(int offeringId, string teacherId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_TeacherAssignments_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);
                cmd.Parameters.AddWithValue("@UniversityTeacherId", teacherId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTeacherAssignment(int assignmentId, int offeringId, string teacherId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_TeacherAssignments_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AssignmentId", assignmentId);
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);
                cmd.Parameters.AddWithValue("@UniversityTeacherId", teacherId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTeacherAssignment(int assignmentId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_TeacherAssignments_Delete", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AssignmentId", assignmentId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ========= Enrollments =========
        public DataTable GetEnrollments(string q)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Enrollments_Get", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : q.Trim());

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddEnrollment(string studentId, int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Enrollments_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UniversityStudentId", studentId);
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateEnrollment(int enrollmentId, string studentId, int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Enrollments_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EnrollmentId", enrollmentId);
                cmd.Parameters.AddWithValue("@UniversityStudentId", studentId);
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteEnrollment(int enrollmentId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Enrollments_Delete", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EnrollmentId", enrollmentId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ========= LecturePlan =========
        public DataTable GetLecturePlan(string q)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_LecturePlan_Get", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : q.Trim());

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddLecture(int offeringId, int lectureNo, string title, string content, bool isExtra)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_LecturePlan_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);
                cmd.Parameters.AddWithValue("@LectureNo", lectureNo);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Content", (object)content ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IsExtra", isExtra);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateLecture(int planLectureId, int offeringId, int lectureNo, string title, string content, bool isExtra)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_LecturePlan_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlanLectureId", planLectureId);
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);
                cmd.Parameters.AddWithValue("@LectureNo", lectureNo);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Content", (object)content ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IsExtra", isExtra);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteLecture(int planLectureId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_LecturePlan_Delete", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlanLectureId", planLectureId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // --- Backward-compatible names used by AdminMainForm ---
        public void AddLecturePlan(int offeringId, int lectureNo, string title, string content, bool isExtra)
            => AddLecture(offeringId, lectureNo, title, content, isExtra);

        public void UpdateLecturePlan(int planLectureId, int offeringId, int lectureNo, string title, string content, bool isExtra)
            => UpdateLecture(planLectureId, offeringId, lectureNo, title, content, isExtra);

        public void DeleteLecturePlan(int planLectureId)
            => DeleteLecture(planLectureId);

        // ========= Activation Codes (App_ActivationCodes) =========
        public DataTable GetActivationCodes(string q)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_ActivationCodes_Get", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : q.Trim());

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddActivationCode(string code, string role, string universityStudentId, string universityTeacherId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_ActivationCodes_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@UniversityStudentId", (object)universityStudentId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@UniversityTeacherId", (object)universityTeacherId ?? DBNull.Value);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateActivationCode(string code, string role, string universityStudentId, string universityTeacherId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_ActivationCodes_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@UniversityStudentId", (object)universityStudentId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@UniversityTeacherId", (object)universityTeacherId ?? DBNull.Value);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteActivationCode(string code)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_ActivationCodes_Delete", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", code);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ========= Lookup helpers =========
        public DataTable GetDepartmentsLookup() => GetDepartments(null);

        public DataTable GetMajorsLookup()
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Majors_Lookup", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTermsLookup()
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Terms_Lookup", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetCoursesLookup()
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Courses_Lookup", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTeachersLookup()
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Teachers_Lookup", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetStudentsLookup()
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Students_Lookup", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetOfferingsLookup()
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Admin_Offerings_Lookup", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using UniTaskSystem.Data;

namespace UniTaskSystem.Services
{
    public class TeacherService
    {
        public DataTable GetTeacherInfo(string teacherId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Teacher_GetInfo", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTeacherOfferings(string teacherId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Teacher_GetOfferings", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAdminNotifications()
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_AdminNotifications_GetAll", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // =====================
        // إدارة المنشورات (تعديل/حذف/بحث)
        // =====================

        public DataTable GetOfferingPosts(int offeringId, string teacherId, string q, string postType)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Posts_GetOfferingPostsForTeacher", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);
                cmd.Parameters.AddWithValue("@q", string.IsNullOrWhiteSpace(q) ? (object)DBNull.Value : q.Trim());
                cmd.Parameters.AddWithValue("@PostType", string.IsNullOrWhiteSpace(postType) ? (object)DBNull.Value : postType.Trim());

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetPostDetails(int postId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Posts_GetDetailsForManage", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void UpdatePost(int postId, string teacherId, int offeringId, string postType, string title, string body, DateTime? deadline)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Posts_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);
                cmd.Parameters.AddWithValue("@PostType", postType);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Body", (object)body ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Deadline", deadline.HasValue ? (object)deadline.Value : DBNull.Value);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePost(int postId, string teacherId, int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Posts_Delete", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetPostAttachments(int postId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Attachments_GetByPostDetails", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetOfferingHeader(int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Offering_GetHeaderForTeacher", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // إنشاء منشور (مهمة/مقرر/نماذج) داخل مادة
        public int CreatePost(int offeringId, string postType, string title, string body, DateTime? deadline, string teacherId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Posts_Create", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);
                cmd.Parameters.AddWithValue("@PostType", postType);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Body", (object)body ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Deadline", deadline.HasValue ? (object)deadline.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);

                var outId = new SqlParameter("@PostId", SqlDbType.Int) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(outId);

                con.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(outId.Value);
            }
        }

        // إضافة مرفق لمنشور (App_Attachments)
        public void AddPostAttachment(int postId, string fileName, string filePath, string mimeType, long sizeBytes)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Attachments_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);
                cmd.Parameters.AddWithValue("@FileName", fileName);
                cmd.Parameters.AddWithValue("@FilePath", filePath);
                cmd.Parameters.AddWithValue("@MimeType", (object)mimeType ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FileSizeBytes", sizeBytes);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // قائمة مهام المادة (ليختار منها الأستاذ لرؤية الحلول)
        public DataTable GetCourseTasks(int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Posts_GetTasksForOffering", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // الطلاب الذين سلموا لحساب مهمة معينة
        public DataTable GetSubmissionsForPost(int postId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Submissions_GetForPost", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PostId", postId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetSubmissionDetails(int submissionId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Submissions_GetDetails", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubmissionId", submissionId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetSubmissionAttachments(int submissionId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_SubmissionAttachments_GetBasic", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubmissionId", submissionId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // حفظ/تحديث الدرجة
        public void UpsertGrade(int submissionId, int score, string feedback, string teacherId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Grades_Upsert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubmissionId", submissionId);
                cmd.Parameters.AddWithValue("@Score", score);
                cmd.Parameters.AddWithValue("@Feedback", (object)feedback ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetExistingGrade(int submissionId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Grades_GetExisting", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubmissionId", submissionId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetGradeSheet(int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Teacher_GetGradeSheet", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void UpsertTermScores(string studentId, int offeringId,
    decimal? attendance, decimal? midterm, decimal? finalScore)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_TermScores_Upsert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                var pAtt = cmd.Parameters.Add("@Attendance", SqlDbType.Decimal);
                pAtt.Precision = 5; pAtt.Scale = 2;
                pAtt.Value = attendance.HasValue ? (object)attendance.Value : DBNull.Value;

                var pMid = cmd.Parameters.Add("@Midterm", SqlDbType.Decimal);
                pMid.Precision = 5; pMid.Scale = 2;
                pMid.Value = midterm.HasValue ? (object)midterm.Value : DBNull.Value;

                var pFin = cmd.Parameters.Add("@FinalScore", SqlDbType.Decimal);
                pFin.Precision = 5; pFin.Scale = 2;
                pFin.Value = finalScore.HasValue ? (object)finalScore.Value : DBNull.Value;

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public DataTable GetStudentTasksInOffering(int offeringId, string studentId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_Teacher_GetStudentTasksInOffering", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetLecturePlan(int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_LecturePlan_GetForTeacher", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void SetLectureCovered(int planLectureId, bool covered, string teacherId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_LecturePlan_SetCovered", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlanLectureId", planLectureId);
                cmd.Parameters.AddWithValue("@IsCovered", covered ? 1 : 0);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AddExtraLecture(int offeringId, string title, string content, string teacherId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_LecturePlan_AddExtra", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Content", (object)content ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetPlanStats(int offeringId)
        {
            using (var con = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_LecturePlan_GetStats", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OfferingId", offeringId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}

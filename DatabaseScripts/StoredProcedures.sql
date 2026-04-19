/*
============================================================
 UniTaskSystem - Stored Procedures (Compat)
 ملاحظة:
 - هذه النسخة متوافقة مع إصدارات SQL Server التي لا تدعم CREATE OR ALTER.
 - شغّلها في SSMS داخل قاعدة بيانات UniTaskSystem.
============================================================
*/

/*
============================================================
 UniTaskSystem - Stored Procedures
 ملاحظة:
 1) نفّذ هذا الملف داخل قاعدة البيانات: UniTaskSystem
 2) استخدم SSMS: افتح قاعدة البيانات ثم New Query ثم الصق الملف وشغّل.
============================================================
*/

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

/* =========================
   AUTH (تسجيل/دخول/كلمات مرور)
   ========================= */
IF OBJECT_ID(N'dbo.sp_Auth_RegisterByActivationCode', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Auth_RegisterByActivationCode AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Auth_RegisterByActivationCode
    @Code NVARCHAR(30),
    @PasswordHash VARBINARY(64),
    @PasswordSalt VARBINARY(16),
    @HashIterations INT,
    @UserId INT OUTPUT,
    @Role NVARCHAR(10) OUTPUT,
    @Identifier NVARCHAR(20) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRAN;

        DECLARE @UniStudentId NVARCHAR(20);
        DECLARE @UniTeacherId NVARCHAR(20);
        DECLARE @IsUsed BIT;

        SELECT
            @Role = Role,
            @UniStudentId = UniversityStudentId,
            @UniTeacherId = UniversityTeacherId,
            @IsUsed = IsUsed
        FROM App_ActivationCodes
        WHERE Code = @Code;

        IF @Role IS NULL
            THROW 50010, N'رمز التفعيل غير صحيح.', 1;

        IF @IsUsed = 1
            THROW 50011, N'رمز التفعيل مستخدم مسبقًا.', 1;

        SET @Identifier = CASE WHEN @Role = N'طالب' THEN @UniStudentId ELSE @UniTeacherId END;

        IF EXISTS (SELECT 1 FROM App_Users WHERE Identifier = @Identifier)
            THROW 50012, N'هذا الحساب مسجل مسبقًا.', 1;

        INSERT INTO App_Users(Role, Identifier, PasswordHash, PasswordSalt, HashIterations)
        VALUES(@Role, @Identifier, @PasswordHash, @PasswordSalt, @HashIterations);

        SET @UserId = SCOPE_IDENTITY();

        INSERT INTO App_UserLinks(UserId, UniversityStudentId, UniversityTeacherId)
        VALUES(@UserId, @UniStudentId, @UniTeacherId);

        UPDATE App_ActivationCodes
        SET IsUsed = 1,
            UsedAt = SYSDATETIME()
        WHERE Code = @Code;

        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
IF OBJECT_ID(N'dbo.sp_Auth_GetUserForLogin', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Auth_GetUserForLogin AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Auth_GetUserForLogin
    @Identifier NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT UserId, Role, Identifier, PasswordHash, PasswordSalt, HashIterations
    FROM App_Users
    WHERE Identifier = @Identifier AND IsActive = 1;
END
GO
IF OBJECT_ID(N'dbo.sp_Auth_ResetPassword', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Auth_ResetPassword AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Auth_ResetPassword
    @Identifier NVARCHAR(20),
    @ResetCode NVARCHAR(30),
    @PasswordHash VARBINARY(64),
    @PasswordSalt VARBINARY(16),
    @HashIterations INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRAN;

        IF NOT EXISTS (SELECT 1 FROM App_Users WHERE Identifier=@Identifier AND IsActive=1)
            THROW 50020, N'المعرف غير موجود.', 1;

        DECLARE @ExpiresAt DATETIME2;
        SELECT @ExpiresAt = ExpiresAt
        FROM App_PasswordResetCodes
        WHERE ResetCode=@ResetCode AND Identifier=@Identifier AND IsUsed=0;

        IF @ExpiresAt IS NULL
            THROW 50021, N'رمز إعادة التعيين غير صحيح أو مستخدم.', 1;

        IF SYSDATETIME() > @ExpiresAt
            THROW 50022, N'انتهت صلاحية رمز إعادة التعيين.', 1;

        UPDATE App_Users
        SET PasswordHash=@PasswordHash,
            PasswordSalt=@PasswordSalt,
            HashIterations=@HashIterations
        WHERE Identifier=@Identifier AND IsActive=1;

        UPDATE App_PasswordResetCodes
        SET IsUsed=1
        WHERE ResetCode=@ResetCode AND Identifier=@Identifier;

        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
IF OBJECT_ID(N'dbo.sp_Auth_CleanupResetCodes', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Auth_CleanupResetCodes AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Auth_CleanupResetCodes
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM App_PasswordResetCodes
    WHERE IsUsed = 1 OR ExpiresAt < SYSDATETIME();
END
GO
IF OBJECT_ID(N'dbo.sp_Auth_GetPasswordInfo', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Auth_GetPasswordInfo AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Auth_GetPasswordInfo
    @UserId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT PasswordHash, PasswordSalt, HashIterations
    FROM App_Users
    WHERE UserId=@UserId AND IsActive=1;
END
GO
IF OBJECT_ID(N'dbo.sp_Auth_UpdatePasswordByUserId', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Auth_UpdatePasswordByUserId AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Auth_UpdatePasswordByUserId
    @UserId INT,
    @PasswordHash VARBINARY(64),
    @PasswordSalt VARBINARY(16),
    @HashIterations INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE App_Users
    SET PasswordHash=@PasswordHash,
        PasswordSalt=@PasswordSalt,
        HashIterations=@HashIterations
    WHERE UserId=@UserId AND IsActive=1;
END
GO

/* =========================
   COMMON (مشترك)
   ========================= */
IF OBJECT_ID(N'dbo.sp_AdminNotifications_GetAll', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_AdminNotifications_GetAll AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_AdminNotifications_GetAll
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Title AS العنوان, Body AS المحتوى, CreatedAt AS التاريخ
    FROM App_AdminNotifications
    ORDER BY CreatedAt DESC;
END
GO

/* =========================
   STUDENT (الطالب)
   ========================= */
IF OBJECT_ID(N'dbo.sp_Student_GetInfo', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Student_GetInfo AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Student_GetInfo
    @StudentId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT s.UniversityStudentId, s.FullName,
           m.Name AS MajorName,
           d.Name AS DepartmentName,
           s.LevelNo,
           (tt.Name + N' - ' + CAST(tt.Year AS NVARCHAR(10))) AS TermName
    FROM Uni_Students s
    JOIN Uni_Majors m ON s.MajorId = m.MajorId
    JOIN Uni_Departments d ON m.DepartmentId = d.DepartmentId
    JOIN Uni_Terms tt ON s.CurrentTermId = tt.TermId
    WHERE s.UniversityStudentId = @StudentId;
END
GO
IF OBJECT_ID(N'dbo.sp_Student_GetUnreadDailyTasks', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Student_GetUnreadDailyTasks AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Student_GetUnreadDailyTasks
    @StudentId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        p.PostId,
        p.OfferingId,
        c.Name AS المادة,
        o.OfferingType AS النوع,
        t.FullName AS الأستاذ,
        p.Title AS العنوان,
        p.Deadline AS الموعد,
        p.CreatedAt AS تاريخ_الإرسال
    FROM App_Posts p
    JOIN Uni_Teachers t ON t.UniversityTeacherId = p.CreatedByTeacherId
    LEFT JOIN Uni_CourseOfferings o ON p.OfferingId = o.OfferingId
    LEFT JOIN Uni_Courses c ON o.CourseId = c.CourseId
    WHERE p.IsActive = 1
      AND p.PostType = N'مهمة'
      AND p.OfferingId IN (
          SELECT OfferingId
          FROM Uni_Enrollments
          WHERE UniversityStudentId = @StudentId
      )
      AND NOT EXISTS (
          SELECT 1 FROM App_PostReads r
          WHERE r.PostId = p.PostId AND r.UniversityStudentId = @StudentId
      )
    ORDER BY p.CreatedAt DESC;
END
GO
IF OBJECT_ID(N'dbo.sp_PostReads_MarkRead', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_PostReads_MarkRead AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_PostReads_MarkRead
    @PostId INT,
    @StudentId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (
        SELECT 1 FROM App_PostReads
        WHERE PostId=@PostId AND UniversityStudentId=@StudentId
    )
    BEGIN
        INSERT INTO App_PostReads(PostId, UniversityStudentId)
        VALUES(@PostId, @StudentId);
    END
END
GO
IF OBJECT_ID(N'dbo.sp_Student_GetCoursesByType', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Student_GetCoursesByType AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Student_GetCoursesByType
    @StudentId NVARCHAR(20),
    @OfferingType NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        o.OfferingId,
        c.Code,
        c.Name AS CourseName,
        o.OfferingType,
        t.FullName AS TeacherName
    FROM Uni_Enrollments e
    JOIN Uni_CourseOfferings o ON e.OfferingId = o.OfferingId
    JOIN Uni_Courses c ON o.CourseId = c.CourseId
    JOIN Uni_TeacherAssignments a ON a.OfferingId = o.OfferingId
    JOIN Uni_Teachers t ON t.UniversityTeacherId = a.UniversityTeacherId
    WHERE e.UniversityStudentId = @StudentId
      AND o.OfferingType = @OfferingType
    ORDER BY c.Name;
END
GO
IF OBJECT_ID(N'dbo.sp_Offering_GetHeaderForStudent', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Offering_GetHeaderForStudent AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Offering_GetHeaderForStudent
    @OfferingId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        c.Name AS CourseName,
        c.Code,
        o.OfferingType,
        t.FullName AS TeacherName
    FROM Uni_CourseOfferings o
    JOIN Uni_Courses c ON o.CourseId = c.CourseId
    JOIN Uni_TeacherAssignments a ON a.OfferingId = o.OfferingId
    JOIN Uni_Teachers t ON t.UniversityTeacherId = a.UniversityTeacherId
    WHERE o.OfferingId = @OfferingId;
END
GO
IF OBJECT_ID(N'dbo.sp_Posts_GetCourseTasks', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Posts_GetCourseTasks AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Posts_GetCourseTasks
    @OfferingId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.PostId,
        p.Title AS العنوان,
        p.Deadline AS الموعد,
        p.CreatedAt AS تاريخ_الإرسال
    FROM App_Posts p
    WHERE p.OfferingId = @OfferingId
      AND p.IsActive = 1
      AND p.PostType IN (N'مهمة')
    ORDER BY p.CreatedAt DESC;
END
GO
IF OBJECT_ID(N'dbo.sp_Posts_GetCourseMaterials', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Posts_GetCourseMaterials AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Posts_GetCourseMaterials
    @OfferingId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.PostId,
        p.PostType AS النوع,
        p.Title AS العنوان,
        p.CreatedAt AS تاريخ_الإرسال
    FROM App_Posts p
    WHERE p.OfferingId = @OfferingId
      AND p.IsActive = 1
      AND p.PostType IN (N'مقرر', N'نماذج')
    ORDER BY p.CreatedAt DESC;
END
GO
IF OBJECT_ID(N'dbo.sp_Posts_GetTaskDetails', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Posts_GetTaskDetails AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Posts_GetTaskDetails
    @PostId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT PostId, Title, Body, Deadline
    FROM App_Posts
    WHERE PostId=@PostId AND IsActive=1;
END
GO
IF OBJECT_ID(N'dbo.sp_Attachments_GetByPostBasic', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Attachments_GetByPostBasic AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Attachments_GetByPostBasic
    @PostId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT AttachmentId, FileName, FilePath
    FROM App_Attachments
    WHERE PostId=@PostId;
END
GO
IF OBJECT_ID(N'dbo.sp_Attachments_GetByPostDetails', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Attachments_GetByPostDetails AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Attachments_GetByPostDetails
    @PostId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT AttachmentId, FileName, FilePath, MimeType, FileSizeBytes, UploadedAt
    FROM App_Attachments
    WHERE PostId=@PostId
    ORDER BY AttachmentId DESC;
END
GO
IF OBJECT_ID(N'dbo.sp_Submissions_SubmitAnswer', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Submissions_SubmitAnswer AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Submissions_SubmitAnswer
    @PostId INT,
    @StudentId NVARCHAR(20),
    @TextAnswer NVARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Deadline DATETIME2;
    SELECT @Deadline = Deadline FROM App_Posts WHERE PostId=@PostId;

    IF @Deadline IS NOT NULL AND SYSDATETIME() > @Deadline
        THROW 50030, N'انتهى وقت التسليم، لا يمكن الإرسال بعد الموعد النهائي.', 1;

    IF EXISTS (SELECT 1 FROM App_Submissions WHERE PostId=@PostId AND UniversityStudentId=@StudentId)
    BEGIN
        UPDATE App_Submissions
        SET TextAnswer=@TextAnswer, SubmittedAt=SYSDATETIME()
        WHERE PostId=@PostId AND UniversityStudentId=@StudentId;

        SELECT SubmissionId
        FROM App_Submissions
        WHERE PostId=@PostId AND UniversityStudentId=@StudentId;
        RETURN;
    END

    INSERT INTO App_Submissions(PostId, UniversityStudentId, TextAnswer)
    OUTPUT INSERTED.SubmissionId
    VALUES(@PostId, @StudentId, @TextAnswer);
END
GO
IF OBJECT_ID(N'dbo.sp_SubmissionAttachments_Insert', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_SubmissionAttachments_Insert AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_SubmissionAttachments_Insert
    @SubmissionId INT,
    @FileName NVARCHAR(255),
    @FilePath NVARCHAR(600),
    @MimeType NVARCHAR(100) = NULL,
    @FileSizeBytes BIGINT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO App_SubmissionAttachments(SubmissionId, FileName, FilePath, MimeType, FileSizeBytes)
    VALUES(@SubmissionId, @FileName, @FilePath, @MimeType, @FileSizeBytes);
END
GO
IF OBJECT_ID(N'dbo.sp_Submissions_GetStudentSubmission', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Submissions_GetStudentSubmission AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Submissions_GetStudentSubmission
    @PostId INT,
    @StudentId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP 1 s.SubmissionId, s.TextAnswer, s.SubmittedAt
    FROM App_Submissions s
    WHERE s.PostId = @PostId AND s.UniversityStudentId = @StudentId
    ORDER BY s.SubmittedAt DESC;
END
GO
IF OBJECT_ID(N'dbo.sp_SubmissionAttachments_GetBySubmission', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_SubmissionAttachments_GetBySubmission AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_SubmissionAttachments_GetBySubmission
    @SubmissionId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT SubmissionAttachmentId, FileName, FilePath, MimeType, FileSizeBytes, UploadedAt
    FROM App_SubmissionAttachments
    WHERE SubmissionId = @SubmissionId
    ORDER BY SubmissionAttachmentId DESC;
END
GO
IF OBJECT_ID(N'dbo.sp_Student_GetTermWork', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Student_GetTermWork AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Student_GetTermWork
    @StudentId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        o.OfferingId,
        c.Name AS المادة,
        o.OfferingType AS النوع,

        ISNULL(ts.AttendanceScore, 0) AS الحضور,
        ISNULL(tasks.TasksScore, 0) AS التكاليف,
        ISNULL(ts.MidtermScore, 0) AS النصفي,
        ISNULL(ts.FinalScore, 0) AS النهائي,

        (ISNULL(ts.AttendanceScore,0) + ISNULL(tasks.TasksScore,0) + ISNULL(ts.MidtermScore,0) + ISNULL(ts.FinalScore,0)) AS المجموع
    FROM Uni_Enrollments e
    JOIN Uni_CourseOfferings o ON e.OfferingId = o.OfferingId
    JOIN Uni_Courses c ON o.CourseId = c.CourseId

    LEFT JOIN App_TermScores ts
        ON ts.UniversityStudentId = e.UniversityStudentId
       AND ts.OfferingId = e.OfferingId

    OUTER APPLY (
        SELECT SUM(g.Score) AS TasksScore
        FROM App_Submissions s
        JOIN App_Posts p ON p.PostId = s.PostId
        JOIN App_Grades g ON g.SubmissionId = s.SubmissionId
        WHERE s.UniversityStudentId = @StudentId
          AND p.OfferingId = o.OfferingId
          AND p.PostType = N'مهمة'
          AND p.IsActive = 1
    ) tasks

    WHERE e.UniversityStudentId = @StudentId
    ORDER BY c.Name, o.OfferingType;
END
GO
IF OBJECT_ID(N'dbo.sp_LecturePlan_GetForStudent', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_LecturePlan_GetForStudent AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_LecturePlan_GetForStudent
    @OfferingId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        LectureNo AS رقم,
        Title AS عنوان,
        Content AS محتوى,
        IsExtra AS إضافية,
        IsCovered AS تم_شرحها,
        CoveredAt AS وقت_الشرح
    FROM Uni_LecturePlan
    WHERE OfferingId = @OfferingId
    ORDER BY IsExtra, LectureNo;
END
GO
IF OBJECT_ID(N'dbo.sp_LecturePlan_GetStats', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_LecturePlan_GetStats AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_LecturePlan_GetStats
    @OfferingId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        SUM(CASE WHEN IsExtra=0 THEN 1 ELSE 0 END) AS PlannedTotal,
        SUM(CASE WHEN IsExtra=0 AND IsCovered=1 THEN 1 ELSE 0 END) AS PlannedCovered,
        SUM(CASE WHEN IsExtra=1 THEN 1 ELSE 0 END) AS ExtraTotal
    FROM Uni_LecturePlan
    WHERE OfferingId=@OfferingId;
END
GO
IF OBJECT_ID(N'dbo.sp_Student_GetWeeklyAchievements', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Student_GetWeeklyAchievements AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Student_GetWeeklyAchievements
    @StudentId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @fromDate DATETIME2 = DATEADD(DAY, -6, CAST(SYSDATETIME() AS DATE));
    DECLARE @toDate   DATETIME2 = DATEADD(DAY,  1, CAST(SYSDATETIME() AS DATE));

    SELECT
        p.PostId,
        p.OfferingId,
        c.Name AS المادة,
        o.OfferingType AS النوع,
        p.Title AS المهمة,
        p.CreatedAt AS تاريخ_الإرسال,
        p.Deadline AS الموعد,

        s.SubmissionId,
        s.SubmittedAt AS وقت_التسليم,

        g.Score AS الدرجة,

        CASE
            WHEN s.SubmissionId IS NULL THEN N'لم يسلّم'
            WHEN g.Score IS NULL THEN N'بانتظار التصحيح'
            ELSE N'مكتملة'
        END AS الحالة,

        CASE WHEN g.Score IS NOT NULL THEN 1 ELSE 0 END AS مكتملة_رقم
    FROM App_Posts p
    JOIN Uni_CourseOfferings o ON o.OfferingId = p.OfferingId
    JOIN Uni_Courses c ON c.CourseId = o.CourseId
    JOIN Uni_Enrollments e ON e.OfferingId = p.OfferingId AND e.UniversityStudentId = @StudentId

    LEFT JOIN App_Submissions s
           ON s.PostId = p.PostId AND s.UniversityStudentId = @StudentId
    LEFT JOIN App_Grades g
           ON g.SubmissionId = s.SubmissionId

    WHERE p.PostType = N'مهمة'
      AND p.IsActive = 1
      AND p.CreatedAt >= @fromDate
      AND p.CreatedAt <  @toDate

    ORDER BY p.CreatedAt DESC;
END
GO
IF OBJECT_ID(N'dbo.sp_Posts_GetSyllabusPosts', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Posts_GetSyllabusPosts AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Posts_GetSyllabusPosts
    @OfferingId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT p.PostId, p.Title AS العنوان, p.Body AS المحتوى, p.CreatedAt AS التاريخ
    FROM App_Posts p
    WHERE p.OfferingId = @OfferingId
      AND p.IsActive = 1
      AND p.PostType = N'مقرر'
    ORDER BY p.CreatedAt DESC;
END
GO
IF OBJECT_ID(N'dbo.sp_Posts_GetModelPosts', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Posts_GetModelPosts AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Posts_GetModelPosts
    @OfferingId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT p.PostId, p.Title AS العنوان, p.Body AS المحتوى, p.CreatedAt AS التاريخ
    FROM App_Posts p
    WHERE p.OfferingId = @OfferingId
      AND p.IsActive = 1
      AND p.PostType = N'نماذج'
    ORDER BY p.CreatedAt DESC;
END
GO

/* =========================
   TEACHER (الأستاذ)
   ========================= */
IF OBJECT_ID(N'dbo.sp_Teacher_GetInfo', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Teacher_GetInfo AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Teacher_GetInfo
    @TeacherId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT UniversityTeacherId, FullName
    FROM Uni_Teachers
    WHERE UniversityTeacherId=@TeacherId;
END
GO
IF OBJECT_ID(N'dbo.sp_Teacher_GetOfferings', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Teacher_GetOfferings AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Teacher_GetOfferings
    @TeacherId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        o.OfferingId,
        c.Code,
        c.Name AS CourseName,
        o.OfferingType
    FROM Uni_TeacherAssignments a
    JOIN Uni_CourseOfferings o ON a.OfferingId = o.OfferingId
    JOIN Uni_Courses c ON o.CourseId = c.CourseId
    WHERE a.UniversityTeacherId = @TeacherId
    ORDER BY c.Name;
END
GO
IF OBJECT_ID(N'dbo.sp_Offering_GetHeaderForTeacher', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Offering_GetHeaderForTeacher AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Offering_GetHeaderForTeacher
    @OfferingId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT c.Name AS CourseName, c.Code, o.OfferingType
    FROM Uni_CourseOfferings o
    JOIN Uni_Courses c ON o.CourseId = c.CourseId
    WHERE o.OfferingId = @OfferingId;
END
GO
IF OBJECT_ID(N'dbo.sp_Posts_Create', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Posts_Create AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Posts_Create
    @OfferingId INT,
    @PostType NVARCHAR(20),
    @Title NVARCHAR(200),
    @Body NVARCHAR(MAX) = NULL,
    @Deadline DATETIME2 = NULL,
    @TeacherId NVARCHAR(20),
    @PostId INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO App_Posts(OfferingId, PostType, Title, Body, Deadline, CreatedByTeacherId)
    VALUES(@OfferingId, @PostType, @Title, @Body, @Deadline, @TeacherId);

    SET @PostId = SCOPE_IDENTITY();
END
GO
IF OBJECT_ID(N'dbo.sp_Attachments_Insert', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Attachments_Insert AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Attachments_Insert
    @PostId INT,
    @FileName NVARCHAR(255),
    @FilePath NVARCHAR(600),
    @MimeType NVARCHAR(100) = NULL,
    @FileSizeBytes BIGINT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO App_Attachments(PostId, FileName, FilePath, MimeType, FileSizeBytes)
    VALUES(@PostId, @FileName, @FilePath, @MimeType, @FileSizeBytes);
END
GO
IF OBJECT_ID(N'dbo.sp_Posts_GetTasksForOffering', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Posts_GetTasksForOffering AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Posts_GetTasksForOffering
    @OfferingId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT PostId, Title
    FROM App_Posts
    WHERE OfferingId=@OfferingId AND PostType=N'مهمة' AND IsActive=1
    ORDER BY CreatedAt DESC;
END
GO
IF OBJECT_ID(N'dbo.sp_Submissions_GetForPost', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Submissions_GetForPost AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Submissions_GetForPost
    @PostId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        s.SubmissionId,
        st.UniversityStudentId AS الرقم_الجامعي,
        st.FullName AS اسم_الطالب,
        s.SubmittedAt AS وقت_الإرسال
    FROM App_Submissions s
    JOIN Uni_Students st ON s.UniversityStudentId = st.UniversityStudentId
    WHERE s.PostId=@PostId
    ORDER BY s.SubmittedAt DESC;
END
GO
IF OBJECT_ID(N'dbo.sp_Submissions_GetDetails', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Submissions_GetDetails AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Submissions_GetDetails
    @SubmissionId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT s.SubmissionId, s.TextAnswer, s.SubmittedAt,
           st.UniversityStudentId, st.FullName
    FROM App_Submissions s
    JOIN Uni_Students st ON s.UniversityStudentId = st.UniversityStudentId
    WHERE s.SubmissionId=@SubmissionId;
END
GO
IF OBJECT_ID(N'dbo.sp_SubmissionAttachments_GetBasic', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_SubmissionAttachments_GetBasic AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_SubmissionAttachments_GetBasic
    @SubmissionId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT SubmissionAttachmentId, FileName, FilePath
    FROM App_SubmissionAttachments
    WHERE SubmissionId=@SubmissionId
    ORDER BY SubmissionAttachmentId DESC;
END
GO
IF OBJECT_ID(N'dbo.sp_Grades_Upsert', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Grades_Upsert AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Grades_Upsert
    @SubmissionId INT,
    @Score DECIMAL(5,2),
    @Feedback NVARCHAR(MAX) = NULL,
    @TeacherId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM App_Grades WHERE SubmissionId=@SubmissionId)
    BEGIN
        UPDATE App_Grades
        SET Score=@Score, Feedback=@Feedback, GradedByTeacherId=@TeacherId, GradedAt=SYSDATETIME()
        WHERE SubmissionId=@SubmissionId;
    END
    ELSE
    BEGIN
        INSERT INTO App_Grades(SubmissionId, Score, Feedback, GradedByTeacherId)
        VALUES(@SubmissionId, @Score, @Feedback, @TeacherId);
    END
END
GO
IF OBJECT_ID(N'dbo.sp_Grades_GetExisting', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Grades_GetExisting AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Grades_GetExisting
    @SubmissionId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Score, Feedback
    FROM App_Grades
    WHERE SubmissionId=@SubmissionId;
END
GO
IF OBJECT_ID(N'dbo.sp_Teacher_GetGradeSheet', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Teacher_GetGradeSheet AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Teacher_GetGradeSheet
    @OfferingId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        e.UniversityStudentId AS الرقم_الجامعي,
        st.FullName AS اسم_الطالب,

        o.MaxTotalScore AS السقف,

        ISNULL(ts.AttendanceScore, 0) AS الحضور,
        ISNULL(tasks.TasksScore, 0) AS التكاليف,
        ISNULL(ts.MidtermScore, 0) AS النصفي,
        ISNULL(ts.FinalScore, 0) AS النهائي,

        (ISNULL(ts.AttendanceScore,0) + ISNULL(tasks.TasksScore,0) + ISNULL(ts.MidtermScore,0) + ISNULL(ts.FinalScore,0)) AS المجموع
    FROM Uni_Enrollments e
    JOIN Uni_Students st ON st.UniversityStudentId = e.UniversityStudentId
    JOIN Uni_CourseOfferings o ON o.OfferingId = e.OfferingId

    LEFT JOIN App_TermScores ts
        ON ts.UniversityStudentId = e.UniversityStudentId
       AND ts.OfferingId = e.OfferingId

    OUTER APPLY (
        SELECT SUM(g.Score) AS TasksScore
        FROM App_Submissions s
        JOIN App_Posts p ON p.PostId = s.PostId
        JOIN App_Grades g ON g.SubmissionId = s.SubmissionId
        WHERE s.UniversityStudentId = e.UniversityStudentId
          AND p.OfferingId = e.OfferingId
          AND p.PostType = N'مهمة'
          AND p.IsActive = 1
    ) tasks

    WHERE e.OfferingId = @OfferingId
    ORDER BY st.FullName;
END
GO
IF OBJECT_ID(N'dbo.sp_TermScores_Upsert', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_TermScores_Upsert AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_TermScores_Upsert
    @StudentId NVARCHAR(20),
    @OfferingId INT,
    @Attendance DECIMAL(5,2),
    @Midterm DECIMAL(5,2),
    @FinalScore DECIMAL(5,2)
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM App_TermScores WHERE UniversityStudentId=@StudentId AND OfferingId=@OfferingId)
    BEGIN
        UPDATE App_TermScores
        SET AttendanceScore=@Attendance,
            MidtermScore=@Midterm,
            FinalScore=@FinalScore,
            UpdatedAt=SYSDATETIME()
        WHERE UniversityStudentId=@StudentId AND OfferingId=@OfferingId;
    END
    ELSE
    BEGIN
        INSERT INTO App_TermScores(UniversityStudentId, OfferingId, AttendanceScore, MidtermScore, FinalScore)
        VALUES(@StudentId, @OfferingId, @Attendance, @Midterm, @FinalScore);
    END
END
GO
IF OBJECT_ID(N'dbo.sp_Teacher_GetStudentTasksInOffering', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_Teacher_GetStudentTasksInOffering AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_Teacher_GetStudentTasksInOffering
    @OfferingId INT,
    @StudentId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        p.PostId,
        p.Title AS المهمة,
        p.Deadline AS الموعد,

        s.SubmissionId,
        s.SubmittedAt AS وقت_الإرسال,

        g.Score AS الدرجة
    FROM App_Posts p
    LEFT JOIN App_Submissions s
           ON s.PostId = p.PostId
          AND s.UniversityStudentId = @StudentId
    LEFT JOIN App_Grades g
           ON g.SubmissionId = s.SubmissionId
    WHERE p.OfferingId = @OfferingId
      AND p.PostType = N'مهمة'
      AND p.IsActive = 1
    ORDER BY p.CreatedAt DESC;
END
GO
IF OBJECT_ID(N'dbo.sp_LecturePlan_GetForTeacher', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_LecturePlan_GetForTeacher AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_LecturePlan_GetForTeacher
    @OfferingId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        PlanLectureId,
        LectureNo AS رقم,
        Title AS عنوان,
        Content AS محتوى,
        IsExtra AS إضافية,
        IsCovered AS تم_شرحها,
        CoveredAt AS وقت_الشرح
    FROM Uni_LecturePlan
    WHERE OfferingId = @OfferingId
    ORDER BY IsExtra, LectureNo;
END
GO
IF OBJECT_ID(N'dbo.sp_LecturePlan_SetCovered', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_LecturePlan_SetCovered AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_LecturePlan_SetCovered
    @PlanLectureId INT,
    @IsCovered BIT,
    @TeacherId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Uni_LecturePlan
    SET IsCovered = @IsCovered,
        CoveredAt = CASE WHEN @IsCovered=1 THEN SYSDATETIME() ELSE NULL END,
        CoveredByTeacherId = CASE WHEN @IsCovered=1 THEN @TeacherId ELSE NULL END
    WHERE PlanLectureId = @PlanLectureId;
END
GO
IF OBJECT_ID(N'dbo.sp_LecturePlan_AddExtra', N'P') IS NULL
    EXEC(N'CREATE PROCEDURE dbo.sp_LecturePlan_AddExtra AS BEGIN SET NOCOUNT ON; END');
GO
ALTER PROCEDURE dbo.sp_LecturePlan_AddExtra
    @OfferingId INT,
    @Title NVARCHAR(200),
    @Content NVARCHAR(MAX) = NULL,
    @TeacherId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NextNo INT;
    SELECT @NextNo = ISNULL(MAX(LectureNo),0) + 1
    FROM Uni_LecturePlan
    WHERE OfferingId=@OfferingId;

    INSERT INTO Uni_LecturePlan(OfferingId, LectureNo, Title, Content, IsExtra, IsCovered, CoveredAt, CoveredByTeacherId)
    VALUES(@OfferingId, @NextNo, @Title, @Content, 1, 1, SYSDATETIME(), @TeacherId);
END
GO

CREATE DATABASE UniTaskSystem;
GO
USE UniTaskSystem;
GO

/* =============== 1) جداول “بيانات الجامعة الرسمية” (تُعبّأ مباشرة من الإدارة) =============== */

CREATE TABLE Uni_Departments (
    DepartmentId INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);

CREATE TABLE Uni_Majors (
    MajorId INT IDENTITY PRIMARY KEY,
    DepartmentId INT NOT NULL,
    Name NVARCHAR(100) NOT NULL,
    CONSTRAINT FK_Uni_Majors_Departments FOREIGN KEY (DepartmentId) REFERENCES Uni_Departments(DepartmentId)
);

CREATE TABLE Uni_Terms (
    TermId INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,         -- مثلا: "ترم 1"
    Year INT NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1
);

CREATE TABLE Uni_Students (
    UniversityStudentId NVARCHAR(20) PRIMARY KEY,  -- الرقم الجامعي
    FullName NVARCHAR(150) NOT NULL,
    MajorId INT NOT NULL,
    LevelNo INT NOT NULL,                 -- المستوى
    CurrentTermId INT NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    CONSTRAINT FK_Uni_Students_Majors FOREIGN KEY (MajorId) REFERENCES Uni_Majors(MajorId),
    CONSTRAINT FK_Uni_Students_Terms FOREIGN KEY (CurrentTermId) REFERENCES Uni_Terms(TermId)
);

CREATE TABLE Uni_Teachers (
    UniversityTeacherId NVARCHAR(20) PRIMARY KEY,  -- رقم وظيفي/اسم مستخدم رسمي
    FullName NVARCHAR(150) NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1
);

CREATE TABLE Uni_Courses (
    CourseId INT IDENTITY PRIMARY KEY,
    Code NVARCHAR(20) NOT NULL UNIQUE,
    Name NVARCHAR(150) NOT NULL,
    HasPractical BIT NOT NULL DEFAULT 0   -- هل للمادة عملي؟
);

-- طرح المادة في ترم معين + نوعها (نظري/عملي)
CREATE TABLE Uni_CourseOfferings (
    OfferingId INT IDENTITY PRIMARY KEY,
    TermId INT NOT NULL,
    CourseId INT NOT NULL,
    OfferingType NVARCHAR(10) NOT NULL CHECK (OfferingType IN (N'نظري', N'عملي')),
    MaxTotalScore INT NOT NULL, -- 100 أو 70 أو 30 حسب الحالة
    CONSTRAINT FK_Offerings_Terms FOREIGN KEY (TermId) REFERENCES Uni_Terms(TermId),
    CONSTRAINT FK_Offerings_Courses FOREIGN KEY (CourseId) REFERENCES Uni_Courses(CourseId),
    CONSTRAINT UQ_Offering UNIQUE (TermId, CourseId, OfferingType)
);

-- ربط المدرس بالمادة (نظري مدرس + عملي مدرس)
CREATE TABLE Uni_TeacherAssignments (
    AssignmentId INT IDENTITY PRIMARY KEY,
    OfferingId INT NOT NULL,
    UniversityTeacherId NVARCHAR(20) NOT NULL,
    CONSTRAINT FK_Assign_Offerings FOREIGN KEY (OfferingId) REFERENCES Uni_CourseOfferings(OfferingId),
    CONSTRAINT FK_Assign_Teachers FOREIGN KEY (UniversityTeacherId) REFERENCES Uni_Teachers(UniversityTeacherId),
    CONSTRAINT UQ_Assignment UNIQUE (OfferingId, UniversityTeacherId)
);

-- تسجيل الطالب في عروض المواد حسب ترمه/تخصصه (الإدارة تُعبئها أو تُولد حسب منطق الجامعة)
CREATE TABLE Uni_Enrollments (
    EnrollmentId INT IDENTITY PRIMARY KEY,
    UniversityStudentId NVARCHAR(20) NOT NULL,
    OfferingId INT NOT NULL,
    CONSTRAINT FK_Enroll_Students FOREIGN KEY (UniversityStudentId) REFERENCES Uni_Students(UniversityStudentId),
    CONSTRAINT FK_Enroll_Offerings FOREIGN KEY (OfferingId) REFERENCES Uni_CourseOfferings(OfferingId),
    CONSTRAINT UQ_Enroll UNIQUE (UniversityStudentId, OfferingId)
);

-- خطة المادة (محاضرات) تُضاف من الإدارة لكل Offering

 CREATE TABLE dbo.Uni_LecturePlan
    (
        PlanLectureId INT IDENTITY(1,1) PRIMARY KEY,
        OfferingId INT NOT NULL,
        LectureNo INT NOT NULL,
        Title NVARCHAR(200) NOT NULL,
        Content NVARCHAR(MAX) NULL,

        IsExtra BIT NOT NULL DEFAULT 0,      -- محاضرة إضافية يضيفها الأستاذ
        IsCovered BIT NOT NULL DEFAULT 0,    -- تم شرحها؟
        CoveredAt DATETIME NULL,
        CoveredByTeacherId NVARCHAR(50) NULL,

        CONSTRAINT FK_Uni_LecturePlan_Offering
            FOREIGN KEY (OfferingId) REFERENCES dbo.Uni_CourseOfferings(OfferingId)
    );

/* =============== 2) الحسابات داخل النظام (Users) =============== */

CREATE TABLE App_Users (
    UserId INT IDENTITY PRIMARY KEY,
    Role NVARCHAR(10) NOT NULL CHECK (Role IN (N'طالب', N'أستاذ')),
    -- Identifier: للطالب = الرقم الجامعي، للأستاذ = UniversityTeacherId
    Identifier NVARCHAR(20) NOT NULL UNIQUE,
    PasswordHash VARBINARY(64) NOT NULL,
    PasswordSalt VARBINARY(16) NOT NULL,
    HashIterations INT NOT NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    IsActive BIT NOT NULL DEFAULT 1
);

-- ربط الحساب ببيانات الجامعة
CREATE TABLE App_UserLinks (
    UserId INT PRIMARY KEY,
    UniversityStudentId NVARCHAR(20) NULL,
    UniversityTeacherId NVARCHAR(20) NULL,
    CONSTRAINT FK_Link_User FOREIGN KEY (UserId) REFERENCES App_Users(UserId),
    CONSTRAINT FK_Link_Student FOREIGN KEY (UniversityStudentId) REFERENCES Uni_Students(UniversityStudentId),
    CONSTRAINT FK_Link_Teacher FOREIGN KEY (UniversityTeacherId) REFERENCES Uni_Teachers(UniversityTeacherId),
    CONSTRAINT CK_Link_OnlyOne CHECK (
        (UniversityStudentId IS NOT NULL AND UniversityTeacherId IS NULL)
        OR
        (UniversityStudentId IS NULL AND UniversityTeacherId IS NOT NULL)
    )
);

-- رمز تفعيل (مرة واحدة) يحدد الدور ويرتبط بالطالب (حسب طلبك) + ويمكن أيضًا للأستاذ
CREATE TABLE App_ActivationCodes (
    Code NVARCHAR(30) PRIMARY KEY,
    Role NVARCHAR(10) NOT NULL CHECK (Role IN (N'طالب', N'أستاذ')),
    UniversityStudentId NVARCHAR(20) NULL,
    UniversityTeacherId NVARCHAR(20) NULL,
    IsUsed BIT NOT NULL DEFAULT 0,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    UsedAt DATETIME2 NULL,
    CONSTRAINT FK_Act_Student FOREIGN KEY (UniversityStudentId) REFERENCES Uni_Students(UniversityStudentId),
    CONSTRAINT FK_Act_Teacher FOREIGN KEY (UniversityTeacherId) REFERENCES Uni_Teachers(UniversityTeacherId),
    CONSTRAINT CK_Act_OnlyOne CHECK (
        (UniversityStudentId IS NOT NULL AND UniversityTeacherId IS NULL AND Role=N'طالب')
        OR
        (UniversityStudentId IS NULL AND UniversityTeacherId IS NOT NULL AND Role=N'أستاذ')
    )
);

-- أكواد استرجاع كلمة المرور (تُضاف من الإدارة مباشرة للقاعدة)
CREATE TABLE App_PasswordResetCodes (
    ResetCode NVARCHAR(30) PRIMARY KEY,
    Identifier NVARCHAR(20) NOT NULL,
    IsUsed BIT NOT NULL DEFAULT 0,
    ExpiresAt DATETIME2 NOT NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME()
);

/* =============== 3) الإشعارات (من الإدارة) =============== */

CREATE TABLE App_AdminNotifications (
    NotificationId INT IDENTITY PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    Body NVARCHAR(MAX) NOT NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    IsActive BIT NOT NULL DEFAULT 1
);

/* =============== 4) محتوى الأستاذ للطلاب: مهام/مقرر/نماذج/مهام يومية =============== */

CREATE TABLE App_Posts (
    PostId INT IDENTITY PRIMARY KEY,
    OfferingId INT NULL, -- NULL للمهام اليومية العامة، وغير NULL لمحتوى مادة
    PostType NVARCHAR(20) NOT NULL CHECK (PostType IN (N'مهمة يومية', N'مهمة', N'مقرر', N'نماذج')),
    Title NVARCHAR(200) NOT NULL,
    Body NVARCHAR(MAX) NULL,
    Deadline DATETIME2 NULL, -- للمهمات فقط
    CreatedByTeacherId NVARCHAR(20) NOT NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    IsActive BIT NOT NULL DEFAULT 1,
    CONSTRAINT FK_Post_Offering FOREIGN KEY (OfferingId) REFERENCES Uni_CourseOfferings(OfferingId),
    CONSTRAINT FK_Post_Teacher FOREIGN KEY (CreatedByTeacherId) REFERENCES Uni_Teachers(UniversityTeacherId)
);

-- مرفقات (مسارات ملفات)
CREATE TABLE App_Attachments (
    AttachmentId INT IDENTITY PRIMARY KEY,
    PostId INT NOT NULL,
    FileName NVARCHAR(255) NOT NULL,
    FilePath NVARCHAR(600) NOT NULL,
    MimeType NVARCHAR(100) NULL,
    FileSizeBytes BIGINT NULL,
    UploadedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT FK_Att_Post FOREIGN KEY (PostId) REFERENCES App_Posts(PostId)
);

-- قراءة الطالب للمهام اليومية (لتختفي من الرئيسية بعد الفتح)
CREATE TABLE App_PostReads (
    PostId INT NOT NULL,
    UniversityStudentId NVARCHAR(20) NOT NULL,
    ReadAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT PK_PostReads PRIMARY KEY (PostId, UniversityStudentId),
    CONSTRAINT FK_Read_Post FOREIGN KEY (PostId) REFERENCES App_Posts(PostId),
    CONSTRAINT FK_Read_Student FOREIGN KEY (UniversityStudentId) REFERENCES Uni_Students(UniversityStudentId)
);

/* =============== 5) تسليمات الطلاب + التصحيح + الدرجات =============== */

CREATE TABLE App_Submissions (
    SubmissionId INT IDENTITY PRIMARY KEY,
    PostId INT NOT NULL, -- يجب أن يكون نوعه "مهمة" أو "مهمة يومية"
    UniversityStudentId NVARCHAR(20) NOT NULL,
    TextAnswer NVARCHAR(MAX) NULL,
    SubmittedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    -- لا متأخر: سنمنع الإرسال برمجيا + ممكن بقيود/Trigger لاحقًا إن رغبت
    CONSTRAINT FK_Sub_Post FOREIGN KEY (PostId) REFERENCES App_Posts(PostId),
    CONSTRAINT FK_Sub_Student FOREIGN KEY (UniversityStudentId) REFERENCES Uni_Students(UniversityStudentId),
    CONSTRAINT UQ_Sub UNIQUE (PostId, UniversityStudentId)
);

CREATE TABLE App_SubmissionAttachments (
    SubmissionAttachmentId INT IDENTITY PRIMARY KEY,
    SubmissionId INT NOT NULL,
    FileName NVARCHAR(255) NOT NULL,
    FilePath NVARCHAR(600) NOT NULL,
    MimeType NVARCHAR(100) NULL,
    FileSizeBytes BIGINT NULL,
    UploadedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT FK_SubAtt_Sub FOREIGN KEY (SubmissionId) REFERENCES App_Submissions(SubmissionId)
);

CREATE TABLE App_Grades (
    GradeId INT IDENTITY PRIMARY KEY,
    SubmissionId INT NOT NULL UNIQUE,
    Score DECIMAL(5,2) NOT NULL,
    Feedback NVARCHAR(MAX) NULL,
    GradedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    GradedByTeacherId NVARCHAR(20) NOT NULL,
    CONSTRAINT FK_Grade_Sub FOREIGN KEY (SubmissionId) REFERENCES App_Submissions(SubmissionId),
    CONSTRAINT FK_Grade_Teacher FOREIGN KEY (GradedByTeacherId) REFERENCES Uni_Teachers(UniversityTeacherId)
);

-- درجات أعمال الفصل (حضور/نصفي/نهائي) لكل طالب في Offering
CREATE TABLE App_TermScores (
    UniversityStudentId NVARCHAR(20) NOT NULL,
    OfferingId INT NOT NULL,
    AttendanceScore DECIMAL(5,2) NULL,
    MidtermScore DECIMAL(5,2) NULL,
    FinalScore DECIMAL(5,2) NULL,
    UpdatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT PK_TermScores PRIMARY KEY (UniversityStudentId, OfferingId),
    CONSTRAINT FK_TS_Student FOREIGN KEY (UniversityStudentId) REFERENCES Uni_Students(UniversityStudentId),
    CONSTRAINT FK_TS_Offering FOREIGN KEY (OfferingId) REFERENCES Uni_CourseOfferings(OfferingId)
);

-- تخصيص توزيع الدرجات لكل Offering (المدرس يحددها)
CREATE TABLE App_OfferingWeights (
    OfferingId INT PRIMARY KEY,
    AttendanceMax DECIMAL(5,2) NOT NULL,
    TasksMax DECIMAL(5,2) NOT NULL,
    MidtermMax DECIMAL(5,2) NOT NULL,
    FinalMax DECIMAL(5,2) NOT NULL,
    CONSTRAINT FK_W_Offering FOREIGN KEY (OfferingId) REFERENCES Uni_CourseOfferings(OfferingId),
    CONSTRAINT CK_Weights_Positive CHECK (
        AttendanceMax >= 0 AND TasksMax >= 0 AND MidtermMax >= 0 AND FinalMax >= 0
    )
);

GO

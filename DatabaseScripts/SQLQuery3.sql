USE UniTaskSystem;
GO

/* 1) تأكد من وجود الترم المستخدم للطالب */
DECLARE @TermId INT = (SELECT TOP 1 CurrentTermId FROM Uni_Students WHERE UniversityStudentId = N'20250001');
IF @TermId IS NULL
BEGIN
    RAISERROR(N'الطالب 20250001 غير موجود في Uni_Students', 16, 1);
    RETURN;
END

/* 2) تأكد من وجود أساتذة إضافيين (للتطابق مع شرط نظري/عملي مدرسين مختلفين) */
IF NOT EXISTS (SELECT 1 FROM Uni_Teachers WHERE UniversityTeacherId=N'T200')
    INSERT INTO Uni_Teachers(UniversityTeacherId, FullName, IsActive) VALUES (N'T200', N'م. ناصر', 1);

IF NOT EXISTS (SELECT 1 FROM Uni_Teachers WHERE UniversityTeacherId=N'T300')
    INSERT INTO Uni_Teachers(UniversityTeacherId, FullName, IsActive) VALUES (N'T300', N'د. فاطمة', 1);

/* 3) إضافة مواد */
IF NOT EXISTS (SELECT 1 FROM Uni_Courses WHERE Code=N'CS101')
    INSERT INTO Uni_Courses(Code, Name, HasPractical) VALUES (N'CS101', N'برمجة 1', 1);

IF NOT EXISTS (SELECT 1 FROM Uni_Courses WHERE Code=N'DB201')
    INSERT INTO Uni_Courses(Code, Name, HasPractical) VALUES (N'DB201', N'قواعد البيانات', 0);

DECLARE @C_CS101 INT = (SELECT CourseId FROM Uni_Courses WHERE Code=N'CS101');
DECLARE @C_DB201 INT = (SELECT CourseId FROM Uni_Courses WHERE Code=N'DB201');

/* 4) طرح المواد في الترم (Offerings) */
-- برمجة 1: نظري 70 + عملي 30
IF NOT EXISTS (SELECT 1 FROM Uni_CourseOfferings WHERE TermId=@TermId AND CourseId=@C_CS101 AND OfferingType=N'نظري')
    INSERT INTO Uni_CourseOfferings(TermId, CourseId, OfferingType, MaxTotalScore) VALUES (@TermId, @C_CS101, N'نظري', 70);

IF NOT EXISTS (SELECT 1 FROM Uni_CourseOfferings WHERE TermId=@TermId AND CourseId=@C_CS101 AND OfferingType=N'عملي')
    INSERT INTO Uni_CourseOfferings(TermId, CourseId, OfferingType, MaxTotalScore) VALUES (@TermId, @C_CS101, N'عملي', 30);

-- قواعد البيانات: نظري 100
IF NOT EXISTS (SELECT 1 FROM Uni_CourseOfferings WHERE TermId=@TermId AND CourseId=@C_DB201 AND OfferingType=N'نظري')
    INSERT INTO Uni_CourseOfferings(TermId, CourseId, OfferingType, MaxTotalScore) VALUES (@TermId, @C_DB201, N'نظري', 100);

DECLARE @Off_CS101_Theo INT = (SELECT OfferingId FROM Uni_CourseOfferings WHERE TermId=@TermId AND CourseId=@C_CS101 AND OfferingType=N'نظري');
DECLARE @Off_CS101_Prac INT = (SELECT OfferingId FROM Uni_CourseOfferings WHERE TermId=@TermId AND CourseId=@C_CS101 AND OfferingType=N'عملي');
DECLARE @Off_DB201_Theo INT = (SELECT OfferingId FROM Uni_CourseOfferings WHERE TermId=@TermId AND CourseId=@C_DB201 AND OfferingType=N'نظري');

/* 5) ربط المدرسين بالمادة (TeacherAssignments) */
IF NOT EXISTS (SELECT 1 FROM Uni_TeacherAssignments WHERE OfferingId=@Off_CS101_Theo AND UniversityTeacherId=N'T100')
    INSERT INTO Uni_TeacherAssignments(OfferingId, UniversityTeacherId) VALUES (@Off_CS101_Theo, N'T100');

IF NOT EXISTS (SELECT 1 FROM Uni_TeacherAssignments WHERE OfferingId=@Off_CS101_Prac AND UniversityTeacherId=N'T200')
    INSERT INTO Uni_TeacherAssignments(OfferingId, UniversityTeacherId) VALUES (@Off_CS101_Prac, N'T200');

IF NOT EXISTS (SELECT 1 FROM Uni_TeacherAssignments WHERE OfferingId=@Off_DB201_Theo AND UniversityTeacherId=N'T300')
    INSERT INTO Uni_TeacherAssignments(OfferingId, UniversityTeacherId) VALUES (@Off_DB201_Theo, N'T300');

/* 6) تسجيل الطالب في المواد (Enrollments) */
IF NOT EXISTS (SELECT 1 FROM Uni_Enrollments WHERE UniversityStudentId=N'20250001' AND OfferingId=@Off_CS101_Theo)
    INSERT INTO Uni_Enrollments(UniversityStudentId, OfferingId) VALUES (N'20250001', @Off_CS101_Theo);

IF NOT EXISTS (SELECT 1 FROM Uni_Enrollments WHERE UniversityStudentId=N'20250001' AND OfferingId=@Off_CS101_Prac)
    INSERT INTO Uni_Enrollments(UniversityStudentId, OfferingId) VALUES (N'20250001', @Off_CS101_Prac);

IF NOT EXISTS (SELECT 1 FROM Uni_Enrollments WHERE UniversityStudentId=N'20250001' AND OfferingId=@Off_DB201_Theo)
    INSERT INTO Uni_Enrollments(UniversityStudentId, OfferingId) VALUES (N'20250001', @Off_DB201_Theo);

PRINT N'✅ تم إدخال مواد + طرح مواد + تسجيل الطالب + ربط المدرسين بنجاح';
GO
--wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww
USE UniTaskSystem;

SELECT 
  e.UniversityStudentId,
  o.OfferingId,
  o.OfferingType,
  c.Code,
  c.Name,
  t.FullName AS Teacher
FROM Uni_Enrollments e
JOIN Uni_CourseOfferings o ON e.OfferingId = o.OfferingId
JOIN Uni_Courses c ON o.CourseId = c.CourseId
JOIN Uni_TeacherAssignments a ON a.OfferingId = o.OfferingId
JOIN Uni_Teachers t ON t.UniversityTeacherId = a.UniversityTeacherId
WHERE e.UniversityStudentId = '20250001';
-- wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww
USE UniTaskSystem;
GO

DECLARE @OffTheo INT =
(SELECT TOP 1 o.OfferingId
 FROM Uni_CourseOfferings o
 JOIN Uni_Courses c ON o.CourseId=c.CourseId
 WHERE c.Code=N'CS101' AND o.OfferingType=N'نظري');

IF @OffTheo IS NULL
BEGIN
    RAISERROR(N'لم يتم العثور على Offering لبرمجة 1 نظري',16,1);
    RETURN;
END

-- مهمة
INSERT INTO App_Posts(OfferingId, PostType, Title, Body, Deadline, CreatedByTeacherId)
VALUES(@OffTheo, N'مهمة', N'واجب 1', N'اكتب برنامج يجمع رقمين.', DATEADD(DAY,3,SYSDATETIME()), N'T100');

-- مقرر
INSERT INTO App_Posts(OfferingId, PostType, Title, Body, Deadline, CreatedByTeacherId)
VALUES(@OffTheo, N'مقرر', N'ملف المقرر', N'ملف يحتوي على مواضيع المقرر.', NULL, N'T100');

-- نماذج
INSERT INTO App_Posts(OfferingId, PostType, Title, Body, Deadline, CreatedByTeacherId)
VALUES(@OffTheo, N'نماذج', N'نماذج اختبارات', N'نماذج للاختبارات السابقة.', NULL, N'T100');

PRINT N'✅ تم إضافة Posts تجريبية للمادة';
GO
--wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww

USE UniTaskSystem;
GO

DECLARE @off INT =
(SELECT TOP 1 o.OfferingId
 FROM Uni_CourseOfferings o
 JOIN Uni_Courses c ON o.CourseId=c.CourseId
 WHERE c.Code=N'CS101' AND o.OfferingType=N'نظري');

IF @off IS NOT NULL
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Uni_LecturePlan WHERE OfferingId=@off)
    BEGIN
        INSERT INTO Uni_LecturePlan(OfferingId, LectureNo, Title, Content, IsExtra)
        VALUES
        (@off, 1, N'مقدمة في البرمجة', N'تعريف البرمجة + بيئة العمل', 0),
        (@off, 2, N'المتغيرات وأنواع البيانات', N'int/string/double + أمثلة', 0),
        (@off, 3, N'الشروط', N'if/else + أمثلة', 0);
    END
END
GO
--wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww

--اعادة تعيين كلمة المرور
INSERT INTO dbo.App_PasswordResetCodes (ResetCode, Identifier, IsUsed, ExpiresAt, CreatedAt)
VALUES (N'RESET-1234', N'20250001', 0, DATEADD(HOUR, 6, SYSDATETIME()), SYSDATETIME());


--الاشعارات
INSERT INTO App_AdminNotifications(Title, Body, CreatedAt)
VALUES (N'تنبيه', N'تم تحديث جدول المحاضرات.', SYSDATETIME());

INSERT INTO App_AdminNotifications(Title, Body, CreatedAt)
VALUES (N'تنبيه للأعضاء', N'غدًا آخر موعد لتسليم مشاريع البرمجة.', SYSDATETIME());

USE UniTaskSystem;
GO

/* ====== بيانات جامعة أساسية ====== */
IF NOT EXISTS (SELECT 1 FROM Uni_Departments WHERE Name=N'تقنية المعلومات')
    INSERT INTO Uni_Departments(Name) VALUES (N'تقنية المعلومات');

DECLARE @DeptIT INT = (SELECT TOP 1 DepartmentId FROM Uni_Departments WHERE Name=N'تقنية المعلومات');

IF NOT EXISTS (SELECT 1 FROM Uni_Majors WHERE Name=N'هندسة البرمجيات')
    INSERT INTO Uni_Majors(DepartmentId, Name) VALUES (@DeptIT, N'هندسة البرمجيات');

DECLARE @MajorSE INT = (SELECT TOP 1 MajorId FROM Uni_Majors WHERE Name=N'هندسة البرمجيات');

IF NOT EXISTS (SELECT 1 FROM Uni_Terms WHERE Name=N'ترم 1' AND Year=2025)
    INSERT INTO Uni_Terms(Name, Year, IsActive) VALUES (N'ترم 1', 2025, 1);

DECLARE @TermId INT = (SELECT TOP 1 TermId FROM Uni_Terms WHERE Name=N'ترم 1' AND Year=2025);

/* طالب واحد */
IF NOT EXISTS (SELECT 1 FROM Uni_Students WHERE UniversityStudentId=N'20250001')
    INSERT INTO Uni_Students(UniversityStudentId, FullName, MajorId, LevelNo, CurrentTermId, IsActive)
    VALUES (N'20250001', N'أحمد محمد', @MajorSE, 2, @TermId, 1);

/* أستاذ واحد */
IF NOT EXISTS (SELECT 1 FROM Uni_Teachers WHERE UniversityTeacherId=N'T100')
    INSERT INTO Uni_Teachers(UniversityTeacherId, FullName, IsActive)
    VALUES (N'T100', N'د. عبدالعزيز', 1);

/* ====== رموز تفعيل (الأهم للتسجيل) ====== */
IF NOT EXISTS (SELECT 1 FROM App_ActivationCodes WHERE Code=N'STU-20250001-A1')
    INSERT INTO App_ActivationCodes(Code, Role, UniversityStudentId, UniversityTeacherId, IsUsed)
    VALUES (N'STU-20250001-A1', N'طالب', N'20250001', NULL, 0);

IF NOT EXISTS (SELECT 1 FROM App_ActivationCodes WHERE Code=N'TEA-T100-B1')
    INSERT INTO App_ActivationCodes(Code, Role, UniversityStudentId, UniversityTeacherId, IsUsed)
    VALUES (N'TEA-T100-B1', N'أستاذ', NULL, N'T100', 0);

/* ====== رمز نسيت كلمة المرور (اختياري) ====== */
IF NOT EXISTS (SELECT 1 FROM App_PasswordResetCodes WHERE ResetCode=N'RST-20250001')
    INSERT INTO App_PasswordResetCodes(ResetCode, Identifier, IsUsed, ExpiresAt)
    VALUES (N'RST-20250001', N'20250001', 0, DATEADD(DAY, 30, SYSDATETIME()));

PRINT N'✅ تم إدخال Seed Data المختصر بنجاح';
GO

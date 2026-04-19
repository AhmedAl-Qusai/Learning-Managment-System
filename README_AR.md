# UniTaskSystem - نسخة محدثة

## 1) إنشاء قاعدة البيانات
1) افتح **SQL Server Management Studio (SSMS)**.
2) نفّذ الملفات بالترتيب:
- `DatabaseScripts/SQLQuery1.sql` (إنشاء قاعدة البيانات والجداول)
- `DatabaseScripts/SQLQuery2.sql` (Seed Data بسيط + أكواد تفعيل للتسجيل)
- `DatabaseScripts/SQLQuery3.sql` (مواد + Offerings + Enrollments + Posts تجريبية)

## 2) إعداد الاتصال (Connection String)
الملف: `UniTaskSystem/UniTaskSystem/App.config`

افحص أو عدّل الاتصال حسب جهازك:
```xml
<add name="Db"
     connectionString="Data Source=.;Initial Catalog=UniTaskSystem;Integrated Security=True;TrustServerCertificate=True"
     providerName="System.Data.SqlClient"/>
```

## 3) لوحة الإدارة (CRUD لكل جداول Uni_*)
- من شاشة البداية **WelcomeForm** اختر **لوحة الإدارة**.
- كلمة المرور الافتراضية: `admin`
- يمكن تغييرها من `App.config`:
```xml
<appSettings>
  <add key="AdminPassword" value="admin"/>
</appSettings>
```

## 4) بيانات تجريبية جاهزة (بعد SQLQuery2 + SQLQuery3)
### أكواد التفعيل للتسجيل
- طالب: `STU-20250001-A1` (الرقم الجامعي: `20250001`)
- أستاذ: `TEA-T100-B1` (معرّف الأستاذ: `T100`)

## 5) ملاحظة المرفقات
مرفقات منشورات الأستاذ تُنسخ افتراضياً إلى:
`C:\UniTaskSystem\PostAttachments\{PostId}`


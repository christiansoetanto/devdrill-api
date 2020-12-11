using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevDrillAPI.Migrations
{
    public partial class seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "Detail", "Name", "PhotoUrl" },
                values: new object[] { "Dalam kursus ini, kalian akan diajarkan dasar-dasar markup language HTML", "Pengenalan Bahasa Pemrograman HTML", "html_course_1.png" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "Detail", "InsertDate", "Name", "PhotoUrl" },
                values: new object[] { "Dalam kursus ini, kalian akan diajarkan HTML sebagai dasar dalam membuat website", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "HTML untuk pembuatan dan desain website", "html_course_2.jpg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "Detail", "InsertDate", "Name", "PhotoUrl" },
                values: new object[] { "Mempelajari tentang HTML dasar", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mulai belajar website dengan HTML", "html_course_3.jpg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "Detail", "InsertDate", "Name", "PhotoUrl" },
                values: new object[] { "Pengenalan bahasa markup HTML", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mengenal HTML", "html_course_4.jpg" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 15, "Belajar dari nol sampai lancar Javascript", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lancar membuat program dalam Javascript", "js_course_5.png", 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 14, "Belajar Javascript untuk membuat web lebih interaktif", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Belajar Javascript untuk pemrograman web", "js_course_4.jpg", 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 13, "Belajar Javascript untuk pemula", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mengenal pemrograman Javascript untuk pemula", "js_course_3.jpg", 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 5, "Tutorial HTML dasar", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Kursus HTML untuk semua orang", "html_course_5.jpg", 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 11, "Cara mudah memahami Javascript dengan mudah", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pemograman dasar dengan Javascript", "js_course_1.png", 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 10, "Mempelajari tentang CSS untuk mempercantik website", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mempercantik tampilan website dengan CSS", "css_course_5.png", 2 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 9, "Belajar CSS bagi pemula", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "CSS untuk pemula", "css_course_4.png", 2 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 12, "Tutorial lengkap mengenai Javascript terbaru", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Panduan lengkap Javascript 2020", "js_course_2.jpg", 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 8, "Khusus pemula yang ingin membuat website dengan CSS dan HTML", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Kupas Tuntas CSS dari Nol", "css_course_3.jpg", 2 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 7, "Panduan lengkap CSS terbaru", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Panduan lengkap CSS 2020", "css_course_2.jpg", 2 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 6, "Dalam kursus ini, akan diperkenalkan CSS untuk mempercantik tampilan website", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tutorial dasar CSS untuk desain website", "css_course_1.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 1,
                column: "LessonGroupName",
                value: "HTML Basic");

            migrationBuilder.UpdateData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 2,
                column: "LessonGroupName",
                value: "HTML Table");

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 7, 4, "HTML Basic" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 6, 3, "HTML Table" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 5, 3, "HTML Basic" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 4, 2, "HTML Table" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 3, 2, "HTML Basic" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 8, 4, "HTML Table" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "Detail", "EndDateTime", "Name", "StartDateTime" },
                values: new object[] { "Pada lesson kali ini, akan diajarkan HTML Elements", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(5556), "HTML Elements", new DateTime(2020, 12, 11, 23, 2, 40, 745, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "Detail", "EndDateTime", "Name", "StartDateTime" },
                values: new object[] { "Pada lesson kali ini, akan diajarkan HTML Headings", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6751), "HTML Headings", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime" },
                values: new object[] { "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6779), 2, "Membuat table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "Detail", "EndDateTime", "Name", "StartDateTime" },
                values: new object[] { "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6782), "Pelajaran lebih lanjut mengenai table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "MappingUserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Progress",
                value: 8);

            migrationBuilder.UpdateData(
                table: "MappingUserTracks",
                keyColumns: new[] { "TrackId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Progress",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 3,
                columns: new[] { "Detail", "InsertDate", "ThreadId", "Upvote" },
                values: new object[] { "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6233), 3, 9 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "Detail", "InsertDate", "Topic", "Upvote" },
                values: new object[] { "Apa saja hal penting yang harus di install?", new DateTime(2020, 12, 11, 23, 2, 40, 754, DateTimeKind.Local).AddTicks(8973), "Bagaimana konfigurasi setup?", 68 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 16, "Apa saja hal penting yang harus di install?", 6, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(266), "Bagaimana konfigurasi setup?", 56, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 25, "Apa saja hal penting yang harus di install?", 9, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(433), "Bagaimana konfigurasi setup?", 377, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 22, "Apa saja hal penting yang harus di install?", 8, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(379), "Bagaimana konfigurasi setup?", 54, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 19, "Apa saja hal penting yang harus di install?", 7, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(323), "Bagaimana konfigurasi setup?", 177, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 13, "Apa saja hal penting yang harus di install?", 5, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(159), "Bagaimana konfigurasi setup?", 199, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 10, "Apa saja hal penting yang harus di install?", 4, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(103), "Bagaimana konfigurasi setup?", 101, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 7, "Apa saja hal penting yang harus di install?", 3, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(44), "Bagaimana konfigurasi setup?", 492, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 4, "Apa saja hal penting yang harus di install?", 2, new DateTime(2020, 12, 11, 23, 2, 40, 754, DateTimeKind.Local).AddTicks(9984), "Bagaimana konfigurasi setup?", 84, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "instructor1@email.com", "instructor 1", "instructor1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsInstructor", "Name", "Password", "PhoneNumber", "PhotoUrl" },
                values: new object[] { 6, "user3@email.com", (byte)0, "user3", "user3", "081945670143", "photo3.jpg" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsInstructor", "Name", "Password", "PhoneNumber", "PhotoUrl" },
                values: new object[] { 5, "instructor3@email.com", (byte)1, "instructor 3", "instructor 3", "08123546778", "photo5.jpg" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsInstructor", "Name", "Password", "PhoneNumber", "PhotoUrl" },
                values: new object[] { 4, "instructor2@email.com", (byte)1, "instructor 2", "instructor2", "08130785690", "photo4.png" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsInstructor", "Name", "Password", "PhoneNumber", "PhotoUrl" },
                values: new object[] { 3, "user2@email.com", (byte)0, "user2", "user2", "081945680235", "photo3.jpg" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "CompanyName", "Title", "UserId" },
                values: new object[] { 2, "X", "Instructor X", 4 });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "CompanyName", "Title", "UserId" },
                values: new object[] { 3, "Y", "Instructor Y", 5 });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 9, 5, "HTML Basic" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 30, 15, "JS variables" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 29, 15, "JS introduction" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 28, 14, "JS variables" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 27, 14, "JS introduction" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 26, 13, "JS variables" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 25, 13, "JS introduction" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 24, 12, "JS variables" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 22, 11, "JS variables" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 21, 11, "JS introduction" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 23, 12, "JS introduction" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 19, 10, "CSS Syntax" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 18, 9, "CSS Box Model" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 17, 9, "CSS Syntax" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 16, 8, "CSS Box Model" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 15, 8, "CSS Syntax" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 14, 7, "CSS Box Model" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 13, 7, "CSS Syntax" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 12, 6, "CSS Box Model" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 11, 6, "CSS Syntax" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 10, 5, "HTML Table" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 20, 10, "CSS Box Model" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5,
                columns: new[] { "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime" },
                values: new object[] { "Pada lesson kali ini, akan diajarkan HTML Elements", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6784), 3, "HTML Elements", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 6,
                columns: new[] { "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime" },
                values: new object[] { "Pada lesson kali ini, akan diajarkan HTML Headings", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6787), 3, "HTML Headings", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 15, "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6806), 8, "Membuat table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6805), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 16, "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6809), 8, "Pelajaran lebih lanjut mengenai table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6808), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 13, "Pada lesson kali ini, akan diajarkan HTML Elements", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6802), 7, "HTML Elements", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6801), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 14, "Pada lesson kali ini, akan diajarkan HTML Headings", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6804), 7, "HTML Headings", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6803), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 11, "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6798), 6, "Membuat table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6797), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 7, "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6789), 4, "Membuat table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6788), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 10, "Pada lesson kali ini, akan diajarkan HTML Headings", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6795), 5, "HTML Headings", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6794), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 9, "Pada lesson kali ini, akan diajarkan HTML Elements", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6793), 5, "HTML Elements", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6792), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 8, "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6791), 4, "Pelajaran lebih lanjut mengenai table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6790), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 12, "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6800), 6, "Pelajaran lebih lanjut mengenai table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6799), "lesson1.jpg", "video1" });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 1,
                columns: new[] { "Detail", "InsertDate", "Upvote", "UserId" },
                values: new object[] { "Jadi yang harus di install duluan itu ada .......", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(4821), 9, 3 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 2,
                columns: new[] { "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6151), 2, 8, 6 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 4,
                columns: new[] { "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { "Jadi yang harus di install duluan itu ada .......", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6255), 4, 7, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 19, "Jadi yang harus di install duluan itu ada .......", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6605), 19, 8, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 7, "Jadi yang harus di install duluan itu ada .......", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6369), 7, 2, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 16, "Jadi yang harus di install duluan itu ada .......", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6545), 16, 8, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 13, "Jadi yang harus di install duluan itu ada .......", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6489), 13, 2, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 10, "Jadi yang harus di install duluan itu ada .......", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6431), 10, 8, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 25, "Jadi yang harus di install duluan itu ada .......", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6720), 25, 7, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 22, "Jadi yang harus di install duluan itu ada .......", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6663), 22, 9, 3 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "Detail", "InsertDate", "Upvote", "UserId" },
                values: new object[] { "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", new DateTime(2020, 12, 11, 23, 2, 40, 754, DateTimeKind.Local).AddTicks(9912), 83, 3 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { "Udah cek code nya tapi tetep muncul Not Found", 1, new DateTime(2020, 12, 11, 23, 2, 40, 754, DateTimeKind.Local).AddTicks(9964), "HTTP:404 Not Found", 467, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 27, "Udah cek code nya tapi tetep muncul Not Found", 9, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(470), "HTTP:404 Not Found", 366, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 24, "Udah cek code nya tapi tetep muncul Not Found", 8, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(414), "HTTP:404 Not Found", 149, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 21, "Udah cek code nya tapi tetep muncul Not Found", 7, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(361), "HTTP:404 Not Found", 374, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 18, "Udah cek code nya tapi tetep muncul Not Found", 6, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(306), "HTTP:404 Not Found", 377, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 15, "Udah cek code nya tapi tetep muncul Not Found", 5, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(247), "HTTP:404 Not Found", 413, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 12, "Udah cek code nya tapi tetep muncul Not Found", 4, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(141), "HTTP:404 Not Found", 187, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 9, "Udah cek code nya tapi tetep muncul Not Found", 3, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(83), "HTTP:404 Not Found", 349, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 14, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 5, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(230), "Error 500", 475, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 11, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 4, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(121), "Error 500", 25, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 5, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 2, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(3), "Error 500", 286, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 26, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 9, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(451), "Error 500", 289, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 23, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 8, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(397), "Error 500", 286, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 8, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 3, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(64), "Error 500", 37, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 17, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 6, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(285), "Error 500", 304, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 6, "Udah cek code nya tapi tetep muncul Not Found", 2, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(25), "HTTP:404 Not Found", 213, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 20, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 7, new DateTime(2020, 12, 11, 23, 2, 40, 755, DateTimeKind.Local).AddTicks(342), "Error 500", 168, 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 16, "Belajar framework javascript React dari dasar sampai topik yang advanced", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "React Masterclass untuk semua", "react_course_1.png", 4 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 52, "Dalam kursus ini, kalian akan diajarkan cara membuat website dengan framework Spring", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Belajar pemrograman website dengan framework Spring", "spring_course_2.png", 11 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 50, "Kuasai NodeJS dengan cepat dengan mengikuti course ini, cocok untuk pemula", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "NodeJS Masterclass untuk semua", "nodejs_course_5.png", 10 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 48, "Dalam kursus ini, kalian akan diajarkan NodeJS dari dasar hingga topik-topik yang advanced", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Belajar framework NodeJS dari Nol", "nodejs_course_3.jpg", 10 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 46, "Belajar Node JS dari dasar-dasarnya hingga dapat membuat REST API untuk website", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Tutorial lengkap NodeJS untuk membuat REST API", "nodejs_course_1.jpg", 10 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 44, "Ikuti panduan paling up to date mengenai framework Django", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Panduan Lengkap Django 2020", "django_course_3.jpg", 9 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 42, "Dalam kursus ini, kalian akan diajarkan cara membuat website dengan framework Django", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Belajar pemrograman website dengan framework Django", "django_course_1.jpg", 9 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 40, "Kuasai Laravel dengan cepat dengan mengikuti course ini, cocok untuk pemula", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Laravel Masterclass untuk semua", "laravel_course_4.jpg", 8 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 55, "Kuasai Spring dengan cepat dengan mengikuti course ini, cocok untuk pemula", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Spring Masterclass untuk semua", "spring_course_5.png", 11 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 38, "Dalam kursus ini, kalian akan diajarkan Laravel dari dasar hingga topik-topik yang advanced", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Belajar framework Laravel dari Nol", "laravel_course_2.jpg", 8 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 34, "Belajar framework .NET Core dengan panduan paling up-to-date", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Panduan lengkap .NET core 2020", "net_course_3.jpg", 7 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 32, "Kursus ini ditargetkan bagi pemula yang tidak memiliki pengalaman sama sekali dengan framework .NET core", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Belajar framework .NET dari Nol", "net_course_1.png", 7 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 30, "Cocok untuk yang sedang ingin mempelajari front-end framework", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Dasar - dasar pemrograman Vue yang cocok untuk pemula", "vue_course_5.png", 6 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 28, "Panduan paling up-to-date tentang framework Vue", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Panduan Lengkap Vue 2020", "vue_course_3.jpg", 6 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 26, "Kursus ini ditujukan untuk pemula yang belum pernah menyentuh framework Vue", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Tutorial Vue bagi pemula", "vue_course_1.jpg", 6 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 24, "Belajar framework javascript React dari dasar sampai topik yang advanced", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Belajar Angular dari Nol", "angular_course_2.png", 5 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 22, "Belajar Typescript dari Nol sebagai persiapan untuk mempelajari framework Angular", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Panduan lengkap Typescript 2020", "typescript2.jpg", 5 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 36, "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman PHP  dari dasar hingga fitur-fitur penting dari PHP sampai di titik kalian dapat mengimplementasikan PHP ke dalam proyek apapun yang kalian kerjakan.Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework Laravel", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Object-Oriented Programming with PHP", "php.png", 8 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 17, "Belajar ReactJS dasar hingga upload ke hosting", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "ReactJS Bahasa Indonesia", "react_course_2.jpg", 4 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 19, "Goal dari kursus ini adalah menguasai framework React", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Belajar Framework React", "react_course_4.jpg", 4 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 21, "Dalam kursus ini, kalian akan diajarkan Typescript dari dasar hingga fitur-fitur penting dari Typescript sampai di titik kalian dapat mengimplementasikan Typescript ke dalam proyek apapun yang kalian kerjakan. Kursus ini juga akan menjadi dasar bagi kalian yang ingin belajar tentang framework Angular", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Introduction to TS", "typescript.png", 5 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 54, "Ikuti panduan paling up to date mengenai framework Spring", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Panduan Lengkap Spring 2020", "spring_course_4.jpg", 11 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 53, "Dalam kursus ini, kalian akan diajarkan Spring dari dasar hingga topik-topik yang advanced", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Belajar framework Spring dari Nol", "nodejs_course_3.jpg", 11 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 51, "Belajar framework Spring dari dasar-dasarnya hingga dapat membuat REST API untuk website", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Tutorial lengkap Spring untuk membuat REST API", "spring_course_1.png", 11 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 49, "Ikuti panduan paling up to date mengenai framework NodeJS", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Panduan Lengkap NodeJS 2020", "nodejs_course_4.png", 10 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 47, "Dalam kursus ini, kalian akan diajarkan cara membuat API website dengan framework NodeJS", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Belajar pemrograman website dengan framework NodeJS", "nodejs_course_2.jpg", 10 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 45, "Kuasai Django dengan cepat dengan mengikuti course ini, cocok untuk pemula", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Django Masterclass untuk semua", "django_course_4.png", 9 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 43, "Dalam kursus ini, kalian akan diajarkan Django dari dasar hingga topik-topik yang advanced", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Belajar framework Django dari Nol", "django_course_2.jpg", 9 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 41, "Python adalah bahasa pemrograman terkenal yang dibuat dengan fokus untuk mempermudah programmer untuk membaca kodingnya.Dalam kursus ini, kalian akan diajarkan Python dari dasar sampai kalian dapat mengimplementasikannya dalam aplikasi kalian. Kursus ini juga disarankan bagi yang berminat untuk mempelajari framework Django, karena Django menggunakan bahasa pemrograman Python.", new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Python Programming Language", "python.png", 9 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 39, "Ikuti panduan paling up to date mengenai framework Laravel", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Panduan Lengkap Laravel 2020", "laravel_course_3.png", 8 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 37, "Dalam kursus ini, kalian akan diajarkan cara membuat website dengan framework Laravel", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Belajar pemrograman website dengan framework Laravel", "laravel_course_1.png", 8 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 35, "Kuasai .NET core dengan cepat dengan mengikuti course ini", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, ".NET core masterclass untuk semua", "net_course_4.png", 7 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 33, "Belajar .NET core untuk membuat REST API", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Buat REST API dengan framework .NET core", "net_course_2.png", 7 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 31, "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman C# dari dasar hingga fitur-fitur penting dari C# sampai di titik kalian dapat mengimplementasikan C# ke dalam proyek apapun yang kalian kerjakan. Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework ASP.NET", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Asynchronus Programming in C#", "csharp.png", 7 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 29, "Belajar framework javascript Vue dari dasar sampai topik yang advanced.", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Vue Masterclass untuk semua", "vue_course_4.png", 6 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 27, "Belajar framework Vue dari Nol. Tujuan dari course ini adalah untuk dapat mengimplementasi Vue kepada project peserta course.", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Belajar Vue dari Nol", "vue_course_2.png", 6 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 25, "Kursus ini ditujukan untuk pemula yang belum pernah menyentuh framework angular", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Tutorial Angular bagi pemula", "angular_course_3.jpg", 5 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 23, "Belajar topik dasar hingga topik advanced dari framework Angular", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Panduan lengkap Angular 2020", "angular_course_1.jpg", 5 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 20, "Belajar React dari Nol", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Tutorial React bagi pemula", "react_course_5.png", 4 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 18, "Tutorial paling lengkap tahun 2020 mengenai framework React", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Panduan lengkap React 2020", "react_course_3.png", 4 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 17, "Pada lesson kali ini, akan diajarkan HTML Elements", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6811), 9, "HTML Elements", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6810), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 37, "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6906), 21, "Apa saja yang bisa dilakukan Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6905), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 39, "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6911), 22, "Tipe Data pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6910), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 38, "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6909), 22, "Mendefinisikan Variabel pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6908), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 18, "Pada lesson kali ini, akan diajarkan HTML Headings", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6813), 9, "HTML Headings", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6812), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 36, "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6904), 21, "Apa itu bahasa pemrograman Javascript?", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6903), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 35, "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6902), 20, "Kustomisasi Box Model CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6901), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 34, "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6900), 20, "Struktur dari CSS Box Model", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6899), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 33, "Pada lesson kali ini, akan diajarkan syntax pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6897), 19, "CSS Syntax", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6896), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 32, "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6895), 18, "Kustomisasi Box Model CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6894), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 31, "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6893), 18, "Struktur dari CSS Box Model", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6892), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 30, "Pada lesson kali ini, akan diajarkan syntax pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6891), 17, "CSS Syntax", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6890), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 29, "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6889), 16, "Kustomisasi Box Model CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6888), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 28, "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6887), 16, "Struktur dari CSS Box Model", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6886), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 27, "Pada lesson kali ini, akan diajarkan syntax pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6884), 15, "CSS Syntax", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6883), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 26, "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6882), 14, "Kustomisasi Box Model CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6881), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 25, "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6829), 14, "Struktur dari CSS Box Model", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6828), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 24, "Pada lesson kali ini, akan diajarkan syntax pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6827), 13, "CSS Syntax", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6826), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 23, "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6825), 12, "Kustomisasi Box Model CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6824), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 22, "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6822), 12, "Struktur dari CSS Box Model", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6822), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 21, "Pada lesson kali ini, akan diajarkan syntax pada CSS", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6820), 11, "CSS Syntax", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6819), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 40, "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6914), 23, "Apa itu bahasa pemrograman Javascript?", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6913), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 20, "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6817), 10, "Pelajaran lebih lanjut mengenai table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6816), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 41, "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6916), 23, "Apa saja yang bisa dilakukan Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6915), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 43, "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6920), 24, "Tipe Data pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6919), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 55, "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6946), 30, "Tipe Data pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6945), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 54, "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6944), 30, "Mendefinisikan Variabel pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6943), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 42, "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6918), 24, "Mendefinisikan Variabel pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6917), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 52, "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6939), 29, "Apa itu bahasa pemrograman Javascript?", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6938), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 51, "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6937), 28, "Tipe Data pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6936), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 50, "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6935), 28, "Mendefinisikan Variabel pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6934), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 53, "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6942), 29, "Apa saja yang bisa dilakukan Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6941), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 48, "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6931), 27, "Apa itu bahasa pemrograman Javascript?", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6930), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 47, "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6929), 26, "Tipe Data pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6928), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 46, "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6926), 26, "Mendefinisikan Variabel pada Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6925), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 45, "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6924), 25, "Apa saja yang bisa dilakukan Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6923), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 44, "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6922), 25, "Apa itu bahasa pemrograman Javascript?", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6921), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 49, "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6933), 27, "Apa saja yang bisa dilakukan Javascript", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6932), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 19, "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6815), 10, "Membuat table pada HTML", new DateTime(2020, 12, 11, 23, 2, 40, 746, DateTimeKind.Local).AddTicks(6814), "lesson1.jpg", "video1" });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 5,
                columns: new[] { "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6273), 5, 5, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 6, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6295), 6, 6, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 9, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6409), 9, 5, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 12, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6469), 12, 8, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 15, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6527), 15, 3, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 18, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6586), 18, 6, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 21, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6643), 21, 6, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 11, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6451), 11, 2, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 24, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6700), 24, 3, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 26, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6737), 26, 1, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 23, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6682), 23, 4, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 20, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6623), 20, 8, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 17, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6565), 17, 3, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 14, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6508), 14, 8, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 8, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6390), 8, 6, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 27, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2020, 12, 11, 23, 2, 40, 753, DateTimeKind.Local).AddTicks(6756), 27, 8, 1 });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 31, 16, "Pengenalan React" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 66, 33, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 65, 33, "Dasar-dasar framework .NET Core" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 62, 31, "Pengenalan Array" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 61, 31, "Dasar-dasar pemrograman C#" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 58, 29, "Pemograman Lanjut Aplikasi Web Vue.js" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 57, 29, "Dasar Pemograman Aplikasi Web dengan Vue.js " });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 54, 27, "Pemograman Lanjut Aplikasi Web Vue.js" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 69, 35, "Dasar-dasar framework .NET Core" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 53, 27, "Dasar Pemograman Aplikasi Web dengan Vue.js " });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 49, 25, "Angular Setup & File Structure" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 46, 23, "Angular Components" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 45, 23, "Angular Setup & File Structure" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 42, 21, "Class & Interface" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 41, 21, "Dasar-dasar Typescript" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 38, 19, "React Components, State & Props" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 37, 19, "Pengenalan React" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 50, 25, "Angular Components" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 34, 17, "React Components, State & Props" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 70, 35, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 74, 37, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 106, 53, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 105, 53, "Dasar - dasar bahasa framework Spring" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 102, 51, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 101, 51, "Dasar - dasar bahasa framework Spring" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 98, 49, "Node Module" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 97, 49, "Dasar - dasar Node" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 94, 47, "Node Module" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 73, 37, "Dasar - dasar bahasa framework Laravel" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 93, 47, "Dasar - dasar Node" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 89, 45, "Django Models & Admin" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 86, 43, "URL Handler & Views" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 85, 43, "Django Models & Admin" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 82, 41, "Object-Oriented Programming pada Python" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 81, 41, "Dasar - dasar bahasa pemrograman Python" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 78, 39, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 77, 39, "Dasar - dasar bahasa framework Laravel" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 90, 45, "URL Handler & Views" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 33, 17, "Pengenalan React" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 110, 55, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 109, 55, "Dasar - dasar bahasa framework Spring" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 63, 32, "Dasar-dasar framework .NET Core" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 60, 30, "Pemograman Lanjut Aplikasi Web Vue.js" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 59, 30, "Dasar Pemograman Aplikasi Web dengan Vue.js " });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 56, 28, "Pemograman Lanjut Aplikasi Web Vue.js" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 55, 28, "Dasar Pemograman Aplikasi Web dengan Vue.js " });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 52, 26, "Pemograman Lanjut Aplikasi Web Vue.js" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 51, 26, "Dasar Pemograman Aplikasi Web dengan Vue.js " });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 64, 32, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 48, 24, "Angular Components" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 44, 22, "Class & Interface" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 43, 22, "Dasar-dasar Typescript" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 40, 20, "React Components, State & Props" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 39, 20, "Pengenalan React" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 36, 18, "React Components, State & Props" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 35, 18, "Pengenalan React" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 32, 16, "React Components, State & Props" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 47, 24, "Angular Setup & File Structure" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 67, 34, "Dasar-dasar framework .NET Core" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 68, 34, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 71, 36, "Dasar - dasar bahasa pemrograman PHP" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 104, 52, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 103, 52, "Dasar - dasar bahasa framework Spring" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 100, 50, "Node Module" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 99, 50, "Dasar - dasar Node" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 96, 48, "Node Module" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 95, 48, "Dasar - dasar Node" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 92, 46, "Node Module" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 91, 46, "Dasar - dasar Node" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 88, 44, "URL Handler & Views" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 87, 44, "Django Models & Admin" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 84, 42, "URL Handler & Views" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 83, 42, "Django Models & Admin" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 80, 40, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 79, 40, "Dasar - dasar bahasa framework Laravel" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 76, 38, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 75, 38, "Dasar - dasar bahasa framework Laravel" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 72, 36, "Object-Oriented Programming pada PHP" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 107, 54, "Dasar - dasar bahasa framework Spring" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 108, 54, "Model-View-Controller Pattern" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "InstructorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "InstructorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "Detail", "Name", "PhotoUrl" },
                values: new object[] { "Dalam kursus ini, kalian akan diajarkan Typescript dari dasar hingga fitur-fitur penting dari Typescript sampai di titik kalian dapa", "Introduction to TS", "typescript.png" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "Detail", "InsertDate", "Name", "PhotoUrl" },
                values: new object[] { "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman C# dari dasar hingga fitur-fitur penting dari C# sampai di titik kalian dapat mengimplementasikan C# ke dalam proyek apapun yang kalian kerjakan. Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework ASP.NET", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asynchronus Programming in C#", "csharp.png" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "Detail", "InsertDate", "Name", "PhotoUrl" },
                values: new object[] { "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman PHP  dari dasar hingga fitur-fitur penting dari PHP sampai di titik kalian dapat mengimplementasikan PHP ke dalam proyek apapun yang kalian kerjakan.Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework Laravel", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Object-Oriented Programming with PHP", "php.png" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                columns: new[] { "Detail", "InsertDate", "Name", "PhotoUrl" },
                values: new object[] { "Python adalah bahasa pemrograman terkenal yang dibuat dengan fokus untuk mempermudah programmer untuk membaca kodingnya.Dalam kursus ini, kalian akan diajarkan Python dari dasar sampai kalian dapat mengimplementasikannya dalam aplikasi kalian.", new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Python Programming Language", "python.png" });

            migrationBuilder.UpdateData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 1,
                column: "LessonGroupName",
                value: "Basic Operation n Meth");

            migrationBuilder.UpdateData(
                table: "LessonGroups",
                keyColumn: "LessonGroupId",
                keyValue: 2,
                column: "LessonGroupName",
                value: "FUnction n class");

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "Detail", "EndDateTime", "Name", "StartDateTime" },
                values: new object[] { "ini adalah lesson hello world in ts", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(1731), "Hello world in ts", new DateTime(2020, 12, 10, 12, 43, 53, 322, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "Detail", "EndDateTime", "Name", "StartDateTime" },
                values: new object[] { "ini adlaah selection n loop control", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2895), "selection n loop control", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime" },
                values: new object[] { "ini adlah creating a basic calculator", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2918), 1, "creating a basic calculator", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "Detail", "EndDateTime", "Name", "StartDateTime" },
                values: new object[] { "ini adalah definig a cufntioni", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2920), "Defining a function", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 6, "ini dalah detail darti making a basci tdiyr pogmra", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2925), 2, "making a basci tdiyr pogmra", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2924), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 5, "this is class n object ", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2922), 2, "class n object ", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2921), "lesson1.jpg", "video1" });

            migrationBuilder.UpdateData(
                table: "MappingUserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Progress",
                value: 9);

            migrationBuilder.UpdateData(
                table: "MappingUserTracks",
                keyColumns: new[] { "TrackId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Progress",
                value: 9);

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 1, "how to make this into this i dont know pleaseeeee help meeeee", new DateTime(2020, 12, 10, 12, 43, 53, 328, DateTimeKind.Local).AddTicks(9761), 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 2, "okay so this is how you do this....", new DateTime(2020, 12, 10, 12, 43, 53, 329, DateTimeKind.Local).AddTicks(626), 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "Detail", "InsertDate", "Topic", "Upvote" },
                values: new object[] { "gk tau samain ama reply", new DateTime(2020, 12, 10, 12, 43, 53, 330, DateTimeKind.Local).AddTicks(3257), "How to make this into", 17 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 2, "gk tau samain ama reply", 1, new DateTime(2020, 12, 10, 12, 43, 53, 330, DateTimeKind.Local).AddTicks(5323), "Error 500", 212, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 3, "gk tau samain ama reply", 3, new DateTime(2020, 12, 10, 12, 43, 53, 330, DateTimeKind.Local).AddTicks(5382), "HTTP404 Not Found", 58, 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password" },
                values: new object[] { "user2@email.com", "instructor", "user2" });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 5, "You want to find this topic but HTTP404 Not Found...", new DateTime(2020, 12, 10, 12, 43, 53, 329, DateTimeKind.Local).AddTicks(769), 3, 8, 2 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 4, "no we cant", new DateTime(2020, 12, 10, 12, 43, 53, 329, DateTimeKind.Local).AddTicks(749), 2, 5, 2 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 3, "hey guys i got error 500 cna somebody help me?", new DateTime(2020, 12, 10, 12, 43, 53, 329, DateTimeKind.Local).AddTicks(727), 2, 8, 1 });
        }
    }
}

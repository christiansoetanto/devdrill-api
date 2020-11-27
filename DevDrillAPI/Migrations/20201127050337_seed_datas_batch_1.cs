using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevDrillAPI.Migrations
{
    public partial class seed_datas_batch_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "InsertDate", "PhotoUrl" },
                values: new object[] { new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "typescript.png" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 4, "Python adalah bahasa pemrograman terkenal yang dibuat dengan fokus untuk mempermudah programmer untuk membaca kodingnya.Dalam kursus ini, kalian akan diajarkan Python dari dasar sampai kalian dapat mengimplementasikannya dalam aplikasi kalian.", new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Python Programming Language", "python.png", 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 2, "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman C# dari dasar hingga fitur-fitur penting dari C# sampai di titik kalian dapat mengimplementasikan C# ke dalam proyek apapun yang kalian kerjakan. Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework ASP.NET", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Asynchronus Programming in C#", "csharp.png", 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 3, "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman PHP  dari dasar hingga fitur-fitur penting dari PHP sampai di titik kalian dapat mengimplementasikan PHP ke dalam proyek apapun yang kalian kerjakan.Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework Laravel", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Object-Oriented Programming with PHP", "php.png", 1 });

            migrationBuilder.UpdateData(
                table: "DiscussionGroups",
                keyColumn: "DiscussionGroupId",
                keyValue: 1,
                columns: new[] { "Name", "PhotoUrl" },
                values: new object[] { "Public Discussion", "" });

            migrationBuilder.UpdateData(
                table: "DiscussionGroups",
                keyColumn: "DiscussionGroupId",
                keyValue: 2,
                columns: new[] { "Name", "PhotoUrl" },
                values: new object[] { "Angular Discussion", "angular.png" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 5, "Laravel discussion", "angular.png" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 6, "React.js discussion", "react.png" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 7, "Vue.js discussion", "vuejs.png" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 8, "Django discussion", "django.png" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 9, "Spring discussion", "spring.png" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 4, "ASP.NET Core Discussion", "netcore.png" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 3, "Node.js Discussion", "nodejs.png" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 5, 2, "Development Advice" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 495, DateTimeKind.Local).AddTicks(4685), new DateTime(2020, 11, 27, 12, 3, 36, 494, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 495, DateTimeKind.Local).AddTicks(7709), new DateTime(2020, 11, 27, 12, 3, 36, 495, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 495, DateTimeKind.Local).AddTicks(7736), new DateTime(2020, 11, 27, 12, 3, 36, 495, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 495, DateTimeKind.Local).AddTicks(7739), new DateTime(2020, 11, 27, 12, 3, 36, 495, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 495, DateTimeKind.Local).AddTicks(7742), new DateTime(2020, 11, 27, 12, 3, 36, 495, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 6,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 495, DateTimeKind.Local).AddTicks(7746), new DateTime(2020, 11, 27, 12, 3, 36, 495, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "MappingUserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Progress",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MappingUserTracks",
                keyColumns: new[] { "TrackId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Progress",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 1,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 501, DateTimeKind.Local).AddTicks(2445), 9 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 2,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 501, DateTimeKind.Local).AddTicks(3605), 7 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 3,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 501, DateTimeKind.Local).AddTicks(3659), 6 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 4,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 501, DateTimeKind.Local).AddTicks(3680), 8 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 5,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 501, DateTimeKind.Local).AddTicks(3701), 2 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 502, DateTimeKind.Local).AddTicks(3660), 204 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 502, DateTimeKind.Local).AddTicks(4813), 236 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 12, 3, 36, 502, DateTimeKind.Local).AddTicks(4866), 443 });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 1,
                column: "PhotoUrl",
                value: "html.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 2,
                column: "PhotoUrl",
                value: "css.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 3,
                column: "PhotoUrl",
                value: "javascript.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 4,
                column: "PhotoUrl",
                value: "react.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 5,
                column: "PhotoUrl",
                value: "angular.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 6,
                column: "PhotoUrl",
                value: "vuejs.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 7,
                column: "PhotoUrl",
                value: "netcore.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 8,
                column: "PhotoUrl",
                value: "laravel.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 9,
                column: "PhotoUrl",
                value: "django.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 10,
                column: "PhotoUrl",
                value: "nodejs.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 11,
                column: "PhotoUrl",
                value: "spring.png");

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 6, 3, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 24, 9, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 23, 8, "Development Advice" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 22, 8, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 21, 8, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 20, 7, "Development Advice" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 19, 7, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 18, 7, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 17, 6, "Development Advice" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 25, 9, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 16, 6, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 14, 5, "Development Advice" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 13, 5, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 12, 5, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 11, 4, "Development Advice" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 10, 4, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 9, 4, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 8, 3, "Development Advice" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 7, 3, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 15, 6, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 26, 9, "Development Advice" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Discussions",
                keyColumn: "DiscussionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DiscussionGroups",
                keyColumn: "DiscussionGroupId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiscussionGroups",
                keyColumn: "DiscussionGroupId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiscussionGroups",
                keyColumn: "DiscussionGroupId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiscussionGroups",
                keyColumn: "DiscussionGroupId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DiscussionGroups",
                keyColumn: "DiscussionGroupId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DiscussionGroups",
                keyColumn: "DiscussionGroupId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DiscussionGroups",
                keyColumn: "DiscussionGroupId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "InsertDate", "PhotoUrl" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 829, DateTimeKind.Local).AddTicks(324), "course1.jpg" });

            migrationBuilder.UpdateData(
                table: "DiscussionGroups",
                keyColumn: "DiscussionGroupId",
                keyValue: 1,
                columns: new[] { "Name", "PhotoUrl" },
                values: new object[] { "Public discussion", "dg1.jpg" });

            migrationBuilder.UpdateData(
                table: "DiscussionGroups",
                keyColumn: "DiscussionGroupId",
                keyValue: 2,
                columns: new[] { "Name", "PhotoUrl" },
                values: new object[] { "Angular discussion", "dg1.jpg" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 836, DateTimeKind.Local).AddTicks(109), new DateTime(2020, 11, 27, 1, 22, 58, 836, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 836, DateTimeKind.Local).AddTicks(1385), new DateTime(2020, 11, 27, 1, 22, 58, 836, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 836, DateTimeKind.Local).AddTicks(1409), new DateTime(2020, 11, 27, 1, 22, 58, 836, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 836, DateTimeKind.Local).AddTicks(1412), new DateTime(2020, 11, 27, 1, 22, 58, 836, DateTimeKind.Local).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 836, DateTimeKind.Local).AddTicks(1414), new DateTime(2020, 11, 27, 1, 22, 58, 836, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 6,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 836, DateTimeKind.Local).AddTicks(1417), new DateTime(2020, 11, 27, 1, 22, 58, 836, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "MappingUserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Progress",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MappingUserTracks",
                keyColumns: new[] { "TrackId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Progress",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 1,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 840, DateTimeKind.Local).AddTicks(4690), 8 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 2,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 840, DateTimeKind.Local).AddTicks(5829), 8 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 3,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 840, DateTimeKind.Local).AddTicks(5886), 1 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 4,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 840, DateTimeKind.Local).AddTicks(5909), 1 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 5,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 840, DateTimeKind.Local).AddTicks(5929), 3 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 842, DateTimeKind.Local).AddTicks(2603), 337 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 842, DateTimeKind.Local).AddTicks(3854), 63 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 1, 22, 58, 842, DateTimeKind.Local).AddTicks(3907), 264 });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 1,
                column: "PhotoUrl",
                value: "../../../assets/html.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 2,
                column: "PhotoUrl",
                value: "../../../assets/css.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 3,
                column: "PhotoUrl",
                value: "../../../assets/javascript.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 4,
                column: "PhotoUrl",
                value: "../../../assets/react.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 5,
                column: "PhotoUrl",
                value: "../../../assets/angular.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 6,
                column: "PhotoUrl",
                value: "../../../assets/vuejs.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 7,
                column: "PhotoUrl",
                value: "../../../assets/netcore.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 8,
                column: "PhotoUrl",
                value: "../../../assets/laravel.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 9,
                column: "PhotoUrl",
                value: "../../../assets/django.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 10,
                column: "PhotoUrl",
                value: "../../../assets/nodejs.png");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 11,
                column: "PhotoUrl",
                value: "../../../assets/spring.png");
        }
    }
}

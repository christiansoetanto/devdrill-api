using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevDrillAPI.Migrations
{
    public partial class seed_tracks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2020, 11, 27, 1, 22, 58, 829, DateTimeKind.Local).AddTicks(324));

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

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 3, "Pada track ini, anda akan fokus pada pemakaian JS sebagai bahasa program yang sering digunakan dalam pembuatan logic dari web. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Javascript", "../../../assets/javascript.png", 1 });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 2, "Pada track ini, anda akan fokus pada pemakaian CSS sebagai style yang sering digunakan untuk mempercantik tampilan web. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "CSS", "../../../assets/css.png", 1 });

            migrationBuilder.InsertData(
                table: "TrackGroups",
                columns: new[] { "TrackGroupId", "TrackGroupName" },
                values: new object[] { 3, "Backend Developer Tracks" });

            migrationBuilder.InsertData(
                table: "TrackGroups",
                columns: new[] { "TrackGroupId", "TrackGroupName" },
                values: new object[] { 2, "Frontend Developer Tracks" });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 4, "Pada track ini, anda akan fokus pada pemakaian React.js sebagai framework frontend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "React.js Developer", "../../../assets/react.png", 2 });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 5, "Pada track ini, anda akan fokus pada pemakaian Angular sebagai framework frontend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Angular Developer", "../../../assets/angular.png", 2 });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 6, "Pada track ini, anda akan fokus pada pemakaian Vue.js sebagai framework frontend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Vue.js Developer", "../../../assets/vuejs.png", 2 });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 7, "Pada track ini, anda akan fokus pada pemakaian .NET Core sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", ".NET Core Developer", "../../../assets/netcore.png", 3 });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 8, "Pada track ini, anda akan fokus pada pemakaian Laravel sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Laravel Developer", "../../../assets/laravel.png", 3 });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 9, "Pada track ini, anda akan fokus pada pemakaian Django sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Django Developer", "../../../assets/django.png", 3 });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 10, "Pada track ini, anda akan fokus pada pemakaian Node.js sebagai run-time environment yang sering digunakan dalam pembuatan web application. Disini kita akan menggunakan Express.js sebagai media frameworknya. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Node.js Developer", "../../../assets/nodejs.png", 3 });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 11, "Pada track ini, anda akan fokus pada pemakaian Spring sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Spring Developer", "../../../assets/spring.png", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TrackGroups",
                keyColumn: "TrackGroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrackGroups",
                keyColumn: "TrackGroupId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2020, 11, 26, 19, 49, 26, 152, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(4093), new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5200), new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5223), new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5226), new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5228), new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 6,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5231), new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "MappingUserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Progress",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MappingUserTracks",
                keyColumns: new[] { "TrackId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Progress",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 1,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 167, DateTimeKind.Local).AddTicks(8430), 6 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 2,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 167, DateTimeKind.Local).AddTicks(9328), 3 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 3,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 167, DateTimeKind.Local).AddTicks(9388), 6 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 4,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 167, DateTimeKind.Local).AddTicks(9409), 3 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 5,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 167, DateTimeKind.Local).AddTicks(9429), 5 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 168, DateTimeKind.Local).AddTicks(9538), 419 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 169, DateTimeKind.Local).AddTicks(465), 184 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 19, 49, 26, 169, DateTimeKind.Local).AddTicks(708), 385 });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "TrackId",
                keyValue: 1,
                column: "PhotoUrl",
                value: "track1.jpg");
        }
    }
}

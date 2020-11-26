using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevDrillAPI.Migrations
{
    public partial class AddEmailPhoneNumberToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2020, 11, 26, 17, 48, 29, 981, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 48, 29, 989, DateTimeKind.Local).AddTicks(5225), new DateTime(2020, 11, 26, 17, 48, 29, 989, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 48, 29, 989, DateTimeKind.Local).AddTicks(6201), new DateTime(2020, 11, 26, 17, 48, 29, 989, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 48, 29, 989, DateTimeKind.Local).AddTicks(6229), new DateTime(2020, 11, 26, 17, 48, 29, 989, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 48, 29, 989, DateTimeKind.Local).AddTicks(6232), new DateTime(2020, 11, 26, 17, 48, 29, 989, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 48, 29, 989, DateTimeKind.Local).AddTicks(6235), new DateTime(2020, 11, 26, 17, 48, 29, 989, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 6,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 48, 29, 989, DateTimeKind.Local).AddTicks(6239), new DateTime(2020, 11, 26, 17, 48, 29, 989, DateTimeKind.Local).AddTicks(6237) });

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
                value: 8);

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2020, 11, 26, 17, 48, 29, 993, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2020, 11, 26, 17, 48, 29, 993, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 3,
                column: "InsertDate",
                value: new DateTime(2020, 11, 26, 17, 48, 29, 993, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 4,
                column: "InsertDate",
                value: new DateTime(2020, 11, 26, 17, 48, 29, 993, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 5,
                column: "InsertDate",
                value: new DateTime(2020, 11, 26, 17, 48, 29, 993, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 48, 29, 994, DateTimeKind.Local).AddTicks(5492), 16 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 48, 29, 994, DateTimeKind.Local).AddTicks(6296), 53 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 48, 29, 994, DateTimeKind.Local).AddTicks(6347), 312 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "user1@email.com", "0812121212112" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "user2@email.com", "08777777" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2020, 11, 26, 17, 26, 43, 879, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 26, 43, 887, DateTimeKind.Local).AddTicks(5583), new DateTime(2020, 11, 26, 17, 26, 43, 887, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 26, 43, 887, DateTimeKind.Local).AddTicks(6567), new DateTime(2020, 11, 26, 17, 26, 43, 887, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 26, 43, 887, DateTimeKind.Local).AddTicks(6587), new DateTime(2020, 11, 26, 17, 26, 43, 887, DateTimeKind.Local).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 26, 43, 887, DateTimeKind.Local).AddTicks(6589), new DateTime(2020, 11, 26, 17, 26, 43, 887, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 26, 43, 887, DateTimeKind.Local).AddTicks(6591), new DateTime(2020, 11, 26, 17, 26, 43, 887, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 6,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 26, 43, 887, DateTimeKind.Local).AddTicks(6594), new DateTime(2020, 11, 26, 17, 26, 43, 887, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "MappingUserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Progress",
                value: 2);

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
                column: "InsertDate",
                value: new DateTime(2020, 11, 26, 17, 26, 43, 891, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2020, 11, 26, 17, 26, 43, 891, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 3,
                column: "InsertDate",
                value: new DateTime(2020, 11, 26, 17, 26, 43, 891, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 4,
                column: "InsertDate",
                value: new DateTime(2020, 11, 26, 17, 26, 43, 891, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 5,
                column: "InsertDate",
                value: new DateTime(2020, 11, 26, 17, 26, 43, 891, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 26, 43, 893, DateTimeKind.Local).AddTicks(1746), 453 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 26, 43, 893, DateTimeKind.Local).AddTicks(2631), 79 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 26, 17, 26, 43, 893, DateTimeKind.Local).AddTicks(2694), 221 });
        }
    }
}

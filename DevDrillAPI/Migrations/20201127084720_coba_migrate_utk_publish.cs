using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevDrillAPI.Migrations
{
    public partial class coba_migrate_utk_publish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cobas",
                columns: table => new
                {
                    Key = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobas", x => x.Key);
                });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 494, DateTimeKind.Local).AddTicks(9171), new DateTime(2020, 11, 27, 15, 47, 19, 493, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 495, DateTimeKind.Local).AddTicks(3311), new DateTime(2020, 11, 27, 15, 47, 19, 495, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 495, DateTimeKind.Local).AddTicks(3335), new DateTime(2020, 11, 27, 15, 47, 19, 495, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 4,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 495, DateTimeKind.Local).AddTicks(3338), new DateTime(2020, 11, 27, 15, 47, 19, 495, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 5,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 495, DateTimeKind.Local).AddTicks(3341), new DateTime(2020, 11, 27, 15, 47, 19, 495, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 6,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 495, DateTimeKind.Local).AddTicks(3343), new DateTime(2020, 11, 27, 15, 47, 19, 495, DateTimeKind.Local).AddTicks(3342) });

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 1,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 499, DateTimeKind.Local).AddTicks(8607), 1 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 2,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 499, DateTimeKind.Local).AddTicks(9815), 9 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 3,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 500, DateTimeKind.Local).AddTicks(77), 5 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 4,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 500, DateTimeKind.Local).AddTicks(100), 1 });

            migrationBuilder.UpdateData(
                table: "Replies",
                keyColumn: "ReplyId",
                keyValue: 5,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 500, DateTimeKind.Local).AddTicks(120), 4 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 1,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 500, DateTimeKind.Local).AddTicks(9569), 267 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 2,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 501, DateTimeKind.Local).AddTicks(1635), 159 });

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "ThreadId",
                keyValue: 3,
                columns: new[] { "InsertDate", "Upvote" },
                values: new object[] { new DateTime(2020, 11, 27, 15, 47, 19, 501, DateTimeKind.Local).AddTicks(1684), 491 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cobas");

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
        }
    }
}

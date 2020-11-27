﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevDrillAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiscussionGroups",
                columns: table => new
                {
                    DiscussionGroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    PhotoUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscussionGroups", x => x.DiscussionGroupId);
                });

            migrationBuilder.CreateTable(
                name: "TrackGroups",
                columns: table => new
                {
                    TrackGroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TrackGroupName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackGroups", x => x.TrackGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Password = table.Column<string>(unicode: false, nullable: false),
                    Name = table.Column<string>(unicode: false, nullable: false),
                    PhotoUrl = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    IsInstructor = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Discussions",
                columns: table => new
                {
                    DiscussionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    DiscussionGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discussions", x => x.DiscussionId);
                    table.ForeignKey(
                        name: "FK_Discussions_DiscussionGroups_DiscussionGroupId",
                        column: x => x.DiscussionGroupId,
                        principalTable: "DiscussionGroups",
                        principalColumn: "DiscussionGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    TrackId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhotoUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    TrackGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.TrackId);
                    table.ForeignKey(
                        name: "FK_Track_TrackGroups_TrackGroupId",
                        column: x => x.TrackGroupId,
                        principalTable: "TrackGroups",
                        principalColumn: "TrackGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InstructorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructorId);
                    table.ForeignKey(
                        name: "FK_Instructors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Threads",
                columns: table => new
                {
                    ThreadId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Topic = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Upvote = table.Column<int>(nullable: false),
                    DiscussionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Threads", x => x.ThreadId);
                    table.ForeignKey(
                        name: "FK_Threads_Discussions_DiscussionId",
                        column: x => x.DiscussionId,
                        principalTable: "Discussions",
                        principalColumn: "DiscussionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Threads_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MappingUserTracks",
                columns: table => new
                {
                    TrackId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Progress = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingUserTracks", x => new { x.TrackId, x.UserId });
                    table.ForeignKey(
                        name: "FK_MappingUserTracks_Track_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Track",
                        principalColumn: "TrackId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MappingUserTracks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhotoUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrackId = table.Column<int>(nullable: false),
                    InstructorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "InstructorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Track_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Track",
                        principalColumn: "TrackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Replies",
                columns: table => new
                {
                    ReplyId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Detail = table.Column<string>(nullable: true),
                    ThreadId = table.Column<int>(nullable: false),
                    Upvote = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replies", x => x.ReplyId);
                    table.ForeignKey(
                        name: "FK_Replies_Threads_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "Threads",
                        principalColumn: "ThreadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Replies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonGroups",
                columns: table => new
                {
                    LessonGroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LessonGroupName = table.Column<string>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonGroups", x => x.LessonGroupId);
                    table.ForeignKey(
                        name: "FK_LessonGroups_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MappingUserCourses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Progress = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingUserCourses", x => new { x.CourseId, x.UserId });
                    table.ForeignKey(
                        name: "FK_MappingUserCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MappingUserCourses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Detail = table.Column<string>(nullable: true),
                    StartDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    VideoUrl = table.Column<string>(nullable: true),
                    ThumbnailUrl = table.Column<string>(nullable: true),
                    LessonGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonId);
                    table.ForeignKey(
                        name: "FK_Lessons_LessonGroups_LessonGroupId",
                        column: x => x.LessonGroupId,
                        principalTable: "LessonGroups",
                        principalColumn: "LessonGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 1, "Public discussion", "dg1.jpg" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 2, "Angular discussion", "dg1.jpg" });

            migrationBuilder.InsertData(
                table: "TrackGroups",
                columns: new[] { "TrackGroupId", "TrackGroupName" },
                values: new object[] { 1, "Fundamental Tracks" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsInstructor", "Name", "Password", "PhoneNumber", "PhotoUrl" },
                values: new object[] { 1, "user1@email.com", (byte)0, "user biasa", "user1", "0812121212112", "photo1.jpg" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsInstructor", "Name", "Password", "PhoneNumber", "PhotoUrl" },
                values: new object[] { 2, "user2@email.com", (byte)1, "instructor", "user2", "08777777", "photo2.jpg" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 1, 1, "General Advice" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 2, 1, "Other Frameworks" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 3, 2, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 4, 2, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "CompanyName", "Title", "UserId" },
                values: new object[] { 1, "Perusahaan Saya", "CEO and Boss", 2 });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 1, "Pada track ini, anda akan fokus pada pemakaian HTML sebagai bahasa markup yang sering digunakan dalam pembuatan struktur tampilan web. Ketika l", "HTML", "track1.jpg", 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 1, "Dalam kursus ini, kalian akan diajarkan Typescript dari dasar hingga fitur-fitur penting dari Typescript sampai di titik kalian dapa", new DateTime(2020, 11, 26, 19, 49, 26, 152, DateTimeKind.Local).AddTicks(2032), 1, "Introduction to TS", "course1.jpg", 1 });

            migrationBuilder.InsertData(
                table: "MappingUserTracks",
                columns: new[] { "TrackId", "UserId", "Progress" },
                values: new object[] { 1, 1, 5 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 1, 1, new DateTime(2020, 11, 26, 19, 49, 26, 168, DateTimeKind.Local).AddTicks(9538), "How to make this into", 419, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 2, 1, new DateTime(2020, 11, 26, 19, 49, 26, 169, DateTimeKind.Local).AddTicks(465), "Error 500", 184, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 3, 3, new DateTime(2020, 11, 26, 19, 49, 26, 169, DateTimeKind.Local).AddTicks(708), "HTTP404 Not Found", 385, 2 });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 1, 1, "Basic Operation n Meth" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 2, 1, "FUnction n class" });

            migrationBuilder.InsertData(
                table: "MappingUserCourses",
                columns: new[] { "CourseId", "UserId", "Progress" },
                values: new object[] { 1, 1, 5 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 1, "how to make this into this i dont know pleaseeeee help meeeee", new DateTime(2020, 11, 26, 19, 49, 26, 167, DateTimeKind.Local).AddTicks(8430), 1, 6, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 2, "okay so this is how you do this....", new DateTime(2020, 11, 26, 19, 49, 26, 167, DateTimeKind.Local).AddTicks(9328), 1, 3, 2 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 3, "hey guys i got error 500 cna somebody help me?", new DateTime(2020, 11, 26, 19, 49, 26, 167, DateTimeKind.Local).AddTicks(9388), 2, 6, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 4, "no we cant", new DateTime(2020, 11, 26, 19, 49, 26, 167, DateTimeKind.Local).AddTicks(9409), 2, 3, 2 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 5, "You want to find this topic but HTTP404 Not Found...", new DateTime(2020, 11, 26, 19, 49, 26, 167, DateTimeKind.Local).AddTicks(9429), 3, 5, 2 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 1, "ini adalah lesson hello world in ts", new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(4093), 1, "Hello world in ts", new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(4039), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 2, "ini adlaah selection n loop control", new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5200), 1, "selection n loop control", new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5195), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 3, "ini adlah creating a basic calculator", new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5223), 1, "creating a basic calculator", new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5222), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 4, "ini adalah definig a cufntioni", new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5226), 2, "Defining a function", new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5225), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 5, "this is class n object ", new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5228), 2, "class n object ", new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5227), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 6, "ini dalah detail darti making a basci tdiyr pogmra", new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5231), 2, "making a basci tdiyr pogmra", new DateTime(2020, 11, 26, 19, 49, 26, 162, DateTimeKind.Local).AddTicks(5230), "lesson1.jpg", "video1" });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TrackId",
                table: "Courses",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_DiscussionGroupId",
                table: "Discussions",
                column: "DiscussionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_UserId",
                table: "Instructors",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LessonGroups_CourseId",
                table: "LessonGroups",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_LessonGroupId",
                table: "Lessons",
                column: "LessonGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MappingUserCourses_CourseId",
                table: "MappingUserCourses",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MappingUserCourses_UserId",
                table: "MappingUserCourses",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MappingUserTracks_TrackId",
                table: "MappingUserTracks",
                column: "TrackId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MappingUserTracks_UserId",
                table: "MappingUserTracks",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Replies_ThreadId",
                table: "Replies",
                column: "ThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_UserId",
                table: "Replies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Threads_DiscussionId",
                table: "Threads",
                column: "DiscussionId");

            migrationBuilder.CreateIndex(
                name: "IX_Threads_UserId",
                table: "Threads",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Track_TrackGroupId",
                table: "Track",
                column: "TrackGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "MappingUserCourses");

            migrationBuilder.DropTable(
                name: "MappingUserTracks");

            migrationBuilder.DropTable(
                name: "Replies");

            migrationBuilder.DropTable(
                name: "LessonGroups");

            migrationBuilder.DropTable(
                name: "Threads");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Discussions");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Track");

            migrationBuilder.DropTable(
                name: "DiscussionGroups");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TrackGroups");
        }
    }
}
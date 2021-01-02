using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevDrillAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cobas",
                columns: table => new
                {
                    Key = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Test = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobas", x => x.Key);
                });

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
                name: "track",
                columns: table => new
                {
                    TrackId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhotoUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    TrackGroupId = table.Column<int>(nullable: false),
                    Progress = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_track", x => x.TrackId);
                    table.ForeignKey(
                        name: "FK_track_TrackGroups_TrackGroupId",
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
                    Detail = table.Column<string>(nullable: true),
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
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CoverUrl = table.Column<string>(nullable: true),
                    PhotoUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrackId = table.Column<int>(nullable: false),
                    InstructorId = table.Column<int>(nullable: false),
                    Progress = table.Column<double>(nullable: true)
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
                        name: "FK_Courses_track_TrackId",
                        column: x => x.TrackId,
                        principalTable: "track",
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
                    VideoType = table.Column<string>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "MappingUserLessonDones",
                columns: table => new
                {
                    LessonId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    LastActive = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingUserLessonDones", x => new { x.LessonId, x.UserId });
                    table.ForeignKey(
                        name: "FK_MappingUserLessonDones_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MappingUserLessonDones_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 1, "Public Discussion", "" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 8, "Django discussion", "django.png" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 7, "Vue.js discussion", "vuejs.png" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 6, "React.js discussion", "react.png" });

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
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 2, "Angular Discussion", "angular.png" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 5, "Laravel discussion", "angular.png" });

            migrationBuilder.InsertData(
                table: "TrackGroups",
                columns: new[] { "TrackGroupId", "TrackGroupName" },
                values: new object[] { 1, "Fundamental Tracks" });

            migrationBuilder.InsertData(
                table: "TrackGroups",
                columns: new[] { "TrackGroupId", "TrackGroupName" },
                values: new object[] { 2, "Frontend Developer Tracks" });

            migrationBuilder.InsertData(
                table: "TrackGroups",
                columns: new[] { "TrackGroupId", "TrackGroupName" },
                values: new object[] { 3, "Backend Developer Tracks" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsInstructor", "Name", "Password", "PhoneNumber", "PhotoUrl" },
                values: new object[] { 5, "instructor3@email.com", (byte)1, "instructor 3", "instructor 3", "08123546778", "" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsInstructor", "Name", "Password", "PhoneNumber", "PhotoUrl" },
                values: new object[] { 1, "user1@email.com", (byte)0, "user biasa", "user1", "0812121212112", "" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsInstructor", "Name", "Password", "PhoneNumber", "PhotoUrl" },
                values: new object[] { 2, "instructor1@email.com", (byte)1, "instructor 1", "instructor1", "08777777", "" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsInstructor", "Name", "Password", "PhoneNumber", "PhotoUrl" },
                values: new object[] { 3, "user2@email.com", (byte)0, "user2", "user2", "081945680235", "" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsInstructor", "Name", "Password", "PhoneNumber", "PhotoUrl" },
                values: new object[] { 4, "instructor2@email.com", (byte)1, "instructor 2", "instructor2", "08130785690", "" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "IsInstructor", "Name", "Password", "PhoneNumber", "PhotoUrl" },
                values: new object[] { 6, "user3@email.com", (byte)0, "user3", "user3", "081945670143", "" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 1, 1, "General Advice" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 26, 9, "Development Advice" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 25, 9, "Regarding Video" });

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
                values: new object[] { 16, 6, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 15, 6, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 14, 5, "Development Advice" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 20, 7, "Development Advice" });

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
                values: new object[] { 6, 3, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 5, 2, "Development Advice" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 4, 2, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 3, 2, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 2, 1, "Other Frameworks" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 13, 5, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "CompanyName", "Title", "UserId" },
                values: new object[] { 1, "Perusahaan Saya", "CEO and Boss", 2 });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "CompanyName", "Title", "UserId" },
                values: new object[] { 3, "Y", "Instructor Y", 5 });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "CompanyName", "Title", "UserId" },
                values: new object[] { 2, "X", "Instructor X", 4 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "Progress", "TrackGroupId" },
                values: new object[] { 3, "Pada track ini, anda akan fokus pada pemakaian JS sebagai bahasa program yang sering digunakan dalam pembuatan logic dari web. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Javascript", "javascript.png", null, 1 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "Progress", "TrackGroupId" },
                values: new object[] { 4, "Pada track ini, anda akan fokus pada pemakaian React.js sebagai framework frontend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "React.js Developer", "react.png", null, 2 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "Progress", "TrackGroupId" },
                values: new object[] { 5, "Pada track ini, anda akan fokus pada pemakaian Angular sebagai framework frontend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Angular Developer", "angular.png", null, 2 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "Progress", "TrackGroupId" },
                values: new object[] { 6, "Pada track ini, anda akan fokus pada pemakaian Vue.js sebagai framework frontend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Vue.js Developer", "vuejs.png", null, 2 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "Progress", "TrackGroupId" },
                values: new object[] { 7, "Pada track ini, anda akan fokus pada pemakaian .NET Core sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", ".NET Core Developer", "netcore.png", null, 3 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "Progress", "TrackGroupId" },
                values: new object[] { 8, "Pada track ini, anda akan fokus pada pemakaian Laravel sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Laravel Developer", "laravel.png", null, 3 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "Progress", "TrackGroupId" },
                values: new object[] { 9, "Pada track ini, anda akan fokus pada pemakaian Django sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Django Developer", "django.png", null, 3 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "Progress", "TrackGroupId" },
                values: new object[] { 10, "Pada track ini, anda akan fokus pada pemakaian Node.js sebagai run-time environment yang sering digunakan dalam pembuatan web application. Disini kita akan menggunakan Express.js sebagai media frameworknya. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Node.js Developer", "nodejs.png", null, 3 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "Progress", "TrackGroupId" },
                values: new object[] { 11, "Pada track ini, anda akan fokus pada pemakaian Spring sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Spring Developer", "spring.png", null, 3 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "Progress", "TrackGroupId" },
                values: new object[] { 2, "Pada track ini, anda akan fokus pada pemakaian CSS sebagai style yang sering digunakan untuk mempercantik tampilan web. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "CSS", "css.png", null, 1 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "Progress", "TrackGroupId" },
                values: new object[] { 1, "Pada track ini, anda akan fokus pada pemakaian HTML sebagai bahasa markup yang sering digunakan dalam pembuatan struktur tampilan web. Ketika l", "HTML", "html.png", null, 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 14, "cover2.png", "Belajar Javascript untuk membuat web lebih interaktif", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Belajar Javascript untuk pemrograman web", "js_course_4.jpg", null, 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 48, "cover2.png", "Dalam kursus ini, kalian akan diajarkan NodeJS dari dasar hingga topik-topik yang advanced", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Belajar framework NodeJS dari Nol", "nodejs_course_3.jpg", null, 10 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 46, "cover2.png", "Belajar Node JS dari dasar-dasarnya hingga dapat membuat REST API untuk website", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Tutorial lengkap NodeJS untuk membuat REST API", "nodejs_course_1.jpg", null, 10 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 44, "cover2.png", "Ikuti panduan paling up to date mengenai framework Django", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Panduan Lengkap Django 2020", "django_course_3.jpg", null, 9 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 42, "cover2.png", "Dalam kursus ini, kalian akan diajarkan cara membuat website dengan framework Django", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Belajar pemrograman website dengan framework Django", "django_course_1.jpg", null, 9 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 40, "cover2.png", "Kuasai Laravel dengan cepat dengan mengikuti course ini, cocok untuk pemula", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Laravel Masterclass untuk semua", "laravel_course_4.jpg", null, 8 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 38, "cover2.png", "Dalam kursus ini, kalian akan diajarkan Laravel dari dasar hingga topik-topik yang advanced", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Belajar framework Laravel dari Nol", "laravel_course_2.jpg", null, 8 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 36, "cover1.png", "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman PHP  dari dasar hingga fitur-fitur penting dari PHP sampai di titik kalian dapat mengimplementasikan PHP ke dalam proyek apapun yang kalian kerjakan.Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework Laravel", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Object-Oriented Programming with PHP", "php.png", null, 8 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 50, "cover2.png", "Kuasai NodeJS dengan cepat dengan mengikuti course ini, cocok untuk pemula", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "NodeJS Masterclass untuk semua", "nodejs_course_5.png", null, 10 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 34, "cover2.png", "Belajar framework .NET Core dengan panduan paling up-to-date", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Panduan lengkap .NET core 2020", "net_course_3.jpg", null, 7 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 30, "cover2.png", "Cocok untuk yang sedang ingin mempelajari front-end framework", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Dasar - dasar pemrograman Vue yang cocok untuk pemula", "vue_course_5.png", null, 6 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 28, "cover2.png", "Panduan paling up-to-date tentang framework Vue", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Panduan Lengkap Vue 2020", "vue_course_3.jpg", null, 6 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 26, "cover2.png", "Kursus ini ditujukan untuk pemula yang belum pernah menyentuh framework Vue", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Tutorial Vue bagi pemula", "vue_course_1.jpg", null, 6 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 24, "cover2.png", "Belajar framework javascript React dari dasar sampai topik yang advanced", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Belajar Angular dari Nol", "angular_course_2.png", null, 5 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 22, "cover2.png", "Belajar Typescript dari Nol sebagai persiapan untuk mempelajari framework Angular", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Panduan lengkap Typescript 2020", "typescript2.jpg", null, 5 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 20, "cover2.png", "Belajar React dari Nol", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Tutorial React bagi pemula", "react_course_5.png", null, 4 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 18, "cover2.png", "Tutorial paling lengkap tahun 2020 mengenai framework React", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Panduan lengkap React 2020", "react_course_3.png", null, 4 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 32, "cover2.png", "Kursus ini ditargetkan bagi pemula yang tidak memiliki pengalaman sama sekali dengan framework .NET core", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Belajar framework .NET dari Nol", "net_course_1.png", null, 7 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 52, "cover2.png", "Dalam kursus ini, kalian akan diajarkan cara membuat website dengan framework Spring", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Belajar pemrograman website dengan framework Spring", "spring_course_2.png", null, 11 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 55, "cover2.png", "Kuasai Spring dengan cepat dengan mengikuti course ini, cocok untuk pemula", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Spring Masterclass untuk semua", "spring_course_5.png", null, 11 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 17, "cover2.png", "Belajar ReactJS dasar hingga upload ke hosting", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "ReactJS Bahasa Indonesia", "react_course_2.jpg", null, 4 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 51, "cover2.png", "Belajar framework Spring dari dasar-dasarnya hingga dapat membuat REST API untuk website", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Tutorial lengkap Spring untuk membuat REST API", "spring_course_1.png", null, 11 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 49, "cover2.png", "Ikuti panduan paling up to date mengenai framework NodeJS", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Panduan Lengkap NodeJS 2020", "nodejs_course_4.png", null, 10 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 47, "cover2.png", "Dalam kursus ini, kalian akan diajarkan cara membuat API website dengan framework NodeJS", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Belajar pemrograman website dengan framework NodeJS", "nodejs_course_2.jpg", null, 10 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 45, "cover2.png", "Kuasai Django dengan cepat dengan mengikuti course ini, cocok untuk pemula", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Django Masterclass untuk semua", "django_course_4.png", null, 9 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 43, "cover2.png", "Dalam kursus ini, kalian akan diajarkan Django dari dasar hingga topik-topik yang advanced", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Belajar framework Django dari Nol", "django_course_2.jpg", null, 9 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 41, "cover4.png", "Python adalah bahasa pemrograman terkenal yang dibuat dengan fokus untuk mempermudah programmer untuk membaca kodingnya.Dalam kursus ini, kalian akan diajarkan Python dari dasar sampai kalian dapat mengimplementasikannya dalam aplikasi kalian. Kursus ini juga disarankan bagi yang berminat untuk mempelajari framework Django, karena Django menggunakan bahasa pemrograman Python.", new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Python Programming Language", "python.png", null, 9 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 39, "cover2.png", "Ikuti panduan paling up to date mengenai framework Laravel", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Panduan Lengkap Laravel 2020", "laravel_course_3.png", null, 8 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 37, "cover2.png", "Dalam kursus ini, kalian akan diajarkan cara membuat website dengan framework Laravel", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Belajar pemrograman website dengan framework Laravel", "laravel_course_1.png", null, 8 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 35, "cover2.png", "Kuasai .NET core dengan cepat dengan mengikuti course ini", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, ".NET core masterclass untuk semua", "net_course_4.png", null, 7 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 33, "cover2.png", "Belajar .NET core untuk membuat REST API", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Buat REST API dengan framework .NET core", "net_course_2.png", null, 7 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 31, "cover3.png", "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman C# dari dasar hingga fitur-fitur penting dari C# sampai di titik kalian dapat mengimplementasikan C# ke dalam proyek apapun yang kalian kerjakan. Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework ASP.NET", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Asynchronus Programming in C#", "csharp.png", null, 7 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 29, "cover2.png", "Belajar framework javascript Vue dari dasar sampai topik yang advanced.", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Vue Masterclass untuk semua", "vue_course_4.png", null, 6 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 27, "cover2.png", "Belajar framework Vue dari Nol. Tujuan dari course ini adalah untuk dapat mengimplementasi Vue kepada project peserta course.", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Belajar Vue dari Nol", "vue_course_2.png", null, 6 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 25, "cover2.png", "Kursus ini ditujukan untuk pemula yang belum pernah menyentuh framework angular", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Tutorial Angular bagi pemula", "angular_course_3.jpg", null, 5 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 23, "cover2.png", "Belajar topik dasar hingga topik advanced dari framework Angular", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Panduan lengkap Angular 2020", "angular_course_1.jpg", null, 5 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 21, "cover2.png", "Dalam kursus ini, kalian akan diajarkan Typescript dari dasar hingga fitur-fitur penting dari Typescript sampai di titik kalian dapat mengimplementasikan Typescript ke dalam proyek apapun yang kalian kerjakan. Kursus ini juga akan menjadi dasar bagi kalian yang ingin belajar tentang framework Angular", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Introduction to TS", "typescript.png", null, 5 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 19, "cover2.png", "Goal dari kursus ini adalah menguasai framework React", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Belajar Framework React", "react_course_4.jpg", null, 4 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 16, "cover2.png", "Belajar framework javascript React dari dasar sampai topik yang advanced", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "React Masterclass untuk semua", "react_course_1.png", null, 4 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 15, "cover2.png", "Belajar dari nol sampai lancar Javascript", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lancar membuat program dalam Javascript", "js_course_5.png", null, 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 54, "cover2.png", "Ikuti panduan paling up to date mengenai framework Spring", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Panduan Lengkap Spring 2020", "spring_course_4.jpg", null, 11 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 13, "cover2.png", "Belajar Javascript untuk pemula", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mengenal pemrograman Javascript untuk pemula", "js_course_3.jpg", null, 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 53, "cover2.png", "Dalam kursus ini, kalian akan diajarkan Spring dari dasar hingga topik-topik yang advanced", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Belajar framework Spring dari Nol", "nodejs_course_3.jpg", null, 11 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 2, "cover2.png", "Dalam kursus ini, kalian akan diajarkan HTML sebagai dasar dalam membuat website", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "HTML untuk pembuatan dan desain website", "html_course_2.jpg", null, 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 3, "cover2.png", "Mempelajari tentang HTML dasar", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mulai belajar website dengan HTML", "html_course_3.jpg", null, 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 4, "cover2.png", "Pengenalan bahasa markup HTML", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mengenal HTML", "html_course_4.jpg", null, 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 5, "cover2.png", "Tutorial HTML dasar", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Kursus HTML untuk semua orang", "html_course_5.jpg", null, 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 6, "cover2.png", "Dalam kursus ini, akan diperkenalkan CSS untuk mempercantik tampilan website", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tutorial dasar CSS untuk desain website", "css_course_1.jpg", null, 2 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 1, "cover2.png", "Dalam kursus ini, kalian akan diajarkan dasar-dasar markup language HTML", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pengenalan Bahasa Pemrograman HTML", "html_course_1.png", null, 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 8, "cover2.png", "Khusus pemula yang ingin membuat website dengan CSS dan HTML", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Kupas Tuntas CSS dari Nol", "css_course_3.jpg", null, 2 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 9, "cover2.png", "Belajar CSS bagi pemula", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "CSS untuk pemula", "css_course_4.png", null, 2 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 10, "cover2.png", "Mempelajari tentang CSS untuk mempercantik website", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mempercantik tampilan website dengan CSS", "css_course_5.png", null, 2 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 11, "cover2.png", "Cara mudah memahami Javascript dengan mudah", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pemograman dasar dengan Javascript", "js_course_1.png", null, 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 12, "cover2.png", "Tutorial lengkap mengenai Javascript terbaru", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Panduan lengkap Javascript 2020", "js_course_2.jpg", null, 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CoverUrl", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "Progress", "TrackId" },
                values: new object[] { 7, "cover2.png", "Panduan lengkap CSS terbaru", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Panduan lengkap CSS 2020", "css_course_2.jpg", null, 2 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 11, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 4, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(5943), "Error 500", 50, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 10, "Apa saja hal penting yang harus di install?", 4, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(5922), "Bagaimana konfigurasi setup?", 152, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 9, "Udah cek code nya tapi tetep muncul Not Found", 3, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(5901), "HTTP:404 Not Found", 493, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 8, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 3, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(5880), "Error 500", 473, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 5, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 2, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(5779), "Error 500", 54, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 6, "Udah cek code nya tapi tetep muncul Not Found", 2, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(5802), "HTTP:404 Not Found", 67, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 4, "Apa saja hal penting yang harus di install?", 2, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(5757), "Bagaimana konfigurasi setup?", 234, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 3, "Udah cek code nya tapi tetep muncul Not Found", 1, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(5736), "HTTP:404 Not Found", 276, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 2, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 1, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(5685), "Error 500", 194, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 12, "Udah cek code nya tapi tetep muncul Not Found", 4, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(5964), "HTTP:404 Not Found", 357, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 7, "Apa saja hal penting yang harus di install?", 3, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(5823), "Bagaimana konfigurasi setup?", 320, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 13, "Apa saja hal penting yang harus di install?", 5, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(5983), "Bagaimana konfigurasi setup?", 87, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 20, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 7, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6124), "Error 500", 242, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 15, "Udah cek code nya tapi tetep muncul Not Found", 5, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6024), "HTTP:404 Not Found", 392, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 16, "Apa saja hal penting yang harus di install?", 6, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6043), "Bagaimana konfigurasi setup?", 243, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 17, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 6, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6062), "Error 500", 154, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 18, "Udah cek code nya tapi tetep muncul Not Found", 6, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6084), "HTTP:404 Not Found", 432, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 19, "Apa saja hal penting yang harus di install?", 7, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6103), "Bagaimana konfigurasi setup?", 88, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 21, "Udah cek code nya tapi tetep muncul Not Found", 7, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6144), "HTTP:404 Not Found", 299, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 22, "Apa saja hal penting yang harus di install?", 8, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6165), "Bagaimana konfigurasi setup?", 107, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 23, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 8, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6186), "Error 500", 255, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 24, "Udah cek code nya tapi tetep muncul Not Found", 8, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6206), "HTTP:404 Not Found", 419, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 25, "Apa saja hal penting yang harus di install?", 9, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6227), "Bagaimana konfigurasi setup?", 312, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 26, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 9, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6245), "Error 500", 375, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 27, "Udah cek code nya tapi tetep muncul Not Found", 9, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6266), "HTTP:404 Not Found", 249, 6 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 14, "Dapet Error 500 tapi saya ga ngerti cara debug nya. Ad yang tau caranya?", 5, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(6004), "Error 500", 373, 3 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 1, "Apa saja hal penting yang harus di install?", 1, new DateTime(2021, 1, 2, 19, 39, 21, 421, DateTimeKind.Local).AddTicks(4543), "Bagaimana konfigurasi setup?", 167, 1 });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 52, 26, "Pemograman Lanjut Aplikasi Web Vue.js" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 37, 19, "Pengenalan React" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 34, 17, "React Components, State & Props" });

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
                values: new object[] { 38, 19, "React Components, State & Props" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 87, 44, "Django Models & Admin" });

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
                values: new object[] { 71, 36, "Dasar - dasar bahasa pemrograman PHP" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 68, 34, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 67, 34, "Dasar-dasar framework .NET Core" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 64, 32, "Model-View-Controller Pattern" });

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
                values: new object[] { 84, 42, "URL Handler & Views" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 41, 21, "Dasar-dasar Typescript" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 42, 21, "Class & Interface" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 45, 23, "Angular Setup & File Structure" });

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
                values: new object[] { 93, 47, "Dasar - dasar Node" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 90, 45, "URL Handler & Views" });

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
                values: new object[] { 74, 37, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 46, 23, "Angular Components" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 49, 25, "Angular Setup & File Structure" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 50, 25, "Angular Components" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 53, 27, "Dasar Pemograman Aplikasi Web dengan Vue.js " });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 54, 27, "Pemograman Lanjut Aplikasi Web Vue.js" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 57, 29, "Dasar Pemograman Aplikasi Web dengan Vue.js " });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 55, 28, "Dasar Pemograman Aplikasi Web dengan Vue.js " });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 58, 29, "Pemograman Lanjut Aplikasi Web Vue.js" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 62, 31, "Pengenalan Array" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 65, 33, "Dasar-dasar framework .NET Core" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 66, 33, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 69, 35, "Dasar-dasar framework .NET Core" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 70, 35, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 73, 37, "Dasar - dasar bahasa framework Laravel" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 61, 31, "Dasar-dasar pemrograman C#" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 107, 54, "Dasar - dasar bahasa framework Spring" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 108, 54, "Model-View-Controller Pattern" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 48, 24, "Angular Components" });

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
                values: new object[] { 9, 5, "HTML Basic" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 8, 4, "HTML Table" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 51, 26, "Dasar Pemograman Aplikasi Web dengan Vue.js " });

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
                values: new object[] { 2, 1, "HTML Table" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 1, 1, "HTML Basic" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 18, 9, "CSS Box Model" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 19, 10, "CSS Syntax" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 7, 4, "HTML Basic" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 21, 11, "JS introduction" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 20, 10, "CSS Box Model" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 47, 24, "Angular Setup & File Structure" });

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
                values: new object[] { 31, 16, "Pengenalan React" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 40, 20, "React Components, State & Props" });

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
                values: new object[] { 23, 12, "JS introduction" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 30, 15, "JS variables" });

            migrationBuilder.InsertData(
                table: "LessonGroups",
                columns: new[] { "LessonGroupId", "CourseId", "LessonGroupName" },
                values: new object[] { 22, 11, "JS variables" });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 11, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1805), 11, 7, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 10, "Jadi yang harus di install duluan itu ada .......", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1785), 10, 1, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 9, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1762), 9, 1, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 8, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1743), 8, 5, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 7, "Jadi yang harus di install duluan itu ada .......", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1722), 7, 4, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 4, "Jadi yang harus di install duluan itu ada .......", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1617), 4, 4, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 5, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1637), 5, 5, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 3, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1595), 3, 7, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 2, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1512), 2, 5, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 12, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1825), 12, 8, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 6, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1661), 6, 8, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 13, "Jadi yang harus di install duluan itu ada .......", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1846), 13, 1, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 23, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(2069), 23, 8, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 15, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1888), 15, 3, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 16, "Jadi yang harus di install duluan itu ada .......", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1920), 16, 6, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 17, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1943), 17, 5, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 18, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1967), 18, 1, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 19, "Jadi yang harus di install duluan itu ada .......", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1988), 19, 2, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 20, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(2009), 20, 5, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 21, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(2030), 21, 9, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 22, "Jadi yang harus di install duluan itu ada .......", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(2050), 22, 3, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 24, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(2091), 24, 1, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 25, "Jadi yang harus di install duluan itu ada .......", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(2112), 25, 5, 3 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 26, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(2133), 26, 6, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 27, "Saya juga pernah dapet error itu, coba pake codingan yang saya kirim ini....", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(2153), 27, 5, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 14, "Masalah itu solusi nya ada di internet, coba cek link berikut untuk penjelasan lebih detail nya", new DateTime(2021, 1, 2, 19, 39, 21, 420, DateTimeKind.Local).AddTicks(1866), 14, 4, 6 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 1, "Jadi yang harus di install duluan itu ada .......", new DateTime(2021, 1, 2, 19, 39, 21, 419, DateTimeKind.Local).AddTicks(9241), 1, 1, 3 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 1, "Pada lesson kali ini, akan diajarkan HTML Elements", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(5924), 1, "HTML Elements", new DateTime(2021, 1, 2, 19, 39, 21, 405, DateTimeKind.Local).AddTicks(8589), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 30, "Pada lesson kali ini, akan diajarkan syntax pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7577), 17, "CSS Syntax", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7576), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 31, "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7580), 18, "Struktur dari CSS Box Model", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7579), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 32, "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7582), 18, "Kustomisasi Box Model CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7581), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 33, "Pada lesson kali ini, akan diajarkan syntax pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7585), 19, "CSS Syntax", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7583), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 34, "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7587), 20, "Struktur dari CSS Box Model", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7586), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 35, "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7590), 20, "Kustomisasi Box Model CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7588), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 36, "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7592), 21, "Apa itu bahasa pemrograman Javascript?", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7591), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 37, "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7594), 21, "Apa saja yang bisa dilakukan Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7593), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 38, "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7597), 22, "Mendefinisikan Variabel pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7596), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 39, "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7600), 22, "Tipe Data pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7599), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 40, "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7603), 23, "Apa itu bahasa pemrograman Javascript?", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7602), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 29, "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7575), 16, "Kustomisasi Box Model CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7574), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 41, "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7605), 23, "Apa saja yang bisa dilakukan Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7604), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 43, "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7610), 24, "Tipe Data pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7609), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 44, "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7613), 25, "Apa itu bahasa pemrograman Javascript?", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7612), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 45, "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7615), 25, "Apa saja yang bisa dilakukan Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7614), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 46, "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7618), 26, "Mendefinisikan Variabel pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7617), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 47, "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7620), 26, "Tipe Data pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7619), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 48, "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7622), 27, "Apa itu bahasa pemrograman Javascript?", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7621), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 49, "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7625), 27, "Apa saja yang bisa dilakukan Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7624), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 50, "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7627), 28, "Mendefinisikan Variabel pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7626), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 51, "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7630), 28, "Tipe Data pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7629), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 52, "Pada lesson kali ini, akan diperkenalkan bahasa pemrograman Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7632), 29, "Apa itu bahasa pemrograman Javascript?", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7631), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 53, "Pada lesson kali ini, akan dijelaskan apa saja kegunaan dari Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7635), 29, "Apa saja yang bisa dilakukan Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7634), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 42, "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7608), 24, "Mendefinisikan Variabel pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7607), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 54, "Pada lesson kali ini, akan diajarkan bagaimana cara mendefinisikan sebuah variabel pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7637), 30, "Mendefinisikan Variabel pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7636), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 28, "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7572), 16, "Struktur dari CSS Box Model", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7571), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 26, "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7567), 14, "Kustomisasi Box Model CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7566), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 2, "Pada lesson kali ini, akan diajarkan HTML Headings", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7477), 1, "HTML Headings", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7470), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 3, "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7509), 2, "Membuat table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7508), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 4, "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7512), 2, "Pelajaran lebih lanjut mengenai table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7511), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 5, "Pada lesson kali ini, akan diajarkan HTML Elements", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7514), 3, "HTML Elements", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7513), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 6, "Pada lesson kali ini, akan diajarkan HTML Headings", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7517), 3, "HTML Headings", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7516), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 7, "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7519), 4, "Membuat table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7518), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 8, "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7522), 4, "Pelajaran lebih lanjut mengenai table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7521), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 9, "Pada lesson kali ini, akan diajarkan HTML Elements", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7524), 5, "HTML Elements", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7523), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 10, "Pada lesson kali ini, akan diajarkan HTML Headings", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7527), 5, "HTML Headings", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7526), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 11, "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7529), 6, "Membuat table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7528), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 12, "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7532), 6, "Pelajaran lebih lanjut mengenai table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7531), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 27, "Pada lesson kali ini, akan diajarkan syntax pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7570), 15, "CSS Syntax", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7569), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 13, "Pada lesson kali ini, akan diajarkan HTML Elements", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7535), 7, "HTML Elements", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7533), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 15, "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7540), 8, "Membuat table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7539), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 16, "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7542), 8, "Pelajaran lebih lanjut mengenai table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7541), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 17, "Pada lesson kali ini, akan diajarkan HTML Elements", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7545), 9, "HTML Elements", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7543), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 18, "Pada lesson kali ini, akan diajarkan HTML Headings", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7547), 9, "HTML Headings", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7546), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 19, "Pada lesson kali ini, akan diajarkan bagaimana membuat table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7550), 10, "Membuat table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7548), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 20, "Pada lesson kali ini, akan diajarkan HTML table secara lebih rinci", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7552), 10, "Pelajaran lebih lanjut mengenai table pada HTML", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7551), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 21, "Pada lesson kali ini, akan diajarkan syntax pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7554), 11, "CSS Syntax", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7553), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 22, "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7558), 12, "Struktur dari CSS Box Model", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7556), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 23, "Pada lesson kali ini, akan diajarkan cara mengkustomisasi Box Model pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7560), 12, "Kustomisasi Box Model CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7559), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 24, "Pada lesson kali ini, akan diajarkan syntax pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7562), 13, "CSS Syntax", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7561), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 25, "Pada lesson kali ini, akan diajarkan struktur dari Box Model pada CSS", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7565), 14, "Struktur dari CSS Box Model", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7564), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 14, "Pada lesson kali ini, akan diajarkan HTML Headings", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7537), 7, "HTML Headings", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7536), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoType", "VideoUrl" },
                values: new object[] { 55, "Pada lesson kali ini, akan diajarkan apa saja tipe data yang ada di Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7640), 30, "Tipe Data pada Javascript", new DateTime(2021, 1, 2, 19, 39, 21, 406, DateTimeKind.Local).AddTicks(7638), "lesson1.jpg", "video/mp4", "sample.mp4" });

            migrationBuilder.InsertData(
                table: "MappingUserLessonDones",
                columns: new[] { "LessonId", "UserId", "LastActive" },
                values: new object[] { 1, 1, new DateTime(2021, 1, 2, 19, 39, 21, 418, DateTimeKind.Local).AddTicks(6600) });

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
                name: "IX_MappingUserLessonDones_UserId",
                table: "MappingUserLessonDones",
                column: "UserId");

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
                name: "IX_track_TrackGroupId",
                table: "track",
                column: "TrackGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cobas");

            migrationBuilder.DropTable(
                name: "MappingUserLessonDones");

            migrationBuilder.DropTable(
                name: "Replies");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Threads");

            migrationBuilder.DropTable(
                name: "LessonGroups");

            migrationBuilder.DropTable(
                name: "Discussions");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "DiscussionGroups");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "track");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TrackGroups");
        }
    }
}

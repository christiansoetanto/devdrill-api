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
                    TrackGroupId = table.Column<int>(nullable: false)
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
                        name: "FK_MappingUserTracks_track_TrackId",
                        column: x => x.TrackId,
                        principalTable: "track",
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
                values: new object[] { 1, "Public Discussion", "" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 2, "Angular Discussion", "angular.png" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 3, "Node.js Discussion", "nodejs.png" });

            migrationBuilder.InsertData(
                table: "DiscussionGroups",
                columns: new[] { "DiscussionGroupId", "Name", "PhotoUrl" },
                values: new object[] { 4, "ASP.NET Core Discussion", "netcore.png" });

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
                values: new object[] { 20, 7, "Development Advice" });

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
                values: new object[] { 19, 7, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 12, 5, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 13, 5, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 3, 2, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 4, 2, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 5, 2, "Development Advice" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 6, 3, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 2, 1, "Other Frameworks" });

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
                values: new object[] { 9, 4, "Installation" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 10, 4, "Regarding Video" });

            migrationBuilder.InsertData(
                table: "Discussions",
                columns: new[] { "DiscussionId", "DiscussionGroupId", "Name" },
                values: new object[] { 11, 4, "Development Advice" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "CompanyName", "Title", "UserId" },
                values: new object[] { 1, "Perusahaan Saya", "CEO and Boss", 2 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 2, "Pada track ini, anda akan fokus pada pemakaian CSS sebagai style yang sering digunakan untuk mempercantik tampilan web. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "CSS", "css.png", 1 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 3, "Pada track ini, anda akan fokus pada pemakaian JS sebagai bahasa program yang sering digunakan dalam pembuatan logic dari web. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Javascript", "javascript.png", 1 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 11, "Pada track ini, anda akan fokus pada pemakaian Spring sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Spring Developer", "spring.png", 3 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 5, "Pada track ini, anda akan fokus pada pemakaian Angular sebagai framework frontend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Angular Developer", "angular.png", 2 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 6, "Pada track ini, anda akan fokus pada pemakaian Vue.js sebagai framework frontend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Vue.js Developer", "vuejs.png", 2 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 7, "Pada track ini, anda akan fokus pada pemakaian .NET Core sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", ".NET Core Developer", "netcore.png", 3 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 8, "Pada track ini, anda akan fokus pada pemakaian Laravel sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Laravel Developer", "laravel.png", 3 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 9, "Pada track ini, anda akan fokus pada pemakaian Django sebagai framework backend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Django Developer", "django.png", 3 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 10, "Pada track ini, anda akan fokus pada pemakaian Node.js sebagai run-time environment yang sering digunakan dalam pembuatan web application. Disini kita akan menggunakan Express.js sebagai media frameworknya. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "Node.js Developer", "nodejs.png", 3 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 1, "Pada track ini, anda akan fokus pada pemakaian HTML sebagai bahasa markup yang sering digunakan dalam pembuatan struktur tampilan web. Ketika l", "HTML", "html.png", 1 });

            migrationBuilder.InsertData(
                table: "track",
                columns: new[] { "TrackId", "Detail", "Name", "PhotoUrl", "TrackGroupId" },
                values: new object[] { 4, "Pada track ini, anda akan fokus pada pemakaian React.js sebagai framework frontend yang sering digunakan dalam pembuatan web application. Ketika lulus dari track ini, anda akan memahami lebih dalam sampai pada trik-triknya.", "React.js Developer", "react.png", 2 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 1, "Dalam kursus ini, kalian akan diajarkan Typescript dari dasar hingga fitur-fitur penting dari Typescript sampai di titik kalian dapa", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Introduction to TS", "typescript.png", 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 2, "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman C# dari dasar hingga fitur-fitur penting dari C# sampai di titik kalian dapat mengimplementasikan C# ke dalam proyek apapun yang kalian kerjakan. Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework ASP.NET", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Asynchronus Programming in C#", "csharp.png", 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 3, "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman PHP  dari dasar hingga fitur-fitur penting dari PHP sampai di titik kalian dapat mengimplementasikan PHP ke dalam proyek apapun yang kalian kerjakan.Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework Laravel", new DateTime(2014, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Object-Oriented Programming with PHP", "php.png", 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Detail", "InsertDate", "InstructorId", "Name", "PhotoUrl", "TrackId" },
                values: new object[] { 4, "Python adalah bahasa pemrograman terkenal yang dibuat dengan fokus untuk mempermudah programmer untuk membaca kodingnya.Dalam kursus ini, kalian akan diajarkan Python dari dasar sampai kalian dapat mengimplementasikannya dalam aplikasi kalian.", new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Python Programming Language", "python.png", 1 });

            migrationBuilder.InsertData(
                table: "MappingUserTracks",
                columns: new[] { "TrackId", "UserId", "Progress" },
                values: new object[] { 1, 1, 9 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 1, "gk tau samain ama reply", 1, new DateTime(2020, 12, 10, 12, 43, 53, 330, DateTimeKind.Local).AddTicks(3257), "How to make this into", 17, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 2, "gk tau samain ama reply", 1, new DateTime(2020, 12, 10, 12, 43, 53, 330, DateTimeKind.Local).AddTicks(5323), "Error 500", 212, 1 });

            migrationBuilder.InsertData(
                table: "Threads",
                columns: new[] { "ThreadId", "Detail", "DiscussionId", "InsertDate", "Topic", "Upvote", "UserId" },
                values: new object[] { 3, "gk tau samain ama reply", 3, new DateTime(2020, 12, 10, 12, 43, 53, 330, DateTimeKind.Local).AddTicks(5382), "HTTP404 Not Found", 58, 2 });

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
                values: new object[] { 1, 1, 9 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 1, "how to make this into this i dont know pleaseeeee help meeeee", new DateTime(2020, 12, 10, 12, 43, 53, 328, DateTimeKind.Local).AddTicks(9761), 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 2, "okay so this is how you do this....", new DateTime(2020, 12, 10, 12, 43, 53, 329, DateTimeKind.Local).AddTicks(626), 1, 3, 2 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 3, "hey guys i got error 500 cna somebody help me?", new DateTime(2020, 12, 10, 12, 43, 53, 329, DateTimeKind.Local).AddTicks(727), 2, 8, 1 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 4, "no we cant", new DateTime(2020, 12, 10, 12, 43, 53, 329, DateTimeKind.Local).AddTicks(749), 2, 5, 2 });

            migrationBuilder.InsertData(
                table: "Replies",
                columns: new[] { "ReplyId", "Detail", "InsertDate", "ThreadId", "Upvote", "UserId" },
                values: new object[] { 5, "You want to find this topic but HTTP404 Not Found...", new DateTime(2020, 12, 10, 12, 43, 53, 329, DateTimeKind.Local).AddTicks(769), 3, 8, 2 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 1, "ini adalah lesson hello world in ts", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(1731), 1, "Hello world in ts", new DateTime(2020, 12, 10, 12, 43, 53, 322, DateTimeKind.Local).AddTicks(9884), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 2, "ini adlaah selection n loop control", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2895), 1, "selection n loop control", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2889), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 3, "ini adlah creating a basic calculator", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2918), 1, "creating a basic calculator", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2917), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 4, "ini adalah definig a cufntioni", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2920), 2, "Defining a function", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2919), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 5, "this is class n object ", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2922), 2, "class n object ", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2921), "lesson1.jpg", "video1" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Detail", "EndDateTime", "LessonGroupId", "Name", "StartDateTime", "ThumbnailUrl", "VideoUrl" },
                values: new object[] { 6, "ini dalah detail darti making a basci tdiyr pogmra", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2925), 2, "making a basci tdiyr pogmra", new DateTime(2020, 12, 10, 12, 43, 53, 324, DateTimeKind.Local).AddTicks(2924), "lesson1.jpg", "video1" });

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
                name: "IX_track_TrackGroupId",
                table: "track",
                column: "TrackGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cobas");

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
                name: "track");

            migrationBuilder.DropTable(
                name: "DiscussionGroups");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TrackGroups");
        }
    }
}

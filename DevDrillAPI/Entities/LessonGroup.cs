using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class LessonGroup

    {
        public int LessonGroupId { get; set; }
        public string LessonGroupName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<Lesson> Lessons { get; set; }

    }

    public class LessonGroupModelBuilder : IEntityTypeConfiguration<LessonGroup>
    {
        public void Configure(EntityTypeBuilder<LessonGroup> entity)
        {
            entity.HasKey(e => e.LessonGroupId);
            entity.Property(e => e.LessonGroupName).IsRequired();
            entity.HasData(
                //HTML
                new
                {
                    LessonGroupId = 1,
                    LessonGroupName = "HTML Basic",
                    CourseId = 1
                },
                new
                {
                    LessonGroupId = 2,
                    LessonGroupName = "HTML Table",
                    CourseId = 1
                },

                new
                {
                    LessonGroupId = 3,
                    LessonGroupName = "HTML Basic",
                    CourseId = 2
                },
                new
                {
                    LessonGroupId = 4,
                    LessonGroupName = "HTML Table",
                    CourseId = 2
                },

                new
                {
                    LessonGroupId = 5,
                    LessonGroupName = "HTML Basic",
                    CourseId = 3
                },
                new
                {
                    LessonGroupId = 6,
                    LessonGroupName = "HTML Table",
                    CourseId = 3
                },

                new
                {
                    LessonGroupId = 7,
                    LessonGroupName = "HTML Basic",
                    CourseId = 4
                },
                new
                {
                    LessonGroupId = 8,
                    LessonGroupName = "HTML Table",
                    CourseId = 4
                },

                new
                {
                    LessonGroupId = 9,
                    LessonGroupName = "HTML Basic",
                    CourseId = 5
                },
                new
                {
                    LessonGroupId = 10,
                    LessonGroupName = "HTML Table",
                    CourseId = 5
                },

                // CSS
                // 1. 
                new
                {
                    LessonGroupId = 11,
                    LessonGroupName = "CSS Syntax",
                    CourseId = 6
                },
                new
                {
                    LessonGroupId = 12,
                    LessonGroupName = "CSS Box Model",
                    CourseId = 6
                },

                 new
                 {
                     LessonGroupId = 13,
                     LessonGroupName = "CSS Syntax",
                     CourseId = 7
                 },
                new
                {
                    LessonGroupId = 14,
                    LessonGroupName = "CSS Box Model",
                    CourseId = 7
                },

                 new
                 {
                     LessonGroupId = 15,
                     LessonGroupName = "CSS Syntax",
                     CourseId = 8
                 },
                new
                {
                    LessonGroupId = 16,
                    LessonGroupName = "CSS Box Model",
                    CourseId = 8
                },

                 new
                 {
                     LessonGroupId = 17,
                     LessonGroupName = "CSS Syntax",
                     CourseId = 9
                 },
                new
                {
                    LessonGroupId = 18,
                    LessonGroupName = "CSS Box Model",
                    CourseId = 9
                },
                 new
                 {
                     LessonGroupId = 19,
                     LessonGroupName = "CSS Syntax",
                     CourseId = 10
                 },
                new
                {
                    LessonGroupId = 20,
                    LessonGroupName = "CSS Box Model",
                    CourseId = 10
                },

                // JS
                new
                {
                    LessonGroupId = 21,
                    LessonGroupName = "JS introduction",
                    CourseId = 11
                },
                new
                {
                    LessonGroupId = 22,
                    LessonGroupName = "JS variables",
                    CourseId = 11
                },

                new
                {
                    LessonGroupId = 23,
                    LessonGroupName = "JS introduction",
                    CourseId = 12
                },
                new
                {
                    LessonGroupId = 24,
                    LessonGroupName = "JS variables",
                    CourseId = 12
                },

                new
                {
                    LessonGroupId = 25,
                    LessonGroupName = "JS introduction",
                    CourseId = 13
                },
                new
                {
                    LessonGroupId = 26,
                    LessonGroupName = "JS variables",
                    CourseId = 13
                },

                new
                {
                    LessonGroupId = 27,
                    LessonGroupName = "JS introduction",
                    CourseId = 14
                },
                new
                {
                    LessonGroupId = 28,
                    LessonGroupName = "JS variables",
                    CourseId = 14
                },

                new
                {
                    LessonGroupId = 29,
                    LessonGroupName = "JS introduction",
                    CourseId = 15
                },
                new
                {
                    LessonGroupId = 30,
                    LessonGroupName = "JS variables",
                    CourseId = 15
                },

                 // React
                 new
                 {
                     LessonGroupId = 31,
                     LessonGroupName = "Pengenalan React",
                     CourseId = 16
                 },
                new
                {
                    LessonGroupId = 32,
                    LessonGroupName = "React Components, State & Props",
                    CourseId = 16
                },

                new
                {
                    LessonGroupId = 33,
                    LessonGroupName = "Pengenalan React",
                    CourseId = 17
                },
                new
                {
                    LessonGroupId = 34,
                    LessonGroupName = "React Components, State & Props",
                    CourseId = 17
                },

                new
                {
                    LessonGroupId = 35,
                    LessonGroupName = "Pengenalan React",
                    CourseId = 18
                },
                new
                {
                    LessonGroupId = 36,
                    LessonGroupName = "React Components, State & Props",
                    CourseId = 18
                },

                 new
                 {
                     LessonGroupId = 37,
                     LessonGroupName = "Pengenalan React",
                     CourseId = 19
                 },
                new
                {
                    LessonGroupId = 38,
                    LessonGroupName = "React Components, State & Props",
                    CourseId = 19
                },

                 new
                 {
                     LessonGroupId = 39,
                     LessonGroupName = "Pengenalan React",
                     CourseId = 20
                 },
                new
                {
                    LessonGroupId = 40,
                    LessonGroupName = "React Components, State & Props",
                    CourseId = 20
                },

                // Angular
                new
                {
                    LessonGroupId = 41,
                    LessonGroupName = "Dasar-dasar Typescript",
                    CourseId = 21
                },
                new
                {
                    LessonGroupId = 42,
                    LessonGroupName = "Class & Interface",
                    CourseId = 21
                },

                 new
                 {
                     LessonGroupId = 43,
                     LessonGroupName = "Dasar-dasar Typescript",
                     CourseId = 22
                 },
                new
                {
                    LessonGroupId = 44,
                    LessonGroupName = "Class & Interface",
                    CourseId = 22
                },

                 new
                 {
                     LessonGroupId = 45,
                     LessonGroupName = "Angular Setup & File Structure",
                     CourseId = 23
                 },
                new
                {
                    LessonGroupId = 46,
                    LessonGroupName = "Angular Components",
                    CourseId = 23
                },

                new
                {
                    LessonGroupId = 47,
                    LessonGroupName = "Angular Setup & File Structure",
                    CourseId = 24
                },
                new
                {
                    LessonGroupId = 48,
                    LessonGroupName = "Angular Components",
                    CourseId = 24
                },

                new
                {
                    LessonGroupId = 49,
                    LessonGroupName = "Angular Setup & File Structure",
                    CourseId = 25
                },
                new
                {
                    LessonGroupId = 50,
                    LessonGroupName = "Angular Components",
                    CourseId = 25
                },

                 // Vue
                 new
                 {
                     LessonGroupId = 51,
                     LessonGroupName = "Dasar Pemograman Aplikasi Web dengan Vue.js ",
                     CourseId = 26
                 },
                new
                {
                    LessonGroupId = 52,
                    LessonGroupName = "Pemograman Lanjut Aplikasi Web Vue.js",
                    CourseId = 26
                },
                 new
                 {
                     LessonGroupId = 53,
                     LessonGroupName = "Dasar Pemograman Aplikasi Web dengan Vue.js ",
                     CourseId = 27
                 },
                new
                {
                    LessonGroupId = 54,
                    LessonGroupName = "Pemograman Lanjut Aplikasi Web Vue.js",
                    CourseId = 27
                },
                new
                {
                    LessonGroupId = 55,
                    LessonGroupName = "Dasar Pemograman Aplikasi Web dengan Vue.js ",
                    CourseId = 28
                },
                new
                {
                    LessonGroupId = 56,
                    LessonGroupName = "Pemograman Lanjut Aplikasi Web Vue.js",
                    CourseId = 28
                },
                new
                {
                    LessonGroupId = 57,
                    LessonGroupName = "Dasar Pemograman Aplikasi Web dengan Vue.js ",
                    CourseId = 29
                },
                new
                {
                    LessonGroupId = 58,
                    LessonGroupName = "Pemograman Lanjut Aplikasi Web Vue.js",
                    CourseId = 29
                },
                new
                {
                    LessonGroupId = 59,
                    LessonGroupName = "Dasar Pemograman Aplikasi Web dengan Vue.js ",
                    CourseId = 30
                },
                new
                {
                    LessonGroupId = 60,
                    LessonGroupName = "Pemograman Lanjut Aplikasi Web Vue.js",
                    CourseId = 30
                },

                // .NET Core
                new
                {
                    LessonGroupId = 61,
                    LessonGroupName = "Dasar-dasar pemrograman C#",
                    CourseId = 31
                },
                new
                {
                    LessonGroupId = 62,
                    LessonGroupName = "Pengenalan Array",
                    CourseId = 31
                },
                new
                {
                    LessonGroupId = 63,
                    LessonGroupName = "Dasar-dasar framework .NET Core",
                    CourseId = 32
                },
                new
                {
                    LessonGroupId = 64,
                    LessonGroupName = "Model-View-Controller Pattern",
                    CourseId = 32
                },
                 new
                 {
                     LessonGroupId = 65,
                     LessonGroupName = "Dasar-dasar framework .NET Core",
                     CourseId = 33
                 },
                new
                {
                    LessonGroupId = 66,
                    LessonGroupName = "Model-View-Controller Pattern",
                    CourseId = 33
                },
                 new
                 {
                     LessonGroupId = 67,
                     LessonGroupName = "Dasar-dasar framework .NET Core",
                     CourseId = 34
                 },
                new
                {
                    LessonGroupId = 68,
                    LessonGroupName = "Model-View-Controller Pattern",
                    CourseId = 34
                },
                 new
                 {
                     LessonGroupId = 69,
                     LessonGroupName = "Dasar-dasar framework .NET Core",
                     CourseId = 35
                 },
                new
                {
                    LessonGroupId = 70,
                    LessonGroupName = "Model-View-Controller Pattern",
                    CourseId = 35
                },

                // Laravel
                new
                {
                    LessonGroupId = 71,
                    LessonGroupName = "Dasar - dasar bahasa pemrograman PHP",
                    CourseId = 36
                },
                new
                {
                    LessonGroupId = 72,
                    LessonGroupName = "Object-Oriented Programming pada PHP",
                    CourseId = 36
                },
                new
                {
                    LessonGroupId = 73,
                    LessonGroupName = "Dasar - dasar bahasa framework Laravel",
                    CourseId = 37
                },
                new
                {
                    LessonGroupId = 74,
                    LessonGroupName = "Model-View-Controller Pattern",
                    CourseId = 37
                },
                new
                {
                    LessonGroupId = 75,
                    LessonGroupName = "Dasar - dasar bahasa framework Laravel",
                    CourseId = 38
                },
                new
                {
                    LessonGroupId = 76,
                    LessonGroupName = "Model-View-Controller Pattern",
                    CourseId = 38
                },
                new
                {
                    LessonGroupId = 77,
                    LessonGroupName = "Dasar - dasar bahasa framework Laravel",
                    CourseId = 39
                },
                new
                {
                    LessonGroupId = 78,
                    LessonGroupName = "Model-View-Controller Pattern",
                    CourseId = 39
                },
                new
                {
                    LessonGroupId = 79,
                    LessonGroupName = "Dasar - dasar bahasa framework Laravel",
                    CourseId = 40
                },
                new
                {
                    LessonGroupId = 80,
                    LessonGroupName = "Model-View-Controller Pattern",
                    CourseId = 40
                },

                // Django
                new
                {
                    LessonGroupId = 81,
                    LessonGroupName = "Dasar - dasar bahasa pemrograman Python",
                    CourseId = 41
                },
                new
                {
                    LessonGroupId = 82,
                    LessonGroupName = "Object-Oriented Programming pada Python",
                    CourseId = 41
                },
                new
                {
                    LessonGroupId = 83,
                    LessonGroupName = "Django Models & Admin",
                    CourseId = 42
                },
                new
                {
                    LessonGroupId = 84,
                    LessonGroupName = "URL Handler & Views",
                    CourseId = 42
                },
                 new
                 {
                     LessonGroupId = 85,
                     LessonGroupName = "Django Models & Admin",
                     CourseId = 43
                 },
                new
                {
                    LessonGroupId = 86,
                    LessonGroupName = "URL Handler & Views",
                    CourseId = 43
                },
                 new
                 {
                     LessonGroupId = 87,
                     LessonGroupName = "Django Models & Admin",
                     CourseId = 44
                 },
                new
                {
                    LessonGroupId = 88,
                    LessonGroupName = "URL Handler & Views",
                    CourseId = 44
                },
                 new
                 {
                     LessonGroupId = 89,
                     LessonGroupName = "Django Models & Admin",
                     CourseId = 45
                 },
                new
                {
                    LessonGroupId = 90,
                    LessonGroupName = "URL Handler & Views",
                    CourseId = 45
                },

                 // Nodejs
                 new
                 {
                     LessonGroupId = 91,
                     LessonGroupName = "Dasar - dasar Node",
                     CourseId = 46
                 },
                new
                {
                    LessonGroupId = 92,
                    LessonGroupName = "Node Module",
                    CourseId = 46
                },
                new
                {
                    LessonGroupId = 93,
                    LessonGroupName = "Dasar - dasar Node",
                    CourseId = 47
                },
                new
                {
                    LessonGroupId = 94,
                    LessonGroupName = "Node Module",
                    CourseId = 47
                },
                new
                {
                    LessonGroupId = 95,
                    LessonGroupName = "Dasar - dasar Node",
                    CourseId = 48
                },
                new
                {
                    LessonGroupId = 96,
                    LessonGroupName = "Node Module",
                    CourseId = 48
                },
                new
                {
                    LessonGroupId = 97,
                    LessonGroupName = "Dasar - dasar Node",
                    CourseId = 49
                },
                new
                {
                    LessonGroupId = 98,
                    LessonGroupName = "Node Module",
                    CourseId = 49
                },
                new
                {
                    LessonGroupId = 99,
                    LessonGroupName = "Dasar - dasar Node",
                    CourseId = 50
                },
                new
                {
                    LessonGroupId = 100,
                    LessonGroupName = "Node Module",
                    CourseId = 50
                },

                // Spring
                new
                {
                    LessonGroupId = 101,
                    LessonGroupName = "Dasar - dasar bahasa framework Spring",
                    CourseId = 51
                },
                new
                {
                    LessonGroupId = 102,
                    LessonGroupName = "Model-View-Controller Pattern",
                    CourseId = 51
                },
                new
                {
                    LessonGroupId = 103,
                    LessonGroupName = "Dasar - dasar bahasa framework Spring",
                    CourseId = 52
                },
                new
                {
                    LessonGroupId = 104,
                    LessonGroupName = "Model-View-Controller Pattern",
                    CourseId = 52
                },
                 new
                 {
                     LessonGroupId = 105,
                     LessonGroupName = "Dasar - dasar bahasa framework Spring",
                     CourseId = 53
                 },
                new
                {
                    LessonGroupId = 106,
                    LessonGroupName = "Model-View-Controller Pattern",
                    CourseId = 53
                },
                 new
                 {
                     LessonGroupId = 107,
                     LessonGroupName = "Dasar - dasar bahasa framework Spring",
                     CourseId = 54
                 },
                new
                {
                    LessonGroupId = 108,
                    LessonGroupName = "Model-View-Controller Pattern",
                    CourseId = 54
                },
                 new
                 {
                     LessonGroupId = 109,
                     LessonGroupName = "Dasar - dasar bahasa framework Spring",
                     CourseId = 55
                 },
                new
                {
                    LessonGroupId = 110,
                    LessonGroupName = "Model-View-Controller Pattern",
                    CourseId = 55
                }
            );
        }
    }
}
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class Course

    {
        public int CourseId { get; set; }
        public string CoverUrl { get; set; }
        public string PhotoUrl { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public DateTime InsertDate { get; set; }
        public List<LessonGroup> LessonGroups { get; set; }
        public int TrackId { get; set; }
        public Track Track { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public double? Progress { get; set; }
    }

    public class CourseModelBuilder : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> entity)
        {
            entity.HasKey(e => e.CourseId);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.HasData(
                //HTML
                new
                {
                    CourseId = 1,
                    PhotoUrl = "html_course_1.png",
                    Name = "Pengenalan Bahasa Pemrograman HTML",
                    Detail = "Dalam kursus ini, kalian akan diajarkan dasar-dasar markup language HTML",
                    InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                    TrackId = 1,
                    InstructorId = 1
                },
                new
                {
                    CourseId = 2,
                    PhotoUrl = "html_course_2.jpg",
                    Name = "HTML untuk pembuatan dan desain website",
                    Detail = "Dalam kursus ini, kalian akan diajarkan HTML sebagai dasar dalam membuat website",
                    InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                    TrackId = 1,
                    InstructorId = 1
                },
                new
                {
                    CourseId = 3,
                    PhotoUrl = "html_course_3.jpg",
                    Name = "Mulai belajar website dengan HTML",
                    Detail = "Mempelajari tentang HTML dasar",
                    InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                    TrackId = 1,
                    InstructorId = 1
                },
                new
                {
                    CourseId = 4,
                    PhotoUrl = "html_course_4.jpg",
                    Name = "Mengenal HTML",
                    Detail = "Pengenalan bahasa markup HTML",
                    InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                    TrackId = 1,
                    InstructorId = 1
                },
                new
                {
                    CourseId = 5,
                    PhotoUrl = "html_course_5.jpg",
                    Name = "Kursus HTML untuk semua orang",
                    Detail = "Tutorial HTML dasar",
                    InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                    TrackId = 1,
                    InstructorId = 1
                },

                //CSS
                new
                {
                    CourseId = 6,
                    PhotoUrl = "css_course_1.jpg",
                    Name = "Tutorial dasar CSS untuk desain website",
                    Detail = "Dalam kursus ini, akan diperkenalkan CSS untuk mempercantik tampilan website",
                    InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                    TrackId = 2,
                    InstructorId = 1
                },
                new
                {
                    CourseId = 7,
                    PhotoUrl = "css_course_2.jpg",
                    Name = "Panduan lengkap CSS 2020",
                    Detail = "Panduan lengkap CSS terbaru",
                    InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                    TrackId = 2,
                    InstructorId = 1
                },
                new
                {
                    CourseId = 8,
                    PhotoUrl = "css_course_3.jpg",
                    Name = "Kupas Tuntas CSS dari Nol",
                    Detail = "Khusus pemula yang ingin membuat website dengan CSS dan HTML",
                    InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                    TrackId = 2,
                    InstructorId = 1
                },
                 new
                 {
                     CourseId = 9,
                     PhotoUrl = "css_course_4.png",
                     Name = "CSS untuk pemula",
                     Detail = "Belajar CSS bagi pemula",
                     InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                     TrackId = 2,
                     InstructorId = 1
                 },
                  new
                  {
                      CourseId = 10,
                      PhotoUrl = "css_course_5.png",
                      Name = "Mempercantik tampilan website dengan CSS",
                      Detail = "Mempelajari tentang CSS untuk mempercantik website",
                      InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                      TrackId = 2,
                      InstructorId = 1
                  },

                 // JS
                 new
                 {
                     CourseId = 11,
                     PhotoUrl = "js_course_1.png",
                     Name = "Pemograman dasar dengan Javascript",
                     Detail = "Cara mudah memahami Javascript dengan mudah",
                     InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                     TrackId = 3,
                     InstructorId = 1
                 },
                  new
                  {
                      CourseId = 12,
                      PhotoUrl = "js_course_2.jpg",
                      Name = "Panduan lengkap Javascript 2020",
                      Detail = "Tutorial lengkap mengenai Javascript terbaru",
                      InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                      TrackId = 3,
                      InstructorId = 1
                  },
                  new
                  {
                      CourseId = 13,
                      PhotoUrl = "js_course_3.jpg",
                      Name = "Mengenal pemrograman Javascript untuk pemula",
                      Detail = "Belajar Javascript untuk pemula",
                      InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                      TrackId = 3,
                      InstructorId = 1
                  },
                   new
                   {
                       CourseId = 14,
                       PhotoUrl = "js_course_4.jpg",
                       Name = "Belajar Javascript untuk pemrograman web",
                       Detail = "Belajar Javascript untuk membuat web lebih interaktif",
                       InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                       TrackId = 3,
                       InstructorId = 1
                   },
                   new
                   {
                       CourseId = 15,
                       PhotoUrl = "js_course_5.png",
                       Name = "Lancar membuat program dalam Javascript",
                       Detail = "Belajar dari nol sampai lancar Javascript",
                       InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                       TrackId = 3,
                       InstructorId = 1
                   },

                   // React
                   new
                   {
                       CourseId = 16,
                       PhotoUrl = "react_course_1.png",
                       Name = "React Masterclass untuk semua",
                       Detail = "Belajar framework javascript React dari dasar sampai topik yang advanced",
                       InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                       TrackId = 4,
                       InstructorId = 2
                   },
                   new
                   {
                       CourseId = 17,
                       PhotoUrl = "react_course_2.jpg",
                       Name = "ReactJS Bahasa Indonesia",
                       Detail = "Belajar ReactJS dasar hingga upload ke hosting",
                       InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                       TrackId = 4,
                       InstructorId = 3
                   },
                   new
                   {
                       CourseId = 18,
                       PhotoUrl = "react_course_3.png",
                       Name = "Panduan lengkap React 2020",
                       Detail = "Tutorial paling lengkap tahun 2020 mengenai framework React",
                       InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                       TrackId = 4,
                       InstructorId = 2
                   },
                   new
                   {
                       CourseId = 19,
                       PhotoUrl = "react_course_4.jpg",
                       Name = "Belajar Framework React",
                       Detail = "Goal dari kursus ini adalah menguasai framework React",
                       InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                       TrackId = 4,
                       InstructorId = 3
                   },
                   new
                   {
                       CourseId = 20,
                       PhotoUrl = "react_course_5.png",
                       Name = "Tutorial React bagi pemula",
                       Detail = "Belajar React dari Nol",
                       InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                       TrackId = 4,
                       InstructorId = 2
                   },

                    // Angular
                    new
                    {
                        CourseId = 21,
                        PhotoUrl = "typescript.png",
                        Name = "Introduction to TS",
                        Detail = "Dalam kursus ini, kalian akan diajarkan Typescript dari dasar hingga fitur-fitur penting dari Typescript sampai di titik kalian dapat mengimplementasikan Typescript ke dalam proyek apapun yang kalian kerjakan. Kursus ini juga akan menjadi dasar bagi kalian yang ingin belajar tentang framework Angular",
                        InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                        TrackId = 5,
                        InstructorId = 3
                    },
                    new
                    {
                        CourseId = 22,
                        PhotoUrl = "typescript2.jpg",
                        Name = "Panduan lengkap Typescript 2020",
                        Detail = "Belajar Typescript dari Nol sebagai persiapan untuk mempelajari framework Angular",
                        InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                        TrackId = 5,
                        InstructorId = 2
                    },
                    new
                    {
                        CourseId = 23,
                        PhotoUrl = "angular_course_1.jpg",
                        Name = "Panduan lengkap Angular 2020",
                        Detail = "Belajar topik dasar hingga topik advanced dari framework Angular",
                        InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                        TrackId = 5,
                        InstructorId = 3
                    },
                    new
                    {
                        CourseId = 24,
                        PhotoUrl = "angular_course_2.png",
                        Name = "Belajar Angular dari Nol",
                        Detail = "Belajar framework javascript React dari dasar sampai topik yang advanced",
                        InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                        TrackId = 5,
                        InstructorId = 2
                    },
                     new
                     {
                         CourseId = 25,
                         PhotoUrl = "angular_course_3.jpg",
                         Name = "Tutorial Angular bagi pemula",
                         Detail = "Kursus ini ditujukan untuk pemula yang belum pernah menyentuh framework angular",
                         InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                         TrackId = 5,
                         InstructorId = 3
                     },

                     // Vue
                     new
                     {
                         CourseId = 26,
                         PhotoUrl = "vue_course_1.jpg",
                         Name = "Tutorial Vue bagi pemula",
                         Detail = "Kursus ini ditujukan untuk pemula yang belum pernah menyentuh framework Vue",
                         InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                         TrackId = 6,
                         InstructorId = 2
                     },
                      new
                      {
                          CourseId = 27,
                          PhotoUrl = "vue_course_2.png",
                          Name = "Belajar Vue dari Nol",
                          Detail = "Belajar framework Vue dari Nol. Tujuan dari course ini adalah untuk dapat mengimplementasi Vue kepada project peserta course.",
                          InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                          TrackId = 6,
                          InstructorId = 3
                      },
                      new
                      {
                          CourseId = 28,
                          PhotoUrl = "vue_course_3.jpg",
                          Name = "Panduan Lengkap Vue 2020",
                          Detail = "Panduan paling up-to-date tentang framework Vue",
                          InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                          TrackId = 6,
                          InstructorId = 2
                      },
                      new
                      {
                          CourseId = 29,
                          PhotoUrl = "vue_course_4.png",
                          Name = "Vue Masterclass untuk semua",
                          Detail = "Belajar framework javascript Vue dari dasar sampai topik yang advanced.",
                          InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                          TrackId = 6,
                          InstructorId = 3
                      },
                       new
                       {
                           CourseId = 30,
                           PhotoUrl = "vue_course_5.png",
                           Name = "Dasar - dasar pemrograman Vue yang cocok untuk pemula",
                           Detail = "Cocok untuk yang sedang ingin mempelajari front-end framework",
                           InsertDate = new DateTime(2012, 9, 12),
					CoverUrl = "cover2.png",
                           TrackId = 6,
                           InstructorId = 2
                       },

                       // .NET
                       new
                       {
                           CourseId = 31,
                           PhotoUrl = "csharp.png",
                           Name = "Asynchronus Programming in C#",
                           Detail = "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman C# dari dasar hingga fitur-fitur penting dari C# sampai di titik kalian dapat mengimplementasikan C# ke dalam proyek apapun yang kalian kerjakan. Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework ASP.NET",
                           InsertDate = new DateTime(2014, 9, 2),
					CoverUrl = "cover3.png",
                           TrackId = 7,
                           InstructorId = 3
                       },
                       new
                       {
                           CourseId = 32,
                           PhotoUrl = "net_course_1.png",
                           Name = "Belajar framework .NET dari Nol",
                           Detail = "Kursus ini ditargetkan bagi pemula yang tidak memiliki pengalaman sama sekali dengan framework .NET core",
                           InsertDate = new DateTime(2014, 9, 2),
					CoverUrl = "cover2.png",
                           TrackId = 7,
                           InstructorId = 2
                       },
                       new
                       {
                           CourseId = 33,
                           PhotoUrl = "net_course_2.png",
                           Name = "Buat REST API dengan framework .NET core",
                           Detail = "Belajar .NET core untuk membuat REST API",
                           InsertDate = new DateTime(2014, 9, 2),
					CoverUrl = "cover2.png",
                           TrackId = 7,
                           InstructorId = 3
                       },
                        new
                        {
                            CourseId = 34,
                            PhotoUrl = "net_course_3.jpg",
                            Name = "Panduan lengkap .NET core 2020",
                            Detail = "Belajar framework .NET Core dengan panduan paling up-to-date",
                            InsertDate = new DateTime(2014, 9, 2),
					CoverUrl = "cover2.png",
                            TrackId = 7,
                            InstructorId = 2
                        },
                        new
                        {
                            CourseId = 35,
                            PhotoUrl = "net_course_4.png",
                            Name = ".NET core masterclass untuk semua",
                            Detail = "Kuasai .NET core dengan cepat dengan mengikuti course ini",
                            InsertDate = new DateTime(2014, 9, 2),
					CoverUrl = "cover2.png",
                            TrackId = 7,
                            InstructorId = 3
                        },

                        // Laravel
                        new
                        {
                            CourseId = 36,
                            PhotoUrl = "php.png",
                            Name = "Object-Oriented Programming with PHP",
                            Detail = "Dalam kursus ini, kalian akan diajarkan bahasa pemrograman PHP  dari dasar hingga fitur-fitur penting dari PHP sampai di titik kalian dapat mengimplementasikan PHP ke dalam proyek apapun yang kalian kerjakan.Kursus ini juga menjadi dasar bagi kalian yang ingin belajar tentang framework Laravel",
                            InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover1.png",
                            TrackId = 8,
                            InstructorId = 2
                        },
                        new
                        {
                            CourseId = 37,
                            PhotoUrl = "laravel_course_1.png",
                            Name = "Belajar pemrograman website dengan framework Laravel",
                            Detail = "Dalam kursus ini, kalian akan diajarkan cara membuat website dengan framework Laravel",
                            InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                            TrackId = 8,
                            InstructorId = 3
                        },
                         new
                         {
                             CourseId = 38,
                             PhotoUrl = "laravel_course_2.jpg",
                             Name = "Belajar framework Laravel dari Nol",
                             Detail = "Dalam kursus ini, kalian akan diajarkan Laravel dari dasar hingga topik-topik yang advanced",
                             InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                             TrackId = 8,
                             InstructorId = 2
                         },
                          new
                          {
                              CourseId = 39,
                              PhotoUrl = "laravel_course_3.png",
                              Name = "Panduan Lengkap Laravel 2020",
                              Detail = "Ikuti panduan paling up to date mengenai framework Laravel",
                              InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                              TrackId = 8,
                              InstructorId = 3
                          },
                          new
                          {
                              CourseId = 40,
                              PhotoUrl = "laravel_course_4.jpg",
                              Name = "Laravel Masterclass untuk semua",
                              Detail = "Kuasai Laravel dengan cepat dengan mengikuti course ini, cocok untuk pemula",
                              InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                              TrackId = 8,
                              InstructorId = 2
                          },

                            // Django
                            new
                            {
                                CourseId = 41,
                                PhotoUrl = "python.png",
                                Name = "Python Programming Language",
                                Detail = "Python adalah bahasa pemrograman terkenal yang dibuat dengan fokus untuk mempermudah programmer untuk membaca kodingnya.Dalam kursus ini, kalian akan diajarkan Python dari dasar sampai kalian dapat mengimplementasikannya dalam aplikasi kalian. Kursus ini juga disarankan bagi yang berminat untuk mempelajari framework Django, karena Django menggunakan bahasa pemrograman Python.",
                                InsertDate = new DateTime(2019, 3, 19),
					CoverUrl = "cover4.png",
                                TrackId = 9,
                                InstructorId = 3
                            },
                            new
                            {
                                CourseId = 42,
                                PhotoUrl = "django_course_1.jpg",
                                Name = "Belajar pemrograman website dengan framework Django",
                                Detail = "Dalam kursus ini, kalian akan diajarkan cara membuat website dengan framework Django",
                                InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                TrackId = 9,
                                InstructorId = 2
                            },
                            new
                            {
                                CourseId = 43,
                                PhotoUrl = "django_course_2.jpg",
                                Name = "Belajar framework Django dari Nol",
                                Detail = "Dalam kursus ini, kalian akan diajarkan Django dari dasar hingga topik-topik yang advanced",
                                InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                TrackId = 9,
                                InstructorId = 3
                            },
                            new
                            {
                                CourseId = 44,
                                PhotoUrl = "django_course_3.jpg",
                                Name = "Panduan Lengkap Django 2020",
                                Detail = "Ikuti panduan paling up to date mengenai framework Django",
                                InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                TrackId = 9,
                                InstructorId = 2
                            },
                            new
                            {
                                CourseId = 45,
                                PhotoUrl = "django_course_4.png",
                                Name = "Django Masterclass untuk semua",
                                Detail = "Kuasai Django dengan cepat dengan mengikuti course ini, cocok untuk pemula",
                                InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                TrackId = 9,
                                InstructorId = 3
                            },

                            // Node JS
                            new
                            {
                                CourseId = 46,
                                PhotoUrl = "nodejs_course_1.jpg",
                                Name = "Tutorial lengkap NodeJS untuk membuat REST API",
                                Detail = "Belajar Node JS dari dasar-dasarnya hingga dapat membuat REST API untuk website",
                                InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                TrackId = 10,
                                InstructorId = 2
                            },
                             new
                             {
                                 CourseId = 47,
                                 PhotoUrl = "nodejs_course_2.jpg",
                                 Name = "Belajar pemrograman website dengan framework NodeJS",
                                 Detail = "Dalam kursus ini, kalian akan diajarkan cara membuat API website dengan framework NodeJS",
                                 InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                 TrackId = 10,
                                 InstructorId = 3
                             },
                            new
                            {
                                CourseId = 48,
                                PhotoUrl = "nodejs_course_3.jpg",
                                Name = "Belajar framework NodeJS dari Nol",
                                Detail = "Dalam kursus ini, kalian akan diajarkan NodeJS dari dasar hingga topik-topik yang advanced",
                                InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                TrackId = 10,
                                InstructorId = 2
                            },
                            new
                            {
                                CourseId = 49,
                                PhotoUrl = "nodejs_course_4.png",
                                Name = "Panduan Lengkap NodeJS 2020",
                                Detail = "Ikuti panduan paling up to date mengenai framework NodeJS",
                                InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                TrackId = 10,
                                InstructorId = 3
                            },
                            new
                            {
                                CourseId = 50,
                                PhotoUrl = "nodejs_course_5.png",
                                Name = "NodeJS Masterclass untuk semua",
                                Detail = "Kuasai NodeJS dengan cepat dengan mengikuti course ini, cocok untuk pemula",
                                InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                TrackId = 10,
                                InstructorId = 2
                            },

                            // Spring
                            new
                            {
                                CourseId = 51,
                                PhotoUrl = "spring_course_1.png",
                                Name = "Tutorial lengkap Spring untuk membuat REST API",
                                Detail = "Belajar framework Spring dari dasar-dasarnya hingga dapat membuat REST API untuk website",
                                InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                TrackId = 11,
                                InstructorId = 3
                            },
                             new
                             {
                                 CourseId = 52,
                                 PhotoUrl = "spring_course_2.png",
                                 Name = "Belajar pemrograman website dengan framework Spring",
                                 Detail = "Dalam kursus ini, kalian akan diajarkan cara membuat website dengan framework Spring",
                                 InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                 TrackId = 11,
                                 InstructorId = 2
                             },
                            new
                            {
                                CourseId = 53,
                                PhotoUrl = "nodejs_course_3.jpg",
                                Name = "Belajar framework Spring dari Nol",
                                Detail = "Dalam kursus ini, kalian akan diajarkan Spring dari dasar hingga topik-topik yang advanced",
                                InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                TrackId = 11,
                                InstructorId = 3
                            },
                            new
                            {
                                CourseId = 54,
                                PhotoUrl = "spring_course_4.jpg",
                                Name = "Panduan Lengkap Spring 2020",
                                Detail = "Ikuti panduan paling up to date mengenai framework Spring",
                                InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                TrackId = 11,
                                InstructorId = 3
                            },
                            new
                            {
                                CourseId = 55,
                                PhotoUrl = "spring_course_5.png",
                                Name = "Spring Masterclass untuk semua",
                                Detail = "Kuasai Spring dengan cepat dengan mengikuti course ini, cocok untuk pemula",
                                InsertDate = new DateTime(2014, 12, 2),
					CoverUrl = "cover2.png",
                                TrackId = 11,
                                InstructorId = 2
                            }
            );
        }
    }
}
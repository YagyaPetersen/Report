using System.Runtime.InteropServices;

namespace ReportDatabase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ReportDatabase;

    internal sealed class Configuration : DbMigrationsConfiguration<ReportDatabase.ReportDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ReportDatabase.ReportDBContext context)
        {
            context.Student.AddOrUpdate(
                 a => a.StudentId,
                 new Student() { StudentId = 1, FName = "Yagya", LName = "Petersen", GradeId = 1 },
                 new Student() { StudentId = 2, FName = "John", LName = "Johnson", GradeId = 2 },
                 new Student() { StudentId = 3, FName = "Jack", LName = "Jackson", GradeId = 1 },
                 new Student() { StudentId = 4, FName = "Billy", LName = "Billson", GradeId = 3 }
                 );

            context.Teacher.AddOrUpdate(
                a => a.TeacherId,
                new Teacher() { TeacherId = 1, FName = "June", LName = "Juniper" },
                new Teacher() { TeacherId = 2, FName = "Rob", LName = "Robertson" },
                new Teacher() { TeacherId = 3, FName = "Rick", LName = "Richardson" },
                new Teacher() { TeacherId = 4, FName = "Mike", LName = "Micheals" },
                new Teacher() { TeacherId = 5, FName = "Jim", LName = "Carrey" },
                new Teacher() { TeacherId = 6, FName = "Eric", LName = "Foreman" },
                new Teacher() { TeacherId = 7, FName = "Samuel", LName = "Jackson" }
            );

            context.Grade.AddOrUpdate(
                a => a.GradeId,
                new Grade() { GradeId = 1, StudentGrade = 12 },
                new Grade() { GradeId = 2, StudentGrade = 9 },
                new Grade() { GradeId = 3, StudentGrade = 10 }
            );

            context.Reports.AddOrUpdate(
                a => a.ReportId,
                new Report() { ReportId = 1, SubjectId = 1, TeacherId = 1, MarkTypeId = 1 },
                new Report() { ReportId = 2, SubjectId = 2, TeacherId = 2, MarkTypeId = 2 },
                new Report() { ReportId = 3, SubjectId = 3, TeacherId = 3, MarkTypeId = 1 },
                new Report() { ReportId = 4, SubjectId = 4, TeacherId = 4, MarkTypeId = 3 },
                new Report() { ReportId = 5, SubjectId = 5, TeacherId = 5, MarkTypeId = 2 },
                new Report() { ReportId = 6, SubjectId = 6, TeacherId = 6, MarkTypeId = 3 },
                new Report() { ReportId = 7, SubjectId = 7, TeacherId = 7, MarkTypeId = 2 }
            );

            context.MarkType.AddOrUpdate(
                a => a.MarkTypeId,
                new MarkType() { MarkTypeId = 1, TypeName = "Exam" },
                new MarkType() { MarkTypeId = 2, TypeName = "Test" },
                new MarkType() { MarkTypeId = 3, TypeName = "Assignment" }
            );

            context.Subject.AddOrUpdate(
                a => a.SubjectId,
                new Subjects() { SubjectId = 1, SubjectName = "Maths" },
                new Subjects() { SubjectId = 2, SubjectName = "IT" },
                new Subjects() { SubjectId = 3, SubjectName = "English" },
                new Subjects() { SubjectId = 4, SubjectName = "Physics" },
                new Subjects() { SubjectId = 5, SubjectName = "Afrikaans" },
                new Subjects() { SubjectId = 6, SubjectName = "Life Orientaion" },
                new Subjects() { SubjectId = 7, SubjectName = "History" }
            );

            context.Term.AddOrUpdate(
                a => a.TermId,
                new Terms() { TermId = 1, Term = 1 },
                new Terms() { TermId = 2, Term = 2 },
                new Terms() { TermId = 3, Term = 3 },
                new Terms() { TermId = 4, Term = 4 }
            );

            context.StudentMark.AddOrUpdate(
                a => a.StudentMarkId,

               //------------------------------------------------------------------------------------------------
               // STUDENT 1

                //Maths
                new StudentMark() { StudentMarkId = 1, ReportId = 1, StudentId = 1, TermId = 1, Mark = 72 },
                new StudentMark() { StudentMarkId = 2, ReportId = 1, StudentId = 1, TermId = 2, Mark = 65 },
                new StudentMark() { StudentMarkId = 3, ReportId = 1, StudentId = 1, TermId = 3, Mark = 80 },
                new StudentMark() { StudentMarkId = 4, ReportId = 1, StudentId = 1, TermId = 4, Mark = 63 },

                //IT
                new StudentMark() { StudentMarkId = 5, ReportId = 2, StudentId = 1, TermId = 1, Mark = 75 },
                new StudentMark() { StudentMarkId = 6, ReportId = 2, StudentId = 1, TermId = 2, Mark = 81 },
                new StudentMark() { StudentMarkId = 7, ReportId = 2, StudentId = 1, TermId = 3, Mark = 78 },
                new StudentMark() { StudentMarkId = 8, ReportId = 2, StudentId = 1, TermId = 4, Mark = 80 },

                //English
                new StudentMark() { StudentMarkId = 9, ReportId = 3, StudentId = 1, TermId = 1, Mark = 90 },
                new StudentMark() { StudentMarkId = 10, ReportId = 3, StudentId = 1, TermId = 2, Mark = 85 },
                new StudentMark() { StudentMarkId = 11, ReportId = 3, StudentId = 1, TermId = 3, Mark = 83 },
                new StudentMark() { StudentMarkId = 12, ReportId = 3, StudentId = 1, TermId = 4, Mark = 88 },

                //Physics
                new StudentMark() { StudentMarkId = 13, ReportId = 4, StudentId = 1, TermId = 1, Mark = 65 },
                new StudentMark() { StudentMarkId = 14, ReportId = 4, StudentId = 1, TermId = 2, Mark = 61 },
                new StudentMark() { StudentMarkId = 15, ReportId = 4, StudentId = 1, TermId = 3, Mark = 67 },
                new StudentMark() { StudentMarkId = 16, ReportId = 4, StudentId = 1, TermId = 4, Mark = 62 },

                //Afrikaans
                new StudentMark() { StudentMarkId = 17, ReportId = 5, StudentId = 1, TermId = 1, Mark = 75 },
                new StudentMark() { StudentMarkId = 18, ReportId = 5, StudentId = 1, TermId = 2, Mark = 70 },
                new StudentMark() { StudentMarkId = 19, ReportId = 5, StudentId = 1, TermId = 3, Mark = 71 },
                new StudentMark() { StudentMarkId = 20, ReportId = 5, StudentId = 1, TermId = 4, Mark = 78 },

                //Life Orientation
                new StudentMark() { StudentMarkId = 21, ReportId = 6, StudentId = 1, TermId = 1, Mark = 100 },
                new StudentMark() { StudentMarkId = 22, ReportId = 6, StudentId = 1, TermId = 2, Mark = 98 },
                new StudentMark() { StudentMarkId = 23, ReportId = 6, StudentId = 1, TermId = 3, Mark = 96 },
                new StudentMark() { StudentMarkId = 24, ReportId = 6, StudentId = 1, TermId = 4, Mark = 100 },

                //History
                new StudentMark() { StudentMarkId = 25, ReportId = 7, StudentId = 1, TermId = 1, Mark = 82 },
                new StudentMark() { StudentMarkId = 26, ReportId = 7, StudentId = 1, TermId = 2, Mark = 85 },
                new StudentMark() { StudentMarkId = 27, ReportId = 7, StudentId = 1, TermId = 3, Mark = 81 },
                new StudentMark() { StudentMarkId = 28, ReportId = 7, StudentId = 1, TermId = 4, Mark = 79 },


               //------------------------------------------------------------------------------------------------
               // STUDENT 2

               //Maths
               new StudentMark() { StudentMarkId = 29, ReportId = 1, StudentId = 2, TermId = 1, Mark = 40 },
               new StudentMark() { StudentMarkId = 30, ReportId = 1, StudentId = 2, TermId = 2, Mark = 51 },
               new StudentMark() { StudentMarkId = 31, ReportId = 1, StudentId = 2, TermId = 3, Mark = 48 },
               new StudentMark() { StudentMarkId = 32, ReportId = 1, StudentId = 2, TermId = 4, Mark = 53 },

               //IT
               new StudentMark() { StudentMarkId = 33, ReportId = 2, StudentId = 2, TermId = 1, Mark = 35 },
               new StudentMark() { StudentMarkId = 34, ReportId = 2, StudentId = 2, TermId = 2, Mark = 40 },
               new StudentMark() { StudentMarkId = 35, ReportId = 2, StudentId = 2, TermId = 3, Mark = 45 },
               new StudentMark() { StudentMarkId = 36, ReportId = 2, StudentId = 2, TermId = 4, Mark = 46 },

               //English
               new StudentMark() { StudentMarkId = 37, ReportId = 3, StudentId = 2, TermId = 1, Mark = 50 },
               new StudentMark() { StudentMarkId = 38, ReportId = 3, StudentId = 2, TermId = 2, Mark = 51 },
               new StudentMark() { StudentMarkId = 39, ReportId = 3, StudentId = 2, TermId = 3, Mark = 55 },
               new StudentMark() { StudentMarkId = 40, ReportId = 3, StudentId = 2, TermId = 4, Mark = 60 },

               //Physics
               new StudentMark() { StudentMarkId = 41, ReportId = 4, StudentId = 2, TermId = 1, Mark = 30 },
               new StudentMark() { StudentMarkId = 42, ReportId = 4, StudentId = 2, TermId = 2, Mark = 34 },
               new StudentMark() { StudentMarkId = 43, ReportId = 4, StudentId = 2, TermId = 3, Mark = 25 },
               new StudentMark() { StudentMarkId = 44, ReportId = 4, StudentId = 2, TermId = 4, Mark = 31 },

               //Afrikaans
               new StudentMark() { StudentMarkId = 45, ReportId = 5, StudentId = 2, TermId = 1, Mark = 53 },
               new StudentMark() { StudentMarkId = 46, ReportId = 5, StudentId = 2, TermId = 2, Mark = 55 },
               new StudentMark() { StudentMarkId = 47, ReportId = 5, StudentId = 2, TermId = 3, Mark = 60 },
               new StudentMark() { StudentMarkId = 48, ReportId = 5, StudentId = 2, TermId = 4, Mark = 53 },

               //Life Orientation
               new StudentMark() { StudentMarkId = 49, ReportId = 6, StudentId = 2, TermId = 1, Mark = 60 },
               new StudentMark() { StudentMarkId = 50, ReportId = 6, StudentId = 2, TermId = 2, Mark = 59 },
               new StudentMark() { StudentMarkId = 51, ReportId = 6, StudentId = 2, TermId = 3, Mark = 63 },
               new StudentMark() { StudentMarkId = 52, ReportId = 6, StudentId = 2, TermId = 4, Mark = 67 },

               //History
               new StudentMark() { StudentMarkId = 53, ReportId = 7, StudentId = 2, TermId = 1, Mark = 68 },
               new StudentMark() { StudentMarkId = 54, ReportId = 7, StudentId = 2, TermId = 2, Mark = 70 },
               new StudentMark() { StudentMarkId = 55, ReportId = 7, StudentId = 2, TermId = 3, Mark = 65 },
               new StudentMark() { StudentMarkId = 56, ReportId = 7, StudentId = 2, TermId = 4, Mark = 69 },


               //------------------------------------------------------------------------------------------------
               // STUDENT 3

               //Maths
               new StudentMark() { StudentMarkId = 57, ReportId = 1, StudentId = 3, TermId = 1, Mark = 61 },
               new StudentMark() { StudentMarkId = 58, ReportId = 1, StudentId = 3, TermId = 2, Mark = 58 },
               new StudentMark() { StudentMarkId = 59, ReportId = 1, StudentId = 3, TermId = 3, Mark = 61 },
               new StudentMark() { StudentMarkId = 60, ReportId = 1, StudentId = 3, TermId = 4, Mark = 70 },

               //IT
               new StudentMark() { StudentMarkId = 61, ReportId = 2, StudentId = 3, TermId = 1, Mark = 50 },
               new StudentMark() { StudentMarkId = 62, ReportId = 2, StudentId = 3, TermId = 2, Mark = 58 },
               new StudentMark() { StudentMarkId = 63, ReportId = 2, StudentId = 3, TermId = 3, Mark = 53 },
               new StudentMark() { StudentMarkId = 64, ReportId = 2, StudentId = 3, TermId = 4, Mark = 60 },

               //English
               new StudentMark() { StudentMarkId = 65, ReportId = 3, StudentId = 3, TermId = 1, Mark = 43 },
               new StudentMark() { StudentMarkId = 66, ReportId = 3, StudentId = 3, TermId = 2, Mark = 47 },
               new StudentMark() { StudentMarkId = 67, ReportId = 3, StudentId = 3, TermId = 3, Mark = 50 },
               new StudentMark() { StudentMarkId = 68, ReportId = 3, StudentId = 3, TermId = 4, Mark = 51 },

               //Physics
               new StudentMark() { StudentMarkId = 69, ReportId = 4, StudentId = 3, TermId = 1, Mark = 60 },
               new StudentMark() { StudentMarkId = 70, ReportId = 4, StudentId = 3, TermId = 2, Mark = 65 },
               new StudentMark() { StudentMarkId = 71, ReportId = 4, StudentId = 3, TermId = 3, Mark = 59 },
               new StudentMark() { StudentMarkId = 72, ReportId = 4, StudentId = 3, TermId = 4, Mark = 60 },

               //Afrikaans
               new StudentMark() { StudentMarkId = 73, ReportId = 5, StudentId = 3, TermId = 1, Mark = 64 },
               new StudentMark() { StudentMarkId = 74, ReportId = 5, StudentId = 3, TermId = 2, Mark = 58 },
               new StudentMark() { StudentMarkId = 75, ReportId = 5, StudentId = 3, TermId = 3, Mark = 68 },
               new StudentMark() { StudentMarkId = 76, ReportId = 5, StudentId = 3, TermId = 4, Mark = 60 },

               //Life Orientation
               new StudentMark() { StudentMarkId = 77, ReportId = 6, StudentId = 3, TermId = 1, Mark = 80 },
               new StudentMark() { StudentMarkId = 78, ReportId = 6, StudentId = 3, TermId = 2, Mark = 75 },
               new StudentMark() { StudentMarkId = 79, ReportId = 6, StudentId = 3, TermId = 3, Mark = 83 },
               new StudentMark() { StudentMarkId = 80, ReportId = 6, StudentId = 3, TermId = 4, Mark = 78 },

               //History
               new StudentMark() { StudentMarkId = 81, ReportId = 7, StudentId = 3, TermId = 1, Mark = 54 },
               new StudentMark() { StudentMarkId = 82, ReportId = 7, StudentId = 3, TermId = 2, Mark = 58 },
               new StudentMark() { StudentMarkId = 83, ReportId = 7, StudentId = 3, TermId = 3, Mark = 50 },
               new StudentMark() { StudentMarkId = 84, ReportId = 7, StudentId = 3, TermId = 4, Mark = 48 },


               //------------------------------------------------------------------------------------------------
               // STUDENT 4

               //Maths
               new StudentMark() { StudentMarkId = 85, ReportId = 1, StudentId = 4, TermId = 1, Mark = 93 },
               new StudentMark() { StudentMarkId = 86, ReportId = 1, StudentId = 4, TermId = 2, Mark = 100 },
               new StudentMark() { StudentMarkId = 87, ReportId = 1, StudentId = 4, TermId = 3, Mark = 95 },
               new StudentMark() { StudentMarkId = 88, ReportId = 1, StudentId = 4, TermId = 4, Mark = 98 },

               //IT
               new StudentMark() { StudentMarkId = 89, ReportId = 2, StudentId = 4, TermId = 1, Mark = 89 },
               new StudentMark() { StudentMarkId = 90, ReportId = 2, StudentId = 4, TermId = 2, Mark = 92 },
               new StudentMark() { StudentMarkId = 91, ReportId = 2, StudentId = 4, TermId = 3, Mark = 91 },
               new StudentMark() { StudentMarkId = 92, ReportId = 2, StudentId = 4, TermId = 4, Mark = 94 },

               //English
               new StudentMark() { StudentMarkId = 93, ReportId = 3, StudentId = 4, TermId = 1, Mark = 97 },
               new StudentMark() { StudentMarkId = 94, ReportId = 3, StudentId = 4, TermId = 2, Mark = 99 },
               new StudentMark() { StudentMarkId = 95, ReportId = 3, StudentId = 4, TermId = 3, Mark = 98 },
               new StudentMark() { StudentMarkId = 96, ReportId = 3, StudentId = 4, TermId = 4, Mark = 97 },

               //Physics
               new StudentMark() { StudentMarkId = 97, ReportId = 4, StudentId = 4, TermId = 1, Mark = 85 },
               new StudentMark() { StudentMarkId = 98, ReportId = 4, StudentId = 4, TermId = 2, Mark = 83 },
               new StudentMark() { StudentMarkId = 99, ReportId = 4, StudentId = 4, TermId = 3, Mark = 87 },
               new StudentMark() { StudentMarkId = 100, ReportId = 4, StudentId = 4, TermId = 4, Mark = 88 },

               //Afrikaans
               new StudentMark() { StudentMarkId = 101, ReportId = 5, StudentId = 4, TermId = 1, Mark = 60 },
               new StudentMark() { StudentMarkId = 102, ReportId = 5, StudentId = 4, TermId = 2, Mark = 62 },
               new StudentMark() { StudentMarkId = 103, ReportId = 5, StudentId = 4, TermId = 3, Mark = 65 },
               new StudentMark() { StudentMarkId = 104, ReportId = 5, StudentId = 4, TermId = 4, Mark = 66 },

               //Life Orientation
               new StudentMark() { StudentMarkId = 105, ReportId = 6, StudentId = 4, TermId = 1, Mark = 100 },
               new StudentMark() { StudentMarkId = 106, ReportId = 6, StudentId = 4, TermId = 2, Mark = 100 },
               new StudentMark() { StudentMarkId = 107, ReportId = 6, StudentId = 4, TermId = 3, Mark = 100 },
               new StudentMark() { StudentMarkId = 108, ReportId = 6, StudentId = 4, TermId = 4, Mark = 100 },

               //History
               new StudentMark() { StudentMarkId = 109, ReportId = 7, StudentId = 4, TermId = 1, Mark = 73 },
               new StudentMark() { StudentMarkId = 110, ReportId = 7, StudentId = 4, TermId = 2, Mark = 80 },
               new StudentMark() { StudentMarkId = 111, ReportId = 7, StudentId = 4, TermId = 3, Mark = 78 },
               new StudentMark() { StudentMarkId = 112, ReportId = 7, StudentId = 4, TermId = 4, Mark = 83 }
               );

            //------------------------------------------------------------------------------------------------
        }
    }
}

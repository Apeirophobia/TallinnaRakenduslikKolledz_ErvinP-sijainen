using TallinnaRakenduslikKolledz.Controllers;
using TallinnaRakenduslikKolledz.Models;

namespace TallinnaRakenduslikKolledz.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();
            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                
                new Student {FirstName = "George", LastName = "Teemus", EnrollmentDate = DateTime.Now, },
                new Student {FirstName = "Jake", LastName = "Dog", EnrollmentDate = DateTime.Now, },
                new Student {FirstName = "Finn", LastName = "Human", EnrollmentDate = DateTime.Now, },
                new Student {FirstName = "Rock", LastName = "Dunkopf", EnrollmentDate = DateTime.Now, },
                new Student {FirstName = "Fire", LastName = "Princess", EnrollmentDate = DateTime.Now, },
                new Student {FirstName = "Alisa", LastName = "Rastaman", EnrollmentDate = DateTime.Now, },
                new Student {FirstName = "Kevin", LastName = "Parker", EnrollmentDate = DateTime.Now, },
            };
            context.Students.AddRange(students);
            context.SaveChanges();
            if (context.Courses.Any()) { return; }
            var courses = new Course[]
            {
                new Course { CourseId = 1001, Title = "Programmeerimsie alused", Credits = 3},
                new Course { CourseId = 2002, Title = "Programmeerimsie 1", Credits = 6},
                new Course { CourseId = 3002, Title = "Programmeerimsie 2", Credits = 9},
                new Course { CourseId = 2003, Title = "Tarkvara Arendusprotsess", Credits = 3},
                new Course { CourseId = 1002, Title = "Multimeedia", Credits = 3},
                new Course { CourseId = 3001, Title = "Kajusrakenduste alused", Credits = 3},
                new Course { CourseId = 3003, Title = "Psühhoakustika alused", Credits = 3},
                new Course { CourseId = 4001, Title = "Muusika", Credits = 3},
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();
            if (context.Enrollments.Any()) { return; }
            var enrollments = new Enrollment[]
            {
                new Enrollment {StudentId = 1, CourseId = 3003, CurrentGrade=Grade.X },
                new Enrollment {StudentId = 1, CourseId = 3001, CurrentGrade=Grade.B },
                new Enrollment {StudentId = 2, CourseId = 1001, CurrentGrade=Grade.A },
                new Enrollment {StudentId = 2, CourseId = 1002, CurrentGrade=Grade.MA },
                new Enrollment {StudentId = 3, CourseId = 1001, CurrentGrade=Grade.C },
                new Enrollment {StudentId = 3, CourseId = 2003, CurrentGrade=Grade.C },
                new Enrollment {StudentId = 4, CourseId = 1002, CurrentGrade=Grade.C },
                new Enrollment {StudentId = 4, CourseId = 2003, CurrentGrade=Grade.C },
                new Enrollment {StudentId = 5, CourseId = 3003, CurrentGrade=Grade.X },
                new Enrollment {StudentId = 5, CourseId = 3001, CurrentGrade=Grade.B },
                new Enrollment {StudentId = 6, CourseId = 1001, CurrentGrade=Grade.A },
                new Enrollment {StudentId = 6, CourseId = 1002, CurrentGrade=Grade.MA },
                new Enrollment {StudentId = 7, CourseId = 1001, CurrentGrade=Grade.C },
                new Enrollment {StudentId = 7, CourseId = 2003, CurrentGrade=Grade.C },
                new Enrollment {StudentId = 8, CourseId = 1002, CurrentGrade=Grade.C },
                new Enrollment {StudentId = 8, CourseId = 2003, CurrentGrade=Grade.C },
            };
            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
            if (context.Instructors.Any()) { return; }
            var instructors = new Instructor[]
            {
                new Instructor() {FirstName = "Daniel", LastName = "Donkey", HireDate = DateTime.Now, Alcoholic = 1, BeenInJail = 1},
                new Instructor() {FirstName = "Richard", LastName = "Watterson", HireDate = DateTime.Now, Alcoholic = 0, BeenInJail = 2},
                new Instructor() {FirstName = "Ervin", LastName = "Sikowitz", HireDate = DateTime.Now, Alcoholic = 1, BeenInJail = 1},
                new Instructor() {FirstName = "Terrance", LastName = "Jeter", HireDate = DateTime.Now, Alcoholic = 0, BeenInJail = 0},
                new Instructor() {FirstName = "Lena", LastName = "Golovach", HireDate = DateTime.Now, Alcoholic = 1, BeenInJail = 0},
            };

            context.Instructors.AddRange(instructors);
            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
            new Course{CourseID=1045,Title="Calculus",Credits=4,},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
            new Course{CourseID=2021,Title="Composition",Credits=3,},
            new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var countries = new List<Country>
            {
            new Country{CountryID=1,Name="Bulgaria"},
            new Country{CountryID=2,Name="France"},
            new Country{CountryID=3,Name="Italy"},
            new Country{CountryID=4,Name="USA"}
            };
            countries.ForEach(s => context.Contries.Add(s));
            context.SaveChanges();

            var instructors = new List<Instructor>
            {
            new Instructor{InstructorID=1,Title="Carson",Age=123,CountryID=1},
            new Instructor{InstructorID=2,Title="Meredith",Age=23,CountryID=1},
            new Instructor{InstructorID=3,Title="Arturo",Age=13,CountryID=1},
            new Instructor{InstructorID=4,Title="Gytis",Age=33,CountryID=1},
            new Instructor{InstructorID=5,Title="Yan",Age=43,CountryID=1},
            new Instructor{InstructorID=6,Title="Peggy",Age=53,CountryID=1},
            new Instructor{InstructorID=7,Title="Laura",Age=63,CountryID=1},
            new Instructor{InstructorID=8,Title="Nino",Age=83,CountryID=1}
            };
            instructors.ForEach(s => context.Instructors.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{EnrollmentID=1,StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{EnrollmentID=2,StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{EnrollmentID=3,StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{EnrollmentID=4,StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{EnrollmentID=5,StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{EnrollmentID=6,StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{EnrollmentID=7,StudentID=3,CourseID=1050},
            new Enrollment{EnrollmentID=8,StudentID=4,CourseID=1050,},
            new Enrollment{EnrollmentID=9,StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{EnrollmentID=10,StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{EnrollmentID=11,StudentID=6,CourseID=1045},
            new Enrollment{EnrollmentID=12,StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

        }
    }
}

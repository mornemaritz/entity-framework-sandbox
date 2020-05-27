using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EF6
{
    //public class SanboxInitialiser : DropCreateDatabaseIfModelChanges<SandboxContext>
    public class SanboxInitialiser: NullDatabaseInitializer<SandboxContext>
    {
        //protected override void Seed(SandboxContext context)
        //{
        //    var students = new List<Student>
        //    {
        //    new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
        //    new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
        //    new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
        //    new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
        //    new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
        //    new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
        //    new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
        //    new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
        //    };

        //    students.ForEach(s => context.Students.Add(s));
        //    context.SaveChanges();
        //    var courses = new List<Course>
        //    {
        //    new Course{CourseID=1050,Title="Chemistry",Credits=3,},
        //    new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
        //    new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
        //    new Course{CourseID=1045,Title="Calculus",Credits=4,},
        //    new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
        //    new Course{CourseID=2021,Title="Composition",Credits=3,},
        //    new Course{CourseID=2042,Title="Literature",Credits=4,}
        //    };
        //    courses.ForEach(s => context.Courses.Add(s));
        //    context.SaveChanges();
        //    var enrollments = new List<Enrollment>
        //    {
        //    new Enrollment{StudentID=1,CourseID=courses.Single(c => c.Title == "Chemistry").CourseID,Grade=Grade.A},
        //    new Enrollment{StudentID=1,CourseID=courses.Single(c => c.Title == "Microeconomics").CourseID,Grade=Grade.C},
        //    new Enrollment{StudentID=1,CourseID=courses.Single(c => c.Title == "Macroeconomics").CourseID,Grade=Grade.B},
        //    new Enrollment{StudentID=2,CourseID=courses.Single(c => c.Title == "Calculus").CourseID,Grade=Grade.B},
        //    new Enrollment{StudentID=2,CourseID=courses.Single(c => c.Title == "Trigonometry").CourseID,Grade=Grade.F},
        //    new Enrollment{StudentID=2,CourseID=courses.Single(c => c.Title == "Composition").CourseID,Grade=Grade.F},
        //    new Enrollment{StudentID=3,CourseID=courses.Single(c => c.Title == "Chemistry").CourseID},
        //    new Enrollment{StudentID=4,CourseID=courses.Single(c => c.Title == "Chemistry").CourseID,},
        //    new Enrollment{StudentID=4,CourseID=courses.Single(c => c.Title == "Microeconomics").CourseID,Grade=Grade.F},
        //    new Enrollment{StudentID=5,CourseID=courses.Single(c => c.Title == "Macroeconomics").CourseID,Grade=Grade.C},
        //    new Enrollment{StudentID=6,CourseID=courses.Single(c => c.Title == "Calculus").CourseID},
        //    new Enrollment{StudentID=7,CourseID=courses.Single(c => c.Title == "Trigonometry").CourseID,Grade=Grade.A},
        //    };
        //    enrollments.ForEach(s => context.Enrollments.Add(s));
        //    context.SaveChanges();
        //}
    }
}

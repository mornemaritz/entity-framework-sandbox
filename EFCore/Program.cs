using System;
using System.Linq;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SandboxContext())
            {
                var x = context.Students.Select(s => new StudentAndCourseGrade
                {
                    StudentFirstMidName = s.FirstMidName,
                    CourseTitle = s.Enrollments.FirstOrDefault().Course.Title,
                    Grade = s.Enrollments.FirstOrDefault().Grade
                });

                /*
                    SELECT
                       [s].[FirstMidName],
                       (
                          SELECT
                             TOP(1) [c].[Title] 
                          FROM
                             [Enrollments] AS [e] 
                             INNER JOIN
                                [Courses] AS [c] 
                                ON [e].[CourseID] = [c].[CourseID] 
                          WHERE
                             [s].[StudentID] = [e].[StudentID]
                       )
                       AS [Title],
                       (
                          SELECT
                             TOP(1) [e0].[Grade] 
                          FROM
                             [Enrollments] AS [e0] 
                          WHERE
                             [s].[StudentID] = [e0].[StudentID]
                       )
                       AS [Grade] 
                    FROM
                       [Students] AS [s]
                 */

                foreach (var item in x)
                {
                    Console.WriteLine($"{item.StudentFirstMidName}: {item.CourseTitle} ({item.Grade})");
                }
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6
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
                   [Project2].[StudentID] AS [StudentID],
                   [Project2].[FirstMidName] AS [FirstMidName],
                   [Extent3].[Title] AS [Title],
                   (
                      SELECT
                         TOP (1) [Extent4].[Grade] AS [Grade] 
                      FROM
                         [dbo].[Enrollments] AS [Extent4] 
                      WHERE
                         [Project2].[StudentID] = [Extent4].[StudentID]
                   )
                   AS [C1] 
                FROM
                   (
                      SELECT
                         [Extent1].[StudentID] AS [StudentID],
                         [Extent1].[FirstMidName] AS [FirstMidName],
                         (
                            SELECT
                               TOP (1) [Extent2].[CourseID] AS [CourseID] 
                            FROM
                               [dbo].[Enrollments] AS [Extent2] 
                            WHERE
                               [Extent1].[StudentID] = [Extent2].[StudentID]
                         )
                         AS [C1] 
                      FROM
                         [dbo].[Students] AS [Extent1] 
                   )
                   AS [Project2] 
                   LEFT OUTER JOIN
                      [dbo].[Courses] AS [Extent3] 
                      ON [Project2].[C1] = [Extent3].[CourseID]
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

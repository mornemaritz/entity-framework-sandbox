using DomainModel;

namespace EF6
{
    public class StudentAndCourseGrade
    {
        public string StudentFirstMidName { get; internal set; }
        public string CourseTitle { get; internal set; }
        public Grade? Grade { get; internal set; }
    }
}

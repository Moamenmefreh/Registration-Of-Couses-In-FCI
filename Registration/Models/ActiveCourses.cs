namespace Registration.Models
{
    public class ActiveCourses
    {

        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int  CourseHours { get; set; }
        public Courses courses { get; set; }
    }
}

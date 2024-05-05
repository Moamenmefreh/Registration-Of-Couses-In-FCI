namespace Registration.Models
{
    public class Courses
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int CourseHoures { get; set; }
        public string CourseActive { get; set; }
        public int LevelId { get; set; }
        public string DepartmentCode { get; set; }
        public int SemsterId { get; set;}

       
        public Level1 Level1 { get; set; }
        public Level2 Level2 { get; set; }
        public Level3 Level3 { get; set; }
        public Level4 Level4 { get; set; }
        public PreRequistes PreRequistes { get;set; }
        public ActiveCourses ActiveCourses { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}

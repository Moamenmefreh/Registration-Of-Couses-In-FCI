namespace Registration.Models
{
    public class Level3
    {
        public string CourseCode3 { get; set; }
        public string CourseName { get; set; }

        public int CourseHoures { get; set; }
        public int Level3Id { get; set; }
        public int SemsterId { get; set; }
        //public Levels levels { get; set; }

        public Courses Courses { get; set; }
    }
}

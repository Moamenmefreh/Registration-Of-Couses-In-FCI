namespace Registration.Models
{
    public class Level4
    {
        public string CourseCode4{ get; set; }
        public string CourseName { get; set; }

        public int CourseHoures { get; set; }
        public int Level4Id { get; set; }
        public int SemsterId { get; set; }
        //public Levels levels { get; set; }
        public Courses Courses { get; set; } = null;
        
    }
}

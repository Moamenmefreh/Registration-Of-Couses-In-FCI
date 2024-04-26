namespace Registration.Models
{
    public class Level2
    {
        public string CourseCode2 { get; set; }
        public string CourseName { get; set; }

        public int CourseHoures { get; set; }
        public int Level2Id { get; set; }
        public int SemsterId { get; set; }



        public Courses Courses { get; set; }
    }
}

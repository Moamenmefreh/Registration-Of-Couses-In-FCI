namespace Registration.Models
{
    public class Level1
    {
        public string CourseCode1 { get; set; }
         public string CourseName { get; set; }
        public int CourseHoures { get; set; }
        public int Level1Id { get; set; }
        public int SemsterId { get; set; }

       
        
        public Courses Courses { get; set; }
    }
}

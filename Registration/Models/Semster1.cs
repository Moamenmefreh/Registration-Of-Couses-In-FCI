using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Registration.Models
{
    public class Semster1
    {
        public string CourseCode { get; set; }
        public int CourseHoures { get; set; }
        public string CourseName { get; set; }
        public int SemsterId { get; set; }
        public Semster Semster { get; set; }
        
    }
   
}

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Registration.Models
{
    public class Students
    {
        public string StudentId { get; set; }
        public string? StudentFullName { get; set; }
        public string StudentPassword { get; set; }
        public int StudentHours { get; set; }
        public float GPA { get; set; }
        public string? RegistrationReport { get; set; }
        public int LevelId { get; set; }
        public string DepartmentCode { get; set; }
        public int AllowedHoures { get; set; }

        public Levels Levels { get; set; } = null;
        [JsonIgnore]
        [IgnoreDataMember]
        public RegistrationStudent RegistrationStudent { get; set; }

        public ICollection<Courses> Courses { get; set; }
        public Department Department { get; set; }
        
    }
}

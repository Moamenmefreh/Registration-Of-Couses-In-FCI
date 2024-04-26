namespace Registration.Models
{
    public class Department
    {
        public string DepartmentCode { get; set; }
        public string? DepartmentName { get; set; }
        public float DepartmentGPA { get; set; }

        public ICollection<Students>? Students {get;set;}

        public ICollection<Courses> Courses { get;set;}
    }
}

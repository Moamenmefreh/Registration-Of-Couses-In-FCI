namespace Registration.Models
{
    public class RegistrationStudent
    {
        public string StudentId { get; set; }
        public string? Course1 { get; set; }
        public string? Course2 { get; set; }
        public string? Course3 { get; set; }
        public string? Course4 { get; set; }
        public string? Course5 { get; set; }
        public string? Course6 { get; set; }
        public string? Course7 { get; set; }
        public string? Course8 { get; set; }

        public ICollection<Students> students { get; set; }= new List<Students>();
    }
}

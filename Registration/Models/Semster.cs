namespace Registration.Models
{
    public class Semster
    {
        public int SemsterId { get; set; }
        public int LevelId { get; set; }
        public int SemsterHoures { get; set; }
        public Levels Levels { get; set; }
        public Semster1 Semster1 { get; set; } = null;
        public Semster2 Semster2 { get; set; }
        public Semster3 Semster3 { get; set; }
        public Semster4 Semster4 { get; set; }
        public Semster5 Semster5 { get; set; }
        public Semster6 Semster6 { get; set; }
        public Semster7 Semster7 { get; set; }
        public Semster8 Semster8 { get; set; }
    }
}

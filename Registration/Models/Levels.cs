namespace Registration.Models
{
    public class Levels
    {
        public int LevelId { get; set; }
        public int LevelHoures { get; set; }

       
        //public Level1 Level1 { get; set; }
        //public Level2 Level2 { get; set; }
        //public Level3 Level3 { get; set; }
        //public Level4 Level4 { get; set; }

        public ICollection<Students> Students { get; set; }
        public ICollection<Semster> Semsters { get; set; }
        

    }
}

namespace PremiumCalculator.Models
{
    public class Occupations
    {
        public int OccupationId { get; set; }
        
        public string OccupationName { get; set; }

        public string OccupationRating { get; set; }

        public Ratings Ratings { get; set; }
    }
}

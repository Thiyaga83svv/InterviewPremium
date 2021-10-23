using PremiumCalculator.Models;
using System.Collections.Generic;
using System.Linq;

namespace PremiumCalculator.Repository
{
    public class RatingsRepository : IRatingsRepository
    {
        public IEnumerable<Ratings> AllOccupationRating =>
            new List<Ratings>
            {
                new Ratings{RatingId = 1, RatingName = "Professional", Factor = 1.0m}, 
                new Ratings{RatingId = 2 , RatingName = "White Collar", Factor = 1.25m},
                new Ratings{RatingId = 3, RatingName = "Light Manual", Factor = 1.50m}, 
                new Ratings{RatingId = 4, RatingName = "Heavy Manual", Factor = 1.75m}
            };

        public decimal GetOccupationRating(string ratingName)
        {
            return AllOccupationRating.FirstOrDefault(e => e.RatingName == ratingName).Factor;
        }
    }
}

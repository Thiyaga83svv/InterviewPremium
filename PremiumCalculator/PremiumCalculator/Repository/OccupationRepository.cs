using PremiumCalculator.Models;
using System.Collections.Generic;
using System.Linq;

namespace PremiumCalculator.Repository
{
    public class OccupationRepository : IOccupationRepository
    {
        private readonly IRatingsRepository _ratingRepository = new RatingsRepository();
        public IEnumerable<Occupations> AllOccupation => 
            new List<Occupations>
            { 
                new Occupations
                {
                    OccupationId = 1, 
                    OccupationName = "Cleaner" , 
                    OccupationRating ="Light Manual",
                    Ratings = _ratingRepository.AllOccupationRating.ToList()[2]
                },
                new Occupations
                {
                    OccupationId = 2, 
                    OccupationName = "Doctor", 
                    OccupationRating = "Professional",
                    Ratings = _ratingRepository.AllOccupationRating.ToList()[0]
                },
                new Occupations
                {
                    OccupationId = 3, 
                    OccupationName = "Author", 
                    OccupationRating = "White Collar",
                    Ratings = _ratingRepository.AllOccupationRating.ToList()[1]
                },
                new Occupations
                {
                    OccupationId = 4, 
                    OccupationName = "Farmer", 
                    OccupationRating = "Heavy Manual",
                    Ratings = _ratingRepository.AllOccupationRating.ToList()[2]
                },
                new Occupations
                {
                    OccupationId = 5, 
                    OccupationName = "Mechanic" , 
                    OccupationRating = "Heavy Manual",
                    Ratings = _ratingRepository.AllOccupationRating.ToList()[0]
                },
                new Occupations
                {
                    OccupationId = 6, 
                    OccupationName = "Florist", 
                    OccupationRating = "Light Manual",
                    Ratings = _ratingRepository.AllOccupationRating.ToList()[0]
                }
            };

        public decimal GetOccupationRatingFactor(string occupationName)
        {
            return AllOccupation.FirstOrDefault(o => o.OccupationName == occupationName).Ratings.Factor;
        }
    }
}

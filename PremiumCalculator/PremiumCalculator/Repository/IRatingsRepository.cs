using PremiumCalculator.Models;
using System.Collections.Generic;

namespace PremiumCalculator.Repository
{
    public interface IRatingsRepository
    {
        IEnumerable<Ratings> AllOccupationRating { get; }

        decimal GetOccupationRating(string OccupationName);
    }
}

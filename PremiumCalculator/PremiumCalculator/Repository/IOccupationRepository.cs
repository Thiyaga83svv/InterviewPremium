using PremiumCalculator.Models;
using System.Collections.Generic;

namespace PremiumCalculator.Repository
{
    public interface IOccupationRepository 
    {
        IEnumerable<Occupations> AllOccupation { get; }

        decimal GetOccupationRatingFactor(string occupationName);
    }
}

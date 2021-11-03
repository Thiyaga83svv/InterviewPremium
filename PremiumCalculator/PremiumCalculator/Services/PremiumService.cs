using PremiumCalculator.BusinessLogic;
using PremiumCalculator.Models;
using PremiumCalculator.Repository;
using System.Collections.Generic;

namespace PremiumCalculator.Services
{
    public class PremiumService : IPremiumService
    {
        private readonly IMonthlyPremiumCalculator _monthlyPremiumCalculator;
        private readonly IOccupationRepository _occupationRepository;

        public PremiumService(IMonthlyPremiumCalculator monthlyPremiumCalculator,
                                IOccupationRepository occupationRepository)
        {
            _monthlyPremiumCalculator = monthlyPremiumCalculator;
            _occupationRepository = occupationRepository;
        }

        public IEnumerable<Occupations> GetOccupations()
        {
            return _occupationRepository.AllOccupation;
        }

        public decimal GetPremiumAmount(MonthlyPremium monthlyPremium)
        {
            var occupationFactor = _occupationRepository.GetOccupationRatingFactor(monthlyPremium.Occupation);
            var premium = _monthlyPremiumCalculator.GetMonthlyPremium(monthlyPremium.SumAssured, occupationFactor, monthlyPremium.Age);
            return premium;
        }
    }
}

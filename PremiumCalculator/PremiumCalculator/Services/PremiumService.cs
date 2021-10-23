﻿using PremiumCalculator.BusinessLogic;
using PremiumCalculator.Models;
using PremiumCalculator.Repository;

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

        public decimal GetPremiumAmount(MonthlyPremium monthlyPremium)
        {
            var occupationFactor = _occupationRepository.GetOccupationRatingFactor(monthlyPremium.OccupationName);
            var premium = _monthlyPremiumCalculator.GetMonthlyPremium(monthlyPremium.SumAssured, occupationFactor, monthlyPremium.Age);
            return premium;
        }
    }
}

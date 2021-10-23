using System;

namespace PremiumCalculator.BusinessLogic
{
    public class MonthlyPremiumCalculator : IMonthlyPremiumCalculator
    {
        public decimal GetMonthlyPremium(int deathCoverAmount, decimal occupationRatingFactor, int age)
        {
            decimal deathPremium = Math.Round((deathCoverAmount * occupationRatingFactor * age) / (1000 * 12), 2);

            return deathPremium;
        }

        public int GetAge(DateTime dateOfBirth)
        {
            return DateTime.Now.Year - dateOfBirth.Year;
        }
    }
}

using System;

namespace PremiumCalculator.BusinessLogic
{
    public interface IMonthlyPremiumCalculator
    {
        decimal GetMonthlyPremium(int deathCoverAmount, decimal occupationRatingFactor, int age);

        int GetAge(DateTime dateOfBirth);
    }
}

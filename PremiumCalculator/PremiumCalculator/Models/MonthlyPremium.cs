using System;

namespace PremiumCalculator.Models
{
    public class MonthlyPremium
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string OccupationName { get; set; }

        public int SumAssured { get; set; }
    }
}

using PremiumCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Services
{
    public interface IPremiumService
    {
        decimal GetPremiumAmount(MonthlyPremium monthlyPremium);
    }
}

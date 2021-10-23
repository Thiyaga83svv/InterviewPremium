using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PremiumCalculator.BusinessLogic;
using PremiumCalculator.Models;
using PremiumCalculator.Repository;
using PremiumCalculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PremiumController : ControllerBase
    {
        private readonly IPremiumService _premiumService;
        private readonly ILogger<PremiumController> _logger;
        private readonly IMonthlyPremiumCalculator _monthlyPremiumCalculator;

        public PremiumController(IPremiumService premiumService,
                                  ILogger<PremiumController> logger,
                                  IMonthlyPremiumCalculator monthlyPremiumCalculator)
        {
            _premiumService = premiumService;
            _logger = logger;
            _monthlyPremiumCalculator = monthlyPremiumCalculator;
        }

        [HttpPost]
        [Route("premium")]
        public JsonResult CalculatePremium(MonthlyPremium monthlyPremium)
        {
            var premium = _premiumService.GetPremiumAmount(monthlyPremium);
            _logger.LogInformation("Premium calculated for {0} is {1}", monthlyPremium.Name, premium);
            return new JsonResult(premium);
        }

        [HttpPost]
        [Route("age")]
        public JsonResult GetAge(DateTime dateOfbirth)
        {
            int age = _monthlyPremiumCalculator.GetAge(dateOfbirth);
            return new JsonResult(age);
        }
        [HttpGet]
        [Route("occupation")]
        public JsonResult GetOccupation()
        {
            return new JsonResult(_premiumService.GetOccupations());
        }

    }
}


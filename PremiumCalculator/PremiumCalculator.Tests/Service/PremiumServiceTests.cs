using PremiumCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Moq;
using AutoFixture;
using PremiumCalculator.Repository;
using PremiumCalculator.BusinessLogic;
using PremiumCalculator.Services;

namespace PremiumCalculator.UnitTests.Service
{
    public class PremiumServiceTests : UnitTests
    {

        private Mock<IMonthlyPremiumCalculator> _mockIMonthlyPremiumCalculator = new Mock<IMonthlyPremiumCalculator>();
        private Mock<IOccupationRepository> _mockOccupationRepository = new Mock<IOccupationRepository>();
        public PremiumServiceTests()
        {
            _mockIMonthlyPremiumCalculator = new Mock<IMonthlyPremiumCalculator>();
            _mockOccupationRepository = new Mock<IOccupationRepository>();
        }
        [Fact]
        public void GetMonthlyPremiumAmount()
        {
            //Arrange
            var monthlyPremium = Fixture.Create<MonthlyPremium>();
            monthlyPremium.SumAssured = 100000;
            monthlyPremium.Age = 35;
            var factor = 2.0m;
            var occupationName = Fixture.Create<string>();
            var sut = new PremiumService(_mockIMonthlyPremiumCalculator.Object, _mockOccupationRepository.Object);
            //var occupationRepository = Fixture.Freeze<Mock<IOccupationRepository>>();
            //occupationRepository.Setup(_ => _.GetOccupationRatingFactor(occupationName))
            //    .Returns(factor);
            //var premium = Fixture.Freeze<Mock<IMonthlyPremiumCalculator>>();
            //premium.Setup(_ => _.GetMonthlyPremium(It.IsAny<int>(), factor, It.IsAny<int>()))
            //    .Returns(4.25m);
            //SUT
            var service = Fixture.Create<PremiumService>();

            var result = sut.GetPremiumAmount(monthlyPremium);
            //Assert
            result.Should().Be(4.25m);
        }
    }
}

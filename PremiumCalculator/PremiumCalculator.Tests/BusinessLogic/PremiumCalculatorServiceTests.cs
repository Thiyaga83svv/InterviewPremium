using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using AutoFixture;
using PremiumCalculator.BusinessLogic;

namespace PremiumCalculator.UnitTests.BusinessLogic
{
    public class PremiumCalculatorServiceTests : UnitTests
    {
        [Fact]
        public void GetAgeReturnsCorrectValue()
        {
            //Arrange
            var dob = "21/02/1980";
            //SUT
            var service = Fixture.Create<MonthlyPremiumCalculator>();
            //ACT
            var result = service.GetAge(DateTime.Parse(dob));
            //Assert
            result.Should().Be(41);
        }

        [Fact]
        public void GetAgeReturnsCorrectValueZero()
        {
            //Arrange
            var dob = Fixture.Create<DateTime>();

            //SUT
            var service = Fixture.Create<MonthlyPremiumCalculator>();
            //ACT
            var result = service.GetAge(dob);
            //Assert
            result.Should().Be(DateTime.Now.Year - dob.Year);
        }

        [Fact]
        public void GetMonthlyPremiumShouldReturnValue()
        {
            //Arrange
            var deathCoverAmount = 100000;
            var occupationRatingFactor = 2;
            var age = 35;
            //SUT
            var service = Fixture.Create<MonthlyPremiumCalculator>();
            //Act
            var result = service.GetMonthlyPremium(deathCoverAmount, occupationRatingFactor, age);

            //ASSERT
            result.Should().Be(583.33M);

        }
    }
}

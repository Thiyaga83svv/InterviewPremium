using AutoFixture;
using AutoFixture.AutoMoq;
using System;
using Xunit;

namespace PremiumCalculator.UnitTests
{
    public abstract class UnitTests
    {
        protected UnitTests()
        {
            Fixture = new Fixture();
            Fixture.Customize(new AutoMoqCustomization());
        }
        protected IFixture Fixture { get; }
    }
}

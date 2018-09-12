using System;
using Xunit;

namespace BusCompany.UnitTests
{
    public class PriceCalculatorTests
    {
        [Fact]
        public void CalculatePrice_DistanceIs0_PriceShouldBe2500()
        {
            //Arrange
            PriceCalculator calculator = new PriceCalculator();

            //Act
            decimal price = calculator.CalculatePrice(0);

            //Assert
            Assert.Equal(2500, price);
        }
    }
}

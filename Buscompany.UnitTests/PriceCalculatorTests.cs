using System;
using Xunit;

namespace BusCompany.UnitTests
{
    public class PriceCalculatorTests
    {
        PriceCalculator calculator;

        public PriceCalculatorTests(){
            calculator = new PriceCalculator();
        }

        [Fact]
        public void CalculatePrice_DistanceIs0_PriceShouldBe2500()
        {
            //Act
            decimal price = calculator.CalculatePrice(0);
            //Assert
            Assert.Equal(2500, price);
        }

        [Fact]
        public void CalculatePrice_DistanceIs1_PriceShouldBe2510()
        {
            //Act
            decimal price = calculator.CalculatePrice(1);
            //Assert
            Assert.Equal(2510, price);
        }

    }
}

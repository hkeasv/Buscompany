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

        [Fact]
        public void CalculatePrice_DistanceIs100_PriceShouldBe3498()
        {
            //Act
            decimal price = calculator.CalculatePrice(100);
            //Assert
            Assert.Equal(3498, price);
        }

        [Fact]
        public void CalculatePrice_DistanceIs501_PriceShouldBe6704()
        {
            //Act
            decimal price = calculator.CalculatePrice(501);
            //Assert
            Assert.Equal(6704, price);
        }

        [Fact]
        public void CalculatePrice_NegativeDistance_ThrowsException()
        {
            Assert.Throws<System.ArgumentException>(() => calculator.CalculatePrice(-1));
        }


    }
}

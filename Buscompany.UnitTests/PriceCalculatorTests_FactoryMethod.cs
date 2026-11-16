using System;
using BusCompany;
using Xunit;

namespace Buscompany.UnitTests
{
    public class PriceCalculatorTests_FactoryMethod
    {
        // A factory method is used for setup. If different test 
        // methods require different setup, a factory method for
        // each type of setup could be provided.
        public PriceCalculator CreateCalculator(){
            return new PriceCalculator();
        }

        [Fact]
        public void CalculatePrice_DistanceIs0_PriceShouldBe2500()
        {
            decimal price = CreateCalculator().CalculatePrice(0);
            Assert.Equal(2500, price);
        }

        [Fact]
        public void CalculatePrice_DistanceIs1_PriceShouldBe2510()
        {
            decimal price = CreateCalculator().CalculatePrice(1);
            Assert.Equal(2510, price);
        }

        [Fact]
        public void CalculatePrice_DistanceIs100_PriceShouldBe3498()
        {
            decimal price = CreateCalculator().CalculatePrice(100);
            Assert.Equal(3498, price);
        }

        [Fact]
        public void CalculatePrice_DistanceIs501_PriceShouldBe6704()
        {
            decimal price = CreateCalculator().CalculatePrice(501);
            Assert.Equal(6704, price);
        }

        [Fact]
        public void CalculatePrice_NegativeDistance_ThrowsException()
        {
            const int negativeDistance = -1;

            // Arrange
            var calculator = CreateCalculator();

            // Act
            Action actual = () => calculator.CalculatePrice(negativeDistance);

            // Assert
            Assert.Throws<System.ArgumentException>(actual);
        }
    }
}

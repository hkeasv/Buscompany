using System;
using Xunit;

namespace BusCompany.UnitTests
{
    public class PriceCalculatorTests : IDisposable
    {
        // This class uses the "Constructor and dispose" approach
        // to sharing a test context. This approach is good when
        // all test methods require the same setup.

        // Shared: code but not instance

        PriceCalculator calculator;

        // Constructor is used for setup. The test runner creates
        // a new instance of the test class every time a test is
        // run. Hence the code in the constructor is run for each test.
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

        public void Dispose()
        {
            // There is nothing to dispose in this case.
        }
    }
}

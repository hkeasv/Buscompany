using Xunit;

namespace Buscompany.UnitTests
{
    public class PriceCalculatorTests_ClassFixtures :
        IClassFixture<PriceCalculatorFixture>
    {
        // This class uses the "Class fixtures" approach
        // to sharing a test context. When this approach is used
        // all test methods in the class will share the same test context.

        // In this example, all test methods share the same
        // PriceCalculator instance. This instance is created
        // by the PriceCalculatorFixture class.

        // Shared: code + instance

        PriceCalculatorFixture _fixture;

        public PriceCalculatorTests_ClassFixtures(PriceCalculatorFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void CalculatePrice_DistanceIs0_PriceShouldBe2500()
        {
            //Act
            decimal price = _fixture.Calculator.CalculatePrice(0);
            //Assert
            Assert.Equal(2500, price);
        }

        [Fact]
        public void CalculatePrice_DistanceIs1_PriceShouldBe2510()
        {
            //Act
            decimal price = _fixture.Calculator.CalculatePrice(1);
            //Assert
            Assert.Equal(2510, price);
        }

        [Fact]
        public void CalculatePrice_DistanceIs100_PriceShouldBe3498()
        {
            //Act
            decimal price = _fixture.Calculator.CalculatePrice(100);
            //Assert
            Assert.Equal(3498, price);
        }

        [Fact]
        public void CalculatePrice_DistanceIs501_PriceShouldBe6704()
        {
            //Act
            decimal price = _fixture.Calculator.CalculatePrice(501);
            //Assert
            Assert.Equal(6704, price);
        }

        [Fact]
        public void CalculatePrice_NegativeDistance_ThrowsException()
        {
            Assert.Throws<System.ArgumentException>(() => _fixture.Calculator.CalculatePrice(-1));
        }

    }
}

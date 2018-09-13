using Xunit;

namespace Buscompany.UnitTests
{
    [Collection("BusCompany collection")]
    public class PriceCalculatorTests_CollectionFixtures
    {
        // This class uses the "Collection fixtures" approach
        // to sharing a test context. Similar to class fixtures,
        // collection fixtures is used to create a test context
        // that is shared among tests, but this time the tests
        // can be in several classes belonging to the same collection.

        // A fixture class similar to the one used for class fixtures
        // must be available. In addition, a collection definition class
        // must be created and used. This example uses the BusCompanyCollection
        // class.

        // Every test class that needs to share a test context should
        // be decorated with a Collection attribute using the same
        // collection name as defined in the collection definition class.

        PriceCalculatorFixture _fixture;

        public PriceCalculatorTests_CollectionFixtures(PriceCalculatorFixture fixture)
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

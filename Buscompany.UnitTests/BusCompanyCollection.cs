using Xunit;

namespace Buscompany.UnitTests
{
    [CollectionDefinition("BusCompany collection")]
    public class BusCompanyCollection : ICollectionFixture<PriceCalculatorFixture>
    {
    }
}

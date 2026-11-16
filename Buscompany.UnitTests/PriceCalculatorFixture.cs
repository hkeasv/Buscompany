using System;
using BusCompany;

namespace Buscompany.UnitTests
{
    public class PriceCalculatorFixture : IDisposable
    {
        public PriceCalculator Calculator { get; }

        public PriceCalculatorFixture()
        {
            Calculator = new PriceCalculator();
        }

        public void Dispose()
        {
            // There is nothing to dispose in this case.
        }
    }
}

using System;

namespace BusCompany
{
    public class PriceCalculator
    {
        int initialFee = 2500;
        int kmFee = 10;

        public decimal CalculatePrice(int distance){
            decimal price = initialFee + kmFee*distance;
            return price;

        }


    }
}

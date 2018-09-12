using System;

namespace BusCompany
{
    public class PriceCalculator
    {
        int initialFee = 2500;
        int d1KmFee = 10;
        int d2KmFee = 8;

        public decimal CalculatePrice(int distance){
            int d1 = 0;
            int d2 = 0;

            if (distance < 100)
                d1 = distance;
            else
            {
                d1 = 99;
                d2 = distance - 99;
            }


            decimal price = initialFee + d1KmFee*d1 + d2KmFee*d2;
            return price;

        }


    }
}

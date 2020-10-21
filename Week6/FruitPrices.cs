using System;
using System.Collections.Generic;
using System.Text;

namespace Week6
{
    class FruitPrices
    {
        public static double orange= 25;
        public static double apple= 60;
        public static string achat;
        
        public static double CalculateCharge(List<Shopping_Cart> shopping_s)
        {
            double charge = 0;
            foreach(Shopping_Cart shop in shopping_s)
            {
                if (achat = shopping_s.orange)
                {
                    charge += orange;

                }
                else if (achat = shopping_s.apple)
                {
                    charge += apple;
                }
            }
            return charge;
        }
    }
}

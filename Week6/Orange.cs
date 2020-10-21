using System;
using System.Collections.Generic;
using System.Text;

namespace Week6
{
   public  class Orange
   {
        public List<Shopping_Cart> oranges { get; set; }

        public Orange()
        {
            oranges = new List<Shopping_Cart>();

        }
        public double CalculatePrice()
        {
            double total = 0;
            foreach (Orange o in oranges)
            {
                total += FruitPrices.CalculateCharge();
            }
            return total;
        }
   }
}

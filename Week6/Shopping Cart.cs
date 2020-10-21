using System;
using System.Collections.Generic;
using System.Text;

namespace Week6
{
    public class Shopping_Cart
    {

        public List<Shopping_Cart> shopping_s { get; set; }

        public Shopping_Cart()
        {
            shopping_s = new List<Shopping_Cart>();

        }
        public double CalculateCharges(Orange orange, Apple pomme)
        {
            double total = 0;
            foreach (Shopping_Cart shop in shopping_s)
            {
                total += FruitPrices.CalculateCharge(shop);
            }
            return total;
        }
        
    }
}

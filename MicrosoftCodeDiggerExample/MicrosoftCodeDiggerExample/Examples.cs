using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicrosoftCodeDiggerExample
{
    public class CodeDiggerExample
    {
        //Simple method to sum an array of integers
        public static int Sum(int[] values)
        {
            //Sums the values of the array
            return values.Sum();
        }

        //A simple method to calculate the average price per piece of candy given several bags of candy
        public static decimal CalculateCandyPricePerServing(IEnumerable<BagOfCandy> bagsOfCandy)
        {
            //Rough attempt to fix several more of the issues apparent in the first table
            if(bagsOfCandy == null || !bagsOfCandy.Any(p => p != null && p.Price != 0 && p.Servings != 0))
            {
                //Return -1 for invalid results
                return -1;
            }
            else
            {
                //Attempt to average the values otherwise
                return bagsOfCandy.Average(p => p.Servings / p.Price);
            }
        }

        //A simple method to calculate the average price per piece of candy given several bags of candy
        public static decimal UpdatedCalculateCandyPricePerServing(IEnumerable<BagOfCandy> bagsOfCandy)
        {
            //If the bags of candy are not null and contain any bags that are not null
            if (bagsOfCandy != null && bagsOfCandy.Any(b => b != null))
            {
                //Gather the unempty bags with valid prices
                var unemptyBags = bagsOfCandy.Where(b => b != null && b.Price > 0);

                //If there are any of these bags - output the average, otherwise -1
                return (unemptyBags.Any()) ? unemptyBags.Average(p => p.Servings / p.Price) : -1;
            }
            else
            {
                //Otherwise return -1
                return -1;
            }
        }
    }
 
    //A Bag of Candy
    public class BagOfCandy
    {
        public int Servings { get; set; }
        public decimal Price { get; set; }

        public BagOfCandy()
        {
        }
    }
}

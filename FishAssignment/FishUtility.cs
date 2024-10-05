using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishAssignment
{
    public class FishUtility : Fish
    {
        public void AddFish(string species,double pricePerFish)
        {
            Species = species;
            PricePerFish = pricePerFish;
        }

        public bool BuyFish()
        {
            if (Species == "Clownfish" || Species == "Goldfish")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CalculatePrice(int numberOfFishes)
        {
            double additionalCharges = 0;

            if (Species == "Clownfish")
            {
                additionalCharges = 100;
            }
            else if (Species == "Goldfish")
            {
                additionalCharges = 150;
            }
            return (PricePerFish * numberOfFishes) + additionalCharges;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssessment
{
    public class BabyDressUtility
    {
        public void AddDressToCart(BabyDress dress)
        {
            Program.DressesCart.Add(dress);
        }

        public bool RemoveDressFromCart(string brand)
        {
            foreach(var dress in Program.DressesCart)
            {
                if(dress.Brand == brand)
                {
                    Program.DressesCart.Remove(dress);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}

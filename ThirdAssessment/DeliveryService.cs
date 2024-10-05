using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssessment
{
    public class DeliveryService
    {
        public bool PlaceOrder(Product product)
        {
            if(product.Stock > 0)
            {
                return true;  //Product is in stock
            }
            else
            {
                throw new ProductOutOfStockException();
            }
        }
    }
}

namespace ThirdAssessment
{
    public class ProductOutOfStockException : Exception
    {
        public override string Message => "Product Out Of Stock";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           DeliveryService deliveryService = new DeliveryService();

            try
            {
                //Prompt user
                Console.WriteLine("Enter the product name : ");
                string pname = Console.ReadLine();
                Console.WriteLine("Enter the number of stock : ");
                int stock = Convert.ToInt32(Console.ReadLine());

                Product product = new Product
                {
                    Name = pname,
                    Stock = stock
                };
                if(deliveryService.PlaceOrder(product))
                {
                    Console.WriteLine("Your Order is placed successfully");
                }
            }
            catch (ProductOutOfStockException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

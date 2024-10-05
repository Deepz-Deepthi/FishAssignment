namespace FishAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FishUtility fishUtility = new FishUtility();

            //prompt the user to enter the species to buy
            Console.WriteLine("Enter the Species of the fish to buy : ");
            string species = Console.ReadLine();
            //prompt the user to enter the price per fish
            Console.WriteLine("Enter the price per fish : ");
            double pricePerFish = Convert.ToDouble(Console.ReadLine());
             
            fishUtility.AddFish(species, pricePerFish);

            if (fishUtility.BuyFish())
            {
                Console.WriteLine("Enter the number of fishes you need to buy : ");
                int numberOfFishes = Convert.ToInt32(Console.ReadLine());

                double totalCost = fishUtility.CalculatePrice(numberOfFishes);
                Console.WriteLine($"Total cost is : {totalCost}");
            }
            else
            {
                Console.WriteLine($"{species} species not valid");
            }

        }
    }
}

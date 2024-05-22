using System;

namespace KasaStore
{
    class Program
    {
        enum ProductType
        {
            Food = 1,
            Clothing,
            Electronics,
            Books
        }

        static void Main(string[] args)
        {
            decimal totalCost = 0.0m;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select product type:");
                foreach (var type in Enum.GetValues(typeof(ProductType)))
                {
                    Console.WriteLine($"{(int)type} - {type}");
                }
                Console.Write("Enter the number of the product type (or 0 to finish): ");
                if (int.TryParse(Console.ReadLine(), out int productType) && productType == 0)
                {
                    break;
                }

                if (!Enum.IsDefined(typeof(ProductType), productType))
                {
                    Console.WriteLine("Invalid product type. Please try again.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Enter the price of the product: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal price) && price >= 0)
                {
                    totalCost += price;
                    Console.WriteLine($"Product added. Current total cost: {totalCost:C2}");
                }
                else
                {
                    Console.WriteLine("Invalid price. Please try again.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            Console.WriteLine($"Final total cost of all products: {totalCost:C2}");
            Console.ReadKey();
        }
    }
}

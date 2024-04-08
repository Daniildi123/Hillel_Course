using System;

class Program
{
    static void Main(string[] args)
    {
        double price = 100; 
        double discountPercentage = 20; 

        double discountAmount = price * (discountPercentage / 100);

        Console.WriteLine("Price of the product: $" + price);
        Console.WriteLine("Discount percentage: " + discountPercentage + "%");
        Console.WriteLine("Amount of the discount: $" + discountAmount);
        Console.ReadKey();
    }
}

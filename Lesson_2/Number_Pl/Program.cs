using System;

class Program
{
    static void Main(string[] args)
    {
        int price = 100;
        int discountPercentage = 20;

        double discount = price * (discountPercentage / 100.0);

        Console.WriteLine("Price of the product: $" + price);
        Console.WriteLine("Discount percentage: " + discountPercentage + "%");
        Console.WriteLine("Amount of the discount: $" + discount);
        Console.ReadKey();
    }
}

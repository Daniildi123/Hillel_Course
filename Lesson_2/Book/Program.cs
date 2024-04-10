using System;
//в) Створіть програму, яка виводить інформацію про книгу, використовуючи форматований рядок.
//Параметри книги - назва, автор, рік та ціна. 
class Program
{
    static void Main(string[] args)
    {
        string nameBook = "Shogun(Novel)";
        string autorBook = "James Clavell";
        int ageBook = 1975;
        decimal priceBook = 100;

        Console.WriteLine("Назва:{0} Автор: {1} Рiк: {2} Цiна: {3}", nameBook, autorBook, ageBook, priceBook);
        Console.ReadKey();
    }
}

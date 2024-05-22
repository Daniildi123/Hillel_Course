using Classes;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        // Створення екземпляру книги "Відлуння"
        Book theShining = new Book();
        theShining.Title = "Відлуння";
        theShining.Author = "Стівен Кінг";
        theShining.Year = 1977;
        theShining.Pages = 447;
         
        // Виведення інформації про книгу "Відлуння" та перевірка на товстоту
        Console.WriteLine("Інформація про книгу \"Відлуння\":");
        theShining.DisplayInfo();
        theShining.IsThick();

        // Створення ще одного екземпляру книги
        Book anotherBook = new Book();
        anotherBook.Title = "Темна башта";
        anotherBook.Author = "Стівен Кінг";
        anotherBook.Year = 1999;
        anotherBook.Pages = 768;

        // Виведення інформації про іншу книгу та перевірка на товстоту
        Console.WriteLine("\nІнформація про книгу \"Темна башта\":");
        anotherBook.DisplayInfo();
        anotherBook.IsThick();
        Console.ReadKey();
    }
}

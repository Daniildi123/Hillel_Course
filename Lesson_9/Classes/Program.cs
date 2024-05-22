using Classes;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
       
        Book theShining = new Book();
        theShining.Title = "Відлуння";
        theShining.Author = "Стівен Кінг";
        theShining.Year = 1977;
        theShining.Pages = 447;
         
        
        Console.WriteLine("Інформація про книгу \"Відлуння\":");
        theShining.DisplayInfo();
        theShining.IsThick();

        
        Book anotherBook = new Book();
        anotherBook.Title = "Темна башта";
        anotherBook.Author = "Стівен Кінг";
        anotherBook.Year = 1999;
        anotherBook.Pages = 768;

        
        Console.WriteLine("\nІнформація про книгу \"Темна башта\":");
        anotherBook.DisplayInfo();
        anotherBook.IsThick();
        Console.ReadKey();
    }
}

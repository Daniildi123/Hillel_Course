using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Book
    {

      
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        
        public void DisplayInfo()
        {
            Console.WriteLine("Назва книги: {0}", Title);
            Console.WriteLine("Автор: {0}", Author);
            Console.WriteLine("Рік видання: {0}", Year);
            Console.WriteLine("Кількість сторінок: {0}", Pages);
        }

        // Метод для перевірки, чи книга є товстою
        public void IsThick()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            if (Pages > 500)
            {
                Console.WriteLine("Ця книга товста!");
            }
            else
            {
                Console.WriteLine("Ця книга не така товста.");
                Console.ReadKey();  
            }
        }
    }
}

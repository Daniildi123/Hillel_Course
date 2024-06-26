﻿using System;
// Написати програму, в якій користувач вводить номер місяця.
// Якщо місяць 1,2,12 відображає "Зима"; 3,4,5 - «Весна»; 6-8 - «Літо»; 9-11 – «Осінь».
// У будь-якому іншому випадку - "Немає такого місяця на цій планеті" .
namespace Season

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть номер місяця:");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month == 1 || month == 2 || month == 12)
            {
                Console.WriteLine("Зима");
            }
            else if (month == 3 || month == 4 || month == 5)
            {
                Console.WriteLine("Весна");
            }
            else if (month == 6 || month == 7 || month == 8)
            {
                Console.WriteLine("Літо");
            }
            else if (month == 9 || month == 10 || month == 11)
            {
                Console.WriteLine("Осінь");
            }
            else
            {
                Console.WriteLine("Немає такого місяця на цій планеті");
            }

            Console.ReadLine(); 
        }
    }
}

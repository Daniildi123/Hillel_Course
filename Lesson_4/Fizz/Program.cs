using System;
//3) Напишіть програму, яка приймає від користувача число від 1 до 100.
//При цьому якщо число кратне трьом,
//програма повинна виводити слово Fizz, а якщо кратно п'яти - слово Buzz


namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть число від 1 до 100:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 15 == 0)
            {
               Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
              Console.WriteLine(number);
            }

            Console.ReadLine(); 
        }
    }
}

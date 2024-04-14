using System;

namespace AverageCalculator
{
    class Program
    {
        //4) Написати програму, яка обчислює середнє арифметичне двох чисел.


        static void Main(string[] args)
        {
            double num1, num2, average;

            
            Console.Write("Введіть перше число: ");
            string input1 = Console.ReadLine();

         
            Console.Write("Введіть друге число: ");
            string input2 = Console.ReadLine();

            num1 = double.Parse(input1);
            num2 = double.Parse(input2);

          
            average = (num1 + num2) / 2;

            Console.WriteLine($"Середнє арифметичне чисел {num1} і {num2} дорівнює {average}");

         
            Console.ReadKey();
        }
    }
}


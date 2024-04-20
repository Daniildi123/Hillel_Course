using System;
//Необхідно написати консольну програму, де користувач вводитиме
//з клавіатури 2 числа. Числа будуть порівнюватися з наступним виведенням
//в консоль результату цього порівняння (чи рівні значення, а якщо ні, яке число більше/менше).
namespace Keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть перше число:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine($"Числа {number1} і {number2} рівні.");
            }
            else if (number1 > number2)
            {
                Console.WriteLine($"Число {number1} більше за число {number2}.");
            }
            else
            {
                Console.WriteLine($"Число {number1} менше за число {number2}.");
            }

            Console.ReadLine();
        }
    }
}
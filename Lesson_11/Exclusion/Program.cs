using System;

namespace Exclusion
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            while (true)
            {
                try
                {
                    Console.Write("Введіть свій вік: ");
                    string input = Console.ReadLine();
                    int age;

                    if (!int.TryParse(input, out age) || age < 0)
                    {
                        throw new FormatException("Вік повинен бути цілим додатнім числом.");
                    }

                    Console.WriteLine($"Ваш вік: {age} років.");
                    break; 
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}. Спробуйте ще раз.");
                }
            }

           
            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}

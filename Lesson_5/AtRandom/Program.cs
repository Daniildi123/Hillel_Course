using System;
//2) Програма загадує число від 1 до 146 (привіт, Random). Користувач намагається вгадати його.
//У разі неправильної відповіді програма підказує «більше» або «менше»
namespace AtRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Random random = new Random();
            int secretNumber = random.Next(1, 147);
            int guess;

            Console.WriteLine("Спробуйте вгадати число від 1 до 146.");

            do
            {
                Console.WriteLine("Введіть свій варіант:");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < secretNumber)
                {
                    Console.WriteLine("Більше!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Менше!");
                }

            } while (guess != secretNumber);

            Console.WriteLine($"Вітаємо! Ви вгадали число {secretNumber}!");

            Console.ReadLine(); 
        }
    }
}

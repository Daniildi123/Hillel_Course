using System;
// Таблиця множення


namespace MultiplicationTable
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Таблиця множення:");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i} × {j} = {i * j}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(); 
            for (int i = 6; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i} × {j} = {i * j}\t");
                }
                Console.WriteLine(); 
            }

            Console.ReadLine(); 
        }
    }
}

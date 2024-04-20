using System;
//1) Задати масив із 10 елементів. Заповнити цей масив рандомними числами від -100 до 100.
//Знайти кількість додатніх чисел у масиві.
//Вивести на екран масив і кількість порахованих чисел. 
//{ 5, -9, 8, 7} =>{ 5, -9, 8, 7} , кількість додатних чисел = 3  
namespace Masiif
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            int positiveCount = 0;

            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
                if (array[i] > 0)
                {
                    positiveCount++;
                }
            }

          
            Console.Write("");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("");

           
            Console.WriteLine($"кількість додатніх чисел = {positiveCount}");

            Console.ReadLine();
        }
    }
}

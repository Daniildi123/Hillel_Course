using System;
//4)Написати програму, яка виводить всі елементи масиву доки не зустрінеться елемент -1.
//Масив заповнити рандомними числами, діапазон чисел від -5 до 5. 

namespace Encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[20]; 

           
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-5, 6);
            }

           
            foreach (int num in array)
            {
                if (num == -1)
                {
                    Console.WriteLine(num); 
                    break;
                }
                Console.WriteLine(num); 
            }

            Console.ReadLine();
        }
    }
}

using System;
//Написати програму, яка виводить всі елементи масиву доки не зустрінеться елемент -1.
//Масив заповнити рандомними числами, діапазон чисел від -5 до 5. 

namespace PrintUntilMinusOneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[20]; 
            int index = 0;

            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-5, 6);
            }

            Console.WriteLine("Початковий масив:");
            PrintArray(array);

            Console.WriteLine("Елементи масиву до першого зустрічного елемента -1:");

            while (index < array.Length && array[index] != -1)
            {
                Console.Write(array[index] + " ");
                index++;
            }

            Console.ReadLine(); 
        }

        
        static void PrintArray(int[] arr)
        {
            Console.Write("{");
            foreach (var item in arr)
            {
                Console.Write(item);
                if (item != arr[arr.Length - 1])
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }
    }
}

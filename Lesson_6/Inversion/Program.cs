using System;
//2) Написати програму для інверсії масиву, тобто перевороту його у зворотному порядку.
//В цьому завданні недостатньо просто вивести елементи масиву у зворотному порядку. 
//Ідеально написати 2 способами (*вища оцінка буде) - через новий масив та переписавши значення заданного масиву. 
//{5, -9, 8, 7} => { 7, 8, -9, 5}

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, -9, 8, 7 }; 

            // Виведення початкового масиву
            Console.WriteLine("Початковий масив:");
            PrintArray(array);

            // Інверсія масиву
            ReverseArray(array);

            // Виведення інверсованого масиву
            Console.WriteLine("\nМасив після інверсії:");
            PrintArray(array);

            Console.ReadLine(); 
        }

        // Метод для інверсії масиву
        static void ReverseArray(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}

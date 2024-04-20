using System;
//2) Написати програму для інверсії масиву, тобто перевороту його у зворотному порядку.
//В цьому завданні недостатньо просто вивести елементи масиву у зворотному порядку. 
//Ідеально написати 2 способами (*вища оцінка буде) - через новий масив та переписавши значення заданного масиву. 
//{5, -9, 8, 7} => { 7, 8, -9, 5}

namespace Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, -9, 8, 7 };

            Console.WriteLine("Початковий масив:");
            PrintArray(array);

            int[] reversedArray1 = ReverseArrayUsingNewArray(array);
            Console.WriteLine("Масив після інверсії через новий масив:");
            PrintArray(reversedArray1);

            ReverseArrayInPlace(array);
            Console.WriteLine("Масив після інверсії переписавши значення:");
            PrintArray(array);

            Console.ReadLine();
        }

        static int[] ReverseArrayUsingNewArray(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversed[arr.Length - 1 - i] = arr[i];
            }
            return reversed;
        }

        static void ReverseArrayInPlace(int[] arr)
        {
            int temp;
            int n = arr.Length;
            for (int i = 0; i < n / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - 1 - i] = temp;
            }
        }

        static void PrintArray(int[] arr)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }
    }
}

using System;
//3) Потрібно додати до масиву елемент на початок. Нехай масив буде на 10 елементів.
//Масив заповнити рандомними числами. Той елемент, що потрібно додати, також взяти рандомно. 
namespace RandomMassif
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
            }

            Console.WriteLine("Початковий масив:");
            PrintArray(array);

            int newElement = random.Next(-100, 101);

            array = AddElementToArray(array, newElement);

            Console.WriteLine($"Масив після додавання елемента {newElement} на початок:");
            PrintArray(array);

            Console.ReadLine();
        }

        static int[] AddElementToArray(int[] arr, int element)
        {
            int[] newArray = new int[arr.Length + 1];
            newArray[0] = element;

            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = arr[i - 1];
            }

            return newArray;
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

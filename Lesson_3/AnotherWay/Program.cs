using System;

namespace SwapTwoVariables
//Дослідити інші способи поміняти місцями значення двох змінних без використання
//тимчасової змінної та використання суми/множення. 
{
    internal class Program
        {
            static void Main(string[] args)
            {
                int num1, num2;
                Console.Write("Введіть перше число: ");
                string? input1 = Console.ReadLine();
                Console.Write("Введіть друге число: ");
                string? input2 = Console.ReadLine();

                num1 = int.Parse(input1);
                num2 = int.Parse(input2);

                
                num1 = num1 * num2; // num1 = 10 * 20 = 200
                num2 = num1 / num2; // num2 = 200 / 20 = 10
                num1 = num1 / num2; // num1 = 200 / 10 = 20

                Console.WriteLine($"num1 = {num1}");
                Console.WriteLine($"num2 = {num2}");

                Console.ReadKey();
            }
        }
    }

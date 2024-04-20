using System;
//1) Напишіть програму, яка «запитуватиме» правильний пароль, доки він не буде введений.
//Правильний пароль нехай буде "root". Якщо пароль неправильний,
//програма повинна сказати "Неправильний пароль!"


namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string correctPassword = "root";
            string inputPassword = "";

            while (inputPassword != correctPassword)
            {
                Console.WriteLine("Введіть пароль:");
                inputPassword = Console.ReadLine();

                if (inputPassword != correctPassword)
                {
                    Console.WriteLine("Неправильний пароль!");
                }
            }

            Console.WriteLine("Пароль вірний! Вхід дозволено.");

            Console.ReadLine(); 
        }
    }
}

using System;
//б) Час в секундах
//Задайте час у годинах, хвилинах та секундах як змінні.
//Обчисліть загальний час у секундах.
//Виведіть результат у консоль.

class Program
{
    static void Main(string[] args)
    {
        int hours = 2;
        int minutes = 30;
        int seconds = 60;

        int TotalTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds;

        Console.WriteLine("Total time in seconds: " + TotalTimeInSeconds);
        Console.ReadKey();
    }
}

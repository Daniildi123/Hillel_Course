using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть день: ");
        int day = GetValidInput(1, 31);

        Console.Write("Введіть місяць: ");
        int month = GetValidInput(1, 12);

        Console.Write("Введіть рік: ");
        int year = GetValidInput(1, int.MaxValue);

        StringBuilder dateBuilder = new StringBuilder();
        dateBuilder.Append(day.ToString("D2")); 
        dateBuilder.Append("-");
        dateBuilder.Append(month.ToString("D2")); 
        dateBuilder.Append("-");
        dateBuilder.Append(year); 

        
        Console.WriteLine("Дата: " + dateBuilder.ToString());
        Console.ReadKey();
    }

    
    static int GetValidInput(int minValue, int maxValue)
    {
        int value;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out value))
            {
                if (value >= minValue && value <= maxValue)
                {
                    break; 
                }
            }

            Console.WriteLine($"Введіть коректне ціле число від {minValue} до {maxValue}:");
        }
        return value;
    }
}

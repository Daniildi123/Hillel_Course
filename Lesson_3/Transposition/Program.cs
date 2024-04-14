namespace Transposition

//3) Дано тризначне число. Знайти число, отримане під час перестановки першої та другої цифр заданого числа.
{
    class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Ведіть трьох значне  число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int firstDigit = number / 100;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = number % 10;

        int swappedNumber = secondDigit * 100 + firstDigit * 10 + thirdDigit;

        Console.WriteLine($"Число під час перестановки першої та другої цифр: {swappedNumber}");
        Console.ReadKey();
    }
 
  }

}








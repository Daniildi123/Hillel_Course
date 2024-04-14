
namespace Quadrat
{
    class Program
    //2)Написати програму, яка обчислює квадрат будь-якого введеного числа (бажано використати Math).
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вести число яке пiдноситься до квадрата");
            double number = Convert.ToDouble(Console.ReadLine());

            double multiplication = Math.Pow(number, 2);

            Console.WriteLine($"Квадрат числа {number} дорiвнюдє  {multiplication}");
            Console.ReadKey();
        }
    }
}
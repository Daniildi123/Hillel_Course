namespace Radius
{
    //5) Користувач вводить радіус круга. Напишіть програму, яка обчислює площу цього
    //круга і виводить в консоль результат. 
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;

            Console.WriteLine("Введіть радіус круга:");
            radius = double.Parse(Console.ReadLine());

            // S = πr2 формула

            area = Math.PI * radius * radius;

            Console.WriteLine($"Площа круга з радіусом {radius} дорівнює {area}");
            Console.ReadKey();
        }

    }

}
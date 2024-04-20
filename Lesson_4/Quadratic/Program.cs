using System;
//4*) Квадратне рівняння.
namespace Quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            double a = random.Next(1, 11); 
            double b = random.Next(1, 11);
            double c = random.Next(1, 11); 

            Console.WriteLine($"Рівняння: {a}x^2 + {b}x + {c} = 0");

            double discriminant = CalculateDiscriminant(a, b, c);

            if (discriminant < 0)
            {
                Console.WriteLine("Рівняння не має коренів.");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"Рівняння має один корінь: x = {root}");
            }
            else

            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Рівняння має два корені: x1 = {root1}, x2 = {root2}");
            }

            Console.ReadLine(); 
        }

        static double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }
}

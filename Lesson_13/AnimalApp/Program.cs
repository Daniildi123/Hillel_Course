using System;

namespace AnimalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal bird = new Bird();

            Console.WriteLine("Dog:");
            dog.MakeSound();
            dog.Move();

            Console.WriteLine("\nBird:");
            bird.MakeSound();
            bird.Move();

            Console.ReadKey();
        }
    }
}

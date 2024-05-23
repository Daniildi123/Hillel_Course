using System;

namespace TransportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car авто = new Car("Audi A7", 250, 3);
            Bicycle вело = new Bicycle("Cube", 32, "Гірський");

            авто.Move();
            вело.Move();

            Console.ReadKey();
        }
    }
}

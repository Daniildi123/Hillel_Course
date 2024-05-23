using AnimalApp;

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    public override void Move()
    {
        Console.WriteLine("Runs");
    }
}

using AnimalApp;

public class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Chirp");
    }

    public override void Move()
    {
        Console.WriteLine("Flies");
    }
}

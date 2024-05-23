public class Car : Transport
{
    public int КількістьДверей { get; set; }

    public Car(string назва, int максимальнаШвидкість, int кількістьДверей)
        : base(назва, максимальнаШвидкість)
    {
        КількістьДверей = кількістьДверей;
    }

    public override void Move()
    {
        Console.WriteLine($"{Назва} з {КількістьДверей} дверима рухається зі швидкістю {МаксимальнаШвидкість} км/год.");
    }
}

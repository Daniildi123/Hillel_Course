public class Bicycle : Transport
{
    public string ТипВелосипеда { get; set; }

    public Bicycle(string назва, int максимальнаШвидкість, string типВелосипеда)
        : base(назва, максимальнаШвидкість)
    {
        ТипВелосипеда = типВелосипеда;
    }

    public override void Move()
    {
        Console.WriteLine($"{ТипВелосипеда} велосипед {Назва} рухається зі швидкістю {МаксимальнаШвидкість} км/год.");
    }
}

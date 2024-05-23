public class Transport
{
    public string Назва { get; set; }
    public int МаксимальнаШвидкість { get; set; }

    public Transport(string назва, int максимальнаШвидкість)
    {
        Назва = назва;
        МаксимальнаШвидкість = максимальнаШвидкість;
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Назва} рухається зі швидкістю {МаксимальнаШвидкість} км/год.");
    }
}

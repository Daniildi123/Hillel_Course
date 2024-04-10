namespace  Numeric;

class Program
{
    //Дано тризначне число.Знайти число, отримане під час прочитання його цифр справа наліво.
    // 239
    static void Main(string[] args)
    {
        int number = 239;
        int reversedNumber = 0;
        int digit = number - 230;
        int ten = number - 207;
       
        reversedNumber = digit * 100 + ten;
      


        Console.WriteLine("Число, отримане справа наліво : " + reversedNumber);
        Console.ReadKey();

    }
}

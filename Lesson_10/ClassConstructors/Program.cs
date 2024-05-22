using ClassConstructors;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
 
        Person person1 = new Person("Іван", 25, Gender.Male);
        Person person2 = new Person("Марія");
        Person person3 = new Person("Петро", 30);

      
        Console.WriteLine("Інформація про першу людину:");
        person1.PrintDetails();

        Console.WriteLine("\nІнформація про другу людину:");
        person2.PrintDetails();

        Console.WriteLine("\nІнформація про третю людину:");
        person3.PrintDetails();

       
        Console.WriteLine("\nЧи перша людина є дорослою? " + (person1.IsAdult() ? "Так" : "Ні"));
        Console.WriteLine("Чи друга людина є дорослою? " + (person2.IsAdult() ? "Так" : "Ні"));
        Console.WriteLine("Чи третя людина є дорослою? " + (person3.IsAdult() ? "Так" : "Ні"));

       
        person1.ChangeName("Олександр");
        Console.WriteLine("\nІм'я першої людини після зміни: " + person1.Name);
        Console.ReadKey();  
    }
}

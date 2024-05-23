using System;
using UkrainianStringUtilsLibrary;

namespace UkrainianStringUtilsDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string testString = "Доброго дня , як ваші справи? Це тестовий рядок.";

            Console.WriteLine("Оригінальний рядок: " + testString);
            Console.WriteLine("Кількість голосних: " + UkrainianStringUtils.CountVowels(testString));
            Console.WriteLine("Кількість приголосних: " + UkrainianStringUtils.CountConsonants(testString));
            Console.WriteLine("Реверсований рядок: " + UkrainianStringUtils.ReverseString(testString));
            Console.WriteLine("Рядок без дублікатів: " + UkrainianStringUtils.RemoveDuplicates(testString));
            Console.WriteLine("Рядок без пунктуації: " + UkrainianStringUtils.RemovePunctuation(testString));
            Console.ReadKey();
        }
    }
}

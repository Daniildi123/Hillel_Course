using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGrades
{
    internal class Program
    {
      
        static List<int> marksMath = new List<int>();
        static List<int> marksHistory = new List<int>();
        static List<int> marksLanguage = new List<int>();

        static void Main(string[] args)
        {
           
            InitializeData();

            while (true)
            {
                int input = MultipleChoice(true, new MainMenu());
                switch ((MainMenu)input)
                {
                    case MainMenu.EnterGrades:
                        EnterGrades();
                        break;
                    case MainMenu.CalculateAverage:
                        CalculateAverage();
                        break;
                    case MainMenu.DisplayGrades:
                        DisplayGrades();
                        break;
                    case MainMenu.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        // Ініціалізація початкових даних
        static void InitializeData()
        {
            marksMath.AddRange(new int[] { 85, 90, 78 });
            marksHistory.AddRange(new int[] { 88, 76, 90 });
            marksLanguage.AddRange(new int[] { 92, 81, 85 });
        }

        // Метод для введення оцінок
        static void EnterGrades()
        {
            Console.Clear();
            Console.WriteLine("Enter grades for Math:");
            EnterSubjectGrades(marksMath);
            Console.WriteLine("Enter grades for History:");
            EnterSubjectGrades(marksHistory);
            Console.WriteLine("Enter grades for Language:");
            EnterSubjectGrades(marksLanguage);
        }

        static void EnterSubjectGrades(List<int> marks)
        {
            marks.Clear();
            while (true)
            {
                Console.Write("Enter grade (or -1 to finish): ");
                if (int.TryParse(Console.ReadLine(), out int grade) && grade == -1)
                    break;
                if (grade >= 0 && grade <= 100)
                    marks.Add(grade);
                else
                    Console.WriteLine("Invalid grade. Please enter a grade between 0 and 100.");
            }
        }

        // Метод для обчислення середньої оцінки
        static void CalculateAverage()
        {
            Console.Clear();
            Console.WriteLine("Average grades:");
            Console.WriteLine($"Math: {marksMath.Average():F2}");
            Console.WriteLine($"History: {marksHistory.Average():F2}");
            Console.WriteLine($"Language: {marksLanguage.Average():F2}");
            Console.WriteLine($"Overall: {(marksMath.Concat(marksHistory).Concat(marksLanguage).Average()):F2}");
        }

        // Метод для виведення оцінок
        static void DisplayGrades()
        {
            Console.Clear();
            Console.WriteLine("Grades:");
            Console.WriteLine($"Math: {string.Join(", ", marksMath)}");
            Console.WriteLine($"History: {string.Join(", ", marksHistory)}");
            Console.WriteLine($"Language: {string.Join(", ", marksLanguage)}");
        }

        // Інтерактивне меню
        enum MainMenu
        {
            EnterGrades, CalculateAverage, DisplayGrades, Exit
        }

        public static int MultipleChoice(bool canCancel, Enum userEnum, int spacingPerLine = 18, int optionsPerLine = 2, int startX = 1, int startY = 1)
        {
            int currentSelection = 0;
            ConsoleKey key;
            Console.CursorVisible = false;
            int length = Enum.GetValues(userEnum.GetType()).Length;
            do
            {
                Console.Clear();

                for (int i = 0; i < length; i++)
                {
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(Enum.Parse(userEnum.GetType(), i.ToString()));

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                currentSelection++;
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection >= optionsPerLine)
                                currentSelection -= optionsPerLine;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection + optionsPerLine < length)
                                currentSelection += optionsPerLine;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (canCancel)
                                return -1;
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;

            return currentSelection;
        }
    }
}

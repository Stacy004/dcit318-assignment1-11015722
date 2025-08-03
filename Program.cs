using System;

namespace GradeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GRADE CALCULATOR ===");
            int grade;
            string input;
            // Prompt until valid input is received
            do
            {
                Console.Write("Enter your score (0 - 100): ");
                input = Console.ReadLine();
                if (!int.TryParse(input, out grade) || grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                }
            } while (!int.TryParse(input, out grade) || grade < 0 || grade > 100);

            if (grade >= 90)
                Console.WriteLine(" Grade: A");
            else if (grade >= 80)
                Console.WriteLine(" Grade: B");
            else if (grade >= 70)
                Console.WriteLine(" Grade: C");
            else if (grade >= 60)
                Console.WriteLine(" Grade: D");
            else
                Console.WriteLine(" Grade: F");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

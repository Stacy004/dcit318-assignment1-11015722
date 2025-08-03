using System;

namespace DCIT318Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear(); // Clear previous screen

                Console.WriteLine("=== DCIT 318 ASSIGNMENT MENU ===");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunGradeCalculator();
                        break;
                    case "2":
                        Console.WriteLine("\nTicket Price Calculator not yet implemented.");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("\nTriangle Type Identifier not yet implemented.");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("\nExiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void RunGradeCalculator()
        {
            Console.Clear();
            Console.WriteLine("=== GRADE CALCULATOR ===");
            Console.Write("Enter a numerical grade (0 - 100): ");

            string input = Console.ReadLine();
            int grade;

            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                if (grade >= 90)
                    Console.WriteLine("Letter Grade: A");
                else if (grade >= 80)
                    Console.WriteLine("Letter Grade: B");
                else if (grade >= 70)
                    Console.WriteLine("Letter Grade: C");
                else if (grade >= 60)
                    Console.WriteLine("Letter Grade: D");
                else
                    Console.WriteLine("Letter Grade: F");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }
}

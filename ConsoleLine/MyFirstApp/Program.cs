using System;

class Program
{
    static void Main()
    {
        // --- Simple if statement ---
        Console.WriteLine("=== Simple if Statement ===");
        Console.Write("Enter a number: ");
        int number;

        // Validate input using TryParse
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid input. Please enter a valid integer: ");
        }

        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is zero or negative.");
        }

        // --- Nested if statement ---
        Console.WriteLine("\n=== Nested if Statement ===");
        Console.Write("Enter your age: ");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.Write("Invalid input. Please enter a valid age: ");
        }

        Console.Write("Do you have an ID? (yes/no): ");
        string idResponse = Console.ReadLine().Trim().ToLower();
        bool hasID = (idResponse == "yes");

        if (age >= 18)
        {
            if (hasID)
            {
                Console.WriteLine("You are allowed to enter.");
            }
            else
            {
                Console.WriteLine("You must have an ID to enter.");
            }
        }
        else
        {
            Console.WriteLine("You must be at least 18 years old.");
        }

        Console.WriteLine("\nProgram finished. Press any key to exit.");
        Console.ReadKey();
    }
}

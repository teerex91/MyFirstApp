using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== If Statement vs Shortcut (Ternary) ===");

        // Example 1: Standard if...else
        Console.Write("Enter a number: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid input. Enter a valid integer: ");
        }

        string result;
        if (number > 0)
        {
            result = "Positive";
        }
        else
        {
            result = "Zero or Negative";
        }
        Console.WriteLine($"[If Statement] The number is: {result}");

        // Example 2: Ternary operator (shortcut)
        string resultShortcut = (number > 0) ? "Positive" : "Zero or Negative";
        Console.WriteLine($"[Ternary Shortcut] The number is: {resultShortcut}");

        // Example 3: Nested ternary
        Console.Write("\nEnter your score (0-100): ");
        int score;
        while (!int.TryParse(Console.ReadLine(), out score))
        {
            Console.Write("Invalid input. Enter a number between 0 and 100: ");
        }

        string grade = (score >= 90) ? "A"
                     : (score >= 80) ? "B"
                     : (score >= 70) ? "C"
                     : (score >= 60) ? "D"
                     : "F";

        Console.WriteLine($"[Ternary Shortcut] Your grade is: {grade}");

        Console.WriteLine("\nProgram finished. Press any key to exit.");
        Console.ReadKey();
    }
}

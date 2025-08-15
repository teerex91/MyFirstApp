using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Advanced Switch Example ===");

        // --- Example 1: Multiple case labels ---
        Console.Write("Enter a day number (1-7): ");
        if (int.TryParse(Console.ReadLine(), out int dayNumber))
        {
            switch (dayNumber)
            {
                case 1:
                case 7:
                    Console.WriteLine("Weekend!");
                    break;

                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Weekday.");
                    break;

                default:
                    Console.WriteLine("Invalid day number.");
                    break;
            }
        }

        // --- Example 2: Pattern matching ---
        Console.Write("\nEnter your score (0-100): ");
        if (int.TryParse(Console.ReadLine(), out int score))
        {
            switch (score)
            {
                case int s when s >= 90:
                    Console.WriteLine("Grade: A");
                    break;
                case int s when s >= 80:
                    Console.WriteLine("Grade: B");
                    break;
                case int s when s >= 70:
                    Console.WriteLine("Grade: C");
                    break;
                case int s when s >= 60:
                    Console.WriteLine("Grade: D");
                    break;
                default:
                    Console.WriteLine("Grade: F");
                    break;
            }
        }

        // --- Example 3: Switch expression ---
        Console.Write("\nEnter a fruit name: ");
        string fruit = Console.ReadLine()?.ToLower();

        string category = fruit switch
        {
            "apple" or "banana" or "orange" => "Fruit",
            "carrot" or "potato" or "onion" => "Vegetable",
            null or "" => "No input provided",
            _ => "Unknown food category"
        };

        Console.WriteLine($"Category: {category}");

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}

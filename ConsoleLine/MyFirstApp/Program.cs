using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Switch & Case Example ===");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1 - Say Hello");
        Console.WriteLine("2 - Show Date");
        Console.WriteLine("3 - Show Time");
        Console.WriteLine("4 - Exit");

        Console.Write("Enter your choice (1-4): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Hello there!");
                break;

            case "2":
                Console.WriteLine($"Today's date is {DateTime.Now.ToShortDateString()}");
                break;

            case "3":
                Console.WriteLine($"Current time is {DateTime.Now.ToShortTimeString()}");
                break;

            case "4":
                Console.WriteLine("Exiting program...");
                break;

            default:
                Console.WriteLine("Invalid choice. Please enter 1-4.");
                break;
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}

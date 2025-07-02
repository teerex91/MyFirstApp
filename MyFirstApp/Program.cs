using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Advanced Console";
            PrintWelcome();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{DateTime.Now:HH:mm:ss} > ");
                Console.ResetColor();

                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                switch (input.Trim().ToLower())
                {
                    case "exit":
                        PrintInfo("Exiting application. Goodbye!");
                        return;
                    case "help":
                        PrintHelp();
                        break;
                    case "clear":
                        Console.Clear();
                        PrintWelcome();
                        break;
                    default:
                        PrintError($"Unknown command: {input}");
                        break;
                }
            }
        }

        static void PrintWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=== Welcome to the Advanced Console ===");
            Console.WriteLine("Type 'help' for a list of commands.");
            Console.ResetColor();
        }

        static void PrintHelp()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Available commands:");
            Console.WriteLine("  help  - Show this help message");
            Console.WriteLine("  clear - Clear the console");
            Console.WriteLine("  exit  - Exit the application");
            Console.ResetColor();
        }

        static void PrintInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
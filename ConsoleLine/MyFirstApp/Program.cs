using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Loop Examples in C# ===");

        // 1. for loop - run a fixed number of times
        Console.WriteLine("\nFor Loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }

        // 2. while loop - run while condition is true
        Console.WriteLine("\nWhile Loop:");
        int count = 1;
        while (count <= 5)
        {
            Console.WriteLine($"Count is {count}");
            count++;
        }

        // 3. do...while loop - runs at least once
        Console.WriteLine("\nDo...While Loop:");
        int number = 1;
        do
        {
            Console.WriteLine($"Number is {number}");
            number++;
        } while (number <= 5);

        // 4. foreach loop - loop through items in a collection
        Console.WriteLine("\nForeach Loop:");
        string[] fruits = { "Apple", "Banana", "Cherry" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine($"Fruit: {fruit}");
        }

        Console.WriteLine("\nAll loops finished!");
    }
} 

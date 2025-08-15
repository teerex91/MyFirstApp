using System;

class Program
{
    static void Main()
    {
        Calculate();
        Console.Read();
    }

    public static int Calculate()
    {
        int a, b;

        Console.WriteLine("Enter first number to add:");
        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        Console.WriteLine("Enter second number to add:");
        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        int sum = 0;

        // Only add if both numbers are positive
        if (a > 0 && b > 0)
        {
            sum = a + b;
            Console.WriteLine($"The sum of {a} and {b} is {sum}");
        }
        else
        {
            Console.WriteLine("Both numbers must be positive to add.");
        }

        return sum;
    }
}

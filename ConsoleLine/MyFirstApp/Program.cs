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
        Console.WriteLine("Enter first number to add:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number to add:");
        int b = Convert.ToInt32(Console.ReadLine());

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

using System;

class Program
{
    static void Main()
    {
        Calculate();
        //Console.WriteLine(Calculate());
        Console.Read();
    }

    public static int Calculate()
    {
        Console.WriteLine("Enter first numbers to add:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second numbers to add:");
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine($"The sum of {a} and {b} is {sum}");
        return sum;

    }


}

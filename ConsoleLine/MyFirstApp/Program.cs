using MyFirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", "Corolla");

        Console.WriteLine($"Brand: {car.Brand}");

        Console.WriteLine($"Model: {car.Model}");

        Console.WriteLine($"Wheels: {Car.Wheels}");

        Console.WriteLine($"Created On: {car.CreatedOn}");

        car.Drive();

        Console.WriteLine("First part: " + car[1]); // indexer

        Car car1 = new Car("ISUZU", "D'Max");

        Console.WriteLine($"Brand: {car1.Brand}");
        Console.WriteLine($"Model: {car1.Model}");
        Console.WriteLine($"Wheels: {Car.Wheels}");
        Console.WriteLine($"Created On: {car1.CreatedOn}");

        car.Drive();

        Console.WriteLine("First part: " + car[0]); // indexer
    }
}

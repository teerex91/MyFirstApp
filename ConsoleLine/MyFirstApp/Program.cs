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
        // Create an object (instance of Car)
        Car myCar = new Car();

        // Set values
        myCar.Brand = "Tesla";
        myCar.Speed = 120;

        // Call method
        myCar.Drive();
    }
} 

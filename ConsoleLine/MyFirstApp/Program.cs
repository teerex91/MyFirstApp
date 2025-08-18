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
        Car car1 = new Car("BMW", 150);
        car1.Drive();

        Car car2 = new Car("Audi", 180);
        car2.Drive();
    }
} 

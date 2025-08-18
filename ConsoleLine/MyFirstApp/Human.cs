using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Car
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        // Constructor
        public Car(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void Drive()
        {
            Console.WriteLine($"{Brand} is driving at {Speed} km/h.");
        }
    }

}

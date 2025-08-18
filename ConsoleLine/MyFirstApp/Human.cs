using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Car
    {
        // Properties (data)
        public string Brand { get; set; }
        public int Speed { get; set; }

        // Method (behavior)
        public void Drive()
        {
            Console.WriteLine($"{Brand} is driving at {Speed} km/h.");
        }
    }
}

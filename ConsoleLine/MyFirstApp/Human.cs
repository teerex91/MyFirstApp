using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Human
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor (runs when you create a Human object)
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method (behavior)
        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
        }
    }

}

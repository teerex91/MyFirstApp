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
        private string Name { get; set; }
        private int Age { get; set; }
        private string eyecolor { get; set; }

        // Default constructor
        public Human()
        {
            Name = "Unknown";
            Age = 0;
            eyecolor = "Unknown";
        }

        // Parameterized constructor

        public Human(string name, string eyecolor)
        {
            Name = name;
            this.eyecolor = eyecolor;
        }

        public Human(string name, int age, string eyecolor)
        {
            Name = name;
            Age = age;
            this.eyecolor = eyecolor;
        }

        // Method (behavior)
        public void Introduce()
        {
            //Console.WriteLine($"Hi, my name is {Name}, I am {Age} years old and i have color of my eyes is {eyecolor}");
            if(Age != 0)
                Console.WriteLine("Hi, my name is {0}, I am {1} year old and my eyes is {2}", Name, Age, eyecolor);
            else
                Console.WriteLine("Hello, my name is {0}, and my eyes is {1}", Name, eyecolor);
        }
    }

}

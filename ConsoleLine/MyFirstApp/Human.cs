using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    // this class is a bludprint for a datatype
    internal class Human
    {
        // menber and variable 
        public string firstName = "teerex";

        // member 
        public void IntroduceMySelf()
        {
            // this is a method
            Console.WriteLine("Hello, my name is " + firstName);
        }
    }
}

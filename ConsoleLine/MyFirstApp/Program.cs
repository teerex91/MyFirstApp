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
       //Create an object of the class 
       //an instand of human 
       Human denis = new Human();
       // acess public varible from outside, and even change it 
       denis.firstName = "Denis";
       // call the method of the class
        denis.IntroduceMySelf();

        // Create another object of the class
        Human teerex = new Human();
        // Access the public variable from outside, and even change it
        teerex.firstName = "Teerex dino";
        // Call the method of the class
        teerex.IntroduceMySelf();

        Console.ReadKey();
    }
} 

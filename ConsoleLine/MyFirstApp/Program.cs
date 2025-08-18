using MyFirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Human person1 = new Human();
        person1.Introduce();

        Human person2 = new Human("Bob", 30);
        person2.Introduce();
    }
} 

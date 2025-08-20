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

        Human person2 = new Human("Bob", 30, "black");
        person2.Introduce();

        Human person3 = new Human("TeeRex", 24, "Blue");
        person3.Introduce();

        Human person4 = new Human("Thawary", 07, "Red");
        person4.Introduce();

        Human person5 = new Human("Thawary", 01, "Brown");
        person5.Introduce();
    }
} 

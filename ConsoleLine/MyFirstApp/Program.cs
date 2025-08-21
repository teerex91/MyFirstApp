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
        Box box = new Box();
        box.Length = 10;
        box.Width = 5;
        box.Height = 2;
        box.Displayinfo();
    }
} 

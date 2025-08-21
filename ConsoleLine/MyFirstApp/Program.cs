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
        //box.Length = 10;
        box.SetLength(-2); // Fixed: Changed 'setlength' to 'setLength' for proper naming convention
        box.Width = 5;
        box.Height = 2;
        Console.WriteLine("Box length is " + box.GetLength());
        Console.WriteLine("Box Volume is " + box.GetVolume());
        box.Displayinfo();
    }
} 

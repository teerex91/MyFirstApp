using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Box
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int volume { get; set; }

        public void Displayinfo() // Fixed: Added 'void' as the return type  
        {
            Console.WriteLine("Box Information:");
            Console.WriteLine("Length: {0}, Width: {1}, Height: {2}, Volume: {3}", Length, Width, Height, volume = Length * Height * Width);
        }
    }
}

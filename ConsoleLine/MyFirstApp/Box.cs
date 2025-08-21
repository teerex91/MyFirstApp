using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Box
    {
        //Member Variables
        private int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Volume { get; set; }

        public void SetLength(int Length) // Fixed: Changed 'setlength' to 'setLength' for proper naming convention
        {
            if (Length < 0)
            {
                throw new Exception("Length cannot be negative"); // Fixed: Added exception handling for negative length
            }
            else
            {
                this.Length = Length; // Fixed: Used 'this.Length' to refer to the class member variable
            }
        }

        public int GetLength() // Fixed: Changed 'getlength' to 'getLength' for proper naming convention
        {
            return Length;
        }

        public int GetVolume()
        {
            return Length * Width * Height; // Fixed: Added 'return' statement to return the calculated volume
        }

        public void Displayinfo() // Fixed: Added 'void' as the return type  
        {
            Console.WriteLine("==Box Information:==");
            Console.WriteLine("Length: {0}, Width: {1}, Height: {2}, Volume: {3}", Length, Width, Height, Volume = Length * Height * Width);
        }
    }
}

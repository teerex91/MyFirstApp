using System;

namespace MyFirstApp
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        static void Main()
        {
            WriteMessage();
            WriteSomwthing("I Am Argument and call from method !");
            Console.Read();
        }
        // Access Modifier 
        public static void WriteMessage()
        {
            Console.WriteLine("This is a message from the WriteMessage method.");
        }
        //
        public static void WriteSomwthing(string  mytext)
        {
            Console.WriteLine(mytext);
        }
    }
}
using System;

namespace MyFirstApp
{
    public class Car
    {
        // 1. Field (private data)
        private string brand;

        // 2. Property (public way to access brand)
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        // 3. Auto-implemented property
        public string Model { get; set; }

        // 4. Constant (cannot change)
        public const int Wheels = 4;

        // 5. Readonly field (set only in constructor)
        public readonly DateTime CreatedOn;

        // 6. Constructor
        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
            CreatedOn = DateTime.Now; // set readonly here
        }

        // 7. Method (behavior)
        public void Drive()
        {
            Console.WriteLine($"{Brand} {Model} is driving...");
        }

        // 8. Indexer (treat car like an array of parts)
        private string[] parts = { "Engine", "Wheels", "Doors" };
        public string this[int index]
        {
            get { return parts[index]; }
        }
    }
}

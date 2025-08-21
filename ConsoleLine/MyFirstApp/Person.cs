using System;

namespace MyFirstApp
{
    // Base class
    public class Person
    {
        // Auto property
        public string Name { get; set; }

        // Property with validation
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    age = 0;  // prevent negative ages
                else
                    age = value;
            }
        }

        // Read-only property (calculated)
        public string Info
        {
            get { return $"{Name} is {Age} years old."; }
        }
    }

    // Derived class (inherits Person)
    public class Student : Person
    {
        public string School { get; set; }
        public double GPA { get; set; }

        // Extended read-only property
        public string StudentInfo
        {
            get { return $"{Name}, Age {Age}, studies at {School} with GPA {GPA}"; }
        }
    }
}

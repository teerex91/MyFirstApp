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
        // Create Person
        Person person = new Person();
        person.Name = "Alice";
        person.Age = -5;   // validation will set it to 0

        Console.WriteLine(person.Info);

        // Create Student
        Student student = new Student();
        student.Name = "Bob";
        student.Age = 20;
        student.School = "Tech University";
        student.GPA = 3.8;

        Console.WriteLine(student.StudentInfo);

        Console.ReadLine(); // keep console open
    }
} 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Employee
    {
        // key concept in OOP (encapsulation or "data hiding") indicate this data should not be public, access should be mediated through a property

        //private int age; // common in C# for the private variable to be lowercase and the public to begin with Uppercase
        //public int Age
        //{
        //    get { return age; } // getter
        //    set { age = value; } // setter
        //}

        public int Age { get; set; } // implies above including backing variable "age"
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee(); // creates an instance of Employee
            Employee.Age = 45; // sets age
            Console.WriteLine("Employee age is {0}", Employee.Age); //display age
        }
    }
}

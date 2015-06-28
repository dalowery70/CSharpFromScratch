using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string PhoneNumber { get; set; }

        // method of the class example
        public void Bonus(double bonusPercent)
        {
            Salary += Salary * bonusPercent;
        }

        // constructor - to create an instance of a class
        public Employee(int age, string name, double salary, DateTime startDate, string phoneNumber)
        {
            Age = age;
            Name = name;
            Salary = salary;
            StartDate = startDate;
            PhoneNumber = phoneNumber;
        }

        // default constructor - one that take no arguments, if no other constuctors have been created you will receive this by default
        public Employee() // this is for empty initialization
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Method 2 using initialization
            Employee Employee = new Employee()
            {
                Age = 45,
                Name = "Dave",
                Salary = 50000.00,
                StartDate = new DateTime(2012, 7, 10),
                PhoneNumber = "408-555-1234"
            };
            Console.WriteLine("{0}'s age is {1}, started on {2} and makes {3}", Employee.Name, Employee.Age, Employee.StartDate, Employee.Salary); // before bonus
            Employee.Bonus(0.05);
            Console.WriteLine("{0}'s age is {1}, started on {2} and makes {3} with bonus", Employee.Name, Employee.Age, Employee.StartDate, Employee.Salary); // after bonus

            // Method 3 using contructor
            Employee Employee2 = new Employee(25, "Mary", 60000.00, new DateTime(2010, 2, 28), "408-321-5555");
            Console.WriteLine("{0}'s age is {1}, started on {2} and makes {3}", Employee2.Name, Employee2.Age, Employee2.StartDate, Employee2.Salary);
        }
    }
}

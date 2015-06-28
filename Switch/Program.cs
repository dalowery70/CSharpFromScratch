using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pick a number between 1 and 5: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 5:
                    Console.WriteLine("Correct");
                    break;
                case 4:
                case 3:
                case 2:
                case 1:
                    Console.WriteLine("Nope!");
                    break;
                default:
                    Console.WriteLine("Not a legal entry. Please try again.");
                    break;
            }
        }
    }
}

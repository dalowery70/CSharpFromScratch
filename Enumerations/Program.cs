using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    class Program
    {
        enum Color
        {
            Red, Orange, Green, Blue
        }

        static void Main(string[] args)
        {
            Color color = Color.Green;

            switch(color)
            {
                case Color.Red:
                    Console.WriteLine("You chose Red");
                    break;
                case Color.Orange:
                    Console.WriteLine("You chose Orange");
                    break;
                case Color.Green:
                    Console.WriteLine("You chose Green");
                    break;
                case Color.Blue:
                    Console.WriteLine("You chose Blue");
                    break;
                default:
                    Console.WriteLine("You didnt choose a color");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var newWarehouse = new Warehouse("Warehouse1", 101);
            var myItem = newWarehouse.FindAndReturnItem(101);
            Console.WriteLine("My new item is {0}", myItem.Name);

            var myComputer = new Computer();
            myComputer.ID = 102;

            Item mySecondComputer = new Computer(); // only get properties from Item
            mySecondComputer.ID = 103;
            Computer mySecondComputer2 = mySecondComputer as Computer; // treat AS Computer, get all Computer properties
            mySecondComputer2.CPUType = "i7";
            string myCPUype = mySecondComputer2.CPUType;
            mySecondComputer2.Name = "Jupiter";
            mySecondComputer2.Purchase();

            Software mySoftware = new Software();
            mySoftware.Name = "Foo Software";
            mySoftware.ID = 101;
            mySoftware.ISBN = "1234";
            mySoftware.Purchase();
        }
    }
}

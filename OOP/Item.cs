using System;

namespace OOP
{
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual void Purchase()
        {
            Console.WriteLine("Purchasing {0}", Name);
        }
    }

    // Normally this would be one class per file - shown this way for simplicity

    class Software : Item // Inherits from Item (base-class means more general form). This means software already has an ID and Name
    {
        public string ISBN { get; set; }
        public override void Purchase()
        {
            base.Purchase();
            Console.WriteLine("My ID is {0} and my ISBN is {1}", ID, ISBN);
        }

    }

    class Hardware : Item
    {
        public string SerialNumber { get; set; }
    }

    class Computer : Hardware
    {
        public string CPUType { get; set; }
        public string Disks { get; set; }
        public override void Purchase()
        {
            base.Purchase();
            Console.WriteLine("myCPUType is {0}", CPUType);
        }
    }

    class Peripheral : Hardware
    {
        public string Description { get; set; }
    }
}
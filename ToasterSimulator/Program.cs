using System;

namespace ToasterSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var toaster = new Toaster(2);

            Console.WriteLine("Load Items");
            toaster.ToasterCompartments[0] = new ToasterCompartment();
            toaster.ToasterCompartments[1] = new ToasterCompartment();

            toaster.ToasterCompartments[0].TimerSeconds = 20;
            toaster.ToasterCompartments[0].TimerSeconds = 10;

            toaster.ToasterCompartments[0].Slot1 = new Bread();
            toaster.ToasterCompartments[0].Slot1 = new Waffle();
            toaster.ToasterCompartments[1].Slot1 = new Bread();
            toaster.ToasterCompartments[1].Slot2 = new Waffle();
            Console.WriteLine("Items Loaded");

            Console.WriteLine("Starting Toast");
            toaster.ToasterCompartments[0].Start();
            toaster.ToasterCompartments[1].Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToasterSimulator.ToasterItems;

namespace ToasterSimulator
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var toaster = new Toaster();

            //var toasterComa



            Console.WriteLine("Load Items");

            var items1 = new List<ToasterItem> {
                new Bread(),
                new Waffle(),
                new Bread(),
                new Waffle(),
                new Waffle()
            };

            var items2 = new List<ToasterItem> {
                new Waffle(),
                new Waffle(),
                new Waffle()
            };

            var items3 = new List<ToasterItem> {
                new Bread(),
                new Bread(),
            };


            toaster.LoadItemsinCompartment(items1, 20);
            toaster.LoadItemsinCompartment(items2, 60);
            toaster.LoadItemsinCompartment(items3, 35);

            Console.WriteLine("Items Loaded");

            Console.WriteLine("Starting Toast");

            await toaster.StartAll();

            toaster.ShowToast();

        }
    }
}

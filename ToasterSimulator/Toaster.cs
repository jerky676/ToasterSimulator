using System;
using System.Collections.Generic;
using System.Text;

namespace ToasterSimulator
{
    public class Toaster
    {
        public Toaster(int NumberOfComaprtments)
        {
            ToasterCompartments = new ToasterCompartment[NumberOfComaprtments];
        }

        public ToasterCompartment[] ToasterCompartments { get; private set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ToasterSimulator
{
    public class Toaster
    {
        public Toaster(int NumberOfCompartments)
        {
            ToasterCompartments = new ToasterCompartment[NumberOfCompartments];
        }

        public ToasterCompartment[] ToasterCompartments { get; private set; }
    }
}

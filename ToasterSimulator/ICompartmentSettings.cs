using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToasterSimulator.ToasterItems;

namespace ToasterSimulator
{
    public interface ICompartmentSettings
    {
        ToasterItem Slot1 { get; set; }
        ToasterItem Slot2 { get; set; }
        int TimerInSeconds { get;}
        Task Start();
        void Stop();
    }
}

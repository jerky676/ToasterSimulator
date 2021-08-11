using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToasterSimulator.ToasterItems;

namespace ToasterSimulator
{
    public class Toaster
    {
        public List<CompartmentSettings> ToasterCompartments;

        public Toaster()
        {
            ToasterCompartments = new List<CompartmentSettings>();
        }

        public async Task StartAll()
        {
           Task.WaitAll(ToasterCompartments.ToList().Select(x => x.Start()).ToArray());
        }

        public void LoadItemsinCompartment(List<ToasterItem> toasterItems, int timerInSeconds)
        {
            var compartmentSettings = new CompartmentSettings(timerInSeconds);
            foreach(var toasterItem in toasterItems)
            {
                if (!compartmentSettings.Full)
                {
                    compartmentSettings.Load(toasterItem);
                }
                else
                {
                    ToasterCompartments.Add(compartmentSettings);
                    compartmentSettings = new CompartmentSettings(timerInSeconds);
                }
            }
        }


        public void ShowToast()
        {
            foreach(var toasterCompartment in ToasterCompartments)
            {
                toasterCompartment.ShowToast();
            }
        }
    }   
}

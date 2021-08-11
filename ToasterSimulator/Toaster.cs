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
            int iteration = 0;
            foreach (var toasterItem in toasterItems)
            {
                iteration++;
                if (compartmentSettings.Full)
                {
                    ToasterCompartments.Add(compartmentSettings);
                    compartmentSettings = new CompartmentSettings(timerInSeconds);
                }

                compartmentSettings.Load(toasterItem);
                
                if (iteration == toasterItems.Count())
                {
                    ToasterCompartments.Add(compartmentSettings);
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

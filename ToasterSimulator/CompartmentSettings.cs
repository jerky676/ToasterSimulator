using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToasterSimulator.ToasterItems;

namespace ToasterSimulator
{
    public class CompartmentSettings
    {
        private readonly Empty empty;
        private const int MilliSecondInterval = 1000;
        private ToasterItem[] slots;
        private int timerInSeconds;
        private int timeLeftInSeconds;

        public CompartmentSettings(int toasterTimerInSeconds)
        {
            slots = new ToasterItem[2];
            empty = new Empty();
            timerInSeconds = toasterTimerInSeconds;
        }

        public async Task Start()
        {
            timeLeftInSeconds = timerInSeconds;
            while (timeLeftInSeconds != 0)
            {
                var task = Task.Delay(MilliSecondInterval);
                await task;
                timeLeftInSeconds--;

                UpdateStatus(timeElapsedInSeconds);
                Console.WriteLine($"timeLeft {TimeLeft.ToString()}");
                Console.WriteLine($"Elapsed {TimeElapsed.ToString()}");
            }
            Stopped();
        }

        public void Stopped()
        {
            Console.WriteLine("Done!");
        }

        public void Load(ToasterItem toasterItem)
        { 
            if (slots[0] == null)
            {
                slots[0] = toasterItem;
            }
            else if (slots[1] == null)
            {
                slots[1] = toasterItem;
            }
            else
            {
                Console.WriteLine("Both toaster slot full");
            }
        }

        public bool Full
        {
            get
            {
                return (slots[0] != null) && (slots[1] != null);
            }
        }

        private int timeElapsedInSeconds => timerInSeconds - timeLeftInSeconds;

        public TimeSpan TimeLeft => TimeSpan.FromSeconds(timeLeftInSeconds);
      
        public TimeSpan TimeElapsed => TimeSpan.FromSeconds(timeElapsedInSeconds);

        public ToasterItem Slot1
        {
            get
            {
                return slots[0] ?? empty;
            }
            set
            {
                slots[0] = value;
            }
        }
        public ToasterItem Slot2
        {
            get
            {
                return slots[1] ?? empty;
            }
            set
            {
                slots[1] = value;
            }
        }

        public void ShowToast()
        {
            Console.WriteLine(Slot1 == empty ? "Slot 1 is empty" : $"Slot 1 {Slot1.Name} is {Slot1.CurrentToastLevel}");
            Console.WriteLine(Slot2 == empty ? "Slot 2 is empty" : $"Slot 2 {Slot2.Name} is {Slot2.CurrentToastLevel}");
        }

        public void UpdateStatus(int secondsElapsed)
        {
            foreach (var slot in slots)
            {
                if (slot != null)
                {
                    slot.ChangeToasterState(secondsElapsed);
                }

            }
        }


    }
}

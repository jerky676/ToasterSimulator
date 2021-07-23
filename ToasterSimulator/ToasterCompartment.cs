﻿using System;
using System.Threading;

namespace ToasterSimulator
{
    public abstract class ToasterCompartment
    {
        public ToasterItem Slot1 { get; set; }
        public ToasterItem Slot2 { get; set; }

        public int TimerSeconds { get; set; }

        public int RollingTimerSeconds { get; set; }

        private Timer toastTimer;

        public void Start()
        {
            TimerCallback callback = new TimerCallback(UpdateStatus);
            toastTimer = new Timer(callback,null, 0, 1000);
            while (toastTimer != null)
            {
                //toasting
            }
        }
        public void Stop()
        {
            toastTimer = null;
            Console.WriteLine($"{Slot1.Name} is {Slot1.CurrentToastLevel}");
            Console.WriteLine($"{Slot2.Name} is {Slot2.CurrentToastLevel}");
        }

        private void UpdateStatus(Object stateInfo)
        {
            RollingTimerSeconds--;
            var elapsed = TimerSeconds - RollingTimerSeconds;
            if (Slot1 != null)
            {
                Slot1.ChangeToasterState(elapsed);
            }

            if (Slot2 != null)
            {
                Slot2.ChangeToasterState(elapsed);
            }

            if(elapsed == 0)
            {
                Stop();
            }
        }

       


    }
}
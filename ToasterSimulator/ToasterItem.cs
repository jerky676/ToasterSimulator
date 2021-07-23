using System;
using System.Collections.Generic;
using System.Text;

namespace ToasterSimulator
{
    public abstract class ToasterItem
    {
        public string Name { get; set; }

        public int ToastLevelIncrementInSeconds { get; set; }

        public ToastLevel CurrentToastLevel { get; private set; }

        public void ChangeToasterState(int timeElasped)
        {
            decimal toastLevelNumber = timeElasped / ToastLevelIncrementInSeconds;
            var toastLevel = Math.Round(toastLevelNumber, 0);
            if (toastLevel >= (int)ToastLevel.Burnt)
            {
                CurrentToastLevel = ToastLevel.Burnt;
            }

            CurrentToastLevel = (ToastLevel)toastLevel;
        }


    }
}

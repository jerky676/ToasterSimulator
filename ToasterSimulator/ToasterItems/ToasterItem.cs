using System;
using System.Collections.Generic;
using System.Text;

namespace ToasterSimulator.ToasterItems
{
    public abstract class ToasterItem
    {
        public string Name { get; set; }

        public int ToastLevelIncrementInSeconds { get; set; }

        public ToastLevel CurrentToastLevel { get; private set; }

        public void ChangeToasterState(int timeElasped)
        {
            var toastLevel = (int)Math.Round((decimal)(timeElasped / ToastLevelIncrementInSeconds),0);
            var onfireInt = (int)ToastLevel.OnFire;
            if (toastLevel > onfireInt)
            {
                CurrentToastLevel = ToastLevel.OnFire;
            }
            else
            {
                CurrentToastLevel = (ToastLevel)toastLevel;
            }
        }


    }
}

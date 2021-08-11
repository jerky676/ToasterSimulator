using System;
using System.Collections.Generic;
using System.Text;

namespace ToasterSimulator.ToasterItems
{
    public class Bread : ToasterItem
    {
        public Bread()
        {
            Name = "Bread";
            ToastLevelIncrementInSeconds = 7;
        }
    }
}

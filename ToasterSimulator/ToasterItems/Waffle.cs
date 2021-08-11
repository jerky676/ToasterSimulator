using System;
using System.Collections.Generic;
using System.Text;

namespace ToasterSimulator.ToasterItems
{
    public class Waffle: ToasterItem
    {
        public Waffle()
        {
            Name = "Waffle";
            ToastLevelIncrementInSeconds = 7;
        }
    }
}

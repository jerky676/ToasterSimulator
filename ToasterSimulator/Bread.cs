using System;
using System.Collections.Generic;
using System.Text;

namespace ToasterSimulator
{
    public class Bread : ToasterItem
    {
        public Bread()
        {
            Name = "Waffle";
            ToastLevelIncrementInSeconds = 7;
        }
    }
}

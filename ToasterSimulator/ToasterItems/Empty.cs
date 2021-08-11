using System;
using System.Collections.Generic;
using System.Text;

namespace ToasterSimulator.ToasterItems
{
    public class Empty : ToasterItem
    {
        public Empty()
        {
            Name = "Empty";
            ToastLevelIncrementInSeconds = -1;
        }
    }
}

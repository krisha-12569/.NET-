using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5
{
    internal abstract class Appliance
    {
        public abstract void TurnOn();
    }
    internal class Fan : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Fan is On");
        }
    }
    internal class Light : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Light is On");
        }

    }
}

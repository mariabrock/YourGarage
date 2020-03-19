using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    abstract class Watercraft : Vehicle
    {
        //2. Include a method for driving
        public override void Driving(string watercraft)
        {
            Console.WriteLine($"You are driving your {watercraft}.");

        }
    }
}

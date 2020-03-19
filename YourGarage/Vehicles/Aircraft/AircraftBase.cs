using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    abstract class AircraftBase : Vehicle
    {

        public override void Driving(string aircraft)
        {
            Console.WriteLine($"You are driving your {aircraft}.");

        }

        //2. Include methods for flying, and landing
        public abstract void Flying();

        public abstract void Landing();


    }
}

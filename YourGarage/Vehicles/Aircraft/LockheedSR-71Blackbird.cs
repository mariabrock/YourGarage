using System;
using System.Collections.Generic;
using System.Text;
using YourGarage;

namespace YourGarage.Vehicles.Aircraft
{
    class LockheedSR_71Blackbird : AircraftBase
    {
        public override void Flying()
        {
            Console.WriteLine($"Zoom Zoom.");

        }

        public override void Landing()
        {
            Console.WriteLine($"Flight, this is SR-71 coming in for landing.");

        }
    }
}

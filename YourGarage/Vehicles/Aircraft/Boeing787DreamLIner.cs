using System;
using System.Collections.Generic;
using System.Text;
using YourGarage;

namespace YourGarage.Vehicles.Aircraft
{
    class Boeing787DreamLIner : AircraftBase
    {
        public override void Flying()
        {
            Console.WriteLine($"Zoom Zoom.");
        }

        public override void Landing()
        {
            Console.WriteLine($"This your Capitan speaking.");
        }
    }
}

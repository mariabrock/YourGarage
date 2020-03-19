using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Cars
{
    class HondaCivic : Car
    {
        public override void Braking()
        {
            Console.WriteLine($"Slow doooooown.");
        }
    }
}

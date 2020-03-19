using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Cars
{
    class Corvette : Car
    {
        public override void Braking()
        {
            Console.WriteLine($"Slow doooooown.");
        }
    }
}

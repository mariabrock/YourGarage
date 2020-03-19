using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    abstract class Vehicle
    {
        //1. Include properties for fuel capacity, color, and passenger occupancy
        public bool FullTank => true;
        public VehicleColor Color { get; set; }
        public int Occupancy { get; set; }

        //2. Include methods for refueling, driving

        public abstract void Driving(string name);

        public void Refueling(Vehicle vehicleToFuel)
        {
            Console.WriteLine($"You need to refuel {vehicleToFuel}.");
        }
    }
}

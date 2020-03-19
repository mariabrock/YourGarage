using System;
using YourGarage.Vehicles.Aircraft;
using YourGarage.Vehicles.Cars;
using YourGarage.Vehicles.Watercrafts;

namespace YourGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var roadster = new Corvette();
            roadster.Driving("corvette");

            var imOnnaBoat = new SailBoat();
            imOnnaBoat.Driving("sailboat");

            var flyBoy = new LockheedSR_71Blackbird();
            flyBoy.Flying();

            Console.ReadKey();
        }
    }
}

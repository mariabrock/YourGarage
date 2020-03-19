using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage 
{
    abstract class Car : Vehicle
    {
        public override void Driving(string car)
        {
            Console.WriteLine($"You are driving your {car}.");
        }

        //2. Include method for braking
        public abstract void Braking();
    }
}

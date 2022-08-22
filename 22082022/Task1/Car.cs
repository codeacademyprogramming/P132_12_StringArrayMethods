using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Car:Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;

        public void AddFuel(double lt)
        {
            if (FuelCapacity >= CurrentFuel + lt)
            {
                CurrentFuel += lt;
            }
            else
            {
                Console.WriteLine("benzin artiqdir");
            }
        }
    }
}

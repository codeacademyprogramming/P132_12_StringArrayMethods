using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;

        public void Drive(double km)
        {
            double neededFuel = km * FuelFor1Km;
            if (CurrentFuel >= neededFuel)
            {
                Millage += km;
                CurrentFuel -= neededFuel;
            }
            else
            {
                Console.WriteLine("Kifayet qeder benzin yoxdur!!, Benzin doldur , kasib!");
            }
           
        }
    }
}

using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[]
            {
                new Notebook("Macbook pro 13","Apple",300),
                new Notebook("Predator","Acer",3500),
                new Notebook("XPS 15","DELL",4500),
                new Notebook("Macbook air","Apple",2500),
                new Notebook("E55","Acer",1500)
            };

            Console.Write("Min price: ");
            string minPriceStr = Console.ReadLine();
            double minPrice = Convert.ToDouble(minPriceStr);

            Console.Write("Max price: ");
            string maxPriceStr = Console.ReadLine();
            double maxPrice = Convert.ToDouble(maxPriceStr);

            for (int i = 0; i < notebooks.Length; i++)
            {
                if(notebooks[i].Price>=minPrice && notebooks[i].Price<=maxPrice)
                    Console.WriteLine(notebooks[i].Name+" - "+notebooks[i].BrandName+" "+notebooks[i].Price);
            }

            Car car1 = new Car
            {
                Brand = "Mercedes",
                Model = "E200",
                Millage = 0,
                CurrentFuel = 40,
                FuelFor1Km = 0.5
            };

            car1.Drive(20);
            car1.Drive(5);
            car1.Drive(3);


            Console.WriteLine(car1.Brand+" - "+car1.Model +" - "+car1.Millage+" - "+car1.CurrentFuel);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Notebook
    {
        public Notebook(string name,string brand,double price)
        {
            this.Name = name;
            this.BrandName = brand;
            this.Price = price;
        }
        public string Name;
        public string BrandName;
        public double Price;
    }
}

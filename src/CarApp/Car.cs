using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp
{
     public class Car
    {
        public string Model { get; set; }
        public int Price { get; set; }
        public int Power { get; set; }

        public Car (string model, int price,int power)
        {
            Model = model;
            Price = price;
            Power = power;
        }
    }
}

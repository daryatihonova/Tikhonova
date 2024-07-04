using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CarApp
{
     public class CarControl
    {
        private Car[] _cars;
        public CarControl(int size)
        {
            _cars = new Car[size];
        }

        public void AddCar(Car car)
        {
            for (int i = 0; i < _cars.Length; i++)
            {
                if (_cars[i] == null)
                {
                    _cars[i] = car;
                    return;
                }
            }
        }


        public void CarSort()
        {
            
            Array.Sort(_cars, (c1, c2) =>
            {
                if (c1.Power.CompareTo(c2.Power) == 0)
                {
                    return c1.Price.CompareTo(c2.Price);
                }
                else
                {
                    return c1.Power.CompareTo(c2.Power);
                }
            });
        }

        public void ExportToFile(string fileName)
        {
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                foreach (Car car in _cars)
                {
                    if (car.Model != null)
                    {
                        streamWriter.WriteLine($"Модель машины - {car.Model}, цена - {car.Price}, мощность двигателя - {car.Power}");
                    }
                }
            }
        }


    }
}

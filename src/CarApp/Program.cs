using System;
using System.IO;
using CarApp;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве: ");
            int carCount;
            while (!int.TryParse(Console.ReadLine(), out carCount) || carCount <= 0)
            {
                Console.Write("Некорректный ввод числа. Введите число:  ");
            }
            CarControl carControl = new CarControl(carCount);
            for (int i = 0; i < carCount; i++)
            {
                Console.WriteLine($"Введите данные для машины {i + 1}");
                Console.Write("Модель: ");
                string model = Console.ReadLine();
                while (string.IsNullOrEmpty(model))
                {
                    Console.Write("Некорректный ввод модели. Введите модель автомобиля:  ");
                    model = Console.ReadLine();
                }
                Console.Write("Цена: ");
                int price;
                while (!int.TryParse(Console.ReadLine(), out price) || price <= 0)
                {
                    Console.Write("Некорректный ввод цены. Введите цену автомобиля:  ");
                }
                Console.Write("Мощность: ");
                int power;
                while (!int.TryParse(Console.ReadLine(), out power) || power <= 0)
                {
                    Console.Write("Некорректный ввод мощности. Введите мощность автомобиля:  ");
                }
                Car car = new Car(model, price, power);
                carControl.AddCar(car);
                
            }
            carControl.CarSort();
            carControl.ExportToFile("car.txt");
        }
    }
}

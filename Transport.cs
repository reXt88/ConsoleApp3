using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Car
    {
        double fuelconsumption;
        double tanksize;
        string category;
        public Car(double consumption, double tanksize, string category)
        {
            fuelconsumption = consumption / 100;
            this.tanksize = tanksize;
            this.category = category;
        }
        public void MovingCar(int move)
        {
            double remainingfuel = tanksize;
            remainingfuel -= fuelconsumption * move;
            Console.Write("Остаток бензина: " + remainingfuel);
            double powerreserve = (remainingfuel / (fuelconsumption));
            Console.WriteLine($"    Запас хода: {powerreserve:0.00} км");
        }
        public void Show() => Console.WriteLine($"Категория прав: {category}");
    }
    class Plane
    {
        double fuelconsumption;
        double tanksize;
        string category = "Лицензия на управление самолетом";
        public Plane(double consumption, double tanksize, string category)
        {
            fuelconsumption = consumption / 100;
            this.tanksize = tanksize;
        }
        public void MovingPlane(int move)
        {
            double remainingfuel = tanksize;
            remainingfuel -= fuelconsumption * move;
            Console.Write("Остаток бензина: " + remainingfuel);
            double powerreserve = (remainingfuel / (fuelconsumption));
            Console.WriteLine($"    Запас хода: {powerreserve:0.00} км");
        }
        public void Show() => Console.WriteLine($"Категория прав: {category}");
    }
    class Boat
    {
        double fuelconsumption;
        double tanksize;
        string category = "Моторное судно";
        public Boat(double consumption, double tanksize)
        {
            fuelconsumption = consumption / 100;
            this.tanksize = tanksize;
        }
        public void MovingBoat(int move)
        {
            double remainingfuel = tanksize;
            remainingfuel -= fuelconsumption * move;
            Console.Write("Остаток бензина: " + remainingfuel);
            double powerreserve = (remainingfuel / (fuelconsumption));
            Console.WriteLine($"    Запас хода: {powerreserve:0.00} км");
        }
        public void Show() => Console.WriteLine($"Категория прав: {category}");
    }
}


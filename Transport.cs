using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Transport
    {
        double fuelconsumption;
        double tanksize;
        public Transport(double consumption, double tanksize)
        {
            fuelconsumption = consumption / 100;
            this.tanksize = tanksize;
        }
        public virtual void Moving(int move)
        {
            double remainingfuel = tanksize;
            remainingfuel -= fuelconsumption * move;
            Console.Write("Остаток топлива: " + remainingfuel);
            double powerreserve = (remainingfuel / (fuelconsumption));
            Console.WriteLine($"    Запас хода: {powerreserve:0.00} км");
        }
        public virtual void Show() { }
    }
    class Car : Transport
    {
        string category = "Автомобильные права";
        public Car(double consumption, double tanksize) : base (consumption, tanksize) { }

        public override void Show() => Console.WriteLine($"Категория прав: {category}");
    }
    class Plane : Transport
    {
        string category = "Лицензия на управление самолетом";
        public Plane(double consumption, double tanksize) : base (consumption, tanksize) { }


        public void Show() => Console.WriteLine($"Категория прав: {category}");
    }
    class Boat : Transport
    {
        string category = "Моторное судно";
        public Boat(double consumption, double tanksize) : base (consumption, tanksize) { }
        public void Show() => Console.WriteLine($"Категория прав: {category}");
    }
}


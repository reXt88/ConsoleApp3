using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car n = new Car(10, 65, "B");
            n.MovingCar(400);
            n.Show();
            Console.ReadKey();
        }
    }
}

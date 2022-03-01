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
            Car n = new Car(10, 65);
            n.Moving(400);
            n.Show();
            Boat v = new Boat(30, 500);
            v.Moving(500);
            v.Show();
            Plane p = new Plane(320, 30000);
            p.Moving(1400);
            p.Show();
            Console.ReadKey();
        }
    }
}

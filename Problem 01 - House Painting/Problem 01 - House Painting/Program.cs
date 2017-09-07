using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double front = 2 * (x * x) - (1.2 * 2);
            double sides = 2 * (x * y - 1.5 * 1.5);
            double pokr = 2 * (x * y) + 2 * (x * h / 2);

            double green = (front + sides) / 3.4;
            double red = pokr / 4.3;

            Console.WriteLine("{0:f2}", green);
            Console.WriteLine("{0:f2}", red);
        }
    }
}
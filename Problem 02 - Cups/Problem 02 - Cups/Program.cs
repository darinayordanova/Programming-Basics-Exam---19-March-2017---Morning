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
            int cups = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double hours = workers * days * 8;
            double cupsMade = Math.Floor(hours / 5);
            double diff = cups - cupsMade;

            if (diff >= 0)
            {
                double mon = diff * 4.2;
                Console.WriteLine("Losses: {0:f2}", mon);
            }
            else
            {
                diff = Math.Abs(diff);
                double mon = diff * 4.2;

                Console.WriteLine("{0:f2} extra money", mon);
            }

        }
    }
}
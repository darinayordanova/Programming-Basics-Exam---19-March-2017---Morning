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
            double mon = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string loc, place;
            double price;
            if (mon <= 1000)
            {
                place = "Camp";
                if (season == "Summer")
                {
                    loc = "Alaska";
                    price = mon * 0.65;
                }
                else
                {
                    loc = "Morocco";
                    price = mon * 0.45;
                }
            }
            else if (mon <= 3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    loc = "Alaska";
                    price = mon * 0.80;
                }
                else
                {
                    loc = "Morocco";
                    price = mon * 0.60;
                }
            }
            else
            {
                place = "Hotel";
                if (season == "Summer")
                {
                    loc = "Alaska";
                    price = mon * 0.90;
                }
                else
                {
                    loc = "Morocco";
                    price = mon * 0.90;
                }
            }
            Console.WriteLine(loc + " - " + place + " - {0:f2}", price);

        }
    }
}
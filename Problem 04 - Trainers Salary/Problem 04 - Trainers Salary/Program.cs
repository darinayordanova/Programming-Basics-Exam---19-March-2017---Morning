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
            int lec = int.Parse(Console.ReadLine());
            double mon = double.Parse(Console.ReadLine());

            double perlection = mon / lec;
            int jelevbr = 0, royalbr = 0, rolibr = 0, trofonbr = 0, sinobr = 0, otherbr = 0;

            for (int i = 0; i < lec; i++)
            {
                string lector = Console.ReadLine();
                if (lector == "Jelev")
                {
                    jelevbr++;
                }
                else if (lector == "RoYaL")
                {
                    royalbr++;
                }
                else if (lector == "Roli")
                {
                    rolibr++;
                }
                else if (lector == "Trofon")
                {
                    trofonbr++;
                }
                else if (lector == "Sino")
                {
                    sinobr++;
                }
                else
                {
                    otherbr++;
                }
            }
            
            double jelev = jelevbr * perlection;
            double royal = royalbr * perlection;
            double roli = rolibr * perlection;
            double trofon = trofonbr * perlection;
            double sino = sinobr * perlection;
            double other = otherbr * perlection;

            Console.WriteLine("Jelev salary: {0:f2} lv", jelev);
            Console.WriteLine("RoYaL salary: {0:f2} lv", royal);
            Console.WriteLine("Roli salary: {0:f2} lv", roli);
            Console.WriteLine("Trofon salary: {0:f2} lv", trofon);
            Console.WriteLine("Sino salary: {0:f2} lv", sino);
            Console.WriteLine("Others salary: {0:f2} lv", other);
        }
    }
}

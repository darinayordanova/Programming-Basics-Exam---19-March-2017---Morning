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
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int br = 0, a = 0, b = 0;

            for (int i = start; i >= end; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    br++;
                    if (i + j == number)
                    {
                        a = i;
                        b = j;
                        goto done;
                    }
                }
            }
            Console.WriteLine(br + " combinations - neither equals " + number);
            return;

            done:
            Console.WriteLine("Combination N:" + br + " (" + a + " + " + b + " = " + number + ")");


        }
    }
}
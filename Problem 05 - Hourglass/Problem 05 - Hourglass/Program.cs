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
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n * 2 + 1; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            Console.Write(".");
            Console.Write("*");

            for (int i = 0; i < n * 2 - 3; i++)
            {
                Console.Write(" ");
            }

            Console.Write("*");
            Console.WriteLine(".");

            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(".");
                }

                Console.Write("*");

                for (int k = 0; k < (n * 2 + 1) - 2 * (i + 2); k++)
                {
                    Console.Write("@");
                }

                Console.Write("*");

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(".");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(".");
            }

            Console.Write("*");

            for (int i = 0; i < n; i++)
            {
                Console.Write(".");
            }

            Console.WriteLine();

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    Console.Write(".");
                }

                Console.Write("*");

                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }

                Console.Write("@");

                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int j = 0; j < n - 1 - i; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

            Console.Write(".");
            Console.Write("*");

            for (int i = 0; i < n * 2 - 3; i++)
            {
                Console.Write("@");
            }

            Console.Write("*");
            Console.WriteLine(".");

            for (int i = 0; i < n * 2 + 1; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
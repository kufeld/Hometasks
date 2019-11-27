using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_11_If_Number_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для вычисления значения функции f(x) введите значение аргумента х");
            var x = double.Parse(Console.ReadLine());

            if (x > 2)
            {
                Console.WriteLine("f(x) = 2");
            }
            else if (x >= -2 & x <= 2)
            {
                Console.WriteLine("f(x) = " + x);
            }
            else
            {
                Console.WriteLine("f(x) = -2");
            }

            Console.ReadKey();
        }
    }
}


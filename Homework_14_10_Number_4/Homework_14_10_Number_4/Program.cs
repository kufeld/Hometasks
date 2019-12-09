using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14_10_Number_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = F(2,3) + F(5,7) + F(11,13);

            Console.WriteLine("x = {0:F3}", x);

        }
        static double F(double x, double y, double z)
        {
            return ((Math.Sin(x)+Math.Sin(y)) / x+y);
        }
    }
}

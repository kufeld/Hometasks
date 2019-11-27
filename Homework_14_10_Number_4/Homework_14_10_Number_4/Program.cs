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
            var x = F(2,3,5) + F(5,7,12) + F(11,13,24);

            Console.WriteLine("x = {0:F3}", x);

        }
        static double F(double x, double y, double z)
        {
            var sin1 = Math.Sin(x);
            var sin2 = Math.Sin(y);
            return ((sin1 + sin2) / z);
        }
    }
}

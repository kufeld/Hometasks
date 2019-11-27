using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14_10_Number_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = Input("m");
            var n = Input("n");
            var k = Input("k");
            Console.WriteLine("Только одно из чисел кратно 5 " + L(m, n, k));
            Console.ReadKey();
        }

        static bool L(double m, double n, double k)
        {
            return (m % 5 == 0 & n % 5 != 0 & k % 5 != 0) |
                (m % 5 != 0 & n % 5 == 0 & k % 5 != 0) |
                (m % 5 != 0 & n % 5 != 0 & k % 5 != 0);
        }
        static double Input(string name)
        {
            Console.WriteLine("Введите число " + name);
            return double.Parse(Console.ReadLine());
        }
    }
}

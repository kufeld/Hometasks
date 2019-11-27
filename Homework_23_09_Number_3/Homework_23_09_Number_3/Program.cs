using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_23_09_Number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double result, first, second;
            Console.WriteLine("Введите любое число х, для которого нужно вычислить значение функции f(x)");
            double x = double.Parse(Console.ReadLine());
            first = x * x + 10;
            second = Math.Sqrt(x * x + 1);
            result = first / second;
            Console.Write("Значение функции равно ");
            Console.WriteLine(result);
        }
    }
}

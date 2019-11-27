using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_23_09_Number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, b1, b2, c1, c2, d2;
            a1 = 15;
            a2 = a1 * Math.PI / 180;
            Console.Write("Угол (в градусах) равен = ");
            Console.WriteLine(a1);
            Console.Write("Синус угла равен = ");
            Console.WriteLine(Math.Round(Math.Sin(a2), 3));
            Console.Write("Косинус угла равен = ");
            Console.WriteLine(Math.Round(Math.Cos(a2), 3));
            b1 = 37;
            b2 = b1 * Math.PI / 180;
            Console.Write("Угол (в градусах) равен = ");
            Console.WriteLine(b1);
            Console.Write("Синус угла равен = ");
            Console.WriteLine(Math.Round(Math.Sin(b2), 3));
            Console.Write("Косинус угла равен = ");
            Console.WriteLine(Math.Round(Math.Cos(b2), 3));
            c1 = 113;
            c2 = c1 * Math.PI / 180;
            Console.Write("Угол (в градусах) равен = ");
            Console.WriteLine(c1);
            Console.Write("Синус угла равен = ");
            Console.WriteLine(Math.Round(Math.Sin(c2), 3));
            Console.Write("Косинус угла равен = ");
            Console.WriteLine(Math.Round(Math.Cos(c2), 3));
            Console.WriteLine("Введите значение угла, для которого нужно вычислить синус и косинус");
            double d1 = double.Parse(Console.ReadLine());
            d2 = d1 * Math.PI / 180;
            Console.Write("Угол (в градусах) равен = ");
            Console.WriteLine(d1);
            Console.Write("Синус угла равен = ");
            Console.WriteLine(Math.Round(Math.Sin(d2), 3));
            Console.Write("Косинус угла равен = ");
            Console.WriteLine(Math.Round(Math.Cos(d2), 3));
        }
    }
}

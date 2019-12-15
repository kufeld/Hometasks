using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вычисление_Величин_5вариант
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ax = InputCoordinate("A", "x");
            var Ay = InputCoordinate("A", "y");
            var Bx = InputCoordinate("B", "x");
            var By = InputCoordinate("B", "y");
            var Cx = InputCoordinate("C", "x");
            var Cy = InputCoordinate("C", "y");

            var AB = GetSideLenght(Ax, Ay, Bx, By);
            var BC = GetSideLenght(Bx, By, Cx, Cy);
            var AC = GetSideLenght(Ax, Ay, Cx, Cy);

            var perimeter = AB + BC + AC;
            Console.WriteLine("Периметр треугольника " + perimeter);
            var p = perimeter / 2;
            var square = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
            Console.WriteLine("Площадь треугольника " + square);

            Console.ReadKey();
        }

        static double InputCoordinate(string PointName, string CoordinateName)
        {
            Console.WriteLine("Введите координату " + CoordinateName + " точки " + PointName);
            return double.Parse(Console.ReadLine());
        }

        static double GetSideLenght(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
    }
}

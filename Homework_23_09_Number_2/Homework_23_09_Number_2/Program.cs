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
            PrintSinCos(15);
            PrintSinCos(37);
            PrintSinCos(113);

            Console.WriteLine("Введите значение угла, для которого нужно вычислить синус и косинус");
            double customAngle = double.Parse(Console.ReadLine());
            PrintSinCos(customAngle);

            Console.ReadKey();
        }

        private static void PrintSinCos(double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * Math.PI / 180;
            Console.Write("Угол (в градусах) равен = ");
            Console.WriteLine(angleInDegrees);
            Console.Write("Синус угла равен = ");
            Console.WriteLine(Math.Round(Math.Sin(angleInRadians), 3));
            Console.Write("Косинус угла равен = ");
            Console.WriteLine(Math.Round(Math.Cos(angleInRadians), 3));
        }

    }
}

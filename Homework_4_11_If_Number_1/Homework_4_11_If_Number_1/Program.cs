using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_11_If_Number_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату Х точки");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату У точки");
            var y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка принадлежит первой четверти");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка принадлежит второй четверти");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка принадлежит третьей четверти");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка принадлежит четвёртой четверти");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Точка лежит на оси абсцисс");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Точка лежит на оси ординат");
            }
            else
            {
                Console.WriteLine("Точка совпадает с началом координат");
            }
            Console.ReadKey();
        }
    }
}

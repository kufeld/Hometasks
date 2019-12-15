using System;

namespace ЛогическиеОперации_Номер_2
{
    class Program
    {
        static void Main(string[] args)

        {
            var x = Input("x");
            var y = Input("y");

            Console.WriteLine("Точка принадлежит графику " + CheckGraphic(x, y));

            Console.ReadKey();
        }

        static bool CheckGraphic(double x, double y)

        {
            return y > -2 && y < 1.5;
        }
        static double Input(string name)

        {
            Console.WriteLine("Введите координаты точки x, y. " + name + " = ");
            return double.Parse(Console.ReadLine());
        }

    }
}

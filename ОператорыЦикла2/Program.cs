using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОператорыЦикла2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество административных единиц в стране");
            var n = int.Parse(Console.ReadLine());
            double population = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите количество жителей " + (i + 1) + "-й админ. ед. в тысячах человек");
                var amount = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите плотность населения " + (i + 1) + "-й админ. ед. в тыс.чел./км^2");
                var density = double.Parse(Console.ReadLine());
                population = population + amount / density;
            }
            Console.WriteLine("Площадь страны составляет " + population + " км^2");
            Console.ReadKey();

        }
    }
}

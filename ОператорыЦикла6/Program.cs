using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОператорыЦикла6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите нижнюю границу диапазона");
            //var a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите вернхюю границу диапазона");
            //var b = int.Parse(Console.ReadLine());
            var a = Input("a");
            var b = Input("b");
            int sum = 0;
            int i = 1;

            while (a <= b)
            {
                if (i <= a)
                {

                    if (a % i == 0)
                    {
                        sum += i;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    a++;
                    i = 1;
                } 
            }
            Console.WriteLine(sum);

            Console.ReadKey();

        }

        static int Input(string name)
        {
            Console.WriteLine("Введите значения нижней (a) и верхней (b) границ диапазона: " + name + " =");
            return int.Parse(Console.ReadLine());
        }
    }
}

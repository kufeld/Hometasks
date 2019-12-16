using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_11_Cycle_Number_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текущий курс доллара");
            Console.Write("1$ = ");
            var dollar = double.Parse(Console.ReadLine());

 

            for (int i = 10; i <= 1000; i=i+10)
            {
                Console.WriteLine(i + "$ = " + i * dollar + " руб.");
            }

            Console.ReadKey();
        }
    }
}

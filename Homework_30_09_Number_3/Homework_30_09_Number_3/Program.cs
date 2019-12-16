using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_30_09_Number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Вашу электронную почту");

            var str = Console.ReadLine();
            var index = str.IndexOf('@');
            var mailBox = str.Substring(0, index);
            var mailService = str.Substring(index + 1);
            Console.WriteLine("Ваш почтовый ящик " + mailBox + " находится на сервисе " + mailService);

            Console.ReadKey();
        }
    }
}

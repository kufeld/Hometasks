using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УсловныеОператоры2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");

            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {

                if (char.IsUpper(str[i]))
                    Console.WriteLine("{0} - заглавная буква.", str[i]);

                else if (char.IsLower(str[i]))
                    Console.WriteLine("{0} - строчная буква.", str[i]);

                else if (char.IsDigit(str[i]))
                    Console.WriteLine("{0} - число.", str[i]);

                else if (char.IsPunctuation(str[i]))
                    Console.WriteLine("{0} - знак пунктуации.", str[i]);

                else if (char.IsWhiteSpace(str[i]))
                    Console.WriteLine("{0} - пробел.", str[i]);

                else
                    Console.WriteLine(" {0} - специальный символ.", str[i]);
            }

            Console.ReadKey();
        }
    }
}

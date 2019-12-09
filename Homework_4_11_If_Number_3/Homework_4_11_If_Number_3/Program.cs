using System;

namespace Homework_4_11_If_Number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str;
                Console.WriteLine("Input the number of the year (Press Enter to stop the program)");
                str = Console.ReadLine();
                if (str == string.Empty)
                    break;
                var year = int.Parse(str);
                if (!int.TryParse(str, out year))
                {
                    Console.WriteLine("Input error. ");
                    continue;
                }

                int numberOfYear;
                if (year >= 1984)
                    numberOfYear = (year - 1984) % 60;
                else
                    numberOfYear = (year - 1984) % 60 + 60;
                Console.WriteLine("{0} is the year of a {1} {2}.", year, GetColour(numberOfYear / 12), GetAnimal(numberOfYear % 12));
                Console.WriteLine();
            }

        }

        static string GetColour(int number)
        {
            switch (number)
            {
                case 0:
                    return "green";
                case 1:
                    return "red";
                case 2:
                    return "yellow";
                case 3:
                    return "white";
                default:
                    return "black";

            }
        }

        static string GetAnimal(int number)
        {
            switch (number)
            {
                case 0:
                    return "rat";
                case 1:
                    return "cow";
                case 2:
                    return "tiger";
                case 3:
                    return "hare";
                case 4:
                    return "dragon";
                case 5:
                    return "snake";
                case 6:
                    return "horse";
                case 7:
                    return "sheep";
                case 8:
                    return "monkey";
                case 9:
                    return "han";
                case 10:
                    return "dog";
                default:
                    return "pig";

            }
        }
    }
}
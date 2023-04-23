using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Индексы и диапазоны в массивах
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = { 3, 16, 32, 64, 51, 77, 88, 55, 101, 7, 29 };

            Index indexArray = new Index(3, true); // new Index(3, true) можно записать как ^3, т.е. синтаксический сахар

            WriteLine(someArray[indexArray]);
            WriteLine();
            WriteLine($"{indexArray.Value} и {indexArray.IsFromEnd}");
            ReadKey();
        }
    }
}
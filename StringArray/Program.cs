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

            string str = "Some words";

            WriteLine(str[2..4]);
            ReadKey();
        }
    }
}
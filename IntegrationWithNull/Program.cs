using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Оператор присванивания объеденения со значением NULL ??=
    // опретор объеденения ??
    // опертор присваивания ??=
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            str ??= string.Empty;

            string result = str ??= "default string";

            WriteLine($"Количество символов в строке {result.Length}");
        }
    }
}
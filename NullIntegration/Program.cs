using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Оператор null объединение
    class Program
    {

        static void Main(string[] args)
        {
            string str = "test";

            WriteLine(str ?? "нет данных");
        }


    }
}
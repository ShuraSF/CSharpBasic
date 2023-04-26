using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Функции и методы C#
    // Простейший калькулятор через методы и функции

    
    class Program
    {
        static int Sum(int value_1, int value_2)
        {
            int result = value_1 + value_2;

            return result;
        }
        static void Main(string[] args)
        {
            int value_1, value_2, c;

            value_1 = int.Parse(ReadLine());
            value_2 = int.Parse(ReadLine());

            c = Sum(value_1, value_2);

            WriteLine(c);

            WriteLine("============================");


        }
    }
}
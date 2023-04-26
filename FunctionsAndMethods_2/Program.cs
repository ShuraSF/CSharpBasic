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
            return value_1 + value_2;
        }
        static void PrintResult(int result)
        {
            WriteLine($"Результат сложения : {result}");
        }

        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(ReadLine());
            b = int.Parse(ReadLine());

            c = Sum(a, b);

            PrintResult(c);

            WriteLine("============================");


        }
    }
}
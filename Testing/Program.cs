using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Ссылочные локальные переменные

    // Возвращаемые ссылочные переменные
    public class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double b = 7;
            double res = a / b - ((a / b) % 0.01); // истинный результат минус остаток от деления
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
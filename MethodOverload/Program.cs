using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Перегрузка методов
    // Написание классов ближе уже к ооп


    class Program
    {
        /// <summary>
        /// ВОзвращение суммы двух целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            double result = Sum(2.4, 3.9);

            WriteLine(result);
        }
    }
}
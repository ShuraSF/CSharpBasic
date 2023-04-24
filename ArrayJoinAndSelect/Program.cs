using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Многомерные массивы

    // Двумерный прямоугольный массив
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = { 3, 16, 32, 64, 51, 77, 88, 55, 101, 7, 29 };

            int[] rangeArray = someArray[2..6];

            int[] newArray = new int[3];
            Array.Copy(someArray, 2, newArray, 0, 3);
            Console.WriteLine(string.Join(",", rangeArray.Select(x => x)));
        }
    }
}
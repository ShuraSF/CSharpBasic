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
            // синтаксис такой:
            // тип_данных [,] имя_массива;

            int[,] myArray =
            {
                { 2, 4, 6, 8, 10},
                { 3, 6, 9, 12, 15}, // запись сразу в виде таблицы
                { 4, 8, 12, 16, 20 }
            };

            WriteLine(myArray[0, 2]); //выводится число 6
            ReadKey();
        }

    }
}
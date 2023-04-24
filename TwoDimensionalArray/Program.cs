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

            int[,] myArray; //по сути пустой ярлык для которого мы должны выделить пямять, т.е. ниже

            myArray = new int[3, 5]; // выделили память и создали 3 строки и 5 столбцов

            // можно все это сделать одной строкой:
            // int[,] myArray = new int[3, 5];

            myArray[0, 2] = 54; // поместили в 1 строчку в 3 столбец число 54
            ReadKey();
        }

    }
}
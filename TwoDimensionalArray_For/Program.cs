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

            int height = myArray.GetLength(0); // показывает длину, т.е. покажет что у нас 3 строки
            int width = myArray.GetLength(1); // покажет кол-во, т.е. 5 столбцов

            // смысл этого цикла, это перебор столбцов и строк, т.е. сначала выбирается строка
            // а потом перебирается каждый столбец в этой строке и выводится в консоль
            // и дальше к следующей строке
            // и так до конца
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Write(myArray[y, x]);
                }
                WriteLine();
            }
            ReadKey();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JanuaryTraining
{
    internal class fiveElementsMassive
    {
        static void Main(string[] args)
        {

            // массивы

            //создаем массив
            int[] someArrays;

            //присваиваем массиву someArrays 5 элементов, т.е. 0, 1, 2, 3, 4
            someArrays = new int[5];

            //дали массиву 1 число 54
            someArrays[2] = 54;

            WriteLine(someArrays[2]);




        }
    }
}
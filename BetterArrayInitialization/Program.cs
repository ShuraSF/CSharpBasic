using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JanuaryTraining
{
    internal class BetterArrayInitialization
    {
        static void Main(string[] args)
        {

            // инициализация массивов начиная с определенного значения

            int[] betterInit = Enumerable.Range(10, 4).ToArray();

            // в консоль выводится массив 12, т.к. массивы 10, 11, 12, 13

            WriteLine(betterInit[2]);

        }
    }
}
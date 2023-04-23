using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JanuaryTraining
{
    internal class arrayInitialization
    {
        static void Main(string[] args)
        {

            // инициализация массивов

            string[] myArray = new string[3] { "qwerty", "box", "modding" };

            // выводится массив "box", т.к. массив под номером 1 - "box"

            WriteLine(myArray[1]);

        }
    }
}
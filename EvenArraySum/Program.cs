using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JanuaryTraining
{
    internal class MinimumValueInArray
    {
        static void Main(string[] args)
        {

            // нахождение суммы четных чисел

            int[] someArray = { 34, 3, 69, 100, 24, 662, 40, 122, 846, 159 };

            WriteLine(someArray.Where(i => i % 2 == 0).Sum());

            ReadLine();
        }
    }
}
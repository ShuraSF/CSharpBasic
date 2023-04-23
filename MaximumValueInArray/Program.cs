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

            // нахождение наибольшего числа в массиве

            int[] someArray = { 11, 3, 6, 10, 24, 66, 40, 12, 84, 59 };

            // int result = someArray.Max();

            WriteLine(someArray.Max());
        }
    }
}
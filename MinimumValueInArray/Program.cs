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

            // нахождение наименьшего числа в массиве

            int[] someArray = { 24, 11, 3, 55, 54, 14, 63, 89 };

            int minValue = someArray[0];

            for (int i = 0; i < someArray.Length; i++)
            {
                if (someArray[i] < minValue)
                {
                    minValue = someArray[i];
                }

            }
            WriteLine($"НАименьшее число в массиве = {minValue}");
        }
    }
}
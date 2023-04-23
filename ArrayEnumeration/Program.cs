using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JanuaryTraining
{
    internal class ArrayEnumeration
    {
        static void Main(string[] args)
        {

            int[] someArrays = { 3, 6, 90, 12 };

            for (int i = 0; i < someArrays.Length; i++)
            {
                WriteLine(someArrays[i]);
                // выводятся массивы [0] - 3; [1] - 6; [2] - 90; [3] - 12.
                // после цикл завершился.
            }

        }
    }
}
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
            int[] someArray = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < someArray.Length; i++)
            {
                WriteLine(someArray[i]);
            }
        }
    }
}
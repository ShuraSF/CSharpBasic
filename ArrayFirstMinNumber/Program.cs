using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JanuaryTraining
{
    internal class ArrayFirstMinNumber
    {
        static void Main(string[] args)
        {

            // нахождение первого наименьшего числа

            int[] someArray = { 34, 3, 69, 100, 24, 662, 40, 122, 846, 159 };

            int result = someArray.Where(i => i < 7).First();
            WriteLine(result);
            ReadLine();
        }
    }
}
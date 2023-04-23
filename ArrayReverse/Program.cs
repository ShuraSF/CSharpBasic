using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JanuaryTraining
{
    internal class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] someArray = { 505, 404, 677, 31, 8, 1024 };

            WriteLine("Вывод массивов:");

            // в цикле for "- 1" - нужен для того чтобы цикл начался с 5, а не с 6

            for (int i = someArray.Length - 1; i >= 0; i--)
            {
                WriteLine(someArray[i]);
            }
            ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Оператор присванивания объеденения со значением NULL ??=
    // опретор объеденения ??
    // опертор присваивания ??=
    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = new int[11];

            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();

            myArray ??= new int[0];

            WriteLine($"Кол-во элементов в массиве {myArray.Length}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    class program
    {
        
        static void Resize(ref int[] array, int newSize)
        {
            int[] newArray = new int[newSize];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;

        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6 };

            Resize(ref myArray, 10);
        }
    }
}
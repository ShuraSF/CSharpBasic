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
        
        static void Resize<T>(ref T[] array, int newSize)
        {
            T[] newArray = new T[newSize];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;

        }
        static void Main(string[] args)
        {
            string[] strArray = { "test", "hello", "world" };
            int[] myArray = { 1, 4, 6 };

            Resize(ref myArray, 10);
        }
    }
}
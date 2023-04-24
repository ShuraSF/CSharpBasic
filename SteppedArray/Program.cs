using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Ступенчатые массивы

    class Program
    {
        static void Main(string[] args)
        {

            int[][] steppedArray = new int[3][];
            int[,] myArray = new int[10, 5];

            int steppedArrayRank = steppedArray.Rank; // C# код считает что первый массив одномерный
            int myArrayRank = myArray.Rank;           // а второй двумерный

            int steppedArrayLength = steppedArray.Length; // то же самое в length
            int myArrayLength = myArray.Length;

        }

    }
}
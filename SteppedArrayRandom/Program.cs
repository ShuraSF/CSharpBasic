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

            int[][] steppedArray = new int[5][];
            steppedArray[0] = new int[5];
            steppedArray[1] = new int[2];
            steppedArray[2] = new int[10];
            steppedArray[3] = new int[8];
            steppedArray[4] = new int[7];

            Random random = new Random();

            for (int i = 0; i < steppedArray.Length; i++)
            {
                for (int j = 0; j < steppedArray[i].Length; j++)
                {
                    steppedArray[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < steppedArray.Length; i++)
            {
                for (int j = 0; j < steppedArray[i].Length; j++)
                {
                    Write(steppedArray[i][j] + "\t");
                }
                WriteLine();
            }
            /*
            steppedArray[0][3] = 55;
            WriteLine(steppedArray[0][3]);
            */



        }
    }
}
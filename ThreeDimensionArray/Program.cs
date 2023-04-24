using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Трехмерные массивы

    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int[,,] someArray = new int[3, 4, 6];
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    for (int k = 0; k < someArray.GetLength(2); k++)
                    {
                        someArray[i, j, k] = random.Next(100);
                    }
                }
            }

            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                WriteLine("Page N':" + (i + 1));
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    for (int k = 0; k < someArray.GetLength(2); k++)
                    {
                        Write(someArray[i, j, k] + "\t");
                    }
                    WriteLine();
                }
            }

            ReadLine();
        }
    }
}
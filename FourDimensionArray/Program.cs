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

            int[,,,] someArray = new int[3, 4, 2, 6];
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    for (int a = 0; a < someArray.GetLength(2); a++)
                    {
                        for (int k = 0; k < someArray.GetLength(3); k++)
                        {
                            someArray[i, j, a, k] = random.Next(100);
                        }
                    }
                }
            }

            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                WriteLine("Book N':" + (i + 1));
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    WriteLine("Page N:" + (j + 1));
                    for (int a = 0; a < someArray.GetLength(2); a++)
                    {
                        for (int k = 0; k < someArray.GetLength(3); k++)
                        {
                            Write(someArray[i, j, a, k] + "\t");
                        }
                        WriteLine();
                    }
                    WriteLine();
                }
                WriteLine();
            }

            ReadLine();
        }
    }
}
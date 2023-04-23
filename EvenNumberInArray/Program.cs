using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JanuaryTraining
{
    internal class EvenNumberInArray
    {
        static void Main(string[] args)
        {

            // нахождение суммы четных чисел в массиве

            int[] someArray = { 12, 55, 33, 11, 71, 83, 54, 28, 90, 3 };

            int evenResult = 0;

            for (int i = 0; i < someArray.Length; i++)
            {
                if (someArray[i] % 2 == 0)
                {
                    evenResult = evenResult + someArray[i];
                }

            }

            WriteLine(evenResult);
        }
    }
}
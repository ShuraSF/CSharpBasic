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
            // тоже самое но запись немного другая

            int[] someArray = { 303, 21, 49, 34, 55, 691, 33, 80 };

            int evenResult = 0;

            for (int i = 0; i < someArray.Length; i++)
            {
                if (someArray[i] % 2 == 0)
                {
                    evenResult += someArray[i];
                }

            }

            WriteLine($"Сумма четных числе равна = {evenResult}");
        }
    }
}
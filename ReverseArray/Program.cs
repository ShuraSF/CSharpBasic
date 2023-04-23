using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JanuaryTraining
{
    internal class BetterArrayInitialization
    {
        static void Main(string[] args)
        {
            // вывод массивов в обратном порядке


            /*
            int a = int.Parse(ReadLine());
            int[] reverseArray = new int[a];
            Write("Введите кол-во массивов:");

            for(int count = reverseArray.Length; count < reverseArray.Length; count++)
            {
                Write($"Введите значение для массива {count}");
                reverseArray[count] = int.Parse(ReadLine());
            }

            */

            int[] arrays = { 12, 31, 540, 88 };

            WriteLine("Вывод массивов:");

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                WriteLine(arrays[i]);
            }


            // for (int)

        }
    }
}
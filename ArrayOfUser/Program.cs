using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JanuaryTraining
{
    internal class userArray
    {
        static void Main(string[] args)
        {
            Write("Введите несколько массивов: ");

            int a = int.Parse(ReadLine());
            int[] userArray = new int[a];

            for (int b = 0; b < userArray.Length; b++)
            {
                Write($"Введите элемент массива под индексом {b}: ");
                userArray[b] = int.Parse(ReadLine());
            }

            WriteLine("Выходные массивы: ");
            for (int b = 0; b < userArray.Length; b++)
            {
                WriteLine(userArray[b]);
            }
        }
    }
}
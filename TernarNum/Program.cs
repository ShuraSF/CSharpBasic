using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JanuaryTraining
{
    internal class ternarNumbers
    {
        static void Main(string[] args)
        {

            // тернарный оператор
            // вводится любое число и если оно положительное то оно выводится в консоль
            // если оно отрицательное то выводится 0

            int inputNumber = int.Parse(ReadLine());
            int outputNumber = (inputNumber < 0) ? 0 : inputNumber;

            WriteLine(outputNumber);
            ReadLine();

        }
    }
}
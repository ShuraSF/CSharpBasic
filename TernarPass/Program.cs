using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JanuaryTraining
{
    internal class ternarPas
    {
        static void Main(string[] args)
        {

            // ввод пароля через тернарный оператор

            bool accessAllowed;

            string storedPas = "qwerty";
            string enteredPas = ReadLine();

            accessAllowed = enteredPas == storedPas ? true : false;
            WriteLine(accessAllowed);
            ReadLine();
        }
    }
}
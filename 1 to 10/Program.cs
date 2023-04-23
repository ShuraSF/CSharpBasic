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
            for (int i = 1; ; i++)
            {
                WriteLine(i);
                if (i == 5)
                {
                    break;
                }
            }
        }
    }
}
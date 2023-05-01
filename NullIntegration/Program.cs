using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Оператор null объединение
    class Program
    {

        static void Main(string[] args)
        {
            string str = null;

            string result;
            if (true == null)
            {
                result = "Нет данных";
            }
            else
            {
                result = str;
            }
            WriteLine(result);
        }


    }
}
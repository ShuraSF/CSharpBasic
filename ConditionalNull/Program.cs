using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{

    // Оператор условного null ?

    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();

            
            // для проверки на null мы просто добавили ?
            // поэтому в консоле не будет ошибки
            WriteLine($"Сумма элементов массива {myArray?.Sum() ?? 0}");
        }
    }
}
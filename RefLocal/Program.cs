using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Ссылочные локальные переменные

    // Возвращаемые ссылочные переменные
    public class Program
    {
        static ref int Foo(int[] numbers)
        {
            return ref numbers[0];
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 6, 1 };

            ref int b = ref arr[0];

            b = -5; // b будет 2
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    public class Program
    {
        static void Foo(ref int a)
        {
            a = -5;
        }
        static void Main(string[] args)
        {
            int a = 2;

            Foo(ref a);

            WriteLine(a); // с методов ref выводится -5
        }
    }
}
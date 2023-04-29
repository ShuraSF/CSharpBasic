using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Область видимости, или контекст переменной
    // Конфликты областей видимостей

    
    class MyClass
    {

    }
    class Program
    {
        static int b = 11;
        static void Foo()
        {
            int b = 9;

            WriteLine(b);
            ReadLine();
        }

       
        static void Main(string[] args)
        {
            Foo();
        }
        
    }
}
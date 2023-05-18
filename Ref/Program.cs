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
        static void Foo(ref int a) //при помощи ref можно возвращать немколько методов, но этим нельзя злоупотреблять
        {
            a = -5;
        }
        static void Doo(MyClass myClass)
        {
            myClass.a = -5;
        }
        static void Bar(int[] arr)
        {
            arr = null; //null разрывает связь ссылки с управляемой кучей
        }
        struct MyStruct
        {
            public int a;
            public double b;
            public float c;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6 };

            Bar(myArray);
            
            MyClass myClass = new MyClass();

            Doo(myClass);
            
            int a = 2;

            Foo(ref a);

            WriteLine(a); // с методов ref выводится -5
        }
    }
}
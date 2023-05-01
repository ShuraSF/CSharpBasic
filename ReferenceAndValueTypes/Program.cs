using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Ссылочные (reference types) и значимые (value types) типы
    // Стек (stack) и куча (heap)
    
    class Program
    {
        
        static void Main(string[] args)
        {
            // все структуры (struct) и енамы (enum) являются значимыми типами (value types), поэтому размещаются в стеке (stack)
            // а все классы (class) - ссылочные типы (reference types), поэтому размещаются в управляемой куче (heap)
           
            Random random = new Random(); //Random - класс, поэтому создавая Random выделяется место в управляемой куче (heap)
                                          // любой массив являющийся наследником класса, тоже является ссылочным типом, т.е. помещается в управляемой куче

            int a = 2; // данные int являются структурой и будут существовать в той области

            int[] b = new int[10]; // b просто является ссылкой на массив

            // проще говоря int a = 3; - хранится в стэке,
            // а int [] a = new int[3]; - a является ссылкой в стэке, которая отсылает на 3 массива находящихся в управляемой куче
            

        }


    }
}
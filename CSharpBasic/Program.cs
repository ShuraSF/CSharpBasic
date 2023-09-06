using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JanuaryTraining
{
    internal class Triangle1
    {
        static void Main(string[] args)
        {

            // задание на создание треугольника

            // от наименьшего к большему

            Write("Введите высоту треугольника:");
            int height = int.Parse(ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();

            // от наибольшего к меньшему

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();

            // от наименьшего к большему с пробелами

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();

            // от наибольшего к меньшему с пробелами

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Write(" ");
                }
                for (int j = height; j > i; j--)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();
        }
    }
}
// test 23.08.2023
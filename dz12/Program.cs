using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    class program
    {
        static void Weapon(ref int Gun)
        {
            int Gun = int.Parse(ReadLine());
            switch(Gun)
            {
                case 1: WriteLine("Ak-47");
                    break;
                case 2: WriteLine("Glock-18");
                    break;
                case 3: WriteLine("Coctail molotov");
                    break;
                case 4: WriteLine("Knife");
                    break;
                case 5: WriteLine("Awp");
                    break;
                default: WriteLine("Мусор");
                    break;
            }
            
        }
        static void Main(string[] args)
        {

            Weapon(Gun);
            WriteLine($"Вы получили {Gun}");
        }
    }
}
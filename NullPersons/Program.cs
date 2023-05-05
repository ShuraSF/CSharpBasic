using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    class Program
    {
        static Person GetPerson()
        {
            Person person = new Person();
            return person;
        }
        static void Main(string[] args)
        {
            Person person = GetPerson();

            if (person != null && person.Contacts != null)
            {
                if (person.Contacts != null)
                {
                    string phoneNumber = person.Contacts.PhoneNumber;

                    WriteLine(phoneNumber);
                }
            }
            WriteLine("Нет данных");
        }


    }
}
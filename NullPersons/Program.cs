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
        static Person GetPerson()
        {
            Person person = new Person() { Contacts = new Contacts() { PhoneNumber = "241251255" } };
            return person;
        }
        static void Main(string[] args)
        {
            Person person = GetPerson();

            string phoneNumber = person.Contacts.PhoneNumber;

            WriteLine(phoneNumber);
        }
    }
}
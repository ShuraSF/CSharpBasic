using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NullPersons
{
    public class PersonInfo
    {
        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }
        public Contacts Contacts { get; set; }
        public string GetFullName()
        {
            return $"Фамилия : {FirstName} Имя : {MiddleName} Отчество : {SecondName}";
        }
        public string GetPhoneNumber()
        {
            return $"Номер телефона : {Contacts?.PhoneNumber?? "нет данных"}";
        }
        
    }
}

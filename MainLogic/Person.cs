using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }

        // constructors
        public Person()
        {

        }
        public Person(string name,string surname,DateTime date)
        {
            Name = name;
            Surname = surname;
            Date = date;
        }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        override public string ToString()
        {
            return "{" + Name + "," + Surname + "," + Date.ToString() + "}";
        }
    }
}

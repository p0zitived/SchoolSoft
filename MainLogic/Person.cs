using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class Person
    {
        private string _name;
        private string _surname;
        private DateTime _date;

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public DateTime Date { get => _date; set => _date = value; }

        // constructors
        public Person()
        {

        }
        public Person(string name,string surname,DateTime date)
        {
            _name = name;
            _surname = surname;
            _date = date;
        }
        public Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        override public string ToString()
        {
            return "{" + Name + "," + Surname + "," + Date.ToString() + "}";
        }
    }
}

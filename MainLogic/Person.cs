using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }

        // constructors
        public Person()
        {

        }
        public Person(int id, string name, string surname, DateTime date)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Date = date;
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

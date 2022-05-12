using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    public class Teacher : Person
    {
        public Discipline Discipline { get; set; }
        public float Salary { get; set; }

        // constructors
        public Teacher(Discipline item)
        {
            Discipline = item;
        }
        public Teacher() { }
        public Teacher(string name,string surname,DateTime date) : base(name,surname,date) { }
        public Teacher(string name,string surname,DateTime date,Discipline item) : base(name, surname, date) { Discipline = item; }
        public Teacher(string name, string surname) : base(name, surname) { }
        public Teacher(int id, string name, string surname, DateTime date, Discipline item) : base(id,name, surname, date) { Discipline = item; }

        public override string ToString()
        {
            return base.ToString() + Discipline.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class Student : Person
    {
        public List<SchoolItemMarks> Marks { get; set; }

        // constructors
        public Student()
        {
            Marks = new List<SchoolItemMarks>();
        }
        public Student(string name,string surname) : base(name,surname) { Marks = new List<SchoolItemMarks>(); }
        public Student(string name,string surname,DateTime date,List<SchoolItemMarks> marks) : base(name,surname,date)
        {
            Marks = marks;
        }
        public Student(string name, string surname, DateTime date) : base(name, surname, date) { Marks = new List<SchoolItemMarks>(); }

        public override string ToString()
        {
            string s = "{" + Name + "," + Surname + "," + Date.ToString() + "} ";
            foreach (SchoolItemMarks sm in Marks)
            {
                s += sm.ToString() + " ";
            }
            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class Student : Person
    {
        public List<DisciplineMarks> Marks { get; set; }

        // constructors
        public Student()
        {
            Marks = new List<DisciplineMarks>();
        }
        public Student(int id, string name, string surname, DateTime date) : base(id, name, surname, date) { }
        public Student(string name,string surname) : base(name,surname) { Marks = new List<DisciplineMarks>(); }
        public Student(string name,string surname,DateTime date,List<DisciplineMarks> marks) : base(name,surname,date)
        {
            Marks = marks;
        }
        public Student(string name, string surname, DateTime date) : base(name, surname, date) { Marks = new List<DisciplineMarks>(); }

        public override string ToString()
        {
            string s = "{" + Name + "," + Surname + "," + Date.ToString() + "} ";
            foreach (DisciplineMarks sm in Marks)
            {
                s += sm.ToString() + " ";
            }
            return s;
        }
    }
}

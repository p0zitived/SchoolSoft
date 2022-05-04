using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class Student : Person
    {
        private List<SchoolItemMarks> _marks;
        
        public List<SchoolItemMarks> Marks { get => _marks; set => _marks = value; }

        // constructors
        public Student()
        {
            _marks = new List<SchoolItemMarks>();
        }
        public Student(string name,string surname) : base(name,surname) { _marks = new List<SchoolItemMarks>(); }
        public Student(string name,string surname,DateTime date,List<SchoolItemMarks> marks) : base(name,surname,date)
        {
            _marks = marks;
        }

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

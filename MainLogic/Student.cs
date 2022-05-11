using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    public class Student : Person
    {
        public List<DisciplineMarks> Marks { get; set; }
        public Group Group { get; set; }

        // constructors
        public Student()
        {
            Marks = new List<DisciplineMarks>();
        }
        public Student(int id, string name, string surname, DateTime date) : base(id, name, surname, date) { Marks = new List<DisciplineMarks>(); }
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
            s += " Absente=" + GetAbsences();
            return s;
        }
        public int GetAbsences()
        {
            int a = 0;
            foreach (DisciplineMarks dm in Marks)
            {
                a += dm.GetAbsences();
            }
            return a;
        }
        public float GetAverage()
        {
            float sum = 0;
            int count = 0;
            foreach (DisciplineMarks dm in Marks)
            {
                sum += dm.GetAverage();
                count++;
            }
            return (float)((float)sum / (float)count);
        }
    }
}

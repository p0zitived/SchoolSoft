using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class DisciplineMarks
    {
        public Discipline Discipline { get; set; }
        public List<int> Marks { get; set; }

        // constructors
        public DisciplineMarks(){ Marks = new List<int>(); }
        public DisciplineMarks(Discipline discipline, List<int> marks)
        {
            Discipline = discipline;
            Marks = marks;
        }

        public override string ToString()
        {
            string s = "";
            s += Discipline.ToString() + "{";
            foreach (int i in Marks)
            {
                s += i + ",";
            }
            s += "}";
            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    public class DisciplineMarks
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
        public int GetAbsences()
        {
            int a = 0;
            for (int i = 0;i<Marks.Count;i++)
            {
                if (Marks[i] == -1)
                {
                    a++;
                }
            }
            return a;
        }
        public float GetAverage() {
            int sum = 0;
            int count = 0;
            for (int i=0;i<Marks.Count;i++)
            {
                if (Marks[i] != -1)
                {
                    sum += Marks[i];
                    count++;
                }
            }
            if (count != 0)
                return (float) ((float) sum / (float)count);
            return 0;
        }
    }
}

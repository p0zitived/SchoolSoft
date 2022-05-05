using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class DisciplineMarks
    {
        public Discipline Item { get; set; }
        public List<int> Marks { get; set; }

        // constructors
        public DisciplineMarks(){}
        public DisciplineMarks(Discipline item, List<int> marks)
        {
            Item = item;
            Marks = marks;
        }

        public override string ToString()
        {
            string s = "";
            s += Item.ToString() + "{";
            foreach (int i in Marks)
            {
                s += i + ",";
            }
            s += "}";
            return s;
        }
    }
}

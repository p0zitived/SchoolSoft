using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class SchoolItemMarks
    {
        public SchoolItem Item { get; set; }
        public List<int> Marks { get; set; }

        // constructors
        public SchoolItemMarks(){}
        public SchoolItemMarks(SchoolItem item, List<int> marks)
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

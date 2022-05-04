using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class SchoolItemMarks
    {
        private SchoolItem _item;
        private List<int> _marks;

        public SchoolItem Item { get => _item; set => _item = value; }
        public List<int> Marks { get => _marks; set => _marks = value; }

        // constructors
        public SchoolItemMarks(){}
        public SchoolItemMarks(SchoolItem item, List<int> marks)
        {
            _item = item;
            _marks = marks;
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

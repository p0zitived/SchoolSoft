using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class SchoolItem
    {
        public string Name { get; set; }

        // constructors
        public SchoolItem(string name)
        {
            Name = name;
        }
        public SchoolItem() { }

        public override string ToString()
        {
            return string.Format("SchoolItem{0}", Name);
        }
    }
}

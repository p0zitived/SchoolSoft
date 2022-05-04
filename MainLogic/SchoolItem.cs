using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class SchoolItem
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        // constructors
        public SchoolItem(string name)
        {
            _name = name;
        }
        public SchoolItem() { }

        public override string ToString()
        {
            return string.Format("SchoolItem{0}", Name);
        }
    }
}

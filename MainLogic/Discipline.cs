using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class Discipline
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // constructors
        public Discipline(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public Discipline() { }

        public override string ToString()
        {
            return string.Format("SchoolItem{0}", Name);
        }
    }
}

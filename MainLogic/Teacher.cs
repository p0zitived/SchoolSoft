using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class Teacher : Person
    {
        public SchoolItem Item { get; set; }

        // constructors
        public Teacher(SchoolItem item)
        {
            Item = item;
        }
        public Teacher() { }
        public Teacher(string name,string surname,DateTime date) : base(name,surname,date) { }
        public Teacher(string name,string surname,DateTime date,SchoolItem item) : base(name, surname, date) { Item = item; }
        public Teacher(string name, string surname) : base(name, surname) { }

        public override string ToString()
        {
            return base.ToString() + Item.ToString();
        }
    }
}

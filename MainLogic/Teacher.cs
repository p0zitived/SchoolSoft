﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    public class Teacher : Person
    {
        public Discipline Item { get; set; }
        public float Salary { get; set; }

        // constructors
        public Teacher(Discipline item)
        {
            Item = item;
        }
        public Teacher() { }
        public Teacher(string name,string surname,DateTime date) : base(name,surname,date) { }
        public Teacher(string name,string surname,DateTime date,Discipline item) : base(name, surname, date) { Item = item; }
        public Teacher(string name, string surname) : base(name, surname) { }
        public Teacher(int id, string name, string surname, DateTime date, Discipline item) : base(id,name, surname, date) { Item = item; }

        public override string ToString()
        {
            return base.ToString() + Item.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSoft.MainLogic
{
    class Group
    {
        public char GroupID { get; set; }
        public int GroupYear { get; set; }
        public List<Student> Students { get; set; }
        public Teacher ClassMaster { get; set; }

        // constructors
        public Group() { Students = new List<Student>(); }
        public Group(int _groupYear,char _groupID) { GroupYear = _groupYear; GroupID = _groupID; Students = new List<Student>(); }
        public Group(int _groupYear, char _groupID,List<Student> _students,Teacher _classMaster) {
            GroupYear = _groupYear;
            GroupID = _groupID;
            Students = _students;
            ClassMaster = _classMaster;
            Students = new List<Student>();
        }

        public override string ToString()
        {
            string s = GroupYear+ "" + GroupID + " " + ClassMaster.Surname + " " + ClassMaster.Name +  " Elevi{";
            foreach (Student st in Students)
            {
                s += st.Surname + " " + st.Name;
            }
            s += "}";
            return s;
        }
    }
}

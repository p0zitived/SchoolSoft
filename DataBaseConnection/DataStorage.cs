using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSoft.MainLogic;

namespace SchoolSoft.DataBaseConnection
{
    class DataStorage
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Discipline> Disciplines { get; set; }
        public List<Group> Groups { get; set; }

        public DataStorage()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            Disciplines = new List<Discipline>();
            Groups = new List<Group>();
        }

        public Discipline GetDisciplineByID(int id)
        {
            for (int i=0;i<Disciplines.Count;i++)
            {
                if (Disciplines[i].ID == id)
                {
                    return Disciplines[i];
                }
            }

            return null;
        }
    }
}

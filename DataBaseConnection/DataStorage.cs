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
        public Teacher GetTeacherById(int id)
        {
            for (int i = 0; i < Teachers.Count; i++)
            {
                if (Teachers[i].ID == id)
                {
                    return Teachers[i];
                }
            }

            return null;
        }
        public Group GetGroupById(int id)
        {
            for (int i = 0; i < Groups.Count; i++)
            {
                if (Groups[i].ID == id)
                {
                    return Groups[i];
                }
            }

            return null;
        }
        public Student GetStudentpById(int id)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].ID == id)
                {
                    return Students[i];
                }
            }

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using SchoolSoft.MainLogic;

namespace SchoolSoft.DataBaseConnection
{
    public class DBC
    {
        public DataStorage DS { get; set; }
        private SqlConnection _sqlConnection;
        private SqlDataAdapter _adapter;
        private DataSet _dataSet;

        public DBC(string connectionString)
        {
            DS = new DataStorage();
            _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();
            _adapter = new SqlDataAdapter();
            _dataSet = new DataSet();

            fillDisciplines();
            fillTeachers();
            fillGroups();
            fillStudents();
            fillDisciplineMarks();
        }

        #region fills
        public void fillDisciplines()
        {
            SqlCommand command = new SqlCommand("Select* from Disciplines", _sqlConnection);
            _adapter.SelectCommand = command;
            _adapter.Fill(_dataSet);

            foreach (DataRow row in _dataSet.Tables[0].Rows)
            {
                DS.Disciplines.Add(new Discipline((int) row["ID"], (string) row["DisciplineName"]));
            }

            // curatam datele noastre
            _dataSet.Tables.Clear();
        }
        public void fillTeachers()
        {
            SqlCommand command = new SqlCommand("Select* from Teachers", _sqlConnection);
            _adapter.SelectCommand = command;
            _adapter.Fill(_dataSet);

            int _id;
            int _idDiscipline;
            string _teacherName;
            string _teacherSurname;
            DateTime _birthDate;
            double _salary;

            foreach (DataRow row in _dataSet.Tables[0].Rows)
            {
                
                _id = (int) row["ID"];
                _idDiscipline = (int) row["IDDiscipline"];
                _teacherName = (string) row["TeacherName"];
                _teacherSurname = (string) row["TeacherSurname"];
                _birthDate = (DateTime) row["BirthDate"];
                _salary = (double) row["Salary"];

                Teacher teacher = new Teacher(_id, _teacherName, _teacherSurname, _birthDate, DS.GetDisciplineByID(_idDiscipline));
                DS.Teachers.Add(teacher);
            }

            // curatam pentru a putea folosi mai departe;
            _dataSet.Tables.Clear();
        }
        public void fillGroups()
        {
            SqlCommand command = new SqlCommand("Select* from Groups", _sqlConnection);
            _adapter.SelectCommand = command;
            _adapter.Fill(_dataSet);

            int _id;
            int _year;
            char _letter;
            int _idTeacher;

            foreach (DataRow row in _dataSet.Tables[0].Rows)
            {
                _id = (int) row[0];
                _year = (int) row[1];
                _letter = ((string) row[2])[0];
                _idTeacher = (int) row[3];

                Group g = new Group(_id, _year, _letter, DS.GetTeacherById(_idTeacher));
                DS.Groups.Add(g);
            }

            _dataSet.Tables.Clear();
        }
        public void fillStudents()
        {
            SqlCommand cmmd = new SqlCommand("Select* from Students", _sqlConnection);
            _adapter.SelectCommand = cmmd;
            _adapter.Fill(_dataSet);

            int _id;
            int _idGroup;
            string _name;
            string _surname;
            DateTime _date;

            foreach (DataRow row in _dataSet.Tables[0].Rows)
            {
                _id = (int) row[0];
                _idGroup = (int) row[1];
                _name = (string) row[2];
                _surname = (string) row[3];
                _date = (DateTime) row[4];

                Student st = new Student(_id, _name, _surname, _date);
                st.Group = DS.GetGroupById(_idGroup);

                DS.Students.Add(st);
            }

            _dataSet.Tables.Clear();
        }
        public void fillDisciplineMarks()
        {
            foreach (Student student in DS.Students) {
                List<DisciplineMarks> _marks = new List<DisciplineMarks>();

                foreach (Discipline discipline in DS.Disciplines)
                {
                    string query = string.Format("Select Mark from DisciplineMarks where IDStudent = {0} and IDDiscipline = {1}", student.ID, discipline.ID);
                    SqlCommand cmmd = new SqlCommand(query, _sqlConnection);
                    _adapter.SelectCommand = cmmd;
                    _adapter.Fill(_dataSet);

                    // creiem obiectul DisciplineMarks
                    DisciplineMarks dm = new DisciplineMarks();

                    // adaugam disciplina la DisciplineMarks
                    dm.Discipline = DS.GetDisciplineByID(discipline.ID);

                    // adaugam notele
                    int _mark;
                    foreach (DataRow row in _dataSet.Tables[0].Rows)
                    {
                        _mark = (int)row[0];
                        dm.Marks.Add(_mark);
                    }

                    // legam DM (DisciplineMarks) cu studentul nostru;
                    student.Marks.Add(dm);
                    _dataSet.Tables.Clear();
                }
            }

            foreach (Student s in DS.Students)
            {
                s.Group.Students.Add(s);
            }
        }
        #endregion

        public void CloseConnection()
        {
            if (_sqlConnection != null)
                _sqlConnection.Close();
        }

        public void DeleteStudent(Student student)
        {
            //stergem si in groups
            student.Group.Students.Remove(student);

            for (int i=0;i<DS.Students.Count;i++)
            {
                if (DS.Students[i].ID == student.ID)
                {
                    DS.Students[i].Marks.Clear();
                    DS.Students[i].changed = true;
                    SaveChangesInDB();
                    DS.Students.RemoveAt(i);
                }
            }
            SqlCommand command = new SqlCommand($"Delete from Students where ID = {student.ID}", _sqlConnection);
            command.ExecuteNonQuery();
        }
        public void SaveChangesInDB()
        {
            string sql_insert = "Insert into DisciplineMarks values ";
            int countOfMarks;
            int actual_countOfMarks = 0;

            foreach (Student st in DS.Students)
            {
                if (st.changed)
                {
                    // calculam numarul de note
                    countOfMarks = 0;
                    actual_countOfMarks = 0;
                    foreach (DisciplineMarks dm in st.Marks)
                    {
                        countOfMarks += dm.Marks.Count;
                    }

                    SqlCommand command = new SqlCommand($"Delete from DisciplineMarks where IDStudent={st.ID}",_sqlConnection);
                    command.ExecuteNonQuery();

                    foreach (DisciplineMarks disciplineMarks in st.Marks)
                    {
                        for (int i = 0;i<disciplineMarks.Marks.Count;i++)
                        {
                            sql_insert += $"({st.ID},{disciplineMarks.Discipline.ID},{disciplineMarks.Marks[i]})";
                            actual_countOfMarks++;

                            if (actual_countOfMarks == countOfMarks)
                            {
                                sql_insert += ";";
                            }
                            else sql_insert += ",";
                        }
                    }

                    if (st.Marks.Count == 0)
                    {
                        sql_insert = "";
                    }
                    st.changed = false;
                }
            }
            if (sql_insert != "")
            {
                SqlCommand comm = new SqlCommand(sql_insert, _sqlConnection);
                comm.ExecuteNonQuery();
            }
        }
        public void UpdateStudentInDB(Student student)
        {
            string sql_isert = $"Update Students Set IDGroup = {student.Group.ID}, StudentName = '{student.Name}',StudentSurname = '{student.Surname}',BirthDate = '{student.Date.ToString("yyyy-MM-dd")}' where ID = {student.ID}";
            SqlCommand command = new SqlCommand(sql_isert, _sqlConnection);
            command.ExecuteNonQuery();
        }
        public void AddNewStudent(Student student)
        {
            string sql_insert = $"Insert into Students Values ({student.ID},{student.Group.ID},'{student.Name}','{student.Surname}','{student.Date.ToString("yyyy-MM-dd")}');";
            SqlCommand command = new SqlCommand(sql_insert, _sqlConnection);
            command.ExecuteNonQuery();
        }
        public void AddNewGroup(Group group)
        {
            string sql_insert = $"Insert into Groups Values ({group.ID},{group.GroupYear},'{group.GroupLetter}',{group.ClassMaster.ID});";
            SqlCommand command = new SqlCommand(sql_insert, _sqlConnection);
            command.ExecuteNonQuery();

            DS.Groups.Add(group);
        }
        public void AddNewTeacher(Teacher teacher)
        {
            string sql_insert = $"Insert into Teachers Values ({teacher.ID},{teacher.Discipline.ID},'{teacher.Name}','{teacher.Surname}','{teacher.Date.ToString("yyyy-MM-dd")}',{teacher.Salary});";
            SqlCommand command = new SqlCommand(sql_insert, _sqlConnection);
            command.ExecuteNonQuery();


            DS.Teachers.Add(teacher);
        }
        public void DeleteGroupByID(Group group)
        {
            // stergem toti studentii legati cu grupa data
            foreach (Student st in group.Students)
            {
                DeleteStudent(st);
            }

            // stergem grupa
            string sql_delete = $"Delete from Groups where ID={group.ID}";
            SqlCommand command = new SqlCommand(sql_delete, _sqlConnection);
            command.ExecuteNonQuery();

            DS.Groups.Remove(group);
        }
        public void DeleteTeacherByID(Teacher teacher)
        {
            SqlCommand com;
            string sql_deleteFromGroup = $"Update Groups set IDTeacher = NULL where IDTeacher={teacher.ID}";
            com = new SqlCommand(sql_deleteFromGroup, _sqlConnection);
            com.ExecuteNonQuery();

            string sql_deleteTeacher = $"Delete from Teachers where ID = {teacher.ID}";
            com = new SqlCommand(sql_deleteTeacher, _sqlConnection);
            com.ExecuteNonQuery();

            DS.Teachers.Clear();
            fillTeachers();
        }
        public static string GetConnectionString(string db_name)
        {
            // Environment.CurrentDirectory -> returneaza drumul spre fisierul .exe care se afla in ..\bin\Debug . Prin metoda Replace schimbam bin\Debug cu numele la DB si asta se primeste connectionString
            string dbPath = Environment.CurrentDirectory.Replace(@"bin\Debug", db_name);
            return string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0};Integrated Security=True", dbPath);
        }
    }
}

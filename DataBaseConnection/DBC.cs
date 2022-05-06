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
    class DBC
    {
        public DataStorage DS { get; set; }
        private SqlConnection _sqlConnection;
        private SqlDataAdapter _adapter;
        private DataSet _dataSet;

        public DBC(string connectionString)
        {
            DS = new DataStorage();
            _sqlConnection = new SqlConnection(connectionString);
            _adapter = new SqlDataAdapter();
            _dataSet = new DataSet();

            fillDisciplines();
            fillTeachers();
        }

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
                MessageBox.Show(teacher.ToString());
                
            }
        }

        /*
        public void fillGroups()
        {
            SqlCommand command = new SqlCommand("Select* from Groups", _sqlConnection);
            _adapter.SelectCommand = command;
            _adapter.Fill(_dataSet);

            foreach (DataRow row in _dataSet.Tables[0].Rows)
            {
                DS.Groups.Add(new Group(row["ID"]))
            }
        }
        */

        public void CloseConnection()
        {
            if (_sqlConnection != null)
                _sqlConnection.Close();
        }
        public static string GetConnectionString(string db_name)
        {
            // Environment.CurrentDirectory -> returneaza drumul spre fisierul .exe care se afla in ..\bin\Debug . Prin metoda Replace schimbam bin\Debug cu numele la DB si asta se primeste connectionString
            string dbPath = Environment.CurrentDirectory.Replace(@"bin\Debug", db_name);
            return string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0};Integrated Security=True", dbPath);
        }
    }
}

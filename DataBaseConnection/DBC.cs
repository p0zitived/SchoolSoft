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
        private List<Student> _students;
        private List<Teacher> _teachers;
        private List<Discipline> _disciplines;
        private List<Group> _groups;

        private SqlConnection _sqlConnection;
        private SqlDataAdapter _adapter;
        private DataSet _dataSet;

        public DBC(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
            _adapter = new SqlDataAdapter();
            _dataSet = new DataSet();
        }

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

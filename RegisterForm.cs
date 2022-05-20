using SchoolSoft.DataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolSoft.Crypto;
using SchoolSoft.DataBaseConnection;
using SchoolSoft.MainLogic;

namespace SchoolSoft
{
    public partial class RegisterForm : Form
    {
        private string codeForTeacher = "12teacher21";
        private string codeForDirector = "123director321";

        AuthenticationForm _auth;
        DBC _dbc;
        public RegisterForm(AuthenticationForm auth)
        {
            _dbc = new DBC(DBC.GetConnectionString("SchoolDB.mdf"));
            _auth = auth;
            InitializeComponent();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dbc.CloseConnection();
            _auth.Show();
        }

        private void b_Register_Click(object sender, EventArgs e)
        {
            if (tb_Login.Text != "" && tb_Password.Text != "" && tb_Email.Text != "")
            {
                string login;
                string password;
                string email;
                string permision;

                if (tb_Code.Text == codeForDirector)
                    permision = "Director";
                else if (tb_Code.Text == codeForTeacher)
                    permision = "Teacher";
                else
                    permision = "Student";

                login = EnDeCrypto.EncryptText(tb_Login.Text);
                password = EnDeCrypto.EncryptText(tb_Password.Text);
                email = EnDeCrypto.EncryptText(tb_Email.Text + "@gmail.com");

                SqlConnection conn = new SqlConnection(DBC.GetConnectionString("SchoolDB.mdf"));
                conn.Open();
                string sql_insert = $"Insert into Accounts Values ('{login}','{password}','{email}','{permision}');";
                try
                {
                    SqlCommand command = new SqlCommand(sql_insert, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    Close();
                    _auth.Show();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Datele introduse nu sunt valide");
                }
                conn.Close();
            } else
            {
                MessageBox.Show("Datele nu sunt complete", "Date goale", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GetPerson(string Name,string Surname,string permision)
        {
            if (permision == "Student")
            {
                List<Student> students = new List<Student>();
                foreach (Student st in _dbc.DS.Students)
                {
                    if (st.Name == Name && st.Surname == Surname)
                    {
                        students.Add(st);
                    }
                }

            }
        }
    }
}

using SchoolSoft.DataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolSoft.Crypto;

namespace SchoolSoft
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void b_Enter_Click(object sender, EventArgs e)
        {
            string permision = "";

            bool correctLogin = false;
            bool correctPassword = false;

            string encrypted_login = EnDeCrypto.EncryptText(tb_Login.Text);
            string encrypted_password = EnDeCrypto.EncryptText(tb_Password.Text);

            SqlConnection conn = new SqlConnection(DBC.GetConnectionString("SchoolDB.mdf"));
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            conn.Open();
            SqlCommand command = new SqlCommand($"Select* from Accounts where AccountLogin='{encrypted_login}'",conn);
            adapter.SelectCommand = command;
            adapter.Fill(dataSet);

            if (dataSet.Tables.Count != 0)
            {
                correctLogin = true;
                string password = (string) dataSet.Tables[0].Rows[0]["AccountPassword"];
                if (password == encrypted_password)
                {
                    correctPassword = true;
                    permision = (string) dataSet.Tables[0].Rows[0]["Permision"];
                }
            }

            if (correctLogin && correctPassword)
            {
                MainMenuForm menu = new MainMenuForm(this,permision);
                menu.Show();
                Hide();
            } else
            {
                MessageBox.Show("Login sau parola a fost introdusa gresit");
            }

            conn.Close();
        }

        private void b_Register_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm(this);
            Hide();
            rf.Show();
        }
    }
}

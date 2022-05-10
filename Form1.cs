using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolSoft.DataBaseConnection;

namespace SchoolSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string _cnnString = DBC.GetConnectionString("SchoolDB.mdf");
            DBC dbc = new DBC(_cnnString);

            dbc.CloseConnection();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MainLogic.Student student1 = new MainLogic.Student();
            student1.Name = "Dan";
            student1.Surname = "Hitrov";

            MainLogic.SchoolItem item = new MainLogic.SchoolItem("Matematica");
            int[] marks = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MainLogic.SchoolItemMarks itemMarks = new MainLogic.SchoolItemMarks(item, marks.ToList());

            student1.Marks.Add(itemMarks);

            richTextBox1.Text = student1.ToString();
        }
    }
}

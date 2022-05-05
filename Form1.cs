using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolSoft.MainLogic;

namespace SchoolSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // student test
            Discipline item = new Discipline("Matematica");
            int[] marks = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            DisciplineMarks itemMarks = new DisciplineMarks(item, marks.ToList());

            Student student1 = new Student("Hitrov", "Dan", new DateTime(2003, 12, 13));
            student1.Marks.Add(itemMarks);

            // teacher test
            Teacher teacher1 = new Teacher("Vasilescu","Pontif",new DateTime(1980,11,22),item);

            // gruop test
            Group group1 = new Group(12, 'B');
            group1.Students.Add(student1);
            group1.ClassMaster = teacher1;

            richTextBox1.Text = student1.ToString();
            richTextBox1.Text += "\n" + teacher1.ToString();
            richTextBox1.Text += "\n" + group1.ToString();
        }
    }
}

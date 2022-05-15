using SchoolSoft.DataBaseConnection;
using SchoolSoft.MainLogic;
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
    public partial class EditareForm : Form
    {
        private Student _selectedStudent;

        private DBC _dbc;
        private MainMenuForm _menu;

        public EditareForm(MainMenuForm menu,DBC dbc)
        {
            InitializeComponent();

            _menu = menu;
            _dbc = dbc;

            setUpTreeView();
            setUpComboBox();
        }

        private void setUpTreeView()
        {
            tv_school.BeginUpdate();
            tv_school.Nodes.Clear();

            tv_school.Font = new Font("Microsoft Sans Serif", 12f);
            foreach (Group group in _dbc.DS.Groups)
            {
                TreeNode node = new TreeNode(group.GroupYear + " " + group.GroupLetter);

                foreach (Student student in group.Students)
                {
                    node.Nodes.Add(student.ID + " " + student.Name + " " + student.Surname);
                }

                tv_school.Nodes.Add(node);
            }

            tv_school.EndUpdate();
        }
        private void setUpComboBox()
        {
            foreach (Group g in _dbc.DS.Groups)
            {
                cb_Grupa.Items.Add(g);
            }
        }

        private void tv_school_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // curatim richTextbox-ul
            tb_Name.Text = "";
            tb_Surname.Text = "";
            _selectedStudent = null;
            cb_Grupa.SelectedItem = null;

            // try , deoarece Parse cateodata face erori
            try
            {
                string[] aux = e.Node.Text.Split(' ');
                if (aux.Length >= 3) // am pus asta aici ca denumirile la nodurile de grupa au 2 cuvinte
                {
                    int id_student = int.Parse(aux[0]);
                    _selectedStudent = _dbc.DS.GetStudentpById(id_student);
                    l_SelectedStud.Text = e.Node.Text;

                    tb_Name.Text = _selectedStudent.Name;
                    tb_Surname.Text = _selectedStudent.Surname;
                    cb_Grupa.SelectedItem = _selectedStudent.Group;
                    dtp_Date.Value = _selectedStudent.Date;
                }
            }
            catch
            {

            }
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text != "" && tb_Surname.Text != "" && cb_Grupa.SelectedItem != null)
            {
                _selectedStudent.Name = tb_Name.Text;
                _selectedStudent.Surname = tb_Surname.Text;
                _selectedStudent.Date = dtp_Date.Value;
                _selectedStudent.Group = (Group)cb_Grupa.SelectedItem;

                _dbc.UpdateStudentInDB(_selectedStudent);
            } else
            {
                MessageBox.Show("Datele esentiale nu au fost introudse", "Campuri necompletate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_Deselect_Click(object sender, EventArgs e)
        {
            tb_Name.Text = "";
            tb_Surname.Text = "";
            _selectedStudent = null;
            cb_Grupa.SelectedItem = null;
            l_SelectedStud.Text = "";
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text != "" && tb_Surname.Text != "")
            {
                Student student = new Student();
                student.Name = tb_Name.Text;
                student.Surname = tb_Surname.Text;
                student.Date = dtp_Date.Value;
                student.Group = (Group)cb_Grupa.SelectedItem;

                int max = 0;
                foreach (Student st in _dbc.DS.Students)
                {
                    if (st.ID > max)
                    {
                        max = st.ID;
                    }
                }
                student.ID = max + 1;

                _dbc.DS.Students.Add(student);
                Group grupa = (Group)cb_Grupa.SelectedItem;
                grupa.Students.Add(student);

                _dbc.AddNewStudent(student);

                setUpTreeView();
            } else
            {
                MessageBox.Show("Datele esentiale nu au fost introudse", "Campuri necompletate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_Exmatriculeaza_Click(object sender, EventArgs e)
        {
            if (_selectedStudent != null)
            {
                _dbc.DeleteStudent(_selectedStudent);
                setUpTreeView();
            } else
            {
                MessageBox.Show("Nici un elev nu a fost selectat", "Neselectare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _menu.Show();
        }
    }
}

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
            setUpTeacherComboBox();
            hideCreateGroup();
        }

        private void hideCreateGroup()
        {
            l_Letter.Visible = false;
            l_Year.Visible = false;
            cb_Letter.Visible = false;
            cb_Year.Visible = false;
            b_Create.Visible = false;
            cb_Teachers.Visible = false;
            l_Teacher.Visible = false;
        }
        private void showCreateGroup()
        {
            l_Letter.Visible = true;
            l_Year.Visible = true;
            cb_Letter.Visible = true;
            cb_Year.Visible = true;
            b_Create.Visible = true;
            cb_Teachers.Visible = true;
            l_Teacher.Visible = true;
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
            cb_Grupa.Items.Clear();
            cb_GroupToDelete.Items.Clear();
            foreach (Group g in _dbc.DS.Groups)
            {
                cb_GroupToDelete.Items.Add(g);
            }
            foreach (Group g in _dbc.DS.Groups)
            {
                cb_Grupa.Items.Add(g);
            }
        }
        public void setUpTeacherComboBox()
        {
            cb_Teachers.Items.Clear();
            foreach (Teacher t in _dbc.DS.Teachers)
            {
                cb_Teachers.Items.Add(t);
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

        private void b_CreateGroup_Click(object sender, EventArgs e)
        {
            showCreateGroup();
        }

        private void b_Create_Click(object sender, EventArgs e)
        {
            bool existsSameGroup = false;
            foreach (Group g in _dbc.DS.Groups)
            {
                if (g.GroupYear == int.Parse(cb_Year.SelectedItem.ToString()) && g.GroupLetter == cb_Letter.SelectedItem.ToString().ToArray()[0])
                {
                    existsSameGroup = true;
                }
            }

            if (!existsSameGroup)
            {
                Group g = new Group();
                g.GroupYear =int.Parse(cb_Year.SelectedItem.ToString());
                g.GroupLetter = char.Parse(cb_Letter.SelectedItem.ToString());
                g.ClassMaster =(Teacher) cb_Teachers.SelectedItem;

                int id = 0;
                foreach (Group gr in _dbc.DS.Groups)
                {
                    if (gr.ID > id)
                    {
                        id = gr.ID;
                    }
                }
                id += 1;
                g.ID = id;

                hideCreateGroup();
                setUpTreeView();
                _dbc.AddNewGroup(g);
            } else
            {
                MessageBox.Show("O astfel grupa exista deja !");
            }
        }

        private void b_Profesori_Click(object sender, EventArgs e)
        {
            EditareProfesori ep = new EditareProfesori(this,_dbc);
            ep.Show();
            Hide();
        }

        private void b_DeleteGroup_Click(object sender, EventArgs e)
        {
            try
            {
                _dbc.DeleteGroupByID((Group)cb_GroupToDelete.SelectedItem);
                setUpComboBox();
            } catch (Exception exp)
            {
                MessageBox.Show("Ceva merge gresit :( ");
            }
        }
    }
}

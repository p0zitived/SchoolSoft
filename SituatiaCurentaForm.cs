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
using SchoolSoft.MainLogic;

namespace SchoolSoft
{
    public partial class SituatiaCurentaForm : Form
    {
        private DBC _dbc;

        private MainMenuForm _menu;
        private Student _student;
        public SituatiaCurentaForm(MainMenuForm menu,DBC dbc)
        {
            InitializeComponent();
            _menu = menu;
            _dbc = dbc;

            //setUpData(student,disciplines,new Size(90,80));
            setUpTreeView();

            // transparenta 
            l_Title.BackColor = Color.FromArgb(0, l_Title.BackColor);
            fl_Disciplines.BackColor = Color.FromArgb(100, fl_Disciplines.BackColor);
            fl_Marks.BackColor = Color.FromArgb(100, fl_Marks.BackColor);
            fl_Total.BackColor = Color.FromArgb(100, fl_Total.BackColor);
            fl_Base.BackColor = Color.FromArgb(100, fl_Base.BackColor);
            fl_Restante.BackColor = Color.FromArgb(100, fl_Restante.BackColor);

            foreach (Label lab in fl_Base.Controls)
            {
                lab.BackColor = Color.FromArgb(0, lab.BackColor);
            }
            foreach (Label lab in fl_Restante.Controls)
            {
                lab.BackColor = Color.FromArgb(0, lab.BackColor);
            }
            foreach (Label lab in fl_Marks.Controls)
            {
                lab.BackColor = Color.FromArgb(0, lab.BackColor);
            }
            foreach (Label lab in fl_Total.Controls)
            {
                lab.BackColor = Color.FromArgb(0, lab.BackColor);
            }
        }

        private void setUpData(Student student,List<Discipline> disciplines,Size buttonSize)
        {
            // setarea datelor de baza
            l_NumeAfis.Text = student.Name;
            l_PrenumeAfis.Text = student.Surname;
            l_DataAfis.Text = student.Date.ToString();
            l_ClasaAfis.Text = student.Group.GroupYear + " " + student.Group.GroupLetter;
            l_DiriginteAfis.Text = student.Group.ClassMaster.Name;

            // setarea butoanelor cu disciplinele
            fl_Disciplines.Controls.Clear();
            foreach (Discipline discipline in disciplines)
            {
                Button button = new Button();
                button.Text = discipline.Name;
                button.Size = buttonSize;
                button.Click += DisciplineButtonClick; // adaugam eventul dorit

                fl_Disciplines.Controls.Add(button);
            }

            // setarea restantelor 
            l_Restante.Text = "Restante :";
            foreach (DisciplineMarks dm in _student.Marks)
            {
                if (dm.GetAverage() < 5)
                {
                    l_Restante.Text += dm.Discipline.Name + " ";
                }
            }

            // setarea totalurilor
            l_AbsTotAfis.Text = _student.GetAbsences() + "";
            l_MedTotAfis.Text = _student.GetAverage() + "";
        }
        private void DisciplineButtonClick(object sender,EventArgs e)
        {
            Button button_sender = (Button)sender;

            l_Marks.Text = button_sender.Text + " : \n";
            l_Marks.Text += "Note : ";
            // cautam din lista tuturor obiectelor al studentului
            foreach (DisciplineMarks dm in _student.Marks)
            {
                // verificam daca am gasit disciplina dorita
                if (dm.Discipline.Name == button_sender.Text)
                {
                    // enumeram toate notele din ea , intrun mod frumos
                    foreach (int mark in dm.Marks)
                    {
                        // verificam daca nu este -1 , daca este o scriem ca 'a'
                        if (mark != -1)
                        {
                            l_Marks.Text += mark + " ";
                        } else
                        {
                            l_Marks.Text += "a ";
                        }
                    }

                    l_Marks.Text += "\nMedia : " + dm.GetAverage();
                    l_Marks.Text += "\nAbsente : " + dm.GetAbsences();
                }
            }

        }

        private void SituatiaCurentaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _menu.Show();
        }
        #region tree view of students
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
        private void tv_school_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string[] aux = e.Node.Text.Split(' ');
                if (aux.Length >= 3) // am pus asta aici ca denumirile la nodurile de grupa au 2 cuvinte
                {
                    int id_student = int.Parse(aux[0]);
                    _student = _dbc.DS.GetStudentpById(id_student);
                    setUpData(_student, _dbc.DS.Disciplines, new Size(90, 80));
                }
            }
            catch
            {

            }
        }
        #endregion
    }
}

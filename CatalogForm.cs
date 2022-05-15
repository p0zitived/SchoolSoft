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
    public partial class CatalogForm : Form
    {
        private DBC _dbc;
        private MainMenuForm _menu;
        private DataStorage DS;
        private Student _selectedStudent;
        private DisciplineMarks _selectedDisciplineMarks;

        public CatalogForm(MainMenuForm menu,DBC dbc)
        {
            InitializeComponent();

            _menu = menu;
            _dbc = dbc;
            DS = dbc.DS; // am separat DataStorage de DBC pursisimplu ca sa fie mai comod

            setUpTreeView();
            setUpDisciplineButton(new Size(90,80));
        }

        private void setUpTreeView()
        {
            tv_school.BeginUpdate();

            tv_school.Font = new Font("Microsoft Sans Serif",12f);
            foreach (Group group in DS.Groups)
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

        private void setUpDisciplineButton(Size buttonSize)
        {
            // setarea butoanelor cu disciplinele
            foreach (Discipline discipline in DS.Disciplines)
            {
                Button button = new Button();
                button.Text = discipline.Name;
                button.Size = buttonSize;
                button.Click += DisciplineButtonClick; // adaugam eventul dorit

                fl_Disciplines.Controls.Add(button);
            }
        }
        private void DisciplineButtonClick(object sender, EventArgs e)
        {
            Button button_sender = (Button)sender;

            if (_selectedStudent != null)
            {
                rt_Marks.Text = "";
                // cautam din lista tuturor obiectelor al studentului
                foreach (DisciplineMarks dm in _selectedStudent.Marks)
                {
                    // verificam daca am gasit disciplina dorita
                    if (dm.Discipline.Name == button_sender.Text)
                    {
                        _selectedDisciplineMarks = dm;
                        // enumeram toate notele din ea , intrun mod frumos
                        foreach (int mark in dm.Marks)
                        {
                            // verificam daca nu este -1 , daca este o scriem ca 'a'
                            if (mark != -1)
                            {
                                rt_Marks.Text += mark + " ";
                            }
                            else
                            {
                                rt_Marks.Text += "a ";
                            }
                        }

                        l_MedieAfis.Text = dm.GetAverage()+ "";
                        l_AbsAfis.Text = dm.GetAbsences()+ "";
                    }
                }
            }

        }

        // vor aparea probleme , nu uita sa te uiti ce prostie este aici .
        private void tv_school_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // curatim richTextbox-ul
            rt_Marks.Text = "";
            l_SelectedStud.Text = "Selectati un Elev ...";
            _selectedStudent = null;
            l_MedieAfis.Text = "-";
            l_AbsAfis.Text = "-";
            _selectedDisciplineMarks = null;

            // try , deoarece Parse cateodata face erori
            try {
                string[] aux = e.Node.Text.Split(' ');
                if (aux.Length >= 3) // am pus asta aici ca denumirile la nodurile de grupa au 2 cuvinte
                {
                    int id_student = int.Parse(aux[0]);
                    _selectedStudent = DS.GetStudentpById(id_student);
                    l_SelectedStud.Text = e.Node.Text;
                }
            } catch
            {

            }
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            if (_selectedDisciplineMarks != null && _selectedStudent != null)
            {
                try
                {
                    _selectedDisciplineMarks.Marks.Clear();
                    string[] markStrings = rt_Marks.Text.Split(' ');
                    foreach (string s in markStrings)
                    {
                        if (s.ToArray()[0] == 'a')
                        {
                            _selectedDisciplineMarks.Marks.Add(-1);
                        } else
                        {
                            _selectedDisciplineMarks.Marks.Add(int.Parse(s));
                        }
                    }

                    MessageBox.Show("Notele au fost salvate","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _selectedStudent.changed = true;
                    _dbc.SaveChangesInDB();

                    l_MedieAfis.Text = _selectedDisciplineMarks.GetAverage() + "";
                    l_AbsAfis.Text = _selectedDisciplineMarks.GetAbsences() + "";
                } catch
                {
                    MessageBox.Show("Incercati sa stergeti literele in plus , sau stergeti spatiile libere in plus intre note si la sfarsit.", "Formatul a fost incalcat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Selectati un elev si o disciplina","Nu a fost nimic selectat", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void CatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _menu.Show();
        }
    }
}

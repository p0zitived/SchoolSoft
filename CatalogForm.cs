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
        private MainMenuForm _menu;
        private DataStorage DS;
        private Student _selectedStudent;

        public CatalogForm(MainMenuForm menu,DataStorage ds)
        {
            InitializeComponent();

            _menu = menu;
            DS = ds;

            setUpTreeView();
            setUpDisciplineButton(new Size(90,80));
        }

        private void setUpTreeView()
        {
            tv_school.BeginUpdate();

            foreach (Group group in DS.Groups)
            {
                TreeNode node = new TreeNode(group.GroupYear + " " + group.GroupLetter);
                
                foreach (Student student in group.Students)
                {
                    node.Nodes.Add(student.Name + " " + student.Surname);
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

            rt_Marks.Text = button_sender.Text + " : \n";
            rt_Marks.Text += "Note : ";
            // cautam din lista tuturor obiectelor al studentului
            foreach (DisciplineMarks dm in _selectedStudent.Marks)
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
                            rt_Marks.Text += mark + " ";
                        }
                        else
                        {
                            rt_Marks.Text += "a ";
                        }
                    }

                    rt_Marks.Text += "\nMedia : " + dm.GetAverage();
                    rt_Marks.Text += "\nAbsente : " + dm.GetAbsences();
                }
            }

        }

        private void tv_school_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}

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
        private MainMenuForm _menu;
        private Student _student;
        public SituatiaCurentaForm(MainMenuForm menu,Student student,List<Discipline> disciplines)
        {
            InitializeComponent();
            _menu = menu;
            _student = student;

            setUpData(student,disciplines,new Size(90,80));
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
            foreach (Discipline discipline in disciplines)
            {
                Button button = new Button();
                button.Text = discipline.Name;
                button.Size = buttonSize;
                button.Click += DisciplineButtonClick; // adaugam eventul dorit

                fl_Disciplines.Controls.Add(button);
            }
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
    }
}

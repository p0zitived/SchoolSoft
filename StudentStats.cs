using SchoolSoft.DataBaseConnection;
using SchoolSoft.MainLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSoft
{
    public partial class StudentStats : Form
    {
        private MainMenuForm _menu;
        private DBC _dbc;

        public StudentStats(MainMenuForm menu, DBC dbc)
        {
            InitializeComponent();
            _menu = menu;
            _dbc = dbc;

            setUpRestantieri();
            setUpEminenti();
            setUpMedie8();
            setUpTopGrupe();
        }

        
        private void setUpRestantieri()
        {
            int trophy_count = 0;

            List<Student> restantieri = new List<Student>();
            foreach (Student student in _dbc.DS.Students)
            {
                foreach (DisciplineMarks dm in student.Marks)
                {
                    if (dm.GetAverage() < 5)
                    {
                        restantieri.Add(student);
                        break;
                    }
                }
            }
            restantieri = restantieri.OrderBy(st => st.GetAverage()).ToList();
            foreach (Student st in restantieri)
            {
                Label label = new Label();
                label.Size = new Size(200, 25);
                if (trophy_count < 3)
                {
                    label.Text = $"🏆 {st.Name} {st.Surname} ";
                    trophy_count++;
                }
                else
                {
                    label.Text = $"{trophy_count+1} {st.Name} {st.Surname} ";
                    trophy_count++;
                }
                label.Font = new Font("Microsoft Sans Serif",15);
                fl_restantieri.Controls.Add(label);

                Label label1 = new Label();
                label1.Size = new Size(50, 25);
                label1.Text = $"{st.GetAverage()}";
                label1.Font = new Font("Microsoft Sans Serif", 15);
                fl_restantieri.Controls.Add(label1);
            }
        }
        private void setUpEminenti()
        {
            int trophy_count = 0;

            List<Student> eminenti = new List<Student>();
            foreach (Student student in _dbc.DS.Students)
            {
                bool restante = false;
                foreach (DisciplineMarks dm in student.Marks)
                {
                    if (dm.GetAverage() < 5)
                    {
                        restante = true;
                        break;
                    }
                }
                if (!restante)
                    eminenti.Add(student);
            }
            eminenti = eminenti.OrderByDescending(st => st.GetAverage()).ToList();
            foreach (Student st in eminenti)
            {
                Label label = new Label();
                label.Size = new Size(200, 25);
                if (trophy_count < 3)
                {
                    label.Text = $"🏆 {st.Name} {st.Surname}";
                    trophy_count++;
                }
                else
                {
                    label.Text = $"{trophy_count + 1} {st.Name} {st.Surname}";
                    trophy_count++;
                }
                label.Font = new Font("Microsoft Sans Serif", 15);
                fl_eminenti.Controls.Add(label);

                Label label1 = new Label();
                label1.Size = new Size(50, 25);
                label1.Text = $"{st.GetAverage()}";
                label1.Font = new Font("Microsoft Sans Serif", 15);
                fl_eminenti.Controls.Add(label1);
            }
        }
        private void setUpMedie8()
        {
            int trophy_count = 0;

            List<Student> eminenti = new List<Student>();
            foreach (Student student in _dbc.DS.Students)
            {
                bool restante = false;
                foreach (DisciplineMarks dm in student.Marks)
                {
                    if (dm.GetAverage() < 5)
                    {
                        restante = true;
                        break;
                    }
                }
                if (!restante && student.GetAverage() >= 8.5 && student.GetAbsences() < 40)
                    eminenti.Add(student);
            }
            eminenti = eminenti.OrderByDescending(st => st.GetAverage()).ToList();
            foreach (Student st in eminenti)
            {
                Label label = new Label();
                label.Size = new Size(200, 25);
                if (trophy_count < 3)
                {
                    label.Text = $"🏆 {st.Name} {st.Surname}";
                    trophy_count++;
                }
                else
                {
                    label.Text = $"{trophy_count + 1} {st.Name} {st.Surname}";
                    trophy_count++;
                }
                label.Font = new Font("Microsoft Sans Serif", 15);
                fl_medie.Controls.Add(label);

                Label label1 = new Label();
                label1.Size = new Size(120, 25);
                label1.Text = $"abs:{st.GetAbsences()} {Math.Round(st.GetAverage(),2)}";
                label1.Font = new Font("Microsoft Sans Serif", 15);
                fl_medie.Controls.Add(label1);
            }
        }
        private void setUpTopGrupe()
        {
            Font font = new Font("Microsoft Sans Serif", 15);
            List<Group> groups = _dbc.DS.Groups.OrderBy(g => g.GetAbsences()).ToList();
            foreach (Group group in groups)
            {
                Label label = new Label();
                label.Font = font;
                label.Text = $"{group.GroupYear} {group.GroupLetter}";
                label.Size = new Size(100, 25);
                fl_grupe.Controls.Add(label);

                Label label1 = new Label();
                label1.Font = font;
                label1.Text = $"abs:{group.GetAbsences()}";
                label1.Size = new Size(100, 25);
                fl_grupe.Controls.Add(label1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            bool x = true;
            foreach (Control c in fl_restantieri.Controls)
            {
                Label l = (Label)c;
                if (x)
                {
                    text += l.Text + " ";
                    x = false;
                } else
                {
                    text += l.Text + "\n";
                    x = true;
                }
            }
            File.WriteAllText("Restantieri.html", text);
        }

        private void StudentStats_FormClosing(object sender, FormClosingEventArgs e)
        {
            _menu.Show();
        }
    }
}

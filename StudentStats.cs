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
        }

        
        private void setUpRestantieri()
        {

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
            int aux = 255;
            Color color;
            foreach (Student st in restantieri)
            {
                color = Color.FromArgb(255, aux, 0, 255 - aux);
                Label label = new Label();
                label.Size = new Size(200, 25);
                label.Text = $"{st.Name} {st.Surname} ";
                label.Font = new Font("Microsoft Sans Serif",15);
                label.BackColor = color;
                fl_restantieri.Controls.Add(label);

                Label label1 = new Label();
                label1.Size = new Size(50, 25);
                label1.Text = $"{st.GetAverage()}";
                label1.Font = new Font("Microsoft Sans Serif", 15);
                label1.BackColor = color;
                fl_restantieri.Controls.Add(label1);

                if (aux > 0)
                    aux -= 1;
            }
        }
        private void setUpEminenti()
        {
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
            int aux = 255;
            Color color;
            foreach (Student st in eminenti)
            {
                color = Color.FromArgb(255, 0, aux, 255 - aux);
                Label label = new Label();
                label.Size = new Size(200, 25);
                label.Text = $"{st.Name} {st.Surname} ";
                label.Font = new Font("Microsoft Sans Serif", 15);
                label.BackColor = color;
                fl_eminenti.Controls.Add(label);

                Label label1 = new Label();
                label1.Size = new Size(50, 25);
                label1.Text = $"{st.GetAverage()}";
                label1.Font = new Font("Microsoft Sans Serif", 15);
                label1.BackColor = color;
                fl_eminenti.Controls.Add(label1);

                if (aux > 0)
                    aux -= 1;
            }
        }
    }
}

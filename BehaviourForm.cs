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
    public partial class BehaviourForm : Form
    {
        Color color_of_text = Color.Black;
        string[] events = { "a batut pe", "a muscat pe", "a scuipat pe", "a hartuit pe", "a injurat pe", "a tipat la", "a cantat cu", "a fugit de la lectii cu", "a furat telefonul lui", "a mancat mancarea lui", "a furat banii lui", "a furat pistolul de la", "a frezat chel pe" };
        int time_to_apear = 1000;
        MainMenuForm _menu;
        DBC _dbc;

        public BehaviourForm(MainMenuForm menu, DBC dbc)
        {
            InitializeComponent();

            _menu = menu;
            _dbc = dbc;
        }

        private void ShowFadeEffect(int r,int g,int b)
        {
            l_text.ForeColor = Color.FromArgb(255, r, g, b);
            FadeTimer.Enabled = true;
        }

        private void GenerateEvent(List<string> events)
        {
            Random rand = new Random();
            Student student1 = _dbc.DS.GetStudentpById(rand.Next(_dbc.DS.Students.Count));
            Student student2 = _dbc.DS.GetStudentpById(rand.Next(_dbc.DS.Students.Count));
            string event1 = events[rand.Next(events.Count)];

            try
            {
                l_text.Text += $"{student1.Name} {student1.Surname} {event1} {student2.Name} {student2.Surname} {DateTime.Now.ToShortTimeString()}\n\n";
                time_to_apear = rand.Next(10000);
            } catch (Exception exp)
            {
                
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time_to_apear -= timer.Interval;
            if (time_to_apear <= 0)
            {
                GenerateEvent(events.ToList());
                ShowFadeEffect(0, 255, 55);
            }
        }

        private void BehaviourForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _menu.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (l_text.ForeColor != Color.FromArgb(0,255,255,255))
            {
                int r = l_text.ForeColor.R;
                int g = l_text.ForeColor.G;
                int b = l_text.ForeColor.B;
                l_text.ForeColor = Color.FromArgb(0, r==255?255:r+1, g==255?255:g+1,b==255?255:b+1);
            } else
            {
                FadeTimer.Enabled = false;
            }
        }
    }
}

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

namespace SchoolSoft
{
    public partial class MainMenuForm : Form
    {
        #region move buttons
        private bool goRight = false;
        private bool goLeft = false;
        private int distance;
        private int time = 400;
        private int calc_error; // din cauza la margin apare
        private int controlsCount;

        // changing vars
        private int actualPos = 0;
        private int time_remaining;
        #endregion
        #region situatia curenta
        private DBC dbc;
        #endregion

        public MainMenuForm()
        {
            InitializeComponent();

            b_SwipeToLeft.BackColor = Color.FromArgb(0, b_SwipeToLeft.BackColor);
            buttonsPanel.BackColor = Color.FromArgb(0, buttonsPanel.BackColor);
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            string _cnnString = DBC.GetConnectionString("SchoolDB.mdf");
            dbc = new DBC(_cnnString);

            calc_error = buttonsPanel.Margin.Right * 2;
            distance = buttonsPanel.Controls[0].Width;
            controlsCount = buttonsPanel.Controls.Count;
        }

        #region animations
        private void setUpSelectedControl()
        {
            Color col;
            Button aux;
            for (int i = 0; i < controlsCount; i++)
            {
                if (i != actualPos)
                {
                    aux = (Button) buttonsPanel.Controls[i];
                    aux.Enabled = false;
                } else
                {
                    aux = (Button) buttonsPanel.Controls[i];
                    aux.Enabled = true;
                }
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            // conditia pentru iesirea din margini
            if (actualPos == 0)
            {
                b_SwipeToLeft.Enabled = false;
            }
            if (actualPos == controlsCount-1)
            {
                b_SwipeToRight.Enabled = false;
            }

            // conditia pentru pornire
            if (time_remaining <= 0 && (goRight || goLeft))
            {
                time_remaining = time;

                if (goRight)
                {
                    actualPos--;
                }
                if (goLeft)
                {
                    actualPos++;
                }

                setUpSelectedControl();
            }

            // indeplinirea pornirii
            if (goRight)
            {
                buttonsPanel.Location = new Point(buttonsPanel.Location.X + (int) (((float) distance / time)*timer1.Interval), buttonsPanel.Location.Y); ; ; ; ; ; ;
                time_remaining -= timer1.Interval;

                if (time_remaining<=0)
                {
                    buttonsPanel.Location = new Point(buttonsPanel.Location.X + calc_error, buttonsPanel.Location.Y);
                    goRight = false;
                    b_SwipeToRight.Enabled = true;
                    b_SwipeToLeft.Enabled = true;
                }
            }
            if (goLeft)
            {
                buttonsPanel.Location = new Point(buttonsPanel.Location.X - (int)(((float)distance / time) * timer1.Interval), buttonsPanel.Location.Y);
                time_remaining -= timer1.Interval;

                if (time_remaining <= 0)
                {
                    buttonsPanel.Location = new Point(buttonsPanel.Location.X - calc_error, buttonsPanel.Location.Y);
                    goLeft = false;
                    b_SwipeToRight.Enabled = true;
                    b_SwipeToLeft.Enabled = true;
                }
            }
        }

        private void b_SwipeToRight_Click(object sender, EventArgs e)
        {
            goLeft = true;
            b_SwipeToRight.Enabled = false;
            b_SwipeToLeft.Enabled = false;
        }
        private void b_SwipeToLeft_Click(object sender, EventArgs e)
        {
            goRight = true;
            b_SwipeToRight.Enabled = false;
            b_SwipeToLeft.Enabled = false;
        }

        private void b_SituatiaCurenta_Click(object sender, EventArgs e)
        {
            SituatiaCurentaForm scf = new SituatiaCurentaForm(this,dbc.DS.Students[0],dbc.DS.Disciplines);
            scf.Show();
            Hide();
        }

        private void b_Catalog_Click(object sender, EventArgs e)
        {
            CatalogForm ctf = new CatalogForm(this, dbc);
            ctf.Show();
            Hide();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbc.CloseConnection();
        }

        private void b_Editare_Click(object sender, EventArgs e)
        {
            EditareForm ef = new EditareForm(this, dbc);
            ef.Show();
            Hide();
        }

        private void b_Stats_Click(object sender, EventArgs e)
        {
            StudentStats ss = new StudentStats(this,dbc);
            Hide();
            ss.Show();
        }
    }
}

using SchoolSoft.DataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolSoft.MainLogic;

namespace SchoolSoft
{
    public partial class EditareProfesori : Form
    {
        private DBC _dbc;
        private EditareForm _ef;
        public EditareProfesori(EditareForm ef,DBC dbc)
        {
            InitializeComponent();

            _dbc = dbc;
            _ef = ef;
            setUpComboBoxes();
        }

        public void setUpComboBoxes()
        {
            cb_Discipline.Items.Clear();
            cb_Profesori.Items.Clear();

            foreach (Discipline ds in _dbc.DS.Disciplines)
            {
                cb_Discipline.Items.Add(ds);
            }

            foreach (Teacher t in _dbc.DS.Teachers)
            {
                cb_Profesori.Items.Add(t);
            }
        }

        private void EditareProfesori_FormClosing(object sender, FormClosingEventArgs e)
        {
            _ef.Show();
            _ef.Refresh();
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Name = tb_Name.Text;
            teacher.Surname = tb_Surname.Text;
            teacher.Date = dtp_Date.Value;
            teacher.Salary = (float) nud_Salary.Value;
            teacher.Discipline =(Discipline) cb_Discipline.SelectedItem;

            int ID = 0;
            foreach (Teacher t in _dbc.DS.Teachers)
            {
                if (t.ID > ID)
                {
                    ID = t.ID;
                }
            }
            ID += 1;
            teacher.ID = ID;

            try
            {
                _dbc.AddNewTeacher(teacher);
                MessageBox.Show("Profesorul a fost adaugat");
                setUpComboBoxes();
                _ef.setUpTeacherComboBox(); // facem asta pursisimplu ca sa nu apara probleme in viitor
            }
            catch (Exception exp)
            {
                MessageBox.Show("Datele au fost introduse gresit");
            }
        }

        private void b_Delete_Click(object sender, EventArgs e)
        {
            if (cb_Profesori.SelectedItem != null)
            {
                _dbc.DeleteTeacherByID((Teacher)cb_Profesori.SelectedItem);
                MessageBox.Show("Profesorul a fost Sters");
                setUpComboBoxes();
                _ef.setUpTeacherComboBox(); // facem asta pursisimplu ca sa nu apara probleme in viitor
            }
        }
    }
}

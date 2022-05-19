using Microsoft.Reporting.WinForms;
using SchoolSoft.DataBaseConnection;
using SchoolSoft.MainLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        }

        /*
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
        */
        

        private void StudentStats_FormClosing(object sender, FormClosingEventArgs e)
        {
            _menu.Show();
        }

        private void StudentStats_Load(object sender, EventArgs e)
        {
            DataSet _ds = new DataSet();
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlConnection _connection = new SqlConnection(DBC.GetConnectionString("SchoolDB.mdf"));
            _connection.Open();

            string sql_select = "Select StudentName,StudentSurname,TotalAverage from ( /* Calculam media totala */ Select IDStudent,Avg(Average) as TotalAverage from ( Select IDStudent,DisciplineName,AVG(cast(Mark as float)) as Average from ( Select IDStudent,DisciplineName,Mark from DisciplineMarks Join Disciplines On Disciplines.ID = DisciplineMarks.IDDiscipline where Mark != -1 ) as Note Group By IDStudent,DisciplineName ) as Medii Group by IDStudent ) as MediaTotala Join Students ON ID = IDStudent where TotalAverage < 5 Group by StudentName,StudentSurname,TotalAverage Order by StudentName ";
            string sql_select_emin = "Select StudentName,StudentSurname,TotalAverage from ( /* Calculam media totala */ Select IDStudent,Avg(Average) as TotalAverage from ( Select IDStudent,DisciplineName,AVG(cast(Mark as float)) as Average from ( Select IDStudent,DisciplineName,Mark from DisciplineMarks Join Disciplines On Disciplines.ID = DisciplineMarks.IDDiscipline where Mark != -1 ) as Note Group By IDStudent,DisciplineName ) as Medii Group by IDStudent ) as MediaTotala Join Students ON ID = IDStudent where TotalAverage > 5 Group by StudentName,StudentSurname,TotalAverage Order by TotalAverage desc ";
            string sql_select_8med = "Select StudentName,StudentSurname,TotalAverage,MediaTotala.Absences from ( /* Calculam media totala */ Select Medii.IDStudent,Avg(Average) as TotalAverage,Abss.Absences from ( Select IDStudent,DisciplineName,AVG(cast(Mark as float)) as Average from ( Select IDStudent,DisciplineName,Mark from DisciplineMarks Join Disciplines On Disciplines.ID = DisciplineMarks.IDDiscipline where Mark != -1 ) as Note Group By Note.IDStudent,DisciplineName ) as Medii Join ( /* IDStudent Absences */ Select IDStudent,Count(Mark) as Absences from ( /* idStudent -1 */ Select DisciplineMarks.IDStudent,Mark from DisciplineMarks where Mark = -1 ) as Absente Group by Absente.IDStudent ) as Abss On Medii.IDStudent = Abss.IDStudent Group by Medii.IDStudent,Abss.Absences ) as MediaTotala Join Students ON ID = IDStudent where TotalAverage > 8.5 Group by StudentName,StudentSurname,TotalAverage,Absences Order by TotalAverage desc ";
            string sql_select_groups = "Select GroupYear,GroupLetter,Absences,TotalAverage from Groups join ( Select IDGroup,Avg(TotalAverage) as TotalAverage,Sum(Absences)as Absences from ( select IDGroup,TotalAverage,Absences from (Select Medii.IDStudent,Avg(Average) as TotalAverage,Abss.Absences from ( Select IDStudent,DisciplineName,AVG(cast(Mark as float)) as Average from ( Select IDStudent,DisciplineName,Mark from DisciplineMarks Join Disciplines On Disciplines.ID = DisciplineMarks.IDDiscipline where Mark != -1 ) as Note Group By Note.IDStudent,DisciplineName ) as Medii Join ( /* IDStudent Absences */ Select IDStudent,Count(Mark) as Absences from ( /* idStudent -1 */ Select DisciplineMarks.IDStudent,Mark from DisciplineMarks where Mark = -1 ) as Absente Group by Absente.IDStudent ) as Abss On Medii.IDStudent = Abss.IDStudent Group by Medii.IDStudent,Abss.Absences ) as St join Students on Students.ID = IDStudent ) as Grp group by IDGroup ) as Gr ON Groups.ID = Gr.IDGroup Group by GroupYear,GroupLetter,Absences,TotalAverage ";

            // Restantieri :
            SqlCommand command = new SqlCommand(sql_select + sql_select_emin + sql_select_8med + sql_select_groups, _connection);
            _adapter.SelectCommand = command;
            _adapter.Fill(_ds);
            _connection.Close();
            
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1",_ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Add(source);

            reportViewer2.LocalReport.DataSources.Clear();
            source = new ReportDataSource("DataSet1", _ds.Tables[1]);
            reportViewer2.LocalReport.DataSources.Add(source);

            reportViewer3.LocalReport.DataSources.Clear();
            source = new ReportDataSource("DataSet1", _ds.Tables[2]);
            reportViewer3.LocalReport.DataSources.Add(source);

            reportViewer4.LocalReport.DataSources.Clear();
            source = new ReportDataSource("DataSet1", _ds.Tables[3]);
            reportViewer4.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }
    }
}

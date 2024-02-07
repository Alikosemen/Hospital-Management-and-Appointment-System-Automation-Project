using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Hospital_Management_and_Appointment_System_Automation
{
    public partial class FormAssistantDetails : Form
    {
        public FormAssistantDetails()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        public string no;
        private void FormAssistantDetails_Load(object sender, EventArgs e)
        {
            this.Location = new Point(110, 50);
            LblNo.Text = no;

            SqlCommand sqlCommand = new SqlCommand("SELECT AssistantNameSurname FROM Tbl_Assistants WHERE AssistantNo=@p1", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@p1", LblNo.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                LblPerson.Text = reader[0].ToString();
            }
            conn.sql_connection().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT SpecialtyName FROM Tbl_Specialties", conn.sql_connection());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT (DoctorName + ' ' + DoctorSurname) AS Doctor, DoctorSpecialty, DoctorPassword FROM Tbl_Doctors", conn.sql_connection());
            dataAdapter2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            SqlCommand sqlCommand2 = new SqlCommand("SELECT SpecialtyName FROM Tbl_Specialties", conn.sql_connection());
            SqlDataReader reader2 = sqlCommand2.ExecuteReader();
            while (reader2.Read())
            {
                CmbSpecialty.Items.Add(reader2[0].ToString());
            }
            conn.sql_connection().Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand2 = new SqlCommand("INSERT INTO Tbl_Appointments (AppointmentDate, AppointmentTime, AppointmentSpecialty, AppointmentDoctor) VALUES (@r1,@r2,@r3,@r4)", conn.sql_connection());
            sqlCommand2.Parameters.AddWithValue("@r1", MskDate.Text);
            sqlCommand2.Parameters.AddWithValue("@r2", MskTime.Text);
            sqlCommand2.Parameters.AddWithValue("@r3", CmbSpecialty.Text);
            sqlCommand2.Parameters.AddWithValue("@r4", CmbDoctor.Text);
            sqlCommand2.ExecuteNonQuery();
            conn.sql_connection().Close ();
            MessageBox.Show("An appointment has been made");
        }

        private void CmbSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();

            SqlCommand sqlCommand = new SqlCommand("SELECT DoctorName, DoctorSurname FROM Tbl_Doctors WHERE DoctorSpecialty=@p1",conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@p1", CmbSpecialty.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                CmbDoctor.Items.Add(reader[0] + " " + reader[1]);
            }
            conn.sql_connection().Close();
        }

        private void BtnMakeAnnouncements_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Tbl_Announcements (Announcement) VALUES (@a1)", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@a1", RTxtBoxAnnouncements.Text);
            sqlCommand.ExecuteNonQuery();
            conn.sql_connection().Close();
            MessageBox.Show("An announcement has been made");
        }

        private void BtnDoctorPanel_Click(object sender, EventArgs e)
        {
            FormDoctorPanel formDoctorPanel = new FormDoctorPanel();
            formDoctorPanel.Show();

        }

        private void BtnSecialtyPanel_Click(object sender, EventArgs e)
        {
            FormSpecialtyPanel formSpecialtyPanel = new FormSpecialtyPanel();
            formSpecialtyPanel.Show();
        }

        private void BtnAppointmentPanel_Click(object sender, EventArgs e)
        {
            FormAppointmentList formAppointmentList = new FormAppointmentList();
            formAppointmentList.Show();
        }

        private void BtnAnnouncement_Click(object sender, EventArgs e)
        {
            FormAnnouncements formAnnouncements = new FormAnnouncements();
            formAnnouncements.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAssistantLogin formAssistantLogin = new FormAssistantLogin();
            formAssistantLogin.Show();
            this.Hide();
        }
    }
}

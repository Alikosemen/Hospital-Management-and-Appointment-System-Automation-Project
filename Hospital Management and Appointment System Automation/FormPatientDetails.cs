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

namespace Hospital_Management_and_Appointment_System_Automation
{
    public partial class FormPatientDetails : Form
    {
        public FormPatientDetails()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        public string no;
        private void FormPatientDetails_Load(object sender, EventArgs e)
        {
            this.Location = new Point(240, 50);
            LblNo.Text = no;

            SqlCommand sqlCommand = new SqlCommand("SELECT PatientName, PatientSurname FROM Tbl_Patients WHERE PatientNo=@p1", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@p1", LblNo.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read()) 
            {
                LblPerson.Text = reader[0] + " " + reader[1];
            }
            conn.sql_connection().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Tbl_Appointments WHERE PatientNo=" + no, conn.sql_connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand sqlCommand2 = new SqlCommand("SELECT SpecialtyName FROM Tbl_Specialties", conn.sql_connection());
            SqlDataReader reader2 = sqlCommand2.ExecuteReader();
            while (reader2.Read()) 
            {
                CmbSpecialty.Items.Add(reader2[0]);
            }
            conn.sql_connection().Close();
        }

        private void CmbSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();

            SqlCommand sqlCommand3 = new SqlCommand("SELECT DoctorName, DoctorSurname FROM Tbl_Doctors WHERE DoctorSpecialty=@p1", conn.sql_connection());
            sqlCommand3.Parameters.AddWithValue("@p1", CmbSpecialty.Text);
            SqlDataReader reader3 = sqlCommand3.ExecuteReader();
            while (reader3.Read())
            {
                CmbDoctor.Items.Add(reader3[0] + " " + reader3[1]);
            }
            conn.sql_connection().Close();
        }

        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Tbl_Appointments WHERE AppointmentSpecialty='" + CmbSpecialty.Text + "'" + " AND AppointmentDoctor='" + CmbDoctor.Text + "' AND AppointmentStatus=0", conn.sql_connection());
            sqlDataAdapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkEditYourInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormEditPatientInfo formEditPatientInfo = new FormEditPatientInfo();
            formEditPatientInfo.no = LblNo.Text;
            formEditPatientInfo.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int clicked = dataGridView2.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView2.Rows[clicked].Cells[0].Value.ToString();
        }

        private void BtnMakeAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Tbl_Appointments SET AppointmentStatus=1, PatientNo=@p1, PatientComplaint=@p2 WHERE AppointmentId=@p3", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@p1", LblNo.Text);
            sqlCommand.Parameters.AddWithValue("@p2", RTxtComplaint.Text);
            sqlCommand.Parameters.AddWithValue("@p3", TxtId.Text);
            sqlCommand.ExecuteNonQuery();
            conn.sql_connection().Close();
            MessageBox.Show("An appointment has been made");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormPatientLogin formPatientLogin = new FormPatientLogin();
            formPatientLogin.Show();
            this.Hide();
        }
    }
}

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
    public partial class FormDoctorDetails : Form
    {
        public FormDoctorDetails()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        public string no;
        private void FormDoctorDetails_Load(object sender, EventArgs e)
        {
            this.Location = new Point(240, 50);
            LblNo.Text = no;

            SqlCommand sqlCommand = new SqlCommand("SELECT DoctorName, DoctorSurname FROM Tbl_Doctors WHERE DoctorNo=@p1",conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@p1", LblNo.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                LblPerson.Text = reader[0] + " " + reader[1];
            }
            conn.sql_connection().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Tbl_Appointments WHERE AppointmentDoctor='" + LblPerson.Text + "'",conn.sql_connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FormEditDoctorInfo formEditDoctorInfo = new FormEditDoctorInfo();
            formEditDoctorInfo.no = LblNo.Text;
            formEditDoctorInfo.Show();
        }

        private void BtnAnnouncements_Click(object sender, EventArgs e)
        {
            FormAnnouncements formAnnouncements = new FormAnnouncements();
            formAnnouncements.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int clicked = dataGridView1.SelectedCells[0].RowIndex;
            RTxtComplaint.Text = dataGridView1.Rows[clicked].Cells[7].Value.ToString();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormDoctorLogin formDoctorLogin = new FormDoctorLogin();
            formDoctorLogin.Show();
            this.Hide();
        }
    }
}

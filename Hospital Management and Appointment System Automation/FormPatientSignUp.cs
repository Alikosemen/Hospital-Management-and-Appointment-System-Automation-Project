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
    public partial class FormPatientSignUp : Form
    {
        public FormPatientSignUp()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Tbl_Patients (PatientName, PatientSurname, PatientNo, PatientPhoneNumber, PatientPassword, PatientGender) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@p1", TxtName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtSurname.Text);
            sqlCommand.Parameters.AddWithValue("@p3", MskNo.Text);
            sqlCommand.Parameters.AddWithValue("@p4", MskPhoneNumber.Text);
            sqlCommand.Parameters.AddWithValue("@p5", TxtPassword.Text);
            sqlCommand.Parameters.AddWithValue("@p6", CmbGender.Text);
            sqlCommand.ExecuteNonQuery();
            conn.sql_connection().Close();
            MessageBox.Show("Your registration has been completed! Your password: " + TxtPassword.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FormPatientSignUp_Load(object sender, EventArgs e)
        {
            this.Location = new Point(355, 100);
        }

    }
}

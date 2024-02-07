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
    public partial class FormEditPatientInfo : Form
    {
        public FormEditPatientInfo()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        public string no;
        private void FormEditPatientInfo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(770, 280);
            MskNo.Text = no;
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Tbl_Patients WHERE PatientNo=@p1", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@p1", MskNo.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                TxtName.Text = reader[1].ToString();
                TxtSurname.Text = reader[2].ToString();
                MskPhoneNumber.Text = reader[4].ToString();
                TxtPassword.Text = reader[5].ToString();
                CmbGender.Text = reader[6].ToString();
            }
            conn.sql_connection().Close();
        }

        private void BtnUpdateInfo_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand2 = new SqlCommand("UPDATE Tbl_Patients SET PatientName=@p1, PatientSurname=@p2, PatientPhoneNumber=@p3, PatientPassword=@p4, PatientGender=@p5 WHERE PatientNo=@p6", conn.sql_connection());
            sqlCommand2.Parameters.AddWithValue("@p1", TxtName.Text);
            sqlCommand2.Parameters.AddWithValue("@p2", TxtSurname.Text);
            sqlCommand2.Parameters.AddWithValue("@p3", MskPhoneNumber.Text);
            sqlCommand2.Parameters.AddWithValue("@p4", TxtPassword.Text);
            sqlCommand2.Parameters.AddWithValue("@p5", CmbGender.Text);
            sqlCommand2.Parameters.AddWithValue("@p6", MskNo.Text);
            sqlCommand2.ExecuteNonQuery();
            conn.sql_connection().Close ();
            MessageBox.Show("Your information has been updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     
    }
}

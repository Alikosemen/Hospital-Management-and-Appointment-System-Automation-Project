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
    public partial class FormEditDoctorInfo : Form
    {
        public FormEditDoctorInfo()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        public string no;
        private void FormEditDoctorInfo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(650, 200);
            MskNo.Text = no;

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Tbl_Doctors WHERE DoctorNo=@p1", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@p1", MskNo.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                TxtName.Text = reader[1].ToString();
                TxtSurname.Text = reader[2].ToString();
                CmbSpecialty.Text = reader[3].ToString();
                TxtPassword.Text = reader[5].ToString();
            }
            conn.sql_connection().Close();
        }

        private void BtnUpdateInfo_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Tbl_Doctors SET DoctorName=@p1, DoctorSurname=@p2, DoctorSpecialty=@p3, DoctorPassword=@p4 WHERE DoctorNo=@p5", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@p1", TxtName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtSurname.Text);
            sqlCommand.Parameters.AddWithValue("@p3", CmbSpecialty.Text);
            sqlCommand.Parameters.AddWithValue("@p4", TxtPassword.Text);
            sqlCommand.Parameters.AddWithValue("@p5", MskNo.Text);
            sqlCommand.ExecuteNonQuery();
            conn.sql_connection().Close();
            MessageBox.Show("Your information has been updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

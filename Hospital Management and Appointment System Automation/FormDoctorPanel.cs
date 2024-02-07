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
    public partial class FormDoctorPanel : Form
    {
        public FormDoctorPanel()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void FormDoctorPanel_Load(object sender, EventArgs e)
        {
            this.Location = new Point(170, 150);
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Tbl_Doctors", conn.sql_connection());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand sqlCommand = new SqlCommand("SELECT SpecialtyName FROM Tbl_Specialties", conn.sql_connection());
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                CmbSpecialty.Items.Add(reader[0].ToString());
            }
            conn.sql_connection().Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Tbl_Doctors (DoctorName, DoctorSurname, DoctorSpecialty, DoctorNo, DoctorPassword) VALUES (@d1,@d2,@d3,@d4,@d5)", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@d1", TxtName.Text);
            sqlCommand.Parameters.AddWithValue("@d2", TxtSurname.Text);
            sqlCommand.Parameters.AddWithValue("@d3", CmbSpecialty.Text);
            sqlCommand.Parameters.AddWithValue("@d4", MskNo.Text);
            sqlCommand.Parameters.AddWithValue("@d5", TxtPassword.Text);
            sqlCommand.ExecuteNonQuery();
            conn.sql_connection().Close();
            MessageBox.Show("Doctor has been added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int clicked = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[clicked].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[clicked].Cells[2].Value.ToString();
            CmbSpecialty.Text = dataGridView1.Rows[clicked].Cells[3].Value.ToString();
            MskNo.Text = dataGridView1.Rows[clicked].Cells[4].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[clicked].Cells[5].Value.ToString();

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Tbl_Doctors WHERE DoctorNo=@p1", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@p1", MskNo.Text);
            sqlCommand.ExecuteNonQuery();
            conn.sql_connection().Close();
            MessageBox.Show("User record has been deleted!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Tbl_Doctors SET DoctorName=@d1, DoctorSurname=@d2, DoctorSpecialty=@d3, DoctorPassword=@d5 WHERE  DoctorNo=@d4", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@d1", TxtName.Text);
            sqlCommand.Parameters.AddWithValue("@d2", TxtSurname.Text);
            sqlCommand.Parameters.AddWithValue("@d3", CmbSpecialty.Text);
            sqlCommand.Parameters.AddWithValue("@d4", MskNo.Text);
            sqlCommand.Parameters.AddWithValue("@d5", TxtPassword.Text);
            sqlCommand.ExecuteNonQuery();
            conn.sql_connection().Close();
            MessageBox.Show("Doctor information has been updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

  
    }
}

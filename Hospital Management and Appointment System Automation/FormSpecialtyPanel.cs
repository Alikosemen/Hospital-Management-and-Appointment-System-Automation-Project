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
using System.Xml.Linq;

namespace Hospital_Management_and_Appointment_System_Automation
{
    public partial class FormSpecialtyPanel : Form
    {
        public FormSpecialtyPanel()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void FormSpecialtyPanel_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 285);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Tbl_Specialties", conn.sql_connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Tbl_Specialties (SpecialtyName) VALUES (@s1)", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@s1", TxtSpecialty.Text);
            sqlCommand.ExecuteNonQuery();
            conn.sql_connection().Close();
            MessageBox.Show("A new specialty has been added");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int clicked = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[clicked].Cells[0].Value.ToString();
            TxtSpecialty.Text = dataGridView1.Rows[clicked].Cells[1].Value.ToString();

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Tbl_Specialties WHERE SpecialtyId=@p1", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@p1", TxtId.Text);
            sqlCommand.ExecuteNonQuery();
            conn.sql_connection().Close();
            MessageBox.Show("A specialty has been deleted!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE Tbl_Specialties SET SpecialtyName=@p1 WHERE SpecialtyId=@p2", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@p1", TxtSpecialty.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtId.Text);
            sqlCommand.ExecuteNonQuery();
            conn.sql_connection().Close();
            MessageBox.Show("A specialty has been updated");
        }

    }
}

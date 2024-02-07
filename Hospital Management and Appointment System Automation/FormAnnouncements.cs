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
    public partial class FormAnnouncements : Form
    {
        public FormAnnouncements()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void FormAnnouncements_Load(object sender, EventArgs e)
        {
            this.Location = new Point(95, 75);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Tbl_Announcements", conn.sql_connection());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

   
    }
}

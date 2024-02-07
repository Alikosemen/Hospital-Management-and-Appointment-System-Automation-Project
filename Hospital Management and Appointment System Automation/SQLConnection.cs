using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Hospital_Management_and_Appointment_System_Automation
{
    internal class SQLConnection
    {
        public SqlConnection sql_connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=Your-MSSQL-Server-Name\\;Initial Catalog=\"Hospital Management and Appointment System Automation\";Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}

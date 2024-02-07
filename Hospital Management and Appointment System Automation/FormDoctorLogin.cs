﻿using System;
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
    public partial class FormDoctorLogin : Form
    {
        public FormDoctorLogin()
        {
            InitializeComponent();
        }

        SQLConnection conn = new SQLConnection();

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Tbl_Doctors WHERE DoctorNo=@p1 AND DoctorPassword=@p2", conn.sql_connection());
            sqlCommand.Parameters.AddWithValue("@p1", MskNo.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                FormDoctorDetails formDoctorDetails = new FormDoctorDetails();
                formDoctorDetails.no = MskNo.Text;
                formDoctorDetails.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Doctor No or Password!", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.sql_connection().Close();  
        }

        private void FormDoctorLogin_Load(object sender, EventArgs e)
        {
            this.Location = new Point(355, 100);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormLogins formLogins = new FormLogins();
            formLogins.Show();
            this.Hide();
        }
    }
}

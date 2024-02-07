using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_and_Appointment_System_Automation
{
    public partial class FormLogins : Form
    {
        public FormLogins()
        {
            InitializeComponent();
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            FormPatientLogin formPatientLogin = new FormPatientLogin();
            formPatientLogin.Show();
            this.Hide();
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            FormDoctorLogin formDoctorLogin = new FormDoctorLogin();
            formDoctorLogin.Show();
            this.Hide();
        }

        private void BtnAssistant_Click(object sender, EventArgs e)
        {
            FormAssistantLogin formAssistantLogin = new FormAssistantLogin();
            formAssistantLogin.Show();
            this.Hide();
        }

        private void FormLogins_Load(object sender, EventArgs e)
        {
            this.Location = new Point(355, 100);
        }
    }
}

namespace Hospital_Management_and_Appointment_System_Automation
{
    partial class FormEditDoctorInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditDoctorInfo));
            this.MskNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbSpecialty = new System.Windows.Forms.ComboBox();
            this.BtnUpdateInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MskNo
            // 
            this.MskNo.Location = new System.Drawing.Point(155, 129);
            this.MskNo.Mask = "00000000000";
            this.MskNo.Name = "MskNo";
            this.MskNo.Size = new System.Drawing.Size(133, 29);
            this.MskNo.TabIndex = 27;
            this.MskNo.ValidatingType = typeof(int);
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(155, 94);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(133, 29);
            this.TxtSurname.TabIndex = 26;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(155, 59);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(133, 29);
            this.TxtName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(155, 202);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(133, 29);
            this.TxtPassword.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Specialty:";
            // 
            // CmbSpecialty
            // 
            this.CmbSpecialty.FormattingEnabled = true;
            this.CmbSpecialty.Location = new System.Drawing.Point(155, 164);
            this.CmbSpecialty.Name = "CmbSpecialty";
            this.CmbSpecialty.Size = new System.Drawing.Size(133, 32);
            this.CmbSpecialty.TabIndex = 31;
            // 
            // BtnUpdateInfo
            // 
            this.BtnUpdateInfo.BackColor = System.Drawing.Color.Tomato;
            this.BtnUpdateInfo.Location = new System.Drawing.Point(155, 238);
            this.BtnUpdateInfo.Name = "BtnUpdateInfo";
            this.BtnUpdateInfo.Size = new System.Drawing.Size(133, 57);
            this.BtnUpdateInfo.TabIndex = 32;
            this.BtnUpdateInfo.Text = "Update Information";
            this.BtnUpdateInfo.UseVisualStyleBackColor = false;
            this.BtnUpdateInfo.Click += new System.EventHandler(this.BtnUpdateInfo_Click);
            // 
            // FormEditDoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(341, 331);
            this.Controls.Add(this.BtnUpdateInfo);
            this.Controls.Add(this.CmbSpecialty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MskNo);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormEditDoctorInfo";
            this.Text = "Edit Doctor Information";
            this.Load += new System.EventHandler(this.FormEditDoctorInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MskNo;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbSpecialty;
        private System.Windows.Forms.Button BtnUpdateInfo;
    }
}
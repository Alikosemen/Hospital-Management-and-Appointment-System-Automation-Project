namespace Hospital_Management_and_Appointment_System_Automation
{
    partial class FormLogins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogins));
            this.BtnDoctor = new System.Windows.Forms.Button();
            this.BtnAssistant = new System.Windows.Forms.Button();
            this.BtnPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDoctor
            // 
            this.BtnDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoctor.BackgroundImage")));
            this.BtnDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoctor.Location = new System.Drawing.Point(226, 236);
            this.BtnDoctor.Name = "BtnDoctor";
            this.BtnDoctor.Size = new System.Drawing.Size(179, 156);
            this.BtnDoctor.TabIndex = 1;
            this.BtnDoctor.UseVisualStyleBackColor = true;
            this.BtnDoctor.Click += new System.EventHandler(this.BtnDoctor_Click);
            // 
            // BtnAssistant
            // 
            this.BtnAssistant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAssistant.BackgroundImage")));
            this.BtnAssistant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAssistant.Location = new System.Drawing.Point(411, 236);
            this.BtnAssistant.Name = "BtnAssistant";
            this.BtnAssistant.Size = new System.Drawing.Size(179, 156);
            this.BtnAssistant.TabIndex = 2;
            this.BtnAssistant.UseVisualStyleBackColor = true;
            this.BtnAssistant.Click += new System.EventHandler(this.BtnAssistant_Click);
            // 
            // BtnPatient
            // 
            this.BtnPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPatient.BackgroundImage")));
            this.BtnPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPatient.Location = new System.Drawing.Point(41, 236);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Size = new System.Drawing.Size(179, 156);
            this.BtnPatient.TabIndex = 0;
            this.BtnPatient.UseVisualStyleBackColor = true;
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Assistant";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vivaldi", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "Heart Rhythm Hospital";
            // 
            // FormLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(626, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAssistant);
            this.Controls.Add(this.BtnDoctor);
            this.Controls.Add(this.BtnPatient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormLogins";
            this.Text = "Hospital Automation System Main Page";
            this.Load += new System.EventHandler(this.FormLogins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDoctor;
        private System.Windows.Forms.Button BtnAssistant;
        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}


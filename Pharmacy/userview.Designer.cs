namespace Pharmacy
{
    partial class userview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userview));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.expecience = new System.Windows.Forms.Label();
            this.education = new System.Windows.Forms.Label();
            this.date_of_birth = new System.Windows.Forms.TextBox();
            this.contact_number = new System.Windows.Forms.TextBox();
            this.experience = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Number";
            // 
            // expecience
            // 
            this.expecience.AutoSize = true;
            this.expecience.Location = new System.Drawing.Point(322, 279);
            this.expecience.Name = "expecience";
            this.expecience.Size = new System.Drawing.Size(88, 20);
            this.expecience.TabIndex = 2;
            this.expecience.Text = "Experience";
            // 
            // education
            // 
            this.education.AutoSize = true;
            this.education.Location = new System.Drawing.Point(322, 327);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(81, 20);
            this.education.TabIndex = 3;
            this.education.Text = "Education";
            // 
            // date_of_birth
            // 
            this.date_of_birth.BackColor = System.Drawing.Color.Red;
            this.date_of_birth.Location = new System.Drawing.Point(326, 198);
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.Size = new System.Drawing.Size(267, 26);
            this.date_of_birth.TabIndex = 4;
            // 
            // contact_number
            // 
            this.contact_number.BackColor = System.Drawing.Color.Red;
            this.contact_number.Location = new System.Drawing.Point(326, 255);
            this.contact_number.Name = "contact_number";
            this.contact_number.Size = new System.Drawing.Size(267, 26);
            this.contact_number.TabIndex = 5;
            // 
            // experience
            // 
            this.experience.BackColor = System.Drawing.Color.Red;
            this.experience.Location = new System.Drawing.Point(326, 302);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(267, 26);
            this.experience.TabIndex = 6;
            this.experience.TextChanged += new System.EventHandler(this.experience_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Red;
            this.textBox4.Location = new System.Drawing.Point(326, 350);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(267, 26);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(362, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources.Icons_Land_Vista_People_Medical_Nurse_Male_Light_256;
            this.pictureBox1.Location = new System.Drawing.Point(105, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(326, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // userview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 474);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.experience);
            this.Controls.Add(this.contact_number);
            this.Controls.Add(this.date_of_birth);
            this.Controls.Add(this.education);
            this.Controls.Add(this.expecience);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "userview";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.userview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label expecience;
        private System.Windows.Forms.Label education;
        private System.Windows.Forms.TextBox date_of_birth;
        private System.Windows.Forms.TextBox contact_number;
        private System.Windows.Forms.TextBox experience;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
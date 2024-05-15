namespace Pharmacy
{
    partial class Profile_management
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
            this.number3 = new System.Windows.Forms.TextBox();
            this.birth3 = new System.Windows.Forms.TextBox();
            this.name3 = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.date_b3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.Color.Red;
            this.number3.Location = new System.Drawing.Point(312, 278);
            this.number3.Multiline = true;
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(338, 36);
            this.number3.TabIndex = 42;
            // 
            // birth3
            // 
            this.birth3.BackColor = System.Drawing.Color.Red;
            this.birth3.Location = new System.Drawing.Point(312, 228);
            this.birth3.Multiline = true;
            this.birth3.Name = "birth3";
            this.birth3.Size = new System.Drawing.Size(338, 36);
            this.birth3.TabIndex = 41;
            // 
            // name3
            // 
            this.name3.BackColor = System.Drawing.Color.Red;
            this.name3.Location = new System.Drawing.Point(312, 176);
            this.name3.Multiline = true;
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(338, 36);
            this.name3.TabIndex = 40;
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Location = new System.Drawing.Point(308, 261);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(125, 20);
            this.contact.TabIndex = 39;
            this.contact.Text = "Contact Number";
            // 
            // date_b3
            // 
            this.date_b3.AutoSize = true;
            this.date_b3.Location = new System.Drawing.Point(308, 209);
            this.date_b3.Name = "date_b3";
            this.date_b3.Size = new System.Drawing.Size(99, 20);
            this.date_b3.TabIndex = 38;
            this.date_b3.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Pharmacist Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources.Icons_Land_Vista_People_Medical_Nurse_Male_Light_256;
            this.pictureBox1.Location = new System.Drawing.Point(65, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(370, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 56);
            this.button1.TabIndex = 43;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Profile_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.birth3);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.date_b3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Profile_management";
            this.Text = "Profile_management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number3;
        private System.Windows.Forms.TextBox birth3;
        private System.Windows.Forms.TextBox name3;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label date_b3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
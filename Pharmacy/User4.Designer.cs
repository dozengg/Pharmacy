namespace Pharmacy
{
    partial class User4
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
            this.number4 = new System.Windows.Forms.TextBox();
            this.birth4 = new System.Windows.Forms.TextBox();
            this.name4 = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.date_b3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // number4
            // 
            this.number4.BackColor = System.Drawing.Color.Red;
            this.number4.Location = new System.Drawing.Point(316, 254);
            this.number4.Multiline = true;
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(338, 36);
            this.number4.TabIndex = 47;
            this.number4.TextChanged += new System.EventHandler(this.number3_TextChanged);
            // 
            // birth4
            // 
            this.birth4.BackColor = System.Drawing.Color.Red;
            this.birth4.Location = new System.Drawing.Point(316, 204);
            this.birth4.Multiline = true;
            this.birth4.Name = "birth4";
            this.birth4.Size = new System.Drawing.Size(338, 36);
            this.birth4.TabIndex = 46;
            // 
            // name4
            // 
            this.name4.BackColor = System.Drawing.Color.Red;
            this.name4.Location = new System.Drawing.Point(316, 152);
            this.name4.Multiline = true;
            this.name4.Name = "name4";
            this.name4.Size = new System.Drawing.Size(338, 36);
            this.name4.TabIndex = 45;
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Location = new System.Drawing.Point(312, 237);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(125, 20);
            this.contact.TabIndex = 42;
            this.contact.Text = "Contact Number";
            // 
            // date_b3
            // 
            this.date_b3.AutoSize = true;
            this.date_b3.Location = new System.Drawing.Point(312, 185);
            this.date_b3.Name = "date_b3";
            this.date_b3.Size = new System.Drawing.Size(99, 20);
            this.date_b3.TabIndex = 41;
            this.date_b3.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Pharmacist Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(406, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 47);
            this.button1.TabIndex = 39;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources.Icons_Land_Vista_People_Medical_Nurse_Male_Light_256;
            this.pictureBox1.Location = new System.Drawing.Point(69, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // User4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 474);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.birth4);
            this.Controls.Add(this.name4);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.date_b3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "User4";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.User4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox number4;
        private System.Windows.Forms.TextBox birth4;
        private System.Windows.Forms.TextBox name4;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label date_b3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
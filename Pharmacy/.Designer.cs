namespace Pharmacy
{
    partial class Form1
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.contact2 = new System.Windows.Forms.Label();
            this.date_b1 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Red;
            this.textBox3.Location = new System.Drawing.Point(316, 254);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(338, 36);
            this.textBox3.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(316, 204);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 36);
            this.textBox2.TabIndex = 34;
            // 
            // name2
            // 
            this.name2.BackColor = System.Drawing.Color.Red;
            this.name2.Location = new System.Drawing.Point(316, 152);
            this.name2.Multiline = true;
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(338, 36);
            this.name2.TabIndex = 33;
            // 
            // contact2
            // 
            this.contact2.AutoSize = true;
            this.contact2.Location = new System.Drawing.Point(312, 237);
            this.contact2.Name = "contact2";
            this.contact2.Size = new System.Drawing.Size(125, 20);
            this.contact2.TabIndex = 30;
            this.contact2.Text = "Contact Number";
            // 
            // date_b1
            // 
            this.date_b1.AutoSize = true;
            this.date_b1.Location = new System.Drawing.Point(312, 185);
            this.date_b1.Name = "date_b1";
            this.date_b1.Size = new System.Drawing.Size(99, 20);
            this.date_b1.TabIndex = 29;
            this.date_b1.Text = "Date of Birth";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Location = new System.Drawing.Point(312, 125);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(134, 20);
            this.name1.TabIndex = 28;
            this.name1.Text = "Pharmacist Name";
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Red;
            this.confirm.Location = new System.Drawing.Point(392, 332);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(159, 47);
            this.confirm.TabIndex = 27;
            this.confirm.Text = "confirm";
            this.confirm.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources.Icons_Land_Vista_People_Medical_Nurse_Male_Light_256;
            this.pictureBox1.Location = new System.Drawing.Point(69, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 474);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.contact2);
            this.Controls.Add(this.date_b1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.Label contact2;
        private System.Windows.Forms.Label date_b1;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
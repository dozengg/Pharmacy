namespace Pharmacy
{
    partial class mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmenu));
            this.adduser = new System.Windows.Forms.Button();
            this.viewuser = new System.Windows.Forms.Button();
            this.profilemanagement = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adduser
            // 
            this.adduser.BackColor = System.Drawing.Color.Red;
            this.adduser.Location = new System.Drawing.Point(181, 257);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(174, 49);
            this.adduser.TabIndex = 0;
            this.adduser.Text = "Add User";
            this.adduser.UseVisualStyleBackColor = false;
            this.adduser.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewuser
            // 
            this.viewuser.BackColor = System.Drawing.Color.Red;
            this.viewuser.Location = new System.Drawing.Point(496, 251);
            this.viewuser.Name = "viewuser";
            this.viewuser.Size = new System.Drawing.Size(174, 49);
            this.viewuser.TabIndex = 1;
            this.viewuser.Text = "View User";
            this.viewuser.UseVisualStyleBackColor = false;
            this.viewuser.Click += new System.EventHandler(this.button2_Click);
            // 
            // profilemanagement
            // 
            this.profilemanagement.BackColor = System.Drawing.Color.Red;
            this.profilemanagement.Location = new System.Drawing.Point(313, 328);
            this.profilemanagement.Name = "profilemanagement";
            this.profilemanagement.Size = new System.Drawing.Size(227, 49);
            this.profilemanagement.TabIndex = 2;
            this.profilemanagement.Text = "Profile Management";
            this.profilemanagement.UseVisualStyleBackColor = false;
            this.profilemanagement.Click += new System.EventHandler(this.button3_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Location = new System.Drawing.Point(341, 389);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(174, 49);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(284, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "Main Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(293, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.profilemanagement);
            this.Controls.Add(this.viewuser);
            this.Controls.Add(this.adduser);
            this.Name = "mainmenu";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adduser;
        private System.Windows.Forms.Button viewuser;
        private System.Windows.Forms.Button profilemanagement;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

namespace CSharp_Exam
{
    partial class RegistrationForm
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
            this.lExit = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbUserNameRegistration = new System.Windows.Forms.TextBox();
            this.tbPassRegistration = new System.Windows.Forms.TextBox();
            this.tbPassConfirmRegistration = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lExit
            // 
            this.lExit.AutoSize = true;
            this.lExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(212)))), ((int)(((byte)(227)))));
            this.lExit.Location = new System.Drawing.Point(124, 410);
            this.lExit.Name = "lExit";
            this.lExit.Size = new System.Drawing.Size(41, 20);
            this.lExit.TabIndex = 0;
            this.lExit.Text = "Exit";
            this.lExit.Click += new System.EventHandler(this.lExit_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(26, 365);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(236, 33);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(26, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(26, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(26, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 2;
            // 
            // tbUserNameRegistration
            // 
            this.tbUserNameRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserNameRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserNameRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.tbUserNameRegistration.Location = new System.Drawing.Point(26, 189);
            this.tbUserNameRegistration.Multiline = true;
            this.tbUserNameRegistration.Name = "tbUserNameRegistration";
            this.tbUserNameRegistration.Size = new System.Drawing.Size(236, 24);
            this.tbUserNameRegistration.TabIndex = 8;
            this.tbUserNameRegistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUserNameRegistration.Click += new System.EventHandler(this.tbUserNameRegistration_Click);
            this.tbUserNameRegistration.Leave += new System.EventHandler(this.tbUserNameRegistration_Leave);
            // 
            // tbPassRegistration
            // 
            this.tbPassRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.tbPassRegistration.Location = new System.Drawing.Point(26, 249);
            this.tbPassRegistration.Multiline = true;
            this.tbPassRegistration.Name = "tbPassRegistration";
            this.tbPassRegistration.Size = new System.Drawing.Size(236, 24);
            this.tbPassRegistration.TabIndex = 9;
            this.tbPassRegistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassRegistration.Click += new System.EventHandler(this.tbPassRegistration_Click);
            this.tbPassRegistration.Leave += new System.EventHandler(this.tbPassRegistration_Leave);
            // 
            // tbPassConfirmRegistration
            // 
            this.tbPassConfirmRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassConfirmRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassConfirmRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.tbPassConfirmRegistration.Location = new System.Drawing.Point(26, 309);
            this.tbPassConfirmRegistration.Multiline = true;
            this.tbPassConfirmRegistration.Name = "tbPassConfirmRegistration";
            this.tbPassConfirmRegistration.Size = new System.Drawing.Size(236, 24);
            this.tbPassConfirmRegistration.TabIndex = 10;
            this.tbPassConfirmRegistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassConfirmRegistration.Click += new System.EventHandler(this.tbPassConfirmRegistration_Click);
            this.tbPassConfirmRegistration.Leave += new System.EventHandler(this.tbPassConfirmRegistration_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSharp_Exam.Properties.Resources.registration;
            this.pictureBox1.Location = new System.Drawing.Point(95, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 439);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPassConfirmRegistration);
            this.Controls.Add(this.tbPassRegistration);
            this.Controls.Add(this.tbUserNameRegistration);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.Click += new System.EventHandler(this.RegistrationForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lExit;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbUserNameRegistration;
        private System.Windows.Forms.TextBox tbPassRegistration;
        private System.Windows.Forms.TextBox tbPassConfirmRegistration;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
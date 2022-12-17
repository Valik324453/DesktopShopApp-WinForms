
namespace CSharp_Exam
{
    partial class ListItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTitle = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.lCost = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Location = new System.Drawing.Point(282, 35);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(35, 17);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Title";
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(29, 35);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(192, 160);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 2;
            this.pbIcon.TabStop = false;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(282, 108);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(79, 17);
            this.lDescription.TabIndex = 3;
            this.lDescription.Text = "Description";
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.Location = new System.Drawing.Point(282, 178);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(36, 17);
            this.lCost.TabIndex = 3;
            this.lCost.Text = "Cost";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(468, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pbIcon);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 229);
            this.panel1.TabIndex = 5;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(691, 35);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(19, 17);
            this.lId.TabIndex = 6;
            this.lId.Text = "Id";
            // 
            // ListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lCost);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lTitle);
            this.Name = "ListItems";
            this.Size = new System.Drawing.Size(777, 229);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Label lCost;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lId;
    }
}

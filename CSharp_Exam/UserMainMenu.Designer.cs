
namespace CSharp_Exam
{
    partial class UserMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetNewPicture = new System.Windows.Forms.Button();
            this.tbCost = new System.Windows.Forms.NumericUpDown();
            this.tbNewCost = new System.Windows.Forms.NumericUpDown();
            this.pbSetNewPic = new System.Windows.Forms.PictureBox();
            this.lWrongIdToUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbNewDescription = new System.Windows.Forms.TextBox();
            this.tbNewTitle = new System.Windows.Forms.TextBox();
            this.cbPicture = new System.Windows.Forms.CheckBox();
            this.cbDescription = new System.Windows.Forms.CheckBox();
            this.cbCost = new System.Windows.Forms.CheckBox();
            this.cbTitle = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIdToUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdToDelete = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefreshItemsList = new System.Windows.Forms.Button();
            this.bAddNewItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbSetPic = new System.Windows.Forms.PictureBox();
            this.flpItemsList = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.scSortOptions = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAscDesc = new System.Windows.Forms.CheckBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetNewPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetPic)).BeginInit();
            this.flpItemsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1337, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnSetNewPicture);
            this.panel1.Controls.Add(this.tbCost);
            this.panel1.Controls.Add(this.tbNewCost);
            this.panel1.Controls.Add(this.pbSetNewPic);
            this.panel1.Controls.Add(this.lWrongIdToUpdate);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.tbNewDescription);
            this.panel1.Controls.Add(this.tbNewTitle);
            this.panel1.Controls.Add(this.cbPicture);
            this.panel1.Controls.Add(this.cbDescription);
            this.panel1.Controls.Add(this.cbCost);
            this.panel1.Controls.Add(this.cbTitle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbIdToUpdate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnDeleteItem);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbIdToDelete);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRefreshItemsList);
            this.panel1.Controls.Add(this.bAddNewItem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pbSetPic);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 602);
            this.panel1.TabIndex = 1;
            // 
            // btnSetNewPicture
            // 
            this.btnSetNewPicture.Enabled = false;
            this.btnSetNewPicture.Location = new System.Drawing.Point(143, 543);
            this.btnSetNewPicture.Name = "btnSetNewPicture";
            this.btnSetNewPicture.Size = new System.Drawing.Size(214, 23);
            this.btnSetNewPicture.TabIndex = 21;
            this.btnSetNewPicture.Text = "Set New Picture";
            this.btnSetNewPicture.UseVisualStyleBackColor = true;
            this.btnSetNewPicture.Click += new System.EventHandler(this.btnSetNewPicture_Click);
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(213, 58);
            this.tbCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(144, 22);
            this.tbCost.TabIndex = 20;
            // 
            // tbNewCost
            // 
            this.tbNewCost.Enabled = false;
            this.tbNewCost.Location = new System.Drawing.Point(143, 492);
            this.tbNewCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbNewCost.Name = "tbNewCost";
            this.tbNewCost.Size = new System.Drawing.Size(138, 22);
            this.tbNewCost.TabIndex = 20;
            this.tbNewCost.ValueChanged += new System.EventHandler(this.tbNewCost_ValueChanged);
            // 
            // pbSetNewPic
            // 
            this.pbSetNewPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSetNewPic.Image = global::CSharp_Exam.Properties.Resources.placeholder;
            this.pbSetNewPic.Location = new System.Drawing.Point(287, 470);
            this.pbSetNewPic.Name = "pbSetNewPic";
            this.pbSetNewPic.Size = new System.Drawing.Size(70, 66);
            this.pbSetNewPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSetNewPic.TabIndex = 19;
            this.pbSetNewPic.TabStop = false;
            // 
            // lWrongIdToUpdate
            // 
            this.lWrongIdToUpdate.AutoSize = true;
            this.lWrongIdToUpdate.Location = new System.Drawing.Point(236, 424);
            this.lWrongIdToUpdate.Name = "lWrongIdToUpdate";
            this.lWrongIdToUpdate.Size = new System.Drawing.Size(0, 17);
            this.lWrongIdToUpdate.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(126, 570);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbNewDescription
            // 
            this.tbNewDescription.Enabled = false;
            this.tbNewDescription.Location = new System.Drawing.Point(143, 514);
            this.tbNewDescription.Name = "tbNewDescription";
            this.tbNewDescription.Size = new System.Drawing.Size(138, 22);
            this.tbNewDescription.TabIndex = 16;
            this.tbNewDescription.TextChanged += new System.EventHandler(this.tbNewDescription_TextChanged);
            // 
            // tbNewTitle
            // 
            this.tbNewTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewTitle.Enabled = false;
            this.tbNewTitle.Location = new System.Drawing.Point(143, 468);
            this.tbNewTitle.Name = "tbNewTitle";
            this.tbNewTitle.Size = new System.Drawing.Size(138, 22);
            this.tbNewTitle.TabIndex = 16;
            this.tbNewTitle.TextChanged += new System.EventHandler(this.tbNewTitle_TextChanged);
            // 
            // cbPicture
            // 
            this.cbPicture.AutoSize = true;
            this.cbPicture.Location = new System.Drawing.Point(43, 543);
            this.cbPicture.Name = "cbPicture";
            this.cbPicture.Size = new System.Drawing.Size(74, 21);
            this.cbPicture.TabIndex = 15;
            this.cbPicture.Text = "Picture";
            this.cbPicture.UseVisualStyleBackColor = true;
            this.cbPicture.CheckedChanged += new System.EventHandler(this.cbPicture_CheckedChanged);
            // 
            // cbDescription
            // 
            this.cbDescription.AutoSize = true;
            this.cbDescription.Location = new System.Drawing.Point(43, 516);
            this.cbDescription.Name = "cbDescription";
            this.cbDescription.Size = new System.Drawing.Size(101, 21);
            this.cbDescription.TabIndex = 15;
            this.cbDescription.Text = "Description";
            this.cbDescription.UseVisualStyleBackColor = true;
            this.cbDescription.CheckedChanged += new System.EventHandler(this.cbDescription_CheckedChanged);
            // 
            // cbCost
            // 
            this.cbCost.AutoSize = true;
            this.cbCost.Location = new System.Drawing.Point(43, 493);
            this.cbCost.Name = "cbCost";
            this.cbCost.Size = new System.Drawing.Size(58, 21);
            this.cbCost.TabIndex = 15;
            this.cbCost.Text = "Cost";
            this.cbCost.UseVisualStyleBackColor = true;
            this.cbCost.CheckedChanged += new System.EventHandler(this.cbCost_CheckedChanged);
            // 
            // cbTitle
            // 
            this.cbTitle.AutoSize = true;
            this.cbTitle.Location = new System.Drawing.Point(43, 470);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(57, 21);
            this.cbTitle.TabIndex = 15;
            this.cbTitle.Text = "Title";
            this.cbTitle.UseVisualStyleBackColor = true;
            this.cbTitle.CheckedChanged += new System.EventHandler(this.cbTitle_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "and select at least one of the following:";
            // 
            // tbIdToUpdate
            // 
            this.tbIdToUpdate.Location = new System.Drawing.Point(183, 419);
            this.tbIdToUpdate.Name = "tbIdToUpdate";
            this.tbIdToUpdate.Size = new System.Drawing.Size(46, 22);
            this.tbIdToUpdate.TabIndex = 13;
            this.tbIdToUpdate.Click += new System.EventHandler(this.tbIdToUpdate_Click);
            this.tbIdToUpdate.TextChanged += new System.EventHandler(this.tbIdToUpdate_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "To Update select ID:";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(287, 380);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(58, 23);
            this.btnDeleteItem.TabIndex = 11;
            this.btnDeleteItem.Text = "delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "and press";
            // 
            // tbIdToDelete
            // 
            this.tbIdToDelete.Location = new System.Drawing.Point(169, 380);
            this.tbIdToDelete.Name = "tbIdToDelete";
            this.tbIdToDelete.Size = new System.Drawing.Size(46, 22);
            this.tbIdToDelete.TabIndex = 9;
            this.tbIdToDelete.Click += new System.EventHandler(this.tbIdToDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "To Delete select ID:";
            // 
            // btnRefreshItemsList
            // 
            this.btnRefreshItemsList.Location = new System.Drawing.Point(116, 5);
            this.btnRefreshItemsList.Name = "btnRefreshItemsList";
            this.btnRefreshItemsList.Size = new System.Drawing.Size(132, 23);
            this.btnRefreshItemsList.TabIndex = 7;
            this.btnRefreshItemsList.Text = "Refresh Items List";
            this.btnRefreshItemsList.UseVisualStyleBackColor = true;
            this.btnRefreshItemsList.Click += new System.EventHandler(this.btnRefreshItemsList_Click);
            // 
            // bAddNewItem
            // 
            this.bAddNewItem.Location = new System.Drawing.Point(119, 199);
            this.bAddNewItem.Name = "bAddNewItem";
            this.bAddNewItem.Size = new System.Drawing.Size(132, 23);
            this.bAddNewItem.TabIndex = 6;
            this.bAddNewItem.Text = "Add New Item";
            this.bAddNewItem.UseVisualStyleBackColor = true;
            this.bAddNewItem.Click += new System.EventHandler(this.bAddNewItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(213, 31);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(144, 22);
            this.tbTitle.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(175, 107);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(182, 86);
            this.tbDescription.TabIndex = 2;
            this.tbDescription.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Set Picture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbSetPic
            // 
            this.pbSetPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSetPic.Image = global::CSharp_Exam.Properties.Resources.placeholder;
            this.pbSetPic.Location = new System.Drawing.Point(43, 33);
            this.pbSetPic.Name = "pbSetPic";
            this.pbSetPic.Size = new System.Drawing.Size(123, 121);
            this.pbSetPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSetPic.TabIndex = 0;
            this.pbSetPic.TabStop = false;
            // 
            // flpItemsList
            // 
            this.flpItemsList.AutoScroll = true;
            this.flpItemsList.Controls.Add(this.flowLayoutPanel2);
            this.flpItemsList.Location = new System.Drawing.Point(399, 73);
            this.flpItemsList.Name = "flpItemsList";
            this.flpItemsList.Size = new System.Drawing.Size(938, 529);
            this.flpItemsList.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(851, 0);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // scSortOptions
            // 
            this.scSortOptions.FormattingEnabled = true;
            this.scSortOptions.Location = new System.Drawing.Point(935, 31);
            this.scSortOptions.Name = "scSortOptions";
            this.scSortOptions.Size = new System.Drawing.Size(121, 24);
            this.scSortOptions.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(835, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Sort items by:";
            // 
            // cbAscDesc
            // 
            this.cbAscDesc.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbAscDesc.AutoSize = true;
            this.cbAscDesc.Location = new System.Drawing.Point(1062, 29);
            this.cbAscDesc.Name = "cbAscDesc";
            this.cbAscDesc.Size = new System.Drawing.Size(41, 27);
            this.cbAscDesc.TabIndex = 5;
            this.cbAscDesc.Text = "Asc";
            this.cbAscDesc.UseVisualStyleBackColor = true;
            this.cbAscDesc.CheckedChanged += new System.EventHandler(this.cbAscDesc_CheckedChanged);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(1124, 31);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // UserMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 605);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cbAscDesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.scSortOptions);
            this.Controls.Add(this.flpItemsList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserMainMenu";
            this.Text = "UserMainMenu";
            this.Load += new System.EventHandler(this.UserMainMenu_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserMainMenu_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetNewPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetPic)).EndInit();
            this.flpItemsList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpItemsList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbSetPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Button bAddNewItem;
        private System.Windows.Forms.Button btnRefreshItemsList;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIdToDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNewDescription;
        private System.Windows.Forms.TextBox tbNewTitle;
        private System.Windows.Forms.CheckBox cbPicture;
        private System.Windows.Forms.CheckBox cbDescription;
        private System.Windows.Forms.CheckBox cbCost;
        private System.Windows.Forms.CheckBox cbTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIdToUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lWrongIdToUpdate;
        private System.Windows.Forms.PictureBox pbSetNewPic;
        private System.Windows.Forms.NumericUpDown tbNewCost;
        private System.Windows.Forms.NumericUpDown tbCost;
        private System.Windows.Forms.Button btnSetNewPicture;
        private System.Windows.Forms.ComboBox scSortOptions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbAscDesc;
        private System.Windows.Forms.Button btnSort;
    }
}
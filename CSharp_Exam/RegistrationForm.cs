using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Exam
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void lExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            tbUserNameRegistration.Text = "Enter login...";
            tbPassRegistration.Text = "Enter password...";
            tbPassConfirmRegistration.Text = "Confirm password...";
        }

        private void tbUserNameRegistration_Click(object sender, EventArgs e)
        {
            tbUserNameRegistration.Text = "";
        }

        private void tbPassRegistration_Click(object sender, EventArgs e)
        {
            tbPassRegistration.Text = "";
        }

        private void tbPassConfirmRegistration_Click(object sender, EventArgs e)
        {
            tbPassConfirmRegistration.Text = "";
        }

        private void tbUserNameRegistration_Leave(object sender, EventArgs e)
        {
            if(tbUserNameRegistration.Text == "")
            {
                tbUserNameRegistration.Text = "Enter login...";
            }
        }

        private void tbPassRegistration_Leave(object sender, EventArgs e)
        {
            if (tbPassRegistration.Text == "")
            {
                tbPassRegistration.Text = "Enter password...";
            }
        }

        private void tbPassConfirmRegistration_Leave(object sender, EventArgs e)
        {
            if (tbPassConfirmRegistration.Text == "")
            {
                tbPassConfirmRegistration.Text = "Confirm password...";
            }
        }

        private void RegistrationForm_Click(object sender, EventArgs e)
        {
            tbUserNameRegistration.Text = "Enter login...";
            tbPassRegistration.Text = "Enter password...";
            tbPassConfirmRegistration.Text = "Confirm password...";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tbUserNameRegistration.Text = "Enter login...";
            tbPassRegistration.Text = "Enter password...";
            tbPassConfirmRegistration.Text = "Confirm password...";
        }
        //this.ActiveControl = null;
        //tbUserNameRegistration.Text = "Enter";
    }
}

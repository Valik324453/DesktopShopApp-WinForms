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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text == "Valik" && tbPassword.Text == "1234")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
                tbUserName.Clear();
                tbPassword.Clear();
                tbUserName.Focus();
            }
        }

        private void lClearFields_Click(object sender, EventArgs e)
        {
            tbUserName.Clear();
            tbPassword.Clear();
            tbUserName.Focus();
        }

        private void lExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pUserName_Click(object sender, EventArgs e)
        {
            tbUserName.Focus();
        }

        private void pPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }
    }
}

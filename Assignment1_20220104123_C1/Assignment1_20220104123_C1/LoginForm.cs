using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_20220104123_C1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Predefined credentials
            if (username == "admin" && password == "SDlab123")
            {
                MessageBox.Show("Login Successful!", "Success");
                this.Hide();
                MainForm mainForm = new MainForm(); // Main grading screen
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

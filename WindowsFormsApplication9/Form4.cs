using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            passtxtf.PasswordChar = '*';
        }
        private string facultyUsername = "faculty1";
        private string facultyPassword = "12345";

        private void exitF_Click(object sender, EventArgs e)
        {
            Form2 exitFac = new Form2();
            exitFac.Show();
            this.Hide();
        }

        private void loginbtn1_Click(object sender, EventArgs e)
        {
            string username = usertxtf.Text.Trim();
            string password = passtxtf.Text.Trim();

           
            if (username == facultyUsername && password == facultyPassword)
            {
                MessageBox.Show("Faculty Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form9 loginStud = new Form9();
                loginStud.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
    }


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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            passtxts.PasswordChar = '*';
        }
        private string studentUsername = "student1";
        private string studentPassword = "12345";

        private void loginbtn_Click(object sender, EventArgs e)
        {
        

              string username = usertxts.Text.Trim();
            string password = passtxts.Text.Trim();

            if (username == studentUsername && password == studentPassword)
            {
                MessageBox.Show("Student Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form6 loginStud = new Form6();
                loginStud.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitS_Click(object sender, EventArgs e)
        {
            Form2 exitStud = new Form2();
            exitStud.Show();
            this.Hide();
        }
    }
}

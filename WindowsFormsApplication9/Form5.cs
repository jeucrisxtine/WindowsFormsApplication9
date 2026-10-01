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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            passtxta.PasswordChar = '*';
        }
        private string adminUsername = "Admin1";
        private string adminPassword = "12345";

        private void exitA_Click(object sender, EventArgs e)
        {
            Form2 exitAd = new Form2();
            exitAd.Show();
            this.Hide();
        }

        private void loginbtn2_Click(object sender, EventArgs e)
        {

            string username = usertxta.Text.Trim();
            string password = passtxta.Text.Trim();

            if (username == adminUsername && password == adminPassword)
            {
                Form7 adminDash = new Form7();
                adminDash.AdminName = username;
                adminDash.AdminImage = Image.FromFile(@"C:\Users\User\Downloads\tao.png");
                adminDash.Show();
                this.Hide();
                MessageBox.Show("Admin Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
    }


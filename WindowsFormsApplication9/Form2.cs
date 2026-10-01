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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            Form3 studLogin = new Form3();
            studLogin.Show();
            this.Hide();


        }

        private void facultybtn_Click(object sender, EventArgs e)
        {
            Form4 FacultyLogin = new Form4();
            FacultyLogin.Show();
            this.Hide();
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            Form5 AdminLogin = new Form5();
            AdminLogin.Show();
            this.Hide();
        }
    }
}

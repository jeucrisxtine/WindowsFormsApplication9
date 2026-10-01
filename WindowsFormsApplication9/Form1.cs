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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getstartedbtn_Click(object sender, EventArgs e)
        {
            Form2 Select = new Form2();
            Select.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

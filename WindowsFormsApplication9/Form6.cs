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

        public partial class Form6 : Form
        {
     
            public Form6()
            {
                InitializeComponent();
            }


            public void AddStudent(
    string id,
    string fname,
    string mname,
    string lname,
    string age,
    string gender,
    string dob,
    string email,
    string address,
    string contact,
    string year,
    string course)
            {
                ListViewItem info = new ListViewItem(id);
                info.SubItems.Add(fname);
                info.SubItems.Add(mname);
                info.SubItems.Add(lname);
                info.SubItems.Add(age);
                info.SubItems.Add(gender);
                info.SubItems.Add(dob);
                info.SubItems.Add(email);
                info.SubItems.Add(address);
                info.SubItems.Add(contact);
                info.SubItems.Add(year);
                info.SubItems.Add(course);

                listView1.Items.Add(info);
            }



            private void Form6_Load(object sender, EventArgs e)
            {

             listView1.View = View.Details;
    listView1.FullRowSelect = true;

    if (listView1.Columns.Count == 0)
    {
        listView1.Columns.Add("ID Number", 80);
        listView1.Columns.Add("First Name", 100);
        listView1.Columns.Add("Middle Name", 100);
        listView1.Columns.Add("Last Name", 100);
        listView1.Columns.Add("Age", 60);
        listView1.Columns.Add("Gender", 80);
        listView1.Columns.Add("Date of Birth", 120);
        listView1.Columns.Add("Email", 150);
        listView1.Columns.Add("Address", 150);
        listView1.Columns.Add("Contact", 100);
        listView1.Columns.Add("Year Level", 80);
        listView1.Columns.Add("Course", 80);
    }
          
            }
      

            private void viewprofbtn_Click(object sender, EventArgs e)
            {
                viewprofbtn.Enabled = false;
                classesenbtn.Enabled = true;
                schedbtn.Enabled = true;
                announcementbtn.Enabled = true;
                logoutbtn.Enabled = true;
                dlercbtn.Enabled = true;
                panelStudent.Visible = true;
            }

            private void enrollcoursebtn_Click(object sender, EventArgs e)
            {
                viewprofbtn.Enabled = true;
                classesenbtn.Enabled = false;
                schedbtn.Enabled = true;
                announcementbtn.Enabled = true;
                logoutbtn.Enabled = true;
                dlercbtn.Enabled = true;
                panelStudent.Visible = false;
            }

            private void schedbtn_Click(object sender, EventArgs e)
            {
                viewprofbtn.Enabled = true;
                classesenbtn.Enabled = true;
                schedbtn.Enabled = false;
                announcementbtn.Enabled = true;
                logoutbtn.Enabled = true;
                dlercbtn.Enabled = true;
            }

            private void announcementbtn_Click(object sender, EventArgs e)
            {
                viewprofbtn.Enabled = true;
                classesenbtn.Enabled = true;
                schedbtn.Enabled = true;
                announcementbtn.Enabled = false;
                logoutbtn.Enabled = true;
                dlercbtn.Enabled = true;
            }

            private void logoutbtn_Click(object sender, EventArgs e)
            {
                viewprofbtn.Enabled = true;
                classesenbtn.Enabled = true;
                schedbtn.Enabled = true;
                announcementbtn.Enabled = true;
                logoutbtn.Enabled = false;
                dlercbtn.Enabled = true;

                Form2 logoutStud = new Form2();
                logoutStud.Show();
                this.Hide();
                MessageBox.Show("Account Logged Out!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {
                panelStudent.Visible = false;
            }

            private void dlercbtn_Click(object sender, EventArgs e)
            {
                viewprofbtn.Enabled = true;
                classesenbtn.Enabled = true;
                schedbtn.Enabled = true;
                announcementbtn.Enabled = true;
                logoutbtn.Enabled = true;
                dlercbtn.Enabled = false;
            }
        }
    }

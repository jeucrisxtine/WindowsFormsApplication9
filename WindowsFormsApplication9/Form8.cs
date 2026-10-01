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
    public partial class Form8 : Form
    {
        private Form6 form6;

        public Form8(string selectedCourse, Form6 f6)
        {
            InitializeComponent();
            course.Text = selectedCourse;
            form6 = f6;
        }
        
        private void Form8_Load(object sender, EventArgs e)
        {
            if (listView1.Columns.Count == 0)
            {
                listView1.Columns.Add("ID Number", 120);
                listView1.Columns.Add("First Name", 120);
                listView1.Columns.Add("Middle Name", 120);
                listView1.Columns.Add("Last Name", 120);
                listView1.Columns.Add("Age", 120);
                listView1.Columns.Add("Gender", 120);
                listView1.Columns.Add("Date of Birth", 120);
                listView1.Columns.Add("Email Address", 120);
                listView1.Columns.Add("Address", 120);
                listView1.Columns.Add("Contact Number", 120);
                listView1.Columns.Add("Year Level", 120);
                listView1.Columns.Add("Course", 120);
            }

        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            newbtn.Enabled = false;
            addbtn.Enabled = true;
            idtxt.Enabled = true;
            fname.Enabled = true;
            mname.Enabled = true;
            lname.Enabled = true;
            age.Enabled = true;
            gendera.Enabled = true;
            DOB.Enabled = true;
            emailadd.Enabled = true;
            address.Enabled = true;
            contact.Enabled = true;
            yrlvl.Enabled = true;
            course.Enabled = true;
        }

        private void addbtn_Click_1(object sender, EventArgs e)
        {
            ListViewItem info = new ListViewItem(idtxt.Text);
            info.SubItems.Add(fname.Text);
            info.SubItems.Add(mname.Text);
            info.SubItems.Add(lname.Text);
            info.SubItems.Add(age.Text);
            info.SubItems.Add(gendera.Text);
            info.SubItems.Add(DOB.Text);
            info.SubItems.Add(emailadd.Text);
            info.SubItems.Add(address.Text);
            info.SubItems.Add(contact.Text);
            info.SubItems.Add(yrlvl.Text);
            info.SubItems.Add(course.Text);

            listView1.Items.Add(info);

            if (form6 != null)
            {
                form6.AddStudent(
                    idtxt.Text,
                    fname.Text,
                    mname.Text,
                    lname.Text,
                    age.Text,
                    gendera.Text,
                    DOB.Text,
                    emailadd.Text,
                    address.Text,
                    contact.Text,
                    yrlvl.Text,
                    course.Text
                );
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                idtxt.Text = listView1.SelectedItems[0].SubItems[0].Text;
                fname.Text = listView1.SelectedItems[0].SubItems[1].Text;
                mname.Text = listView1.SelectedItems[0].SubItems[2].Text;
                lname.Text = listView1.SelectedItems[0].SubItems[3].Text;
                age.Text = listView1.SelectedItems[0].SubItems[4].Text;
                gendera.Text = listView1.SelectedItems[0].SubItems[5].Text;
                DOB.Text = listView1.SelectedItems[0].SubItems[6].Text;
                emailadd.Text = listView1.SelectedItems[0].SubItems[7].Text;
                address.Text = listView1.SelectedItems[0].SubItems[8].Text;
                contact.Text = listView1.SelectedItems[0].SubItems[9].Text;
                yrlvl.Text = listView1.SelectedItems[0].SubItems[10].Text;
                course.Text = listView1.SelectedItems[0].SubItems[11].Text;
                updatebtn.Enabled = true;
                deletebtn.Enabled = true;
                idtxt.Enabled = true;
                fname.Enabled = true;
                mname.Enabled = true;
                lname.Enabled = true;
                age.Enabled = true;
                gendera.Enabled = true;
                DOB.Enabled = true;
                emailadd.Enabled = true;
                address.Enabled = true;
                contact.Enabled = true;
                yrlvl.Enabled = true;
                course.Enabled = true;

                
            }
        }

        private void course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form7 ManageStud = new Form7();
            ManageStud.Show();
            this.Hide();
        }
       
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            ListViewItem item = listView1.SelectedItems[0];
            listView1.SelectedItems[0].SubItems[0].Text = idtxt.Text;
            listView1.SelectedItems[0].SubItems[1].Text = fname.Text;
            listView1.SelectedItems[0].SubItems[2].Text = mname.Text;
            listView1.SelectedItems[0].SubItems[3].Text = lname.Text;
            listView1.SelectedItems[0].SubItems[4].Text = age.Text;
            listView1.SelectedItems[0].SubItems[5].Text = gendera.Text;
            listView1.SelectedItems[0].SubItems[6].Text = DOB.Text;
            listView1.SelectedItems[0].SubItems[7].Text = emailadd.Text;
            listView1.SelectedItems[0].SubItems[8].Text = address.Text;
            listView1.SelectedItems[0].SubItems[9].Text = contact.Text;
            listView1.SelectedItems[0].SubItems[10].Text = yrlvl.Text;
            listView1.SelectedItems[0].SubItems[11].Text = course.Text;
            updatebtn.Enabled = false;
            deletebtn.Enabled = true;
            newbtn.Enabled = true;
            idtxt.Enabled = true;
            fname.Enabled = true;
            mname.Enabled = true;
            lname.Enabled = true;
            age.Enabled = true;
            gendera.Enabled = true;
            DOB.Enabled = true;
            emailadd.Enabled = true;
            address.Enabled = true;
            contact.Enabled = true;
            yrlvl.Enabled = true;
            course.Enabled = true;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            idtxt.Text = "";
            fname.Text = "";
            mname.Text = "";
            lname.Text = "";
            age.Text = "";
            gendera.Text = "";
            DOB.Text = "";
            emailadd.Text = "";
            address.Text = "";
            contact.Text = "";
            yrlvl.Text = "";
            course.Text = "";
            updatebtn.Enabled = false;
            deletebtn.Enabled = false;
            idtxt.Enabled = false;
            fname.Enabled = false;
            mname.Enabled = false;
            lname.Enabled = false;
            age.Enabled = false;
            gendera.Enabled = false;
            DOB.Enabled = false;
            emailadd.Enabled = false;
            address.Enabled = false;
            contact.Enabled = false;
            yrlvl.Enabled = false;
            course.Enabled = false;
        }

    }
}

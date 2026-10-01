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
    public partial class Form7 : Form
    {
        public string AdminName { get; set; }
        public Image AdminImage { get; set; }

        public Form7()
        {
            InitializeComponent();

        }

        private void managestud_Click(object sender, EventArgs e)
        {
            managestud.Enabled = false;
            managefac.Enabled = true;
            coursub.Enabled = true;
            logouta.Enabled = true;
            listofstudents.Enabled = true;
            homebtn.Enabled = true;
            adheader.Visible = false;
            adhome.Visible = false;
            adpanel.Visible = true;
            facultii.Visible = false;
            
        }

        private void managefac_Click(object sender, EventArgs e)
        {
            managestud.Enabled = true;
            managefac.Enabled = false;
            coursub.Enabled = true;
            logouta.Enabled = true;
            listofstudents.Enabled = true;
            homebtn.Enabled = true;
            adpanel.Visible = false;
            facultii.Visible = true;
            facultii.Enabled = true;
            
            
        }

        private void coursub_Click(object sender, EventArgs e)
        {
            managestud.Enabled = true;
            managefac.Enabled = true;
            coursub.Enabled = false;
            logouta.Enabled = true;
            listofstudents.Enabled = true;
            homebtn.Enabled = true;
            adpanel.Visible = false;
            facultii.Visible = false;
        }

        private void reports_Click(object sender, EventArgs e)
        {
            managestud.Enabled = true;
            managefac.Enabled = true;
            coursub.Enabled = true;
            logouta.Enabled = true;
            listofstudents.Enabled = true;
            homebtn.Enabled = true;
            adpanel.Visible = false;
            facultii.Visible = false;
        }

        private void logouta_Click(object sender, EventArgs e)
        {
            managestud.Enabled = true;
            managefac.Enabled = true;
            coursub.Enabled = true;
            logouta.Enabled = false;
            listofstudents.Enabled = true;
            homebtn.Enabled = true;
            adpanel.Visible = false;
            facultii.Visible = false;
            Form5 toLogout = new Form5();
            toLogout.Show();
            this.Hide();
            MessageBox.Show("Account Logged Out!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bsncourse_Click(object sender, EventArgs e)
        {
            bsncourse.Enabled = false;
            bscscourse.Enabled = true;
            bsitcourse.Enabled = true;
            bsedcourse.Enabled = true;
            beedcourse.Enabled = true;
            bsnedcourse.Enabled = true;
            bpedcourse.Enabled = true;
            bsccourse.Enabled = true;
            bsbacourse.Enabled = true;
            bscecourse.Enabled = true;
            bsgecourse.Enabled = true;
            bshrmcourse.Enabled = true;
            bstmcourse.Enabled = true;
            Form6 form6 = new Form6();
            form6.Show();

            Form8 form8 = new Form8("BSN", form6);
            form8.Show();
        }

        private void bscscourse_Click(object sender, EventArgs e)
        {
            bsncourse.Enabled = true;
            bscscourse.Enabled = false;
            bsitcourse.Enabled = true;
            bsedcourse.Enabled = true;
            beedcourse.Enabled = true;
            bsnedcourse.Enabled = true;
            bpedcourse.Enabled = true;
            bsccourse.Enabled = true;
            bsbacourse.Enabled = true;
            bscecourse.Enabled = true;
            bsgecourse.Enabled = true;
            bshrmcourse.Enabled = true;
            bstmcourse.Enabled = true;
            Form6 form6 = new Form6();
            form6.Show();

            Form8 form8 = new Form8("BSCS", form6);
            form8.Show();
        }

        private void bsitcourse_Click(object sender, EventArgs e)
        {
            bsncourse.Enabled = true;
            bscscourse.Enabled = true;
            bsitcourse.Enabled = false;
            bsedcourse.Enabled = true;
            beedcourse.Enabled = true;
            bsnedcourse.Enabled = true;
            bpedcourse.Enabled = true;
            bsccourse.Enabled = true;
            bsbacourse.Enabled = true;
            bscecourse.Enabled = true;
            bsgecourse.Enabled = true;
            bshrmcourse.Enabled = true;
            bstmcourse.Enabled = true;
            Form6 form6 = new Form6();
            form6.Show();

            Form8 form8 = new Form8("BSIT", form6);
            form8.Show();
        }

        private void bsedcourse_Click(object sender, EventArgs e)
        {
            bsncourse.Enabled = true;
            bscscourse.Enabled = true;
            bsitcourse.Enabled = true;
            bsedcourse.Enabled = false;
            beedcourse.Enabled = true;
            bsnedcourse.Enabled = true;
            bpedcourse.Enabled = true;
            bsccourse.Enabled = true;
            bsbacourse.Enabled = true;
            bscecourse.Enabled = true;
            bsgecourse.Enabled = true;
            bshrmcourse.Enabled = true;
            bstmcourse.Enabled = true;
            Form6 form6 = new Form6();
            form6.Show();

            Form8 form8 = new Form8("BSED", form6);
            form8.Show();
        }

        private void beedcourse_Click(object sender, EventArgs e)
        {
            bsncourse.Enabled = true;
            bscscourse.Enabled = true;
            bsitcourse.Enabled = true;
            bsedcourse.Enabled = true;
            beedcourse.Enabled = false;
            bsnedcourse.Enabled = true;
            bpedcourse.Enabled = true;
            bsccourse.Enabled = true;
            bsbacourse.Enabled = true;
            bscecourse.Enabled = true;
            bsgecourse.Enabled = true;
            bshrmcourse.Enabled = true;
            bstmcourse.Enabled = true;
            Form6 form6 = new Form6();
            form6.Show();

            Form8 form8 = new Form8("BEED", form6);
            form8.Show();
        }

        private void bsnedcourse_Click(object sender, EventArgs e)
        {
            bsncourse.Enabled = true;
            bscscourse.Enabled = true;
            bsitcourse.Enabled = true;
            bsedcourse.Enabled = true;
            beedcourse.Enabled = true;
            bsnedcourse.Enabled = false;
            bpedcourse.Enabled = true;
            bsccourse.Enabled = true;
            bsbacourse.Enabled = true;
            bscecourse.Enabled = true;
            bsgecourse.Enabled = true;
            bshrmcourse.Enabled = true;
            bstmcourse.Enabled = true;
            Form6 form6 = new Form6();
            form6.Show();

            Form8 form8 = new Form8("BSNED", form6);
            form8.Show();
        }

        private void bpedcourse_Click(object sender, EventArgs e)
        {
            bsncourse.Enabled = true;
            bscscourse.Enabled = true;
            bsitcourse.Enabled = true;
            bsedcourse.Enabled = true;
            beedcourse.Enabled = true;
            bsnedcourse.Enabled = true;
            bpedcourse.Enabled = false;
            bsccourse.Enabled = true;
            bsbacourse.Enabled = true;
            bscecourse.Enabled = true;
            bsgecourse.Enabled = true;
            bshrmcourse.Enabled = true;
            bstmcourse.Enabled = true;
            Form6 form6 = new Form6();
            form6.Show();

            Form8 form8 = new Form8("BPED", form6);
            form8.Show();
        }

        private void bsccourse_Click(object sender, EventArgs e)
        {
            bsncourse.Enabled = true;
            bscscourse.Enabled = true;
            bsitcourse.Enabled = true;
            bsedcourse.Enabled = true;
            beedcourse.Enabled = true;
            bsnedcourse.Enabled = true;
            bpedcourse.Enabled = true;
            bsccourse.Enabled = false;
            bsbacourse.Enabled = true;
            bscecourse.Enabled = true;
            bsgecourse.Enabled = true;
            bshrmcourse.Enabled = true;
            bstmcourse.Enabled = true;
            Form6 form6 = new Form6();
            form6.Show();

            Form8 form8 = new Form8("BSC", form6);
            form8.Show();
        }

        private void bsbacourse_Click(object sender, EventArgs e)
        {
            bsncourse.Enabled = true;
            bscscourse.Enabled = true;
            bsitcourse.Enabled = true;
            bsedcourse.Enabled = true;
            beedcourse.Enabled = true;
            bsnedcourse.Enabled = true;
            bpedcourse.Enabled = true;
            bsccourse.Enabled = true;
            bsbacourse.Enabled = false;
            bscecourse.Enabled = true;
            bsgecourse.Enabled = true;
            bshrmcourse.Enabled = true;
            bstmcourse.Enabled = true;
            Form6 form6 = new Form6();
            form6.Show();

            Form8 form8 = new Form8("BSBA", form6);
            form8.Show();
        }

        private void bscecourse_Click(object sender, EventArgs e)
        {
            bsncourse.Enabled = true;
            bscscourse.Enabled = true;
            bsitcourse.Enabled = true;
            bsedcourse.Enabled = true;
            beedcourse.Enabled = true;
            bsnedcourse.Enabled = true;
            bpedcourse.Enabled = true;
            bsccourse.Enabled = true;
            bsbacourse.Enabled = true;
            bscecourse.Enabled = false;
            bsgecourse.Enabled = true;
            bshrmcourse.Enabled = true;
            bstmcourse.Enabled = true;
            Form6 form6 = new Form6();
            form6.Show();

            Form8 form8 = new Form8("BSCE", form6);
            form8.Show();
        }

        private void bsgecourse_Click(object sender, EventArgs e)
        {
            bsncourse.Enabled = true;
            bscscourse.Enabled = true;
            bsitcourse.Enabled = true;
            bsedcourse.Enabled = true;
            beedcourse.Enabled = true;
            bsnedcourse.Enabled = true;
            bpedcourse.Enabled = true;
            bscscourse.Enabled = true;
            bsbacourse.Enabled = true;
            bscecourse.Enabled = true;
            bsgecourse.Enabled = false;
            bshrmcourse.Enabled = true;
            bstmcourse.Enabled = true;
            Form6 form6 = new Form6();
            form6.Show();

            Form8 form8 = new Form8("BSGE", form6);
            form8.Show();
        }

        private void bshrmcourse_Click(object sender, EventArgs e)
        {
            bsncourse.Enabled = true;
            bscscourse.Enabled = true;
            bsitcourse.Enabled = true;
            bsedcourse.Enabled = true;
            beedcourse.Enabled = true;
            bsnedcourse.Enabled = true;
            bpedcourse.Enabled = true;
            bsccourse.Enabled = true;
            bsbacourse.Enabled = true;
            bscecourse.Enabled = true;
            bsgecourse.Enabled = true;
            bshrmcourse.Enabled = false;
            bstmcourse.Enabled = true;
            Form6 form6 = new Form6();
            form6.Show();

            Form8 form8 = new Form8("BSHRM", form6);
            form8.Show();
        }

        private void bstmcourse_Click(object sender, EventArgs e)
        {
            bsncourse.Enabled = true;
            bscscourse.Enabled = true;
            bsitcourse.Enabled = true;
            bsedcourse.Enabled = true;
            beedcourse.Enabled = true;
            bsnedcourse.Enabled = true;
            bpedcourse.Enabled = true;
            bsccourse.Enabled = true;
            bsbacourse.Enabled = true;
            bscecourse.Enabled = true;
            bsgecourse.Enabled = true;
            bshrmcourse.Enabled = true;
            bstmcourse.Enabled = false;
            Form6 form6 = new Form6();
            form6.Show();

            Form8 form8 = new Form8("BSTM", form6);
            form8.Show();
            this.Hide();

      
        
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            listView2.Columns.Add("First Name", 120);
            listView2.Columns.Add("Middle Name", 120);
            listView2.Columns.Add("Last Name", 120);
            listView2.Columns.Add("Course", 120);

            homebtn.Enabled = false;
            adpanel.Visible = false;
            facultii.Visible = false;
            adnamee.Text = AdminName;

            if (AdminImage != null)
            {
                picsadmin.Image = AdminImage;
                picsadmin.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void listofstudents_Click(object sender, EventArgs e)
        {
            managestud.Enabled = true;
            managefac.Enabled = true;
            coursub.Enabled = true;
            logouta.Enabled = true;
            listofstudents.Enabled = false;
            facultii.Visible = false;
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            managestud.Enabled = true;
            managefac.Enabled = true;
            coursub.Enabled = true;
            logouta.Enabled = true;
            listofstudents.Enabled = true;
            homebtn.Enabled = false;
            adheader.Visible = true;
            adhome.Visible = true;
            adpanel.Visible = false;
            facultii.Visible = false;

        }

        private void newbtnf_Click(object sender, EventArgs e)
        {
            newbtnf.Enabled = false;
            addbtnf.Enabled = true;
            fnamef.Enabled = true;
            mnamef.Enabled = true;
            lnamef.Enabled = true;
            coursef.Enabled = true;
            pictureBox1.Enabled = true;
            addpic.Enabled = true;
        }

        private void addbtnf_Click(object sender, EventArgs e)
        {
            ListViewItem faculty = new ListViewItem(fnamef.Text);
            faculty.SubItems.Add(mnamef.Text);
            faculty.SubItems.Add(lnamef.Text);
            faculty.SubItems.Add(coursef.Text);
            listView2.Items.Add(faculty);
            newbtnf.Enabled = true;
            addbtnf.Enabled = false;
            fnamef.Enabled = false;
            mnamef.Enabled = false;
            lnamef.Enabled = false;
            coursef.Enabled = false;
            pictureBox1.Enabled = false;
            addpic.Enabled = false;
            fnamef.Text = "";
            mnamef.Text = "";
            lnamef.Text = "";
            coursef.Text = "";

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                fnamef.Text = listView2.SelectedItems[0].SubItems[0].Text;
                mnamef.Text = listView2.SelectedItems[0].SubItems[1].Text;
                lnamef.Text = listView2.SelectedItems[0].SubItems[2].Text;
                coursef.Text = listView2.SelectedItems[0].SubItems[3].Text;
                updatebtnf.Enabled = true;
                deletebtnf.Enabled = true;
                fnamef.Enabled = true;
                mnamef.Enabled = true;
                lnamef.Enabled = true;
                coursef.Enabled = true;
                pictureBox1.Enabled = true;
                addpic.Enabled = true;
            }
        }

        private void updatebtnf_Click(object sender, EventArgs e)
        {
            listView2.SelectedItems[0].SubItems[0].Text = fnamef.Text;
            listView2.SelectedItems[0].SubItems[1].Text = mnamef.Text;
            listView2.SelectedItems[0].SubItems[2].Text = lnamef.Text;
            listView2.SelectedItems[0].SubItems[3].Text = coursef.Text;
            newbtnf.Enabled = true;
            fnamef.Enabled = true;
            mnamef.Enabled = true;
            lnamef.Enabled = true;
            coursef.Enabled = true;
            pictureBox1.Enabled = true;
            addpic.Enabled = true;
        }

        private void deletebtnf_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {

                listView2.Items.Remove(listView2.SelectedItems[0]);
            }
            newbtnf.Enabled = true;
            fnamef.Text = "";
            mnamef.Text = "";
            lnamef.Text = "";
            coursef.Text = "";
            fnamef.Enabled = false;
            mnamef.Enabled = false;
            lnamef.Enabled = false;
            coursef.Enabled = false;
            pictureBox1.Enabled = false;
            addpic.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        

        }

        private void addpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
    }
}

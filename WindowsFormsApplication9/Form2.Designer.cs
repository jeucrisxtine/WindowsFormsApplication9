namespace WindowsFormsApplication9
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentbtn = new System.Windows.Forms.Button();
            this.facultybtn = new System.Windows.Forms.Button();
            this.adminbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // studentbtn
            // 
            this.studentbtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentbtn.Location = new System.Drawing.Point(168, 442);
            this.studentbtn.Name = "studentbtn";
            this.studentbtn.Size = new System.Drawing.Size(211, 55);
            this.studentbtn.TabIndex = 0;
            this.studentbtn.Text = "Student";
            this.studentbtn.UseVisualStyleBackColor = true;
            this.studentbtn.Click += new System.EventHandler(this.studentbtn_Click);
            // 
            // facultybtn
            // 
            this.facultybtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultybtn.Location = new System.Drawing.Point(608, 442);
            this.facultybtn.Name = "facultybtn";
            this.facultybtn.Size = new System.Drawing.Size(211, 55);
            this.facultybtn.TabIndex = 1;
            this.facultybtn.Text = "Faculty";
            this.facultybtn.UseVisualStyleBackColor = true;
            this.facultybtn.Click += new System.EventHandler(this.facultybtn_Click);
            // 
            // adminbtn
            // 
            this.adminbtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbtn.Location = new System.Drawing.Point(1070, 442);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(211, 55);
            this.adminbtn.TabIndex = 2;
            this.adminbtn.Text = "Admin";
            this.adminbtn.UseVisualStyleBackColor = true;
            this.adminbtn.Click += new System.EventHandler(this.adminbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication9.Properties.Resources.tao;
            this.pictureBox1.Location = new System.Drawing.Point(198, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication9.Properties.Resources.tao;
            this.pictureBox2.Location = new System.Drawing.Point(638, 301);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication9.Properties.Resources.tao;
            this.pictureBox3.Location = new System.Drawing.Point(1101, 301);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 135);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 755);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminbtn);
            this.Controls.Add(this.facultybtn);
            this.Controls.Add(this.studentbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentbtn;
        private System.Windows.Forms.Button facultybtn;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
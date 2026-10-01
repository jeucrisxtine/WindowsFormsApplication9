namespace WindowsFormsApplication9
{
    partial class Form5
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
            this.adminpanel = new System.Windows.Forms.Panel();
            this.exitA = new System.Windows.Forms.Button();
            this.loginbtn2 = new System.Windows.Forms.Button();
            this.passtxta = new System.Windows.Forms.TextBox();
            this.usertxta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adminpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminpanel
            // 
            this.adminpanel.Controls.Add(this.exitA);
            this.adminpanel.Controls.Add(this.loginbtn2);
            this.adminpanel.Controls.Add(this.passtxta);
            this.adminpanel.Controls.Add(this.usertxta);
            this.adminpanel.Controls.Add(this.label9);
            this.adminpanel.Controls.Add(this.label8);
            this.adminpanel.Controls.Add(this.label7);
            this.adminpanel.Location = new System.Drawing.Point(327, 138);
            this.adminpanel.Name = "adminpanel";
            this.adminpanel.Size = new System.Drawing.Size(820, 458);
            this.adminpanel.TabIndex = 3;
            // 
            // exitA
            // 
            this.exitA.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitA.Location = new System.Drawing.Point(32, 27);
            this.exitA.Name = "exitA";
            this.exitA.Size = new System.Drawing.Size(62, 29);
            this.exitA.TabIndex = 9;
            this.exitA.Text = "Exit";
            this.exitA.UseVisualStyleBackColor = true;
            this.exitA.Click += new System.EventHandler(this.exitA_Click);
            // 
            // loginbtn2
            // 
            this.loginbtn2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn2.Location = new System.Drawing.Point(337, 322);
            this.loginbtn2.Name = "loginbtn2";
            this.loginbtn2.Size = new System.Drawing.Size(107, 40);
            this.loginbtn2.TabIndex = 8;
            this.loginbtn2.Text = "LOGIN";
            this.loginbtn2.UseVisualStyleBackColor = true;
            this.loginbtn2.Click += new System.EventHandler(this.loginbtn2_Click);
            // 
            // passtxta
            // 
            this.passtxta.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxta.Location = new System.Drawing.Point(286, 228);
            this.passtxta.Name = "passtxta";
            this.passtxta.Size = new System.Drawing.Size(333, 34);
            this.passtxta.TabIndex = 7;
            // 
            // usertxta
            // 
            this.usertxta.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxta.Location = new System.Drawing.Point(286, 168);
            this.usertxta.Name = "usertxta";
            this.usertxta.Size = new System.Drawing.Size(333, 34);
            this.usertxta.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 32);
            this.label9.TabIndex = 5;
            this.label9.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(129, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 33);
            this.label7.TabIndex = 3;
            this.label7.Text = "ADMIN LOGIN";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 734);
            this.Controls.Add(this.adminpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form5";
            this.Text = "Form5";
            this.adminpanel.ResumeLayout(false);
            this.adminpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminpanel;
        private System.Windows.Forms.Button exitA;
        private System.Windows.Forms.Button loginbtn2;
        private System.Windows.Forms.TextBox passtxta;
        private System.Windows.Forms.TextBox usertxta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
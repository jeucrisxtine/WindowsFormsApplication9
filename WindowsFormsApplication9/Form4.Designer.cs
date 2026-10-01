namespace WindowsFormsApplication9
{
    partial class Form4
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usertxtf = new System.Windows.Forms.TextBox();
            this.passtxtf = new System.Windows.Forms.TextBox();
            this.loginbtn1 = new System.Windows.Forms.Button();
            this.exitF = new System.Windows.Forms.Button();
            this.facultypanel = new System.Windows.Forms.Panel();
            this.facultypanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "FACULTY LOGIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password:";
            // 
            // usertxtf
            // 
            this.usertxtf.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxtf.Location = new System.Drawing.Point(279, 172);
            this.usertxtf.Name = "usertxtf";
            this.usertxtf.Size = new System.Drawing.Size(324, 34);
            this.usertxtf.TabIndex = 5;
            // 
            // passtxtf
            // 
            this.passtxtf.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxtf.Location = new System.Drawing.Point(279, 246);
            this.passtxtf.Name = "passtxtf";
            this.passtxtf.Size = new System.Drawing.Size(324, 34);
            this.passtxtf.TabIndex = 6;
            // 
            // loginbtn1
            // 
            this.loginbtn1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn1.Location = new System.Drawing.Point(337, 341);
            this.loginbtn1.Name = "loginbtn1";
            this.loginbtn1.Size = new System.Drawing.Size(105, 34);
            this.loginbtn1.TabIndex = 7;
            this.loginbtn1.Text = "LOGIN";
            this.loginbtn1.UseVisualStyleBackColor = true;
            this.loginbtn1.Click += new System.EventHandler(this.loginbtn1_Click);
            // 
            // exitF
            // 
            this.exitF.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitF.Location = new System.Drawing.Point(32, 28);
            this.exitF.Name = "exitF";
            this.exitF.Size = new System.Drawing.Size(62, 29);
            this.exitF.TabIndex = 10;
            this.exitF.Text = "Exit";
            this.exitF.UseVisualStyleBackColor = true;
            this.exitF.Click += new System.EventHandler(this.exitF_Click);
            // 
            // facultypanel
            // 
            this.facultypanel.Controls.Add(this.exitF);
            this.facultypanel.Controls.Add(this.loginbtn1);
            this.facultypanel.Controls.Add(this.passtxtf);
            this.facultypanel.Controls.Add(this.usertxtf);
            this.facultypanel.Controls.Add(this.label6);
            this.facultypanel.Controls.Add(this.label5);
            this.facultypanel.Controls.Add(this.label4);
            this.facultypanel.Location = new System.Drawing.Point(328, 140);
            this.facultypanel.Name = "facultypanel";
            this.facultypanel.Size = new System.Drawing.Size(820, 458);
            this.facultypanel.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 739);
            this.Controls.Add(this.facultypanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form4";
            this.Text = "Form4";
            this.facultypanel.ResumeLayout(false);
            this.facultypanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usertxtf;
        private System.Windows.Forms.TextBox passtxtf;
        private System.Windows.Forms.Button loginbtn1;
        private System.Windows.Forms.Button exitF;
        private System.Windows.Forms.Panel facultypanel;




    }
}
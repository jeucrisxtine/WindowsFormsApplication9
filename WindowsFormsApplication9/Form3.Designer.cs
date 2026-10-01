namespace WindowsFormsApplication9
{
    partial class Form3
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
            this.studentpanel = new System.Windows.Forms.Panel();
            this.exitS = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passtxts = new System.Windows.Forms.TextBox();
            this.usertxts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentpanel
            // 
            this.studentpanel.Controls.Add(this.exitS);
            this.studentpanel.Controls.Add(this.loginbtn);
            this.studentpanel.Controls.Add(this.label3);
            this.studentpanel.Controls.Add(this.passtxts);
            this.studentpanel.Controls.Add(this.usertxts);
            this.studentpanel.Controls.Add(this.label2);
            this.studentpanel.Controls.Add(this.label1);
            this.studentpanel.Location = new System.Drawing.Point(327, 135);
            this.studentpanel.Name = "studentpanel";
            this.studentpanel.Size = new System.Drawing.Size(820, 458);
            this.studentpanel.TabIndex = 0;
            // 
            // exitS
            // 
            this.exitS.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitS.Location = new System.Drawing.Point(32, 27);
            this.exitS.Name = "exitS";
            this.exitS.Size = new System.Drawing.Size(62, 29);
            this.exitS.TabIndex = 10;
            this.exitS.Text = "Exit";
            this.exitS.UseVisualStyleBackColor = true;
            this.exitS.Click += new System.EventHandler(this.exitS_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(337, 322);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(105, 37);
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // passtxts
            // 
            this.passtxts.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxts.Location = new System.Drawing.Point(279, 227);
            this.passtxts.Name = "passtxts";
            this.passtxts.Size = new System.Drawing.Size(340, 34);
            this.passtxts.TabIndex = 4;
            // 
            // usertxts
            // 
            this.usertxts.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxts.Location = new System.Drawing.Point(279, 150);
            this.usertxts.Name = "usertxts";
            this.usertxts.Size = new System.Drawing.Size(340, 34);
            this.usertxts.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT LOGIN";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 738);
            this.Controls.Add(this.studentpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Form3";
            this.studentpanel.ResumeLayout(false);
            this.studentpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel studentpanel;
        private System.Windows.Forms.TextBox passtxts;
        private System.Windows.Forms.TextBox usertxts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitS;
    }
}
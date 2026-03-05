namespace Login_Form
{
    partial class Form1
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
            this.Luser = new System.Windows.Forms.Label();
            this.Lpass = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.link = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lemail = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Luser
            // 
            this.Luser.AutoSize = true;
            this.Luser.BackColor = System.Drawing.Color.White;
            this.Luser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luser.Location = new System.Drawing.Point(27, 98);
            this.Luser.Name = "Luser";
            this.Luser.Size = new System.Drawing.Size(102, 25);
            this.Luser.TabIndex = 0;
            this.Luser.Text = "Username";
            // 
            // Lpass
            // 
            this.Lpass.AutoSize = true;
            this.Lpass.BackColor = System.Drawing.Color.White;
            this.Lpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpass.Location = new System.Drawing.Point(27, 214);
            this.Lpass.Name = "Lpass";
            this.Lpass.Size = new System.Drawing.Size(98, 25);
            this.Lpass.TabIndex = 1;
            this.Lpass.Text = "Password";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(135, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(85, 31);
            this.title.TabIndex = 2;
            this.title.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.link);
            this.panel1.Controls.Add(this.info);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Lemail);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.Lpass);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.Luser);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 426);
            this.panel1.TabIndex = 3;
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.BackColor = System.Drawing.Color.White;
            this.link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.ForeColor = System.Drawing.Color.Blue;
            this.link.Location = new System.Drawing.Point(254, 390);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(60, 17);
            this.link.TabIndex = 13;
            this.link.Text = "Click Me";
            this.link.Click += new System.EventHandler(this.label10_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.White;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(42, 389);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(206, 20);
            this.info.TabIndex = 12;
            this.info.Text = "Want to create an account?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "or";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.LightGreen;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.Black;
            this.submit.Location = new System.Drawing.Point(32, 285);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(291, 46);
            this.submit.TabIndex = 10;
            this.submit.Text = "LOGIN";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = ":";
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.BackColor = System.Drawing.Color.White;
            this.Lemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lemail.Location = new System.Drawing.Point(27, 162);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(60, 25);
            this.Lemail.TabIndex = 6;
            this.Lemail.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(156, 162);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(167, 20);
            this.email.TabIndex = 5;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(156, 215);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(167, 20);
            this.pass.TabIndex = 4;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(156, 103);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(167, 20);
            this.user.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Login Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Luser;
        private System.Windows.Forms.Label Lpass;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label link;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label8;
    }
}


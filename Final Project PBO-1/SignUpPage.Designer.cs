namespace Final_Project_PBO_1
{
    partial class SignUpPage
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
            this.txtUsernameSignUp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailSignUp = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameSignUp = new System.Windows.Forms.MaskedTextBox();
            this.txtPasswordSignUp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearDataSignUp = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backSignUpPage = new System.Windows.Forms.PictureBox();
            this.btnHidePW = new System.Windows.Forms.Button();
            this.btnShowPW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backSignUpPage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsernameSignUp
            // 
            this.txtUsernameSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameSignUp.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSignUp.Location = new System.Drawing.Point(189, 174);
            this.txtUsernameSignUp.Name = "txtUsernameSignUp";
            this.txtUsernameSignUp.Size = new System.Drawing.Size(200, 17);
            this.txtUsernameSignUp.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(185, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(185, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // txtEmailSignUp
            // 
            this.txtEmailSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailSignUp.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSignUp.Location = new System.Drawing.Point(189, 127);
            this.txtEmailSignUp.Name = "txtEmailSignUp";
            this.txtEmailSignUp.Size = new System.Drawing.Size(200, 17);
            this.txtEmailSignUp.TabIndex = 5;
            this.txtEmailSignUp.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtUsername_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(185, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNameSignUp
            // 
            this.txtNameSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameSignUp.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSignUp.Location = new System.Drawing.Point(189, 80);
            this.txtNameSignUp.Name = "txtNameSignUp";
            this.txtNameSignUp.Size = new System.Drawing.Size(200, 17);
            this.txtNameSignUp.TabIndex = 11;
            this.txtNameSignUp.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtNameSignUp_MaskInputRejected);
            // 
            // txtPasswordSignUp
            // 
            this.txtPasswordSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordSignUp.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignUp.Location = new System.Drawing.Point(189, 221);
            this.txtPasswordSignUp.Name = "txtPasswordSignUp";
            this.txtPasswordSignUp.PasswordChar = '*';
            this.txtPasswordSignUp.Size = new System.Drawing.Size(200, 17);
            this.txtPasswordSignUp.TabIndex = 14;
            this.txtPasswordSignUp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(185, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // ClearDataSignUp
            // 
            this.ClearDataSignUp.AutoSize = true;
            this.ClearDataSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.ClearDataSignUp.Location = new System.Drawing.Point(196, 257);
            this.ClearDataSignUp.Name = "ClearDataSignUp";
            this.ClearDataSignUp.Size = new System.Drawing.Size(31, 13);
            this.ClearDataSignUp.TabIndex = 17;
            this.ClearDataSignUp.TabStop = true;
            this.ClearDataSignUp.Text = "Clear";
            this.ClearDataSignUp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.ClearDataSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearDataSignUp_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Poppins ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(244, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sign Up";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(189, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel2.Location = new System.Drawing.Point(189, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel3.Location = new System.Drawing.Point(189, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.panel4.Location = new System.Drawing.Point(189, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 2);
            this.panel4.TabIndex = 22;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(306, 252);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(83, 27);
            this.btnSignUp.TabIndex = 23;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Final_Project_PBO_1.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(552, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backSignUpPage
            // 
            this.backSignUpPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backSignUpPage.Image = global::Final_Project_PBO_1.Properties.Resources.back;
            this.backSignUpPage.Location = new System.Drawing.Point(12, 12);
            this.backSignUpPage.Name = "backSignUpPage";
            this.backSignUpPage.Size = new System.Drawing.Size(39, 17);
            this.backSignUpPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backSignUpPage.TabIndex = 24;
            this.backSignUpPage.TabStop = false;
            this.backSignUpPage.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnHidePW
            // 
            this.btnHidePW.BackgroundImage = global::Final_Project_PBO_1.Properties.Resources.see;
            this.btnHidePW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHidePW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePW.FlatAppearance.BorderSize = 0;
            this.btnHidePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePW.Location = new System.Drawing.Point(373, 218);
            this.btnHidePW.Name = "btnHidePW";
            this.btnHidePW.Size = new System.Drawing.Size(16, 20);
            this.btnHidePW.TabIndex = 27;
            this.btnHidePW.UseVisualStyleBackColor = true;
            this.btnHidePW.Visible = false;
            this.btnHidePW.Click += new System.EventHandler(this.btnHidePW_Click);
            // 
            // btnShowPW
            // 
            this.btnShowPW.BackgroundImage = global::Final_Project_PBO_1.Properties.Resources.hide;
            this.btnShowPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPW.FlatAppearance.BorderSize = 0;
            this.btnShowPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPW.Location = new System.Drawing.Point(373, 218);
            this.btnShowPW.Name = "btnShowPW";
            this.btnShowPW.Size = new System.Drawing.Size(16, 20);
            this.btnShowPW.TabIndex = 26;
            this.btnShowPW.UseVisualStyleBackColor = true;
            this.btnShowPW.Visible = false;
            this.btnShowPW.Click += new System.EventHandler(this.btnShowPW_Click);
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.btnHidePW);
            this.Controls.Add(this.btnShowPW);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backSignUpPage);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClearDataSignUp);
            this.Controls.Add(this.txtPasswordSignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameSignUp);
            this.Controls.Add(this.txtUsernameSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backSignUpPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsernameSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtEmailSignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtNameSignUp;
        private System.Windows.Forms.TextBox txtPasswordSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel ClearDataSignUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox backSignUpPage;
        private System.Windows.Forms.Button btnHidePW;
        private System.Windows.Forms.Button btnShowPW;
    }
}
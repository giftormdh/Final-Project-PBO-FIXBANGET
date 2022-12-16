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
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsernameSignUp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailSignUp = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameSignUp = new System.Windows.Forms.MaskedTextBox();
            this.txtPasswordSignUp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmPassSignUp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearDataSignUp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtUsernameSignUp
            // 
            this.txtUsernameSignUp.Location = new System.Drawing.Point(273, 164);
            this.txtUsernameSignUp.Name = "txtUsernameSignUp";
            this.txtUsernameSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtUsernameSignUp.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // txtEmailSignUp
            // 
            this.txtEmailSignUp.Location = new System.Drawing.Point(273, 138);
            this.txtEmailSignUp.Name = "txtEmailSignUp";
            this.txtEmailSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtEmailSignUp.TabIndex = 5;
            this.txtEmailSignUp.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtUsername_MaskInputRejected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project_PBO_1.Properties.Resources.userprofile;
            this.pictureBox1.Location = new System.Drawing.Point(238, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name";
            // 
            // txtNameSignUp
            // 
            this.txtNameSignUp.Location = new System.Drawing.Point(273, 112);
            this.txtNameSignUp.Name = "txtNameSignUp";
            this.txtNameSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtNameSignUp.TabIndex = 11;
            // 
            // txtPasswordSignUp
            // 
            this.txtPasswordSignUp.Location = new System.Drawing.Point(273, 190);
            this.txtPasswordSignUp.Name = "txtPasswordSignUp";
            this.txtPasswordSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordSignUp.TabIndex = 14;
            this.txtPasswordSignUp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // txtConfirmPassSignUp
            // 
            this.txtConfirmPassSignUp.Location = new System.Drawing.Point(273, 216);
            this.txtConfirmPassSignUp.Name = "txtConfirmPassSignUp";
            this.txtConfirmPassSignUp.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmPassSignUp.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Confirm";
            // 
            // ClearDataSignUp
            // 
            this.ClearDataSignUp.AutoSize = true;
            this.ClearDataSignUp.LinkColor = System.Drawing.Color.Red;
            this.ClearDataSignUp.Location = new System.Drawing.Point(210, 259);
            this.ClearDataSignUp.Name = "ClearDataSignUp";
            this.ClearDataSignUp.Size = new System.Drawing.Size(31, 13);
            this.ClearDataSignUp.TabIndex = 17;
            this.ClearDataSignUp.TabStop = true;
            this.ClearDataSignUp.Text = "Clear";
            this.ClearDataSignUp.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.ClearDataSignUp);
            this.Controls.Add(this.txtConfirmPassSignUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPasswordSignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameSignUp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUsernameSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUsernameSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtEmailSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtNameSignUp;
        private System.Windows.Forms.TextBox txtPasswordSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmPassSignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel ClearDataSignUp;
    }
}
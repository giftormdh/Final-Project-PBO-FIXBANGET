using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_PBO_1
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( txtUsernameSignIn.Text=="variabel_username" && txtPasswordSignIn.Text == "variabel_password")
            {
                var homepage = new HomePage();
                this.Hide();
                homepage.Show();
            }

            else
            {
                MessageBox.Show("Username or Password Incorrect");
            }
        }

        private void txtUsername_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsernameSignIn.Clear();
            txtPasswordSignIn.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signup = new SignUpPage();
            this.Hide();
            signup.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
       
        }

        private void txtPasswordSignIn_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordSignIn.Text.Length > 0)
            {
                btnShowPW.Visible = true;
            }
            else
            {
                btnShowPW.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstPage firstpage = new FirstPage();
            firstpage.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPW_Click(object sender, EventArgs e)
        {
            if (txtPasswordSignIn.PasswordChar == '*')
            {
                txtPasswordSignIn.PasswordChar = '\0';
                btnShowPW.Hide();
                btnHidePW.Show();
                
            }
            else
            {
                txtPasswordSignIn.PasswordChar = '*';
            }
        }

        private void btnHidePW_Click(object sender, EventArgs e)
        {
            if (txtPasswordSignIn.PasswordChar == '\0')
            {
                txtPasswordSignIn.PasswordChar = '*';
                btnHidePW.Hide();
                btnShowPW.Show();
            }
            else
            {
                txtPasswordSignIn.PasswordChar = '\0';
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_PBO_1
{
    public partial class SignUpPage : Form
    {
        public static DataUser inputData = new DataUser();
        
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void txtUsername_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordSignUp.Text.Length > 0)
            {
                btnShowPW.Visible = true;
            }
            else
            {
                btnShowPW.Visible = false;
            }
        }

        private void ClearDataSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsernameSignUp.Clear();
            txtNameSignUp.Clear();
            txtEmailSignUp.Clear();
            txtPasswordSignUp.Clear();
        }

        private void txtNameSignUp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginpage = new LoginPage();
            loginpage.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShowPW_Click(object sender, EventArgs e)
        {
            if (txtPasswordSignUp.PasswordChar == '*')
            {
                txtPasswordSignUp.PasswordChar = '\0';
                btnShowPW.Hide();
                btnHidePW.Show();
            }
            else
            {
                txtPasswordSignUp.PasswordChar = '*';
            }
        }

        private void btnHidePW_Click(object sender, EventArgs e)
        {
            if (txtPasswordSignUp.PasswordChar == '\0')
            {
                txtPasswordSignUp.PasswordChar = '*';
                btnHidePW.Hide();
                btnShowPW.Show();

            }
            else
            {
                txtPasswordSignUp.PasswordChar = '\0';
            }
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            var homepage = new HomePage();
            this.Hide();
            homepage.Show();

            inputData.name = txtNameSignUp.Text;
            inputData.email = txtEmailSignUp.Text;
            inputData.username = txtUsernameSignUp.Text;
            inputData.password = txtPasswordSignUp.Text;

        }
    }
}

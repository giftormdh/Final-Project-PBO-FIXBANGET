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
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            var homepage = new HomePage();
            this.Hide();
            homepage.Show();
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }

        private void AdminPageLogout_Click(object sender, EventArgs e)
        {
            var backtologinpage = new LoginPage();

            this.Hide();

            backtologinpage.Show();
        }
    }
}

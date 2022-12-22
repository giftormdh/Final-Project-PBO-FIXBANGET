using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Final_Project_PBO_1
{
    public partial class HomePage : Form
    {
/*        SqlConnection connection;
        string connectionString;*/
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 19; i++)
            {
                BoxList Container = new Final_Project_PBO_1.BoxList();
                this.panel3.Controls.Add(Container);

                Container.BackColor = System.Drawing.Color.White;
                Container.Location = new System.Drawing.Point(30+(300*(i%4)), 38+(200*(i/4)));
                Container.Margin = new System.Windows.Forms.Padding(3, 1012, 3, 1012);
                Container.Name = "boxList1";
                Container.Size = new System.Drawing.Size(257, 165);
                Container.TabIndex = i;
                Container.Load += new System.EventHandler(this.Container_Load);
            }
        }
        private void Container_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lists1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void boxList1_Load(object sender, EventArgs e)
        {

        }

        private void boxList9_Load(object sender, EventArgs e)
        {

        }

        private void boxList10_Load(object sender, EventArgs e)
        {

        }

        private void boxList11_Load(object sender, EventArgs e)
        {

        }

        private void boxList12_Load(object sender, EventArgs e)
        {

        }

        private void boxList5_Load(object sender, EventArgs e)
        {

        }

        private void boxList6_Load(object sender, EventArgs e)
        {

        }

        private void boxList7_Load(object sender, EventArgs e)
        {

        }

        private void boxList8_Load(object sender, EventArgs e)
        {

        }

        private void boxList4_Load(object sender, EventArgs e)
        {

        }

        private void boxList3_Load(object sender, EventArgs e)
        {

        }

        private void boxList2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*BoxList Container = new BoxList();*/
 
/*
            Container.Size = new Size(257, 218);
            Container.Location = new Point(30, 38);
            Container.Text = "COBAAAA";*/
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BoxList Container = new BoxList();
            this.Controls.Add(Container);

            Container.BackColor = System.Drawing.Color.White;
            Container.Location = new System.Drawing.Point(329, 38);
            Container.Margin = new System.Windows.Forms.Padding(3, 1012, 3, 1012);
            Container.Name = "boxList1";
            Container.Size = new System.Drawing.Size(257, 218);
            Container.TabIndex = 0;
            Container.Load += new System.EventHandler(this.Container_Load);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private void lists1_Load_1(object sender, EventArgs e)
        {
            lists1.Height = 73;
        }*/
    }
}

﻿using System;
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
    public partial class HomeMenu : UserControl
    {
        public HomeMenu()
        {
            InitializeComponent();
        }

        private void HomeMenu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                BoxList Container = new Final_Project_PBO_1.BoxList();
                this.panel3.Controls.Add(Container);

                Container.BackColor = System.Drawing.Color.White;
                Container.Location = new System.Drawing.Point(30 + (300 * (i % 4)), 38 + (200 * (i / 4)));
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

    }
}
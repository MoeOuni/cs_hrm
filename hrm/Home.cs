﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hrm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeaveRequest page = new LeaveRequest();

            page.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LeaveList page = new LeaveList();

            page.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddUser page = new AddUser();

            page.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SubordinatesLeaves page = new SubordinatesLeaves();

            page.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AllLeve
        }
    }
}

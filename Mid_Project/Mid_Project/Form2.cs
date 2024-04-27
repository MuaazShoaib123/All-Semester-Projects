using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mid_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            dgv_stu.Visible = true;
            panel1.Visible = true;
            tableLayoutPanel1.Visible = true;
            button1.Visible = true;
            Search.Visible = false;
            Search_tbox.Visible = false;
            button1.Text = "Insert";
            button1.ForeColor = Color.Red;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dgv_stu.Visible = false;
            panel1.Visible = false;
            Search.Visible = false; ;
            Search_tbox.Visible = false;
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            tableLayoutPanel1.Visible = false;
            Search.Visible = true;
            Search_tbox.Visible = true;
            button1.Visible = false;
        }

        private void updatestu_button_Click(object sender, EventArgs e)
        {
            dgv_stu.Visible = true;
            panel1.Visible = true;
            tableLayoutPanel1.Visible = true;
            button1.Visible = true;
            Search.Visible = false;
            Search_tbox.Visible = false;
            button1.Text = "Update";
            button1.ForeColor = Color.Yellow;
        }
    }
}

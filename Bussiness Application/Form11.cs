using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussiness_Application.BL;
using Bussiness_Application.DL;

namespace Bussiness_Application
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            foreach(Student s in Applied_Stu.Applied_stu)
            {
                dataGridView1.Rows.Add(s.Name, s.Father, s.Age, s.Matricmarks, s.City, s.Discipline, s.Aggrigate);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussiness_Application.DL;
using Bussiness_Application.BL;

namespace Bussiness_Application
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            foreach (Registered_Stu s in Registered_Stu_Dl.Registeredstu)
            {
                dataGridView1.Rows.Add(s.O.username, s.O.password, s.Name, s.Rollno, s.Discipline, s.Session, s.Age, s.City);
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }
    }
}

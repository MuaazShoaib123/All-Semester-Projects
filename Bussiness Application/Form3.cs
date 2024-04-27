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
using Bussiness_Application.Variables;

namespace Bussiness_Application
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            Class1.username = username;
            string password = textBox2.Text;
            Muser_BL login = new Muser_BL(username, password);
           bool flag = Registered_Stu_Dl.checkuser(username, password);
            if(flag == true)
            {
                Form6 f = new Form6();
                f.Show();
            }
            else
            {
                Form4 f = new Form4();
                f.Show();
            }
           
        }
    }
}

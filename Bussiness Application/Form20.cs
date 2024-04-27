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
using System.IO;

namespace Bussiness_Application
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }
        string rollno;
        private void button1_Click(object sender, EventArgs e)
        {
            rollno = textBox1.Text;
            bool flag = checkroll();
            if(flag == true)
            {
                label2.Visible = true;
                textBox2.Visible = true;
                label4.Visible = true;
                textBox3.Visible = true;
                label5.Visible = true;
                textBox4.Visible = true;
                label6.Visible = true;
                textBox5.Visible = true;
                label7.Visible = true;
                textBox6.Visible = true;
                label8.Visible = true;
                textBox7.Visible = true;
                button1.Visible = false;
                button3.Visible = true;
            }
        }
        public bool checkroll()
        {
            foreach(Registered_Stu s in Registered_Stu_Dl.Registeredstu)
            {
                if(rollno == s.Rollno)
                {
                    return true;
                }
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int english = int.Parse(textBox2.Text);
            int urdu = int.Parse(textBox3.Text);
            int physics = int.Parse(textBox4.Text);
            int chemistry = int.Parse(textBox5.Text);
            int mbc = int.Parse(textBox6.Text);
            int islamiat = int.Parse(textBox7.Text);
            Exam_BL f = new Exam_BL(rollno, english, urdu, physics, chemistry, mbc, islamiat);
            Exam_DL.addtolist(f);
            MessageBox.Show("Result Uploaded");
            Form5 g = new Form5();
            g.Show();
            this.Hide();
        }
    }
}

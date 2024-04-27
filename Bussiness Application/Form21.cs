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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }
        string rollno;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            getrollno();
            foreach (Exam_BL f in Exam_DL.Result)
            {
                if (rollno == f.O.Rollno)
                {
                    dataGridView1.Rows.Add(f.O.Rollno, f.English, f.Urdu, f.Physics, f.Chemistry, f.Mbc, f.Islamiat, f.Total);
                    break;
                }
            }

        }
        public void getrollno()
        {
            for (int x = 0; x < Registered_Stu_Dl.Registeredstu.Count; x = x + 1)
            {
                if (Class1.username == Registered_Stu_Dl.Registeredstu[x].O.Username)
                {
                    rollno = Registered_Stu_Dl.Registeredstu[x].Rollno;
                    break;
                }
            }
        }
    }
}

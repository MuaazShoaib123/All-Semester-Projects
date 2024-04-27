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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        string rollno;
        private void button1_Click(object sender, EventArgs e)
        {
            rollno = textBox1.Text;
            bool flag = checkrollno();
            if(flag == true)
            {
                foreach (Registered_Stu s in Registered_Stu_Dl.Registeredstu)
                {

                }
            }
        }
        public bool checkrollno()
        {
            
           for(int x = 0; x < Registered_Stu_Dl.Registeredstu.Count; x = x + 1)
            {
                if(rollno == Registered_Stu_Dl.Registeredstu[x].Rollno)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

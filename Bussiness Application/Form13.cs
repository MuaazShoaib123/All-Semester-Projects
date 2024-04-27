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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        int seatfsceng = 2;
        int seatfscmed = 2;
        int seatics = 1;
        int count = 0;
        public bool checkmerit() { 
        if (count == 1)
        { 
                string name = textBox4.Text;
              List<Student> sortedlist = Applied_Stu.Applied_stu.OrderByDescending(o => o.Aggrigate).ToList();
          foreach (Student s in sortedlist)
        {
        if (name == s.Name)
        {
            if (s.Discipline == "FSC-PRE ENGG" && seatfsceng > 0)
            {
                seatfsceng = seatfsceng - 1;
                return true;
                break;
            }
            if (s.Discipline == "FSC-PRE Medical" && seatfscmed > 0)
            {
                seatfscmed = seatfscmed - 1;
                return true; 
                break;
                 
            }
            if (s.Discipline == "ICS" && seatics > 0)
            {
                seatics = seatics - 1;
                return true;
                break;
            }
        }
    }
}
            return false;
}
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty)
            {
                count = 0;
            }
            else
            {
                count = 1;
            }
            bool flag = checkmerit();
            if(flag == true)
            {
                Form14 f = new Form14();
                f.Show();
            }
            else
            {
                Form15 f = new Form15();
                f.Show();
            }
        }
    }

}

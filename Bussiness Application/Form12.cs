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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        int seatfsceng = 2;
        int seatfscmed = 2;
        int seatics = 1;
        private void Form12_Load(object sender, EventArgs e)
        {
            List<Student> sortedlist = Applied_Stu.Applied_stu.OrderByDescending(o => o.Aggrigate).ToList();
            foreach(Student s in sortedlist)
            {
                if(s.Discipline == "FSC-PRE ENGG" && seatfsceng > 0)
                {
                    dataGridView1.Rows.Add(s.Name, s.Father, s.Age, s.Matricmarks, s.City, s.Discipline, s.Aggrigate);
                    seatfsceng = seatfsceng - 1;
                }
                if(s.Discipline == "FSC-PRE Medical" && seatfscmed > 0)
                {
                    dataGridView1.Rows.Add(s.Name, s.Father, s.Age, s.Matricmarks, s.City, s.Discipline, s.Aggrigate);
                    seatfscmed = seatfscmed - 1;
                }
                if(s.Discipline == "ICS" && seatics > 0)
                {
                    dataGridView1.Rows.Add(s.Name, s.Father, s.Age, s.Matricmarks, s.City, s.Discipline, s.Aggrigate);
                    seatics = seatics - 1; 
                }
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

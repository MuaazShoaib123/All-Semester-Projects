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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        int seatfsceng = 2;
        int seatfscmed = 2;
        int seatics = 1;
        private void Form16_Load(object sender, EventArgs e)
        {
            
            List<Student> sortedlist = Applied_Stu.Applied_stu.OrderByDescending(o => o.Aggrigate).ToList();
            foreach (Student s in sortedlist)
            {
                if (s.Discipline == "FSC-PRE ENGG" && seatfsceng > 0)
                {
                    dataGridView2.Rows.Add(s.Name, s.Father, s.Age, s.Matricmarks, s.City, s.Discipline, s.Aggrigate);
                    seatfsceng = seatfsceng - 1;
                }
                if (s.Discipline == "FSC-PRE Medical" && seatfscmed > 0)
                {
                    dataGridView2.Rows.Add(s.Name, s.Father, s.Age, s.Matricmarks, s.City, s.Discipline, s.Aggrigate);
                    seatfscmed = seatfscmed - 1;
                }
                if (s.Discipline == "ICS" && seatics > 0)
                {
                    dataGridView2.Rows.Add(s.Name, s.Father, s.Age, s.Matricmarks, s.City, s.Discipline, s.Aggrigate);
                    seatics = seatics - 1;
                }
            }
            comboBox3.Items.Add("FSC-PRE ENGG");
            comboBox3.Items.Add("FSC-PRE Medical");
            comboBox3.Items.Add("ICS");
            comboBox4.Items.Add("2020");
            comboBox4.Items.Add("2021");
            comboBox1.Items.Add("15");
            comboBox1.Items.Add("16");
            comboBox1.Items.Add("17");
            comboBox1.Items.Add("18");
            comboBox1.Items.Add("19");
            comboBox1.Items.Add("20");
            comboBox1.Items.Add("21");
            comboBox2.Items.Add("Abbotabad");
            comboBox2.Items.Add("Bhawalpur");
            comboBox2.Items.Add("Chakwal");
            comboBox2.Items.Add("Dera Ghazi Khan");
            comboBox2.Items.Add("Faislabad");
            comboBox2.Items.Add("Gujranwala");
            comboBox2.Items.Add("Hyderabad");
            comboBox2.Items.Add("Jhung");
            comboBox2.Items.Add("Lahore");
            comboBox2.Items.Add("Multan");
            comboBox2.Items.Add("Patoki");
            comboBox2.Items.Add("Rawalpindi");
            comboBox2.Items.Add("Sialkot");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string password = textBox3.Text;
            string name = textBox1.Text;
            string rollno = textBox4.Text;
            string discipline = comboBox3.SelectedItem.ToString();
            string session = comboBox4.SelectedItem.ToString();
            string age = comboBox1.SelectedItem.ToString();
            string city = comboBox2.SelectedItem.ToString();
            dataGridView1.Rows.Add(username, password, name, rollno, discipline,session,age, city);
            Registered_Stu s = new Registered_Stu(username, password, name, rollno, discipline, age, city, session);
            Registered_Stu_Dl.addtolist(s);
        }
    }
}

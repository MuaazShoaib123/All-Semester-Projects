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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        bool flag = false;

        private void Form7_Load(object sender, EventArgs e)
        {
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
            comboBox3.Items.Add("FSC-PRE ENGG");
            comboBox3.Items.Add("FSC-PRE Medical");
            comboBox3.Items.Add("ICS");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             flag = true;
            if (flag == true)
            {
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, father, city, discipline;
            float matricmarks;
            string age;
            name = textBox1.Text;
            father = textBox2.Text + textBox3.Text;
            age = comboBox1.SelectedItem.ToString();
            city = comboBox2.SelectedItem.ToString();
            discipline = comboBox3.SelectedItem.ToString();
            matricmarks = float.Parse(textBox4.Text);
            Student s = new Student(name, father, matricmarks, city, age, discipline,"Applied_Stu.txt");
            Applied_Stu.Applied_stu.Add(s);
            Form8 f = new Form8();
            f.Show();
            this.Hide();
        }
        public void add()
        {

        }
    }
}

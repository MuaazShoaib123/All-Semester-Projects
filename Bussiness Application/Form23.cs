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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }
        int index;
        Registered_Stu previous;
        Registered_Stu updated;
        private void Form23_Load(object sender, EventArgs e)
        {
            Class1.count = 0;
            foreach (Registered_Stu s in Registered_Stu_Dl.Registeredstu)
            {
                dataGridView1.Rows.Add(s.O.Username, s.O.Password, s.Name, s.Rollno, s.Discipline, s.Session, s.Age, s.City);

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

        private void datagrid(object sender, DataGridViewCellEventArgs e)
        {
             index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[2].Value.ToString();
            textBox2.Text = row.Cells[0].Value.ToString();
            textBox3.Text = row.Cells[1].Value.ToString();
            comboBox3.Text = row.Cells[4].Value.ToString();
            comboBox4.Text = row.Cells[5].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            comboBox1.Text = row.Cells[6].Value.ToString();
            comboBox2.Text = row.Cells[7].Value.ToString();
            string name = textBox1.Text;
            string username = textBox2.Text;
            string password = textBox3.Text;
            string discipline = comboBox3.SelectedItem.ToString();
            string session = comboBox4.SelectedItem.ToString();
            string rollno = textBox4.Text;
            string age = comboBox1.SelectedItem.ToString();
            string city = comboBox2.SelectedItem.ToString();
            previous = new Registered_Stu(username, password, name, rollno, discipline, age, city, session);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            DataGridViewRow edit = dataGridView1.Rows[index];
            edit.Cells[0].Value = textBox2.Text;
            edit.Cells[1].Value = textBox3.Text;
            edit.Cells[2].Value = textBox1.Text;
            edit.Cells[3].Value = textBox4.Text;
            edit.Cells[4].Value = comboBox3.SelectedItem.ToString();
            edit.Cells[5].Value = comboBox4.SelectedItem.ToString();
            edit.Cells[6].Value = comboBox1.SelectedItem.ToString();
            edit.Cells[7].Value = comboBox2.SelectedItem.ToString();
            string name = textBox1.Text;
            string username = textBox2.Text;
            string password = textBox3.Text;
            string discipline = comboBox3.SelectedItem.ToString();
            string session = comboBox4.SelectedItem.ToString();
            string rollno = textBox4.Text;
            string age = comboBox1.SelectedItem.ToString();
            string city = comboBox2.SelectedItem.ToString();
            updated = new Registered_Stu(username, password, name, rollno, discipline, age, city, session);
            Registered_Stu_Dl.edituser(previous, updated);
            Registered_Stu_Dl.storeinfile();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(index);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox3.Text = string.Empty;
            comboBox4.Text = string.Empty;
            textBox4.Text = string.Empty;
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            Registered_Stu_Dl.deleteuser(previous);
            Registered_Stu_Dl.storeinfile();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.count = 1;
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }
    }
}

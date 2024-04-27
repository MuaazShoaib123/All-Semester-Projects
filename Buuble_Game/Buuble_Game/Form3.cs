using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buuble_Game.Variables;

namespace Buuble_Game
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void next_link (object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Class1.count == 0)
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            if(Class1.count == 1)
            {
                Form4 f = new Form4();
                f.Show();
                this.Hide();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }
    }
}

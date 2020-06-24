using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string car = "hon";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            car = "hon";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            car = "nis";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            car = "civ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (car == "hon")
            {
                textBox3.Text = "$" + (2 * (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)));
            }
            else if(car == "nis")
            {
                textBox3.Text = "$" + (3 * (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)));
            }
            else
            {
                textBox3.Text = "$" + (4 * (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

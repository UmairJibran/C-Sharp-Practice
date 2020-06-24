using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "" + (int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "" + (int.Parse(textBox1.Text) - int.Parse(textBox2.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "" + (int.Parse(textBox1.Text) * int.Parse(textBox2.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "" + (int.Parse(textBox1.Text) / int.Parse(textBox2.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

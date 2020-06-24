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
        String car = "Honda";
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            car = "Honda";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            car = "Toyota";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            car = "Suzuki";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 0;
            if(car == "Honda")
            {
                price = int.Parse(textBox1.Text) * int.Parse(textBox2.Text) * 10;
            }else if(car == "Toyota")
            {
                price = int.Parse(textBox1.Text) * int.Parse(textBox2.Text) * 7;
            }
            else
            {
                price = int.Parse(textBox1.Text) * int.Parse(textBox2.Text) * 5;
            }
            textBox3.Text = "$" + price;
        }
    }
}

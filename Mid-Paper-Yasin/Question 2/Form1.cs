using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int quantity = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(String book in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(book);
            }
            quantity = checkedListBox1.CheckedItems.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + quantity;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "" + quantity * 500;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
        }
    }
}

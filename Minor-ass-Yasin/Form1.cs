using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minor_ass_Yasin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int entry = int.Parse(textBox1.Text);
            for (int i = 0; i < 30;)
            {
                listBox1.Items.Add(entry + " times " + ++i + " equals " + i * entry);
            }
        }
    }
}

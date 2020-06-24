using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Create(@"D:/yasin.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Move(@"D:/yasin.txt",@"E:/yasin.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Copy(@"D:/yasin.txt", @"E:/yasin.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(@"D:/yasin.txt");
            txt.Write(textBox1.Text);
            txt.Close();
        }
    }
}

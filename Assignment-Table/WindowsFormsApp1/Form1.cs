using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int tableOf;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Focus();
        }
        //8440 - Umair Jibran
        private void button1_Click(object sender, EventArgs e) //table
        {
            listBox1.Items.Clear(); //Clearing it just in case if there was some garbage value in it
            tableOf = int.Parse(textBox1.Text);
            for (int i = 1; i <= 30; i++)
            {
               listBox1.Items.Add(tableOf + " x " + i + " = " + tableOf * i);
            }
        }

        private void button2_Click(object sender, EventArgs e) //reset
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }
        private void button3_Click(object sender, EventArgs e) //exit
        {
            listBox1.Items.Clear(); //Clearing it for sake of Memory Clean up
            textBox1.Clear(); //Clearing it for sake of Memory Clean up
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Noumain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float height = float.Parse(textBox1.Text) / 100;
            float width = float.Parse(textBox2.Text);
            float bmi = width / (height * height);
            listBox1.Items.Add(bmi);
        }
    }
}

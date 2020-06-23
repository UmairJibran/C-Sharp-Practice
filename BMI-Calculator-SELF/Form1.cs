using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator_SELF
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
            float weight = float.Parse(textBox2.Text);
            float bmi = weight / (height * height);
            textBox3.Text = "" + bmi;
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator_8545
{
    public partial class Form1 : Form
    {
        public Form1(){
            InitializeComponent();
        }

        bool imerial = true;

        private void radioButton1_CheckedChanged(object sender, EventArgs e){//Imperial
            imerial = true;
            label1.Text = "Height (Inches)";
            label2.Text = "Weight (Pounds)";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e){//Metric
            imerial = false;
            label1.Text = "Height (Centimeters)";
            label2.Text = "Weight (Kilograms)";
        }

        private void button1_Click(object sender, EventArgs e){
            float height = float.Parse(textBox1.Text);
            float weight = float.Parse(textBox2.Text);
            float bmi = 00;
            if (imerial){
                bmi = 703 * (weight / (height * height));
            }else{
                height = height / 100;
                bmi = weight / (height * height);
            }
            textBox3.Text = "" + bmi;
        }
    }
}

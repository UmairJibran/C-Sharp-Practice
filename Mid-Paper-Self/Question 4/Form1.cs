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
        String carModel = "";
        float rent = 00;
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { carModel = "C"; } //corola
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { carModel = "H"; } //Honda Civic
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { carModel = "N"; } //Nissan
        private void button1_Click(object sender, EventArgs e){
            float days = float.Parse(textBox1.Text);
            float mileage = float.Parse(textBox2.Text);
            switch (carModel){
                case "C":{ //Corolla
                    rent = 2 * (days * mileage);
                    break;
                }
                case "H":{ //Honda
                    rent = 3 * (days * mileage);
                    break;
                }
                case "N":{ //Nissan
                    rent = 4 * (days * mileage);
                    break;
                }
            }
            textBox3.Text = "$" + rent;
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

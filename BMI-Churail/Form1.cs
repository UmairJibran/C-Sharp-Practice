using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Churail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_ayesha_Click(object sender, EventArgs e)
        {
            float height = float.Parse(height_ayesha.Text);
            float width = float.Parse(width_ayesha.Text);
            float bmi = 703 * (width / (height * height));
            answer.Text = "" + bmi;
        }
    }
}

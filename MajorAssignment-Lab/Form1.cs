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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ageInYears = dateTimePicker2.Value.Year - dateTimePicker1.Value.Year;
            var ageInMonths = dateTimePicker2.Value.Month - dateTimePicker1.Value.Month;
            var ageInDays = dateTimePicker2.Value.Day - dateTimePicker1.Value.Day;
            textBox1.Text = "You are " + ageInDays + " Days " + ageInMonths + " Months and " + ageInYears + " Years Old";
        }
    }
}

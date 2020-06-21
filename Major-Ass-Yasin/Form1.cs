using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Major_Ass_Yasin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var thisDate = dateTimePicker2.Value.Year;
            var birth = dateTimePicker1.Value.Year;
            var currentAge = thisDate - birth;
            textBox1.Text = currentAge.ToString();
        }
    }
}

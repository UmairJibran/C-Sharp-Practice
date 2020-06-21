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
            var today = dateTimePicker2.Value.Year;
            var byear = dateTimePicker1.Value.Year;
            var age = today - byear;
            textBox1.Text = "" + age;
        }
    }
}

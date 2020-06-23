using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingDataFromFormToForm
{
    public partial class Form1 : Form
    {
        public static String firstName;
        public static String lastName;
        public static int age;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstName = textBox1.Text;
            lastName = textBox2.Text;
            age = int.Parse(textBox3.Text);
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}

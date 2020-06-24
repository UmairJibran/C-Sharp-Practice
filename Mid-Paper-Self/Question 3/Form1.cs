using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float op1 = 0, op2 = 0, answer = 0;
        void getOperands(){
            op1 = float.Parse(textBox1.Text);
            op2 = float.Parse(textBox2.Text);
        }
        void setResult() { textBox3.Text = "" + answer; }
        private void button5_Click(object sender, EventArgs e){
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e){
            getOperands();
            answer = op1 - op2;
            setResult();
        }

        private void button3_Click(object sender, EventArgs e){
            getOperands();
            answer = op1 * op2;
            setResult();
        }

        private void button4_Click(object sender, EventArgs e){
            getOperands();
            try{
                answer = op1 / op2;
            }catch(DivideByZeroException exception){
                throw exception;
            }
            setResult();
        }

        private void button6_Click(object sender, EventArgs e){
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e){
            getOperands();
            answer = op1 + op2;
            setResult();
        }
    }
}

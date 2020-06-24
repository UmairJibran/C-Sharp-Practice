using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_1
{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }
        //8440 Umair Jibran
        private void button1_Click(object sender, EventArgs e){
            if (File.Exists(@"../.././8440.txt")) MessageBox.Show("File Exists");
            else File.Create(@"../.././8440.txt");
        }
        private void button2_Click(object sender, EventArgs e){
            if (File.Exists(@"../.././8440.txt")){
                File.Copy(@"../.././8440.txt", @".././8440.txt");
                MessageBox.Show("Copied Succesfully");
            }
            else MessageBox.Show("No Such File Exists");

        }
        private void button3_Click(object sender, EventArgs e){
            if (File.Exists(@"../.././8440.txt")){
                File.Move(@"../.././8440.txt", @".././8440.txt");
                MessageBox.Show("Moved Succesfully");
            }
            else MessageBox.Show("No Such File Exists");
        }
        private void button4_Click(object sender, EventArgs e){
            if (File.Exists(@"../.././8440.txt")){
                String message = textBox1.Text;
                TextWriter txt = new StreamWriter(@"../.././8440.txt");
                txt.Write(message);
                txt.Close();
                MessageBox.Show(message + " Written Succesfully");
            }
            else MessageBox.Show("File Doesn't Exist Please Create it First");
        }
    }
}

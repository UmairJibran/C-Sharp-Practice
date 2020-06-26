using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
            connection.Open();
            string id = textBox1.Text;
            string fname = textBox2.Text;
            string lname = textBox3.Text;
            string age = textBox4.Text;
            string query = "INSERT INTO `myfinalpaper`.`question1` (`id`, `fname`, `lname`, `age`) VALUES " + "(" + id + ", '" + fname + "', '" + lname + "', " + age + ");";
            var command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }
}

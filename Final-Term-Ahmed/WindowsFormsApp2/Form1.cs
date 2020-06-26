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
            string name = textBox2.Text;
            string price = textBox4.Text;
            string query = "INSERT INTO `myfinalpaper`.`question2` (`id`, `name`, `price`) VALUES " + "(" + id + ", '" + name + "'," + price + ");";
            var command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
            MySqlDataAdapter myadapter = new MySqlDataAdapter("SELECT * FROM myfinalpaper.question2", connection);
            connection.Open();
            DataSet ds = new DataSet();
            myadapter.Fill(ds, "question2");
            dataGridView1.DataSource = ds.Tables["question2"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
            connection.Open();
            string query = "DELETE FROM myfinalpaper.question2 WHERE `id` = '" + id + "';";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
            connection.Open();
            string id = textBox1.Text;
            string name = textBox2.Text;
            string price = textBox4.Text;
            string query = "UPDATE `myfinalpaper`.`question2` SET `name` = '" + name + "', `price` = '" + price + "' WHERE (`id` = '" + id+"');";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox5.Text;
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
            MySqlDataAdapter myadapter = new MySqlDataAdapter("SELECT * FROM myfinalpaper.question2 WHERE `name` = '"+name+"';", connection);
            connection.Open();
            DataSet ds = new DataSet();
            myadapter.Fill(ds, "question2");
            dataGridView1.DataSource = ds.Tables["question2"];
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kamaluddin_shinwari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        private void Form1_Load(object sender, EventArgs e)
        {
        connection.Open();
            MySqlDataAdapter myadapter = new MySqlDataAdapter("SELECT * FROM  yasin.yasin_table", connection);
            DataSet ds = new DataSet();
            myadapter.Fill(ds, "yasin_table");
            dataGridView2.DataSource = ds.Tables["yasin_table"];
        }
    }
}

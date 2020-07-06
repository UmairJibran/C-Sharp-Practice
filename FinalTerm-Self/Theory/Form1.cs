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

namespace Theory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root");
        private void Form1_Load(object sender, EventArgs e){
            try{
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM db_umair.tbl_umair", conn);
                conn.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tbl_umair");
                dataGridView1.DataSource = ds.Tables["tbl_umair"];
                conn.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}

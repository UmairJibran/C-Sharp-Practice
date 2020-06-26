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

namespace Question_1
{
    public partial class frm_insert : Form
    {
        public frm_insert()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        private void frm_insert_Load(object sender, EventArgs e)
        {
            conn.Open();
            if (conn.State==ConnectionState.Open)
            {
                txtbx_id.Focus();
            }
            else
            {
                MessageBox.Show("Database couldn't be opened!");
            }
        }

        private void btn_insert_record_Click(object sender, EventArgs e)
        {

        }
    }
}

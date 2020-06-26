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

namespace Question_2
{
    public partial class FRM_search : Form
    {
        public FRM_search()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        private void btn_search_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbx_id.Text);
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM final_exam.stationary_store WHERE `item_id` =" + id , conn);
                conn.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "stationary_store");
                dataGridView1.DataSource = ds.Tables["stationary_store"];
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}

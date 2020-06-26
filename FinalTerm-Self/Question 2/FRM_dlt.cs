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
    public partial class FRM_dlt : Form
    {
        public FRM_dlt()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        private void btn_dlt_Click(object sender, EventArgs e){
            conn.Open();
            if (conn.State != ConnectionState.Open) MessageBox.Show("Connection Failed");
            else{
                int id = int.Parse(txtbx_id.Text);
                string sql = "DELETE FROM final_exam.stationary_store WHERE `item_id` = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}

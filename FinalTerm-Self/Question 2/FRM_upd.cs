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
    public partial class FRM_upd : Form
    {
        public FRM_upd()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        private void btn_upd_Click(object sender, EventArgs e){
            conn.Open();
            if (conn.State != ConnectionState.Open) MessageBox.Show("Connection Failed");
            else
            {
                int id = int.Parse(txtbx_id.Text);
                string name = txtbx_name.Text;
                string pprice = txtbx_pprice.Text;
                string rprice = txtbx_rprice.Text;
                string qty = txtbx_qty.Text;
                string sql = "UPDATE `final_exam`.`stationary_store` SET `item_name` = '"+name+"', `item_purchase_price` = '"+pprice+"'," +
                    "`item_retail_price` = '"+rprice+"', `item_quantity` = '"+qty+"' WHERE (`item_id` = "+id+");";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}

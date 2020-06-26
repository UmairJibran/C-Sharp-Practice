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
    public partial class FRM_insert : Form
    {
        public FRM_insert()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        private void btn_add_Click(object sender, EventArgs e){
            string name = txtbx_name.Text;
            string rprice = txtbx_rprice.Text;
            string pprice = txtbx_pprice.Text;
            string qty = txtbx_qty.Text;
            if (conn.State == ConnectionState.Open){
                string sql = "INSERT INTO `final_exam`.`stationary_store` (`item_name`, `item_purchase_price`, `item_retail_price`," +
                    "`item_quantity`) VALUES ('"+name+"', '"+rprice+"', '"+pprice+"', '"+qty+"');";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void FRM_insert_Load(object sender, EventArgs e){conn.Open();}

        private void btn_rst_Click(object sender, EventArgs e){
            txtbx_name.Clear();
            txtbx_pprice.Clear();
            txtbx_rprice.Clear();
            txtbx_qty.Clear();
        }
    }
}

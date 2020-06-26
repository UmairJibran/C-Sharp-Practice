using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_1
{
    public partial class FRM_delete_rec : Form
    {
        public FRM_delete_rec()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        private void FRM_delete_rec_Load(object sender, EventArgs e)
        {
            txtbx_id.Focus();
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                int id = int.Parse(txtbx_id.Text);
                string sql = "DELETE FROM final_exam.student_table WHERE `student_id` = '"+id+"';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                txtbx_id.Clear();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
        }
    }
}

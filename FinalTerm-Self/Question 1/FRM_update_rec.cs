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

namespace Question_1
{
    public partial class FRM_update_rec : Form
    {
        public FRM_update_rec()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        private void FRM_update_rec_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            if(conn.State == ConnectionState.Open)
            {
                int id = int.Parse(txtbx_id.Text);
                string first_name = txtbx_fname.Text;
                string last_name = txtbx_lname.Text;
                int age = int.Parse(txtbx_age.Text);
                string sql = "UPDATE `final_exam`.`student_table` SET `student_first_name` = '"+first_name+"', `student_last_name` = '"+last_name+"', `student_age`="+age+" WHERE (`student_id` = '" + id+"');";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                txtbx_age.Clear();
                txtbx_fname.Clear();
                txtbx_id.Clear();
                txtbx_lname.Clear();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
        }
    }
}

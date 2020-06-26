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
            txtbx_id.Focus();
        }

        private void btn_insert_record_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                int id = int.Parse(txtbx_id.Text);
                string first_name = txtbx_fname.Text;
                string last_name = txtbx_lname.Text;
                int age = int.Parse(txtbx_age.Text);
                string sql = "INSERT INTO `final_exam`.`student_table` (`student_id`, `student_first_name`, `student_last_name`, `student_age`) VALUES (" + id + ", '" + first_name + "', '" + last_name + "', " + age + ");";
                MySqlCommand cmd = new MySqlCommand(sql,conn);
                cmd.ExecuteNonQuery();
                txtbx_id.Clear();
                txtbx_fname.Clear();
                txtbx_lname.Clear();
                txtbx_age.Clear();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
        }
    }
}

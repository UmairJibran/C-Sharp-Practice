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
    public partial class FRM_search : Form
    {
        public FRM_search()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        private void FRM_search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtbx_name.Text;
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM final_exam.student_table WHERE student_first_name LIKE '%"+name+ "%' OR student_last_name LIKE '%" + name+"%'", conn);
                conn.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "student_table");
                dataGridView1.DataSource = ds.Tables["student_table"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

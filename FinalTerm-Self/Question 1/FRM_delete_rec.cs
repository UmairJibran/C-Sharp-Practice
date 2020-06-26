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
    }
}

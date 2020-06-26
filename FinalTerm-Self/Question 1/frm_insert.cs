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
    public partial class frm_insert : Form
    {
        public frm_insert()
        {
            InitializeComponent();
        }

        private void frm_insert_Load(object sender, EventArgs e)
        {
            txtbx_id.Focus();
        }

        private void btn_insert_record_Click(object sender, EventArgs e)
        {

        }
    }
}

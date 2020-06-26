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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e){
            frm_insert insertion_form = new frm_insert();
            insertion_form.Show();
        }
        private void btn_update_Click(object sender, EventArgs e){
            FRM_update_rec updation_form = new FRM_update_rec();
            updation_form.Show();
        }
        private void btn_view_Click(object sender, EventArgs e){
            FRM_view_rec view_Rec = new FRM_view_rec();
            view_Rec.Show();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            FRM_delete_rec delete_Rec = new FRM_delete_rec();
            delete_Rec.Show();
        }
        private void btn_search_Click(object sender, EventArgs e){
            FRM_search search = new FRM_search();
            search.Show();
        }
        private void btn_exit_Click(object sender, EventArgs e){Application.Exit();}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

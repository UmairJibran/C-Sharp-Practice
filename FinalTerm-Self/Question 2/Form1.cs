﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ins_Click(object sender, EventArgs e){
            FRM_insert insert = new FRM_insert();
            insert.Show();
        }
        private void btn_dlt_Click(object sender, EventArgs e){
            FRM_dlt dlt = new FRM_dlt();
            dlt.Show();
        }
        private void btn_upd_Click(object sender, EventArgs e){
            FRM_upd upd = new FRM_upd();
            upd.Show();
        }
        private void btn_view_Click(object sender, EventArgs e){
            FRM_view view = new FRM_view();
            view.Show();
        }
        private void btn_search_Click(object sender, EventArgs e){
            FRM_search search = new FRM_search();
            search.Show();
        }
    }
}

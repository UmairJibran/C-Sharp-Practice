﻿namespace Question_1
{
    partial class frm_insert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_id = new System.Windows.Forms.TextBox();
            this.txtbx_fname = new System.Windows.Forms.TextBox();
            this.txtbx_lname = new System.Windows.Forms.TextBox();
            this.txtbx_age = new System.Windows.Forms.TextBox();
            this.btn_insert_record = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // txtbx_id
            // 
            this.txtbx_id.Location = new System.Drawing.Point(113, 44);
            this.txtbx_id.Name = "txtbx_id";
            this.txtbx_id.Size = new System.Drawing.Size(100, 20);
            this.txtbx_id.TabIndex = 5;
            // 
            // txtbx_fname
            // 
            this.txtbx_fname.Location = new System.Drawing.Point(113, 70);
            this.txtbx_fname.Name = "txtbx_fname";
            this.txtbx_fname.Size = new System.Drawing.Size(100, 20);
            this.txtbx_fname.TabIndex = 6;
            // 
            // txtbx_lname
            // 
            this.txtbx_lname.Location = new System.Drawing.Point(113, 96);
            this.txtbx_lname.Name = "txtbx_lname";
            this.txtbx_lname.Size = new System.Drawing.Size(100, 20);
            this.txtbx_lname.TabIndex = 7;
            // 
            // txtbx_age
            // 
            this.txtbx_age.Location = new System.Drawing.Point(113, 122);
            this.txtbx_age.Name = "txtbx_age";
            this.txtbx_age.Size = new System.Drawing.Size(100, 20);
            this.txtbx_age.TabIndex = 8;
            // 
            // btn_insert_record
            // 
            this.btn_insert_record.Location = new System.Drawing.Point(113, 149);
            this.btn_insert_record.Name = "btn_insert_record";
            this.btn_insert_record.Size = new System.Drawing.Size(100, 23);
            this.btn_insert_record.TabIndex = 9;
            this.btn_insert_record.Text = "Insert";
            this.btn_insert_record.UseVisualStyleBackColor = true;
            this.btn_insert_record.Click += new System.EventHandler(this.btn_insert_record_Click);
            // 
            // frm_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 222);
            this.Controls.Add(this.btn_insert_record);
            this.Controls.Add(this.txtbx_age);
            this.Controls.Add(this.txtbx_lname);
            this.Controls.Add(this.txtbx_fname);
            this.Controls.Add(this.txtbx_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_insert";
            this.Text = "Insert Student Record";
            this.Load += new System.EventHandler(this.frm_insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_id;
        private System.Windows.Forms.TextBox txtbx_fname;
        private System.Windows.Forms.TextBox txtbx_lname;
        private System.Windows.Forms.TextBox txtbx_age;
        private System.Windows.Forms.Button btn_insert_record;
    }
}
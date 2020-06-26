namespace Question_2
{
    partial class FRM_insert
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
            this.txtbx_name = new System.Windows.Forms.TextBox();
            this.txtbx_rprice = new System.Windows.Forms.TextBox();
            this.txtbx_pprice = new System.Windows.Forms.TextBox();
            this.txtbx_qty = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_rst = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Retail Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Purchase Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quantity";
            // 
            // txtbx_name
            // 
            this.txtbx_name.Location = new System.Drawing.Point(201, 54);
            this.txtbx_name.Name = "txtbx_name";
            this.txtbx_name.Size = new System.Drawing.Size(100, 20);
            this.txtbx_name.TabIndex = 2;
            // 
            // txtbx_rprice
            // 
            this.txtbx_rprice.Location = new System.Drawing.Point(201, 93);
            this.txtbx_rprice.Name = "txtbx_rprice";
            this.txtbx_rprice.Size = new System.Drawing.Size(100, 20);
            this.txtbx_rprice.TabIndex = 3;
            // 
            // txtbx_pprice
            // 
            this.txtbx_pprice.Location = new System.Drawing.Point(201, 132);
            this.txtbx_pprice.Name = "txtbx_pprice";
            this.txtbx_pprice.Size = new System.Drawing.Size(100, 20);
            this.txtbx_pprice.TabIndex = 4;
            // 
            // txtbx_qty
            // 
            this.txtbx_qty.Location = new System.Drawing.Point(201, 173);
            this.txtbx_qty.Name = "txtbx_qty";
            this.txtbx_qty.Size = new System.Drawing.Size(100, 20);
            this.txtbx_qty.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(201, 213);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_rst
            // 
            this.btn_rst.Location = new System.Drawing.Point(29, 213);
            this.btn_rst.Name = "btn_rst";
            this.btn_rst.Size = new System.Drawing.Size(100, 23);
            this.btn_rst.TabIndex = 6;
            this.btn_rst.Text = "Reset";
            this.btn_rst.UseVisualStyleBackColor = true;
            this.btn_rst.Click += new System.EventHandler(this.btn_rst_Click);
            // 
            // FRM_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 260);
            this.Controls.Add(this.btn_rst);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtbx_qty);
            this.Controls.Add(this.txtbx_pprice);
            this.Controls.Add(this.txtbx_rprice);
            this.Controls.Add(this.txtbx_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_insert";
            this.Text = "FRM_insert";
            this.Load += new System.EventHandler(this.FRM_insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_name;
        private System.Windows.Forms.TextBox txtbx_rprice;
        private System.Windows.Forms.TextBox txtbx_pprice;
        private System.Windows.Forms.TextBox txtbx_qty;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_rst;
    }
}
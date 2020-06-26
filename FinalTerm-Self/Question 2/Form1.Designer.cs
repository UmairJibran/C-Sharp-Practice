namespace Question_2
{
    partial class Form1
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
            this.btn_ins = new System.Windows.Forms.Button();
            this.btn_dlt = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stationary Managment System";
            // 
            // btn_ins
            // 
            this.btn_ins.Location = new System.Drawing.Point(18, 44);
            this.btn_ins.Name = "btn_ins";
            this.btn_ins.Size = new System.Drawing.Size(75, 23);
            this.btn_ins.TabIndex = 1;
            this.btn_ins.Text = "Insert";
            this.btn_ins.UseVisualStyleBackColor = true;
            this.btn_ins.Click += new System.EventHandler(this.btn_ins_Click);
            // 
            // btn_dlt
            // 
            this.btn_dlt.Location = new System.Drawing.Point(99, 44);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(75, 23);
            this.btn_dlt.TabIndex = 1;
            this.btn_dlt.Text = "Delete";
            this.btn_dlt.UseVisualStyleBackColor = true;
            this.btn_dlt.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // btn_upd
            // 
            this.btn_upd.Location = new System.Drawing.Point(180, 44);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(75, 23);
            this.btn_upd.TabIndex = 1;
            this.btn_upd.Text = "Update";
            this.btn_upd.UseVisualStyleBackColor = true;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(261, 44);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 23);
            this.btn_view.TabIndex = 1;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(342, 44);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 86);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.btn_dlt);
            this.Controls.Add(this.btn_ins);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "8440 - Umair Jibran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ins;
        private System.Windows.Forms.Button btn_dlt;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_search;
    }
}


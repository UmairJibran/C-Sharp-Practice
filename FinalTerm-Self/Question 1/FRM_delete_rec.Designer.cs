namespace Question_1
{
    partial class FRM_delete_rec
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
            this.txtbx_id = new System.Windows.Forms.TextBox();
            this.btn_dlt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete a Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter ID to Delete";
            // 
            // txtbx_id
            // 
            this.txtbx_id.Location = new System.Drawing.Point(188, 60);
            this.txtbx_id.Name = "txtbx_id";
            this.txtbx_id.Size = new System.Drawing.Size(100, 20);
            this.txtbx_id.TabIndex = 2;
            // 
            // btn_dlt
            // 
            this.btn_dlt.Location = new System.Drawing.Point(188, 87);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(100, 23);
            this.btn_dlt.TabIndex = 3;
            this.btn_dlt.Text = "Delete";
            this.btn_dlt.UseVisualStyleBackColor = true;
            // 
            // FRM_delete_rec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 136);
            this.Controls.Add(this.btn_dlt);
            this.Controls.Add(this.txtbx_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_delete_rec";
            this.Text = "Delete Record";
            this.Load += new System.EventHandler(this.FRM_delete_rec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_id;
        private System.Windows.Forms.Button btn_dlt;
    }
}
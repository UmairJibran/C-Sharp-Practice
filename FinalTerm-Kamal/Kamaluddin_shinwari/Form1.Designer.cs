namespace Kamaluddin_shinwari
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
            this.components = new System.ComponentModel.Container();
            this.kamaluddin_shinwariDataSet = new Kamaluddin_shinwari.kamaluddin_shinwariDataSet();
            this.kamaluddinshinwariDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kamaluddin_shinwariDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamaluddinshinwariDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // kamaluddin_shinwariDataSet
            // 
            this.kamaluddin_shinwariDataSet.DataSetName = "kamaluddin_shinwariDataSet";
            this.kamaluddin_shinwariDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kamaluddinshinwariDataSetBindingSource
            // 
            this.kamaluddinshinwariDataSetBindingSource.DataSource = this.kamaluddin_shinwariDataSet;
            this.kamaluddinshinwariDataSetBindingSource.Position = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(367, 301);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 325);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Yasin - 8545";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kamaluddin_shinwariDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamaluddinshinwariDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource kamaluddinshinwariDataSetBindingSource;
        private kamaluddin_shinwariDataSet kamaluddin_shinwariDataSet;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}


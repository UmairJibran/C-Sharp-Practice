namespace Question_1
{
    partial class FRM_view_rec
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
            this.label1 = new System.Windows.Forms.Label();
            this.final_examDataSet = new Question_1.final_examDataSet();
            this.studenttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_tableTableAdapter = new Question_1.final_examDataSetTableAdapters.student_tableTableAdapter();
            this.finalexamDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.students_details = new Question_1.students_details();
            this.studenttableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_tableTableAdapter1 = new Question_1.students_detailsTableAdapters.student_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.final_examDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenttableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalexamDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenttableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Data from Database";
            // 
            // final_examDataSet
            // 
            this.final_examDataSet.DataSetName = "final_examDataSet";
            this.final_examDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studenttableBindingSource
            // 
            this.studenttableBindingSource.DataMember = "student_table";
            this.studenttableBindingSource.DataSource = this.final_examDataSet;
            // 
            // student_tableTableAdapter
            // 
            this.student_tableTableAdapter.ClearBeforeFill = true;
            // 
            // finalexamDataSetBindingSource
            // 
            this.finalexamDataSetBindingSource.DataSource = this.final_examDataSet;
            this.finalexamDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 131);
            this.dataGridView1.TabIndex = 1;
            // 
            // students_details
            // 
            this.students_details.DataSetName = "students_details";
            this.students_details.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studenttableBindingSource1
            // 
            this.studenttableBindingSource1.DataMember = "student_table";
            this.studenttableBindingSource1.DataSource = this.students_details;
            // 
            // student_tableTableAdapter1
            // 
            this.student_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // FRM_view_rec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FRM_view_rec";
            this.Text = "View Records";
            this.Load += new System.EventHandler(this.FRM_view_rec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.final_examDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenttableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalexamDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenttableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private final_examDataSet final_examDataSet;
        private System.Windows.Forms.BindingSource studenttableBindingSource;
        private final_examDataSetTableAdapters.student_tableTableAdapter student_tableTableAdapter;
        private System.Windows.Forms.BindingSource finalexamDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private students_details students_details;
        private System.Windows.Forms.BindingSource studenttableBindingSource1;
        private students_detailsTableAdapters.student_tableTableAdapter student_tableTableAdapter1;
    }
}
namespace BMI_Churail
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
            this.height_ayesha = new System.Windows.Forms.TextBox();
            this.width_ayesha = new System.Windows.Forms.TextBox();
            this.calculate_ayesha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // height_ayesha
            // 
            this.height_ayesha.Location = new System.Drawing.Point(64, 13);
            this.height_ayesha.Name = "height_ayesha";
            this.height_ayesha.Size = new System.Drawing.Size(276, 20);
            this.height_ayesha.TabIndex = 0;
            this.height_ayesha.Text = "in inches";
            // 
            // width_ayesha
            // 
            this.width_ayesha.Location = new System.Drawing.Point(64, 46);
            this.width_ayesha.Name = "width_ayesha";
            this.width_ayesha.Size = new System.Drawing.Size(276, 20);
            this.width_ayesha.TabIndex = 1;
            this.width_ayesha.Text = "in pounds";
            // 
            // calculate_ayesha
            // 
            this.calculate_ayesha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_ayesha.Location = new System.Drawing.Point(12, 75);
            this.calculate_ayesha.Name = "calculate_ayesha";
            this.calculate_ayesha.Size = new System.Drawing.Size(323, 87);
            this.calculate_ayesha.TabIndex = 3;
            this.calculate_ayesha.Text = "Calculate My BMI";
            this.calculate_ayesha.UseVisualStyleBackColor = true;
            this.calculate_ayesha.Click += new System.EventHandler(this.calculate_ayesha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(185, 188);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 31);
            this.answer.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "BMI Score is";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 250);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate_ayesha);
            this.Controls.Add(this.width_ayesha);
            this.Controls.Add(this.height_ayesha);
            this.Name = "Form1";
            this.Text = "Ayesha Ali";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox height_ayesha;
        private System.Windows.Forms.TextBox width_ayesha;
        private System.Windows.Forms.Button calculate_ayesha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label label4;
    }
}


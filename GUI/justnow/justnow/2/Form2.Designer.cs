namespace justnow
{
    partial class Form2
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtxBasic_Salary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOT_Hours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinal_Salary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Basic Salary";
            // 
            // txtxBasic_Salary
            // 
            this.txtxBasic_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxBasic_Salary.Location = new System.Drawing.Point(129, 23);
            this.txtxBasic_Salary.Name = "txtxBasic_Salary";
            this.txtxBasic_Salary.Size = new System.Drawing.Size(217, 29);
            this.txtxBasic_Salary.TabIndex = 12;
            this.txtxBasic_Salary.TextChanged += new System.EventHandler(this.txtxBasic_Salary_TextChanged);
            this.txtxBasic_Salary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtxBasic_Salary_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "OT Hours";
            // 
            // txtOT_Hours
            // 
            this.txtOT_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOT_Hours.Location = new System.Drawing.Point(129, 71);
            this.txtOT_Hours.Name = "txtOT_Hours";
            this.txtOT_Hours.Size = new System.Drawing.Size(217, 29);
            this.txtOT_Hours.TabIndex = 14;
            this.txtOT_Hours.TextChanged += new System.EventHandler(this.txtOT_Hours_TextChanged);
            this.txtOT_Hours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOT_Hours_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Final Salary";
            // 
            // txtFinal_Salary
            // 
            this.txtFinal_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal_Salary.Location = new System.Drawing.Point(129, 125);
            this.txtFinal_Salary.Name = "txtFinal_Salary";
            this.txtFinal_Salary.Size = new System.Drawing.Size(217, 29);
            this.txtFinal_Salary.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 183);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFinal_Salary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOT_Hours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtxBasic_Salary);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtxBasic_Salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOT_Hours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinal_Salary;
    }
}
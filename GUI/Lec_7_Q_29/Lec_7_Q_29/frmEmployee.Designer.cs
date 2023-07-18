namespace Lec_7_Q_29
{
    partial class frmEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.lblBS = new System.Windows.Forms.Label();
            this.txtOT = new System.Windows.Forms.TextBox();
            this.lblOT = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCal);
            this.panel1.Controls.Add(this.txtOT);
            this.panel1.Controls.Add(this.lblOT);
            this.panel1.Controls.Add(this.txtBS);
            this.panel1.Controls.Add(this.lblBS);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 392);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(83, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(15, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 34);
            this.txtName.TabIndex = 1;
            // 
            // txtBS
            // 
            this.txtBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBS.Location = new System.Drawing.Point(15, 162);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(215, 34);
            this.txtBS.TabIndex = 3;
            // 
            // lblBS
            // 
            this.lblBS.AutoSize = true;
            this.lblBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBS.Location = new System.Drawing.Point(50, 122);
            this.lblBS.Name = "lblBS";
            this.lblBS.Size = new System.Drawing.Size(145, 29);
            this.lblBS.TabIndex = 2;
            this.lblBS.Text = "Basic Salary";
            // 
            // txtOT
            // 
            this.txtOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOT.Location = new System.Drawing.Point(15, 263);
            this.txtOT.Name = "txtOT";
            this.txtOT.Size = new System.Drawing.Size(215, 34);
            this.txtOT.TabIndex = 5;
            // 
            // lblOT
            // 
            this.lblOT.AutoSize = true;
            this.lblOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOT.Location = new System.Drawing.Point(56, 223);
            this.lblOT.Name = "lblOT";
            this.lblOT.Size = new System.Drawing.Size(132, 29);
            this.lblOT.TabIndex = 4;
            this.lblOT.Text = "OT Hourse";
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(62, 326);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(121, 44);
            this.btnCal.TabIndex = 6;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 392);
            this.Controls.Add(this.panel1);
            this.Name = "frmEmployee";
            this.Text = "Employee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox txtOT;
        private System.Windows.Forms.Label lblOT;
        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.Label lblBS;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}


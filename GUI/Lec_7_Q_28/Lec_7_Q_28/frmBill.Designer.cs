namespace Lec_7_Q_28
{
    partial class frmBill
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
            this.btnCal = new System.Windows.Forms.Button();
            this.txtFBA = new System.Windows.Forms.TextBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.txtPTT = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFBA = new System.Windows.Forms.Label();
            this.lblPTT = new System.Windows.Forms.Label();
            this.lblSTT = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCal);
            this.panel1.Controls.Add(this.txtFBA);
            this.panel1.Controls.Add(this.txtSTT);
            this.panel1.Controls.Add(this.txtPTT);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblFBA);
            this.panel1.Controls.Add(this.lblPTT);
            this.panel1.Controls.Add(this.lblSTT);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 363);
            this.panel1.TabIndex = 0;
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(155, 169);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(236, 36);
            this.btnCal.TabIndex = 8;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // txtFBA
            // 
            this.txtFBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFBA.Location = new System.Drawing.Point(143, 281);
            this.txtFBA.Name = "txtFBA";
            this.txtFBA.Size = new System.Drawing.Size(261, 34);
            this.txtFBA.TabIndex = 7;
            // 
            // txtSTT
            // 
            this.txtSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTT.Location = new System.Drawing.Point(266, 116);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(261, 34);
            this.txtSTT.TabIndex = 6;
            // 
            // txtPTT
            // 
            this.txtPTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTT.Location = new System.Drawing.Point(266, 66);
            this.txtPTT.Name = "txtPTT";
            this.txtPTT.Size = new System.Drawing.Size(261, 34);
            this.txtPTT.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(266, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 34);
            this.txtName.TabIndex = 4;
            // 
            // lblFBA
            // 
            this.lblFBA.AutoSize = true;
            this.lblFBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBA.Location = new System.Drawing.Point(177, 235);
            this.lblFBA.Name = "lblFBA";
            this.lblFBA.Size = new System.Drawing.Size(193, 29);
            this.lblFBA.TabIndex = 3;
            this.lblFBA.Text = "Final BIll Amount";
            // 
            // lblPTT
            // 
            this.lblPTT.AutoSize = true;
            this.lblPTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTT.Location = new System.Drawing.Point(54, 69);
            this.lblPTT.Name = "lblPTT";
            this.lblPTT.Size = new System.Drawing.Size(189, 29);
            this.lblPTT.TabIndex = 2;
            this.lblPTT.Text = "Peak Talk TIme:";
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTT.Location = new System.Drawing.Point(12, 119);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(231, 29);
            this.lblSTT.TabIndex = 1;
            this.lblSTT.Text = "Standard Talk Time:\r\n";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(49, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(194, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Customer Name:";
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 363);
            this.Controls.Add(this.panel1);
            this.Name = "frmBill";
            this.Text = "Bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFBA;
        private System.Windows.Forms.Label lblPTT;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox txtFBA;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.TextBox txtPTT;
        private System.Windows.Forms.TextBox txtName;
    }
}


namespace Lec_8_Q_32
{
    partial class FrmEmpSal
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
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtBS = new System.Windows.Forms.TextBox();
            this.LblBS = new System.Windows.Forms.Label();
            this.TxtOT = new System.Windows.Forms.TextBox();
            this.LblOT = new System.Windows.Forms.Label();
            this.TxtFS = new System.Windows.Forms.TextBox();
            this.LblFS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(12, 32);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(202, 29);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Employee Name";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(220, 28);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(250, 36);
            this.TxtName.TabIndex = 1;
            this.TxtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtName_KeyDown);
            // 
            // TxtBS
            // 
            this.TxtBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBS.Location = new System.Drawing.Point(220, 78);
            this.TxtBS.Name = "TxtBS";
            this.TxtBS.Size = new System.Drawing.Size(250, 36);
            this.TxtBS.TabIndex = 3;
            this.TxtBS.TextChanged += new System.EventHandler(this.TxtBS_TextChanged);
            this.TxtBS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBS_KeyDown);
            // 
            // LblBS
            // 
            this.LblBS.AutoSize = true;
            this.LblBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBS.Location = new System.Drawing.Point(12, 82);
            this.LblBS.Name = "LblBS";
            this.LblBS.Size = new System.Drawing.Size(155, 29);
            this.LblBS.TabIndex = 2;
            this.LblBS.Text = "Basic Salary";
            // 
            // TxtOT
            // 
            this.TxtOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOT.Location = new System.Drawing.Point(220, 130);
            this.TxtOT.Name = "TxtOT";
            this.TxtOT.Size = new System.Drawing.Size(250, 36);
            this.TxtOT.TabIndex = 5;
            this.TxtOT.TextChanged += new System.EventHandler(this.TxtOT_TextChanged);
            // 
            // LblOT
            // 
            this.LblOT.AutoSize = true;
            this.LblOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOT.Location = new System.Drawing.Point(12, 134);
            this.LblOT.Name = "LblOT";
            this.LblOT.Size = new System.Drawing.Size(121, 29);
            this.LblOT.TabIndex = 4;
            this.LblOT.Text = "OT Hours";
            // 
            // TxtFS
            // 
            this.TxtFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFS.Location = new System.Drawing.Point(220, 178);
            this.TxtFS.Name = "TxtFS";
            this.TxtFS.Size = new System.Drawing.Size(250, 36);
            this.TxtFS.TabIndex = 7;
            // 
            // LblFS
            // 
            this.LblFS.AutoSize = true;
            this.LblFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFS.Location = new System.Drawing.Point(12, 182);
            this.LblFS.Name = "LblFS";
            this.LblFS.Size = new System.Drawing.Size(147, 29);
            this.LblFS.TabIndex = 6;
            this.LblFS.Text = "Final Salary";
            // 
            // FrmEmpSal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 236);
            this.Controls.Add(this.TxtFS);
            this.Controls.Add(this.LblFS);
            this.Controls.Add(this.TxtOT);
            this.Controls.Add(this.LblOT);
            this.Controls.Add(this.TxtBS);
            this.Controls.Add(this.LblBS);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Name = "FrmEmpSal";
            this.Text = "Employee Salary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtBS;
        private System.Windows.Forms.Label LblBS;
        private System.Windows.Forms.TextBox TxtOT;
        private System.Windows.Forms.Label LblOT;
        private System.Windows.Forms.TextBox TxtFS;
        private System.Windows.Forms.Label LblFS;
    }
}


namespace Lec_8_Q_33
{
    partial class FrmDelSys
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
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.LblAdd = new System.Windows.Forms.Label();
            this.LblCon = new System.Windows.Forms.Label();
            this.TxtWP = new System.Windows.Forms.TextBox();
            this.LblWP = new System.Windows.Forms.Label();
            this.CmbCon = new System.Windows.Forms.ComboBox();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.LblCost = new System.Windows.Forms.Label();
            this.BtnCalCost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(40, 30);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(198, 29);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Customer Name";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(244, 26);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(341, 36);
            this.TxtName.TabIndex = 1;
            // 
            // TxtAdd
            // 
            this.TxtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdd.Location = new System.Drawing.Point(244, 84);
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(341, 36);
            this.TxtAdd.TabIndex = 3;
            // 
            // LblAdd
            // 
            this.LblAdd.AutoSize = true;
            this.LblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdd.Location = new System.Drawing.Point(33, 88);
            this.LblAdd.Name = "LblAdd";
            this.LblAdd.Size = new System.Drawing.Size(205, 29);
            this.LblAdd.TabIndex = 2;
            this.LblAdd.Text = "Delivery Address";
            // 
            // LblCon
            // 
            this.LblCon.AutoSize = true;
            this.LblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCon.Location = new System.Drawing.Point(38, 144);
            this.LblCon.Name = "LblCon";
            this.LblCon.Size = new System.Drawing.Size(200, 29);
            this.LblCon.TabIndex = 4;
            this.LblCon.Text = "Delivery Country";
            // 
            // TxtWP
            // 
            this.TxtWP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWP.Location = new System.Drawing.Point(244, 193);
            this.TxtWP.Name = "TxtWP";
            this.TxtWP.Size = new System.Drawing.Size(341, 36);
            this.TxtWP.TabIndex = 7;
            // 
            // LblWP
            // 
            this.LblWP.AutoSize = true;
            this.LblWP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWP.Location = new System.Drawing.Point(12, 197);
            this.LblWP.Name = "LblWP";
            this.LblWP.Size = new System.Drawing.Size(226, 29);
            this.LblWP.TabIndex = 6;
            this.LblWP.Text = "Weight of Package";
            // 
            // CmbCon
            // 
            this.CmbCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCon.FormattingEnabled = true;
            this.CmbCon.Location = new System.Drawing.Point(244, 140);
            this.CmbCon.Name = "CmbCon";
            this.CmbCon.Size = new System.Drawing.Size(341, 37);
            this.CmbCon.TabIndex = 8;
            // 
            // TxtCost
            // 
            this.TxtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCost.Location = new System.Drawing.Point(244, 298);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(341, 36);
            this.TxtCost.TabIndex = 10;
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCost.Location = new System.Drawing.Point(74, 302);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(164, 29);
            this.LblCost.TabIndex = 9;
            this.LblCost.Text = "Delivery Cost";
            // 
            // BtnCalCost
            // 
            this.BtnCalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalCost.Location = new System.Drawing.Point(116, 243);
            this.BtnCalCost.Name = "BtnCalCost";
            this.BtnCalCost.Size = new System.Drawing.Size(345, 44);
            this.BtnCalCost.TabIndex = 11;
            this.BtnCalCost.Text = "Cal Delivery Cost";
            this.BtnCalCost.UseVisualStyleBackColor = true;
            this.BtnCalCost.Click += new System.EventHandler(this.BtnCalCost_Click);
            // 
            // FrmDelSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 349);
            this.Controls.Add(this.BtnCalCost);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.LblCost);
            this.Controls.Add(this.CmbCon);
            this.Controls.Add(this.TxtWP);
            this.Controls.Add(this.LblWP);
            this.Controls.Add(this.LblCon);
            this.Controls.Add(this.TxtAdd);
            this.Controls.Add(this.LblAdd);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Name = "FrmDelSys";
            this.Text = "Delivery System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAdd;
        private System.Windows.Forms.Label LblAdd;
        private System.Windows.Forms.Label LblCon;
        private System.Windows.Forms.TextBox TxtWP;
        private System.Windows.Forms.Label LblWP;
        private System.Windows.Forms.ComboBox CmbCon;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.Button BtnCalCost;
    }
}


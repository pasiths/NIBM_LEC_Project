namespace Lec_8_Q_31
{
    partial class FrmBillMaker
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
            this.TxtSalAmount = new System.Windows.Forms.TextBox();
            this.TxtQunSolved = new System.Windows.Forms.TextBox();
            this.TxtDisPrice = new System.Windows.Forms.TextBox();
            this.TxtDisRate = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.LblSalAmount = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblQunSolved = new System.Windows.Forms.Label();
            this.LblDisPrice = new System.Windows.Forms.Label();
            this.LblDisRate = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtSalAmount);
            this.panel1.Controls.Add(this.TxtQunSolved);
            this.panel1.Controls.Add(this.TxtDisPrice);
            this.panel1.Controls.Add(this.TxtDisRate);
            this.panel1.Controls.Add(this.TxtPrice);
            this.panel1.Controls.Add(this.LblSalAmount);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.LblQunSolved);
            this.panel1.Controls.Add(this.LblDisPrice);
            this.panel1.Controls.Add(this.LblDisRate);
            this.panel1.Controls.Add(this.LblPrice);
            this.panel1.Controls.Add(this.LblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 471);
            this.panel1.TabIndex = 0;
            // 
            // TxtSalAmount
            // 
            this.TxtSalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalAmount.Location = new System.Drawing.Point(15, 417);
            this.TxtSalAmount.Name = "TxtSalAmount";
            this.TxtSalAmount.Size = new System.Drawing.Size(223, 30);
            this.TxtSalAmount.TabIndex = 1;
            // 
            // TxtQunSolved
            // 
            this.TxtQunSolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQunSolved.Location = new System.Drawing.Point(15, 351);
            this.TxtQunSolved.Name = "TxtQunSolved";
            this.TxtQunSolved.Size = new System.Drawing.Size(223, 30);
            this.TxtQunSolved.TabIndex = 1;
            this.TxtQunSolved.TextChanged += new System.EventHandler(this.TxtQunSolved_TextChanged);
            // 
            // TxtDisPrice
            // 
            this.TxtDisPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisPrice.Location = new System.Drawing.Point(15, 277);
            this.TxtDisPrice.Name = "TxtDisPrice";
            this.TxtDisPrice.Size = new System.Drawing.Size(223, 30);
            this.TxtDisPrice.TabIndex = 1;
            // 
            // TxtDisRate
            // 
            this.TxtDisRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisRate.Location = new System.Drawing.Point(15, 202);
            this.TxtDisRate.Name = "TxtDisRate";
            this.TxtDisRate.Size = new System.Drawing.Size(223, 30);
            this.TxtDisRate.TabIndex = 1;
            this.TxtDisRate.TextChanged += new System.EventHandler(this.TxtDisRate_TextChanged);
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(15, 124);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(223, 30);
            this.TxtPrice.TabIndex = 1;
            this.TxtPrice.TextChanged += new System.EventHandler(this.TxtPrice_TextChanged);
            // 
            // LblSalAmount
            // 
            this.LblSalAmount.AutoSize = true;
            this.LblSalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalAmount.Location = new System.Drawing.Point(59, 388);
            this.LblSalAmount.Name = "LblSalAmount";
            this.LblSalAmount.Size = new System.Drawing.Size(135, 25);
            this.LblSalAmount.TabIndex = 0;
            this.LblSalAmount.Text = "Sales Amount";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(15, 51);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(223, 30);
            this.TxtName.TabIndex = 1;
            this.TxtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtName_KeyDown);
            // 
            // LblQunSolved
            // 
            this.LblQunSolved.AutoSize = true;
            this.LblQunSolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQunSolved.Location = new System.Drawing.Point(56, 322);
            this.LblQunSolved.Name = "LblQunSolved";
            this.LblQunSolved.Size = new System.Drawing.Size(140, 25);
            this.LblQunSolved.TabIndex = 0;
            this.LblQunSolved.Text = "Quntity Solved";
            // 
            // LblDisPrice
            // 
            this.LblDisPrice.AutoSize = true;
            this.LblDisPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisPrice.Location = new System.Drawing.Point(58, 248);
            this.LblDisPrice.Name = "LblDisPrice";
            this.LblDisPrice.Size = new System.Drawing.Size(137, 25);
            this.LblDisPrice.TabIndex = 0;
            this.LblDisPrice.Text = "Discount Price";
            // 
            // LblDisRate
            // 
            this.LblDisRate.AutoSize = true;
            this.LblDisRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisRate.Location = new System.Drawing.Point(60, 173);
            this.LblDisRate.Name = "LblDisRate";
            this.LblDisRate.Size = new System.Drawing.Size(133, 25);
            this.LblDisRate.TabIndex = 0;
            this.LblDisRate.Text = "Discount Rate";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(79, 95);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(95, 25);
            this.LblPrice.TabIndex = 0;
            this.LblPrice.Text = "Unit Price";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(73, 22);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(106, 25);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Item Name";
            // 
            // FrmBillMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 471);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBillMaker";
            this.Text = "Bill Maker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtSalAmount;
        private System.Windows.Forms.TextBox TxtQunSolved;
        private System.Windows.Forms.TextBox TxtDisPrice;
        private System.Windows.Forms.TextBox TxtDisRate;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label LblSalAmount;
        private System.Windows.Forms.Label LblQunSolved;
        private System.Windows.Forms.Label LblDisPrice;
        private System.Windows.Forms.Label LblDisRate;
        private System.Windows.Forms.Label LblPrice;
    }
}


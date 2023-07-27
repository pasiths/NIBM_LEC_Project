namespace Lec_7_Q_30
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCal = new System.Windows.Forms.Button();
            this.grpDeliveryType = new System.Windows.Forms.GroupBox();
            this.RdbExpress = new System.Windows.Forms.RadioButton();
            this.RdbNormal = new System.Windows.Forms.RadioButton();
            this.CmbCTD = new System.Windows.Forms.ComboBox();
            this.TxtDC = new System.Windows.Forms.TextBox();
            this.LblDeliveryCost = new System.Windows.Forms.Label();
            this.LblCTD = new System.Windows.Forms.Label();
            this.TxtWOP = new System.Windows.Forms.TextBox();
            this.LblWOP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpDeliveryType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCal);
            this.panel1.Controls.Add(this.grpDeliveryType);
            this.panel1.Controls.Add(this.CmbCTD);
            this.panel1.Controls.Add(this.TxtDC);
            this.panel1.Controls.Add(this.LblDeliveryCost);
            this.panel1.Controls.Add(this.LblCTD);
            this.panel1.Controls.Add(this.TxtWOP);
            this.panel1.Controls.Add(this.LblWOP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 518);
            this.panel1.TabIndex = 0;
            // 
            // BtnCal
            // 
            this.BtnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCal.Location = new System.Drawing.Point(22, 336);
            this.BtnCal.Name = "BtnCal";
            this.BtnCal.Size = new System.Drawing.Size(221, 40);
            this.BtnCal.TabIndex = 4;
            this.BtnCal.Text = "Calculate";
            this.BtnCal.UseVisualStyleBackColor = true;
            this.BtnCal.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // grpDeliveryType
            // 
            this.grpDeliveryType.Controls.Add(this.RdbExpress);
            this.grpDeliveryType.Controls.Add(this.RdbNormal);
            this.grpDeliveryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeliveryType.Location = new System.Drawing.Point(24, 212);
            this.grpDeliveryType.Name = "grpDeliveryType";
            this.grpDeliveryType.Size = new System.Drawing.Size(217, 110);
            this.grpDeliveryType.TabIndex = 3;
            this.grpDeliveryType.TabStop = false;
            this.grpDeliveryType.Text = "Delivery Type";
            // 
            // RdbExpress
            // 
            this.RdbExpress.AutoSize = true;
            this.RdbExpress.Location = new System.Drawing.Point(42, 75);
            this.RdbExpress.Name = "RdbExpress";
            this.RdbExpress.Size = new System.Drawing.Size(104, 29);
            this.RdbExpress.TabIndex = 1;
            this.RdbExpress.TabStop = true;
            this.RdbExpress.Text = "Express";
            this.RdbExpress.UseVisualStyleBackColor = true;
            // 
            // RdbNormal
            // 
            this.RdbNormal.AutoSize = true;
            this.RdbNormal.Location = new System.Drawing.Point(42, 38);
            this.RdbNormal.Name = "RdbNormal";
            this.RdbNormal.Size = new System.Drawing.Size(95, 29);
            this.RdbNormal.TabIndex = 0;
            this.RdbNormal.TabStop = true;
            this.RdbNormal.Text = "Normal";
            this.RdbNormal.UseVisualStyleBackColor = true;
            // 
            // CmbCTD
            // 
            this.CmbCTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCTD.FormattingEnabled = true;
            this.CmbCTD.Items.AddRange(new object[] {
            "Sri Lanka",
            "India",
            "Other"});
            this.CmbCTD.Location = new System.Drawing.Point(22, 144);
            this.CmbCTD.Name = "CmbCTD";
            this.CmbCTD.Size = new System.Drawing.Size(221, 37);
            this.CmbCTD.TabIndex = 2;
            // 
            // TxtDC
            // 
            this.TxtDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDC.Location = new System.Drawing.Point(22, 433);
            this.TxtDC.Name = "TxtDC";
            this.TxtDC.Size = new System.Drawing.Size(221, 34);
            this.TxtDC.TabIndex = 1;
            // 
            // LblDeliveryCost
            // 
            this.LblDeliveryCost.AutoSize = true;
            this.LblDeliveryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeliveryCost.Location = new System.Drawing.Point(55, 401);
            this.LblDeliveryCost.Name = "LblDeliveryCost";
            this.LblDeliveryCost.Size = new System.Drawing.Size(155, 29);
            this.LblDeliveryCost.TabIndex = 0;
            this.LblDeliveryCost.Text = "Delivery Cost";
            // 
            // LblCTD
            // 
            this.LblCTD.AutoSize = true;
            this.LblCTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCTD.Location = new System.Drawing.Point(8, 112);
            this.LblCTD.Name = "LblCTD";
            this.LblCTD.Size = new System.Drawing.Size(248, 29);
            this.LblCTD.TabIndex = 0;
            this.LblCTD.Text = "Country to be Delivery";
            // 
            // TxtWOP
            // 
            this.TxtWOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWOP.Location = new System.Drawing.Point(22, 53);
            this.TxtWOP.Name = "TxtWOP";
            this.TxtWOP.Size = new System.Drawing.Size(221, 34);
            this.TxtWOP.TabIndex = 1;
            // 
            // LblWOP
            // 
            this.LblWOP.AutoSize = true;
            this.LblWOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWOP.Location = new System.Drawing.Point(25, 21);
            this.LblWOP.Name = "LblWOP";
            this.LblWOP.Size = new System.Drawing.Size(214, 29);
            this.LblWOP.TabIndex = 0;
            this.LblWOP.Text = "Weight of Package";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 489);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Delivery System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpDeliveryType.ResumeLayout(false);
            this.grpDeliveryType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtDC;
        private System.Windows.Forms.Label LblCTD;
        private System.Windows.Forms.TextBox TxtWOP;
        private System.Windows.Forms.Label LblWOP;
        private System.Windows.Forms.ComboBox CmbCTD;
        private System.Windows.Forms.GroupBox grpDeliveryType;
        private System.Windows.Forms.Button BtnCal;
        private System.Windows.Forms.RadioButton RdbExpress;
        private System.Windows.Forms.RadioButton RdbNormal;
        private System.Windows.Forms.Label LblDeliveryCost;
    }
}


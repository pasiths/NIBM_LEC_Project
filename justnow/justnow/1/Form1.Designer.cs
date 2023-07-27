namespace justnow
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(156, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 29);
            this.txtName.TabIndex = 0;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unit Price";
            // 
            // txtUP
            // 
            this.txtUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUP.Location = new System.Drawing.Point(156, 66);
            this.txtUP.Name = "txtUP";
            this.txtUP.Size = new System.Drawing.Size(192, 29);
            this.txtUP.TabIndex = 2;
            this.txtUP.TextChanged += new System.EventHandler(this.txtUP_TextChanged);
            this.txtUP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUP_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Discount Rate";
            // 
            // txtDR
            // 
            this.txtDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDR.Location = new System.Drawing.Point(156, 103);
            this.txtDR.Name = "txtDR";
            this.txtDR.Size = new System.Drawing.Size(192, 29);
            this.txtDR.TabIndex = 4;
            this.txtDR.TextChanged += new System.EventHandler(this.txtDR_TextChanged);
            this.txtDR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDR_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Discount Price";
            // 
            // txtDP
            // 
            this.txtDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDP.Location = new System.Drawing.Point(156, 141);
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(192, 29);
            this.txtDP.TabIndex = 6;
            this.txtDP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDP_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quntity Sold";
            // 
            // txtQS
            // 
            this.txtQS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQS.Location = new System.Drawing.Point(156, 188);
            this.txtQS.Name = "txtQS";
            this.txtQS.Size = new System.Drawing.Size(192, 29);
            this.txtQS.TabIndex = 8;
            this.txtQS.TextChanged += new System.EventHandler(this.txtQS_TextChanged);
            this.txtQS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQS_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sales Amount";
            // 
            // txtSA
            // 
            this.txtSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSA.Location = new System.Drawing.Point(156, 233);
            this.txtSA.Name = "txtSA";
            this.txtSA.Size = new System.Drawing.Size(192, 29);
            this.txtSA.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 312);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSA;
    }
}


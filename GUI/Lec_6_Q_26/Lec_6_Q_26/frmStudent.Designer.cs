namespace Lec_6_Q_26
{
    partial class frmStudent
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
            this.btnClick = new System.Windows.Forms.Button();
            this.txtExam = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtAssigment = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.lblExam = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClick);
            this.panel1.Controls.Add(this.txtExam);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.txtAssigment);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.lblAssignment);
            this.panel1.Controls.Add(this.lblExam);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 340);
            this.panel1.TabIndex = 0;
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(38, 206);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(342, 42);
            this.btnClick.TabIndex = 14;
            this.btnClick.Text = "Click Me!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // txtExam
            // 
            this.txtExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExam.Location = new System.Drawing.Point(166, 87);
            this.txtExam.Name = "txtExam";
            this.txtExam.Size = new System.Drawing.Size(214, 34);
            this.txtExam.TabIndex = 13;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(166, 270);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(214, 34);
            this.txtResult.TabIndex = 11;
            // 
            // txtAssigment
            // 
            this.txtAssigment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssigment.Location = new System.Drawing.Point(166, 148);
            this.txtAssigment.Name = "txtAssigment";
            this.txtAssigment.Size = new System.Drawing.Size(214, 34);
            this.txtAssigment.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(166, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 34);
            this.txtName.TabIndex = 10;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(33, 273);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(81, 29);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Result";
            // 
            // lblAssignment
            // 
            this.lblAssignment.AutoSize = true;
            this.lblAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignment.Location = new System.Drawing.Point(33, 151);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(125, 29);
            this.lblAssignment.TabIndex = 9;
            this.lblAssignment.Text = "Assigmnet";
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExam.Location = new System.Drawing.Point(33, 90);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(73, 29);
            this.lblExam.TabIndex = 6;
            this.lblExam.Text = "Exam";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(33, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 340);
            this.Controls.Add(this.panel1);
            this.Name = "frmStudent";
            this.Text = "Student";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txtExam;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtAssigment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.Label lblExam;
        private System.Windows.Forms.Label lblName;
    }
}


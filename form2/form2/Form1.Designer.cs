
namespace form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cmdSex = new System.Windows.Forms.ComboBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Kh Battambang", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "គណនាពន្ធលើប្រាក់ខែរបស់បុគ្គលិក";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Kantumruy Pro Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Kantumruy Pro Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 405);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary : ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Kantumruy Pro Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Kantumruy Pro Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sex : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtName.Location = new System.Drawing.Point(261, 121);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(378, 42);
            this.txtName.TabIndex = 1;
            // 
            // txtSalary
            // 
            this.txtSalary.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSalary.Location = new System.Drawing.Point(261, 405);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(378, 42);
            this.txtSalary.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPhone.Location = new System.Drawing.Point(261, 304);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(378, 42);
            this.txtPhone.TabIndex = 3;
            // 
            // cmdSex
            // 
            this.cmdSex.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmdSex.FormattingEnabled = true;
            this.cmdSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmdSex.Location = new System.Drawing.Point(261, 217);
            this.cmdSex.Name = "cmdSex";
            this.cmdSex.Size = new System.Drawing.Size(253, 37);
            this.cmdSex.TabIndex = 2;
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.ForeColor = System.Drawing.Color.Blue;
            this.btnCal.Location = new System.Drawing.Point(197, 603);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(139, 44);
            this.btnCal.TabIndex = 6;
            this.btnCal.Text = "CALCULATE";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(578, 603);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 44);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Blue;
            this.btnClear.Location = new System.Drawing.Point(383, 603);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 44);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Kantumruy Pro Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 497);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 42);
            this.label6.TabIndex = 12;
            this.label6.Text = "Taxation  : ";
            // 
            // lbTax
            // 
            this.lbTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTax.Font = new System.Drawing.Font("Kantumruy Pro Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTax.Location = new System.Drawing.Point(296, 497);
            this.lbTax.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(343, 42);
            this.lbTax.TabIndex = 5;
            this.lbTax.Text = "0.0 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 784);
            this.Controls.Add(this.lbTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.cmdSex);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Kantumruy Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cmdSex;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTax;
    }
}


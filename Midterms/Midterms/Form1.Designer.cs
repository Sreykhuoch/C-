
namespace Midterms
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtUnitprice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYPub = new System.Windows.Forms.TextBox();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(760, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year Publish";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(760, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(50, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit Price";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(50, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(50, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 44);
            this.label6.TabIndex = 5;
            this.label6.Text = "Title";
            // 
            // txtcode
            // 
            this.txtcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcode.Font = new System.Drawing.Font("Kantumruy Pro Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(238, 24);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(298, 39);
            this.txtcode.TabIndex = 6;
            // 
            // txtUnitprice
            // 
            this.txtUnitprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitprice.Font = new System.Drawing.Font("Kantumruy Pro Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitprice.Location = new System.Drawing.Point(238, 215);
            this.txtUnitprice.Multiline = true;
            this.txtUnitprice.Name = "txtUnitprice";
            this.txtUnitprice.Size = new System.Drawing.Size(298, 39);
            this.txtUnitprice.TabIndex = 7;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Kantumruy Pro Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(238, 153);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(298, 39);
            this.txtQty.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Kantumruy Pro Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(238, 91);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(298, 39);
            this.txtTitle.TabIndex = 9;
            // 
            // txtYPub
            // 
            this.txtYPub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYPub.Font = new System.Drawing.Font("Kantumruy Pro Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYPub.Location = new System.Drawing.Point(936, 91);
            this.txtYPub.Multiline = true;
            this.txtYPub.Name = "txtYPub";
            this.txtYPub.Size = new System.Drawing.Size(298, 39);
            this.txtYPub.TabIndex = 10;
            // 
            // txtauthor
            // 
            this.txtauthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtauthor.Font = new System.Drawing.Font("Kantumruy Pro Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtauthor.Location = new System.Drawing.Point(936, 24);
            this.txtauthor.Multiline = true;
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(298, 39);
            this.txtauthor.TabIndex = 11;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFind.Location = new System.Drawing.Point(774, 219);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(140, 39);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Font = new System.Drawing.Font("Kantumruy Pro Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(936, 219);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(298, 39);
            this.txtsearch.TabIndex = 13;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(54, 305);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1419, 349);
            this.dgv.TabIndex = 14;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNew.Location = new System.Drawing.Point(238, 695);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(155, 47);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnsave.Location = new System.Drawing.Point(459, 695);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(155, 47);
            this.btnsave.TabIndex = 16;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExit.Location = new System.Drawing.Point(1045, 695);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 47);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btndelete.Location = new System.Drawing.Point(854, 695);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(155, 47);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Location = new System.Drawing.Point(661, 695);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 47);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 789);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.txtYPub);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtUnitprice);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
    }
}


namespace Lab_Basic_Command
{
	partial class BillsForm
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
			this.lblFrom = new System.Windows.Forms.Label();
			this.lblTo = new System.Windows.Forms.Label();
			this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
			this.dtpToDate = new System.Windows.Forms.DateTimePicker();
			this.btnView = new System.Windows.Forms.Button();
			this.dgvBills = new System.Windows.Forms.DataGridView();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.lblFinal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFrom
			// 
			this.lblFrom.AutoSize = true;
			this.lblFrom.Location = new System.Drawing.Point(34, 41);
			this.lblFrom.Name = "lblFrom";
			this.lblFrom.Size = new System.Drawing.Size(46, 13);
			this.lblFrom.TabIndex = 0;
			this.lblFrom.Text = "Từ ngày";
			// 
			// lblTo
			// 
			this.lblTo.AutoSize = true;
			this.lblTo.Location = new System.Drawing.Point(34, 91);
			this.lblTo.Name = "lblTo";
			this.lblTo.Size = new System.Drawing.Size(53, 13);
			this.lblTo.TabIndex = 1;
			this.lblTo.Text = "Đến ngày";
			// 
			// dtpFromDate
			// 
			this.dtpFromDate.Location = new System.Drawing.Point(127, 34);
			this.dtpFromDate.Name = "dtpFromDate";
			this.dtpFromDate.Size = new System.Drawing.Size(197, 20);
			this.dtpFromDate.TabIndex = 2;
			// 
			// dtpToDate
			// 
			this.dtpToDate.Location = new System.Drawing.Point(127, 84);
			this.dtpToDate.Name = "dtpToDate";
			this.dtpToDate.Size = new System.Drawing.Size(197, 20);
			this.dtpToDate.TabIndex = 3;
			// 
			// btnView
			// 
			this.btnView.Location = new System.Drawing.Point(210, 137);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(113, 23);
			this.btnView.TabIndex = 4;
			this.btnView.Text = "Xem hoá đơn";
			this.btnView.UseVisualStyleBackColor = true;
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// dgvBills
			// 
			this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBills.Location = new System.Drawing.Point(10, 189);
			this.dgvBills.Name = "dgvBills";
			this.dgvBills.Size = new System.Drawing.Size(313, 142);
			this.dgvBills.TabIndex = 5;
			this.dgvBills.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellDoubleClick);
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(147, 362);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(35, 13);
			this.lblTotal.TabIndex = 6;
			this.lblTotal.Text = "label3";
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Location = new System.Drawing.Point(147, 388);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(35, 13);
			this.lblDiscount.TabIndex = 7;
			this.lblDiscount.Text = "label4";
			// 
			// lblFinal
			// 
			this.lblFinal.AutoSize = true;
			this.lblFinal.Location = new System.Drawing.Point(147, 417);
			this.lblFinal.Name = "lblFinal";
			this.lblFinal.Size = new System.Drawing.Size(35, 13);
			this.lblFinal.TabIndex = 8;
			this.lblFinal.Text = "label5";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 362);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Tổng tạm tính:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 388);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Tổng giảm giá:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 417);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Tổng tiền thực thu:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(288, 362);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Đồng";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(288, 388);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Đồng";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(288, 417);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Đồng";
			// 
			// BillsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 450);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblFinal);
			this.Controls.Add(this.lblDiscount);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.dgvBills);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.dtpToDate);
			this.Controls.Add(this.dtpFromDate);
			this.Controls.Add(this.lblTo);
			this.Controls.Add(this.lblFrom);
			this.Name = "BillsForm";
			this.Text = "BillsForm";
			this.Load += new System.EventHandler(this.BillsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFrom;
		private System.Windows.Forms.Label lblTo;
		private System.Windows.Forms.DateTimePicker dtpFromDate;
		private System.Windows.Forms.DateTimePicker dtpToDate;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.DataGridView dgvBills;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblDiscount;
		private System.Windows.Forms.Label lblFinal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}
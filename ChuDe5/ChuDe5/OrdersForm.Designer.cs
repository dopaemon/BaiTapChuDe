namespace _ChuDe5
{
	partial class OrdersForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.btnFilter = new System.Windows.Forms.Button();
			this.dgvOrders = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTotalBeforeDiscount = new System.Windows.Forms.Label();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.lblRevenue = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
			this.SuspendLayout();
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			this.dgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ ngày";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Đến ngày";
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(147, 7);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(200, 20);
			this.dtpFrom.TabIndex = 2;
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(147, 40);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(200, 20);
			this.dtpTo.TabIndex = 3;
			// 
			// btnFilter
			// 
			this.btnFilter.Location = new System.Drawing.Point(250, 83);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(97, 23);
			this.btnFilter.TabIndex = 4;
			this.btnFilter.Text = "Lọc hoá đơn";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// dgvOrders
			// 
			this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrders.Location = new System.Drawing.Point(34, 139);
			this.dgvOrders.Name = "dgvOrders";
			this.dgvOrders.Size = new System.Drawing.Size(312, 125);
			this.dgvOrders.TabIndex = 5;
			this.dgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellDoubleClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 298);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Tổng tiền:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 334);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Tiền giảm:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(31, 373);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Thực thu:";
			// 
			// lblTotalBeforeDiscount
			// 
			this.lblTotalBeforeDiscount.AutoSize = true;
			this.lblTotalBeforeDiscount.Location = new System.Drawing.Point(118, 298);
			this.lblTotalBeforeDiscount.Name = "lblTotalBeforeDiscount";
			this.lblTotalBeforeDiscount.Size = new System.Drawing.Size(10, 13);
			this.lblTotalBeforeDiscount.TabIndex = 9;
			this.lblTotalBeforeDiscount.Text = ".";
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Location = new System.Drawing.Point(118, 334);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(10, 13);
			this.lblDiscount.TabIndex = 10;
			this.lblDiscount.Text = ".";
			// 
			// lblRevenue
			// 
			this.lblRevenue.AutoSize = true;
			this.lblRevenue.Location = new System.Drawing.Point(118, 373);
			this.lblRevenue.Name = "lblRevenue";
			this.lblRevenue.Size = new System.Drawing.Size(10, 13);
			this.lblRevenue.TabIndex = 11;
			this.lblRevenue.Text = ".";
			// 
			// OrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 406);
			this.Controls.Add(this.lblRevenue);
			this.Controls.Add(this.lblDiscount);
			this.Controls.Add(this.lblTotalBeforeDiscount);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvOrders);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.dtpTo);
			this.Controls.Add(this.dtpFrom);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "OrdersForm";
			this.Text = "OrdersForm";
			this.Load += new System.EventHandler(this.OrdersForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.DataGridView dgvOrders;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTotalBeforeDiscount;
		private System.Windows.Forms.Label lblDiscount;
		private System.Windows.Forms.Label lblRevenue;
	}
}
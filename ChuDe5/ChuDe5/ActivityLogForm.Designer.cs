namespace _ChuDe5
{
	partial class ActivityLogForm
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
			this.lstBills = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTotalBills = new System.Windows.Forms.Label();
			this.lblTotalRevenue = new System.Windows.Forms.Label();
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// lstBills
			// 
			this.lstBills.FormattingEnabled = true;
			this.lstBills.Location = new System.Drawing.Point(12, 12);
			this.lstBills.Name = "lstBills";
			this.lstBills.Size = new System.Drawing.Size(202, 238);
			this.lstBills.TabIndex = 0;
			this.lstBills.SelectedIndexChanged += new System.EventHandler(this.lstBills_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(68, 286);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tổng hoá đơn:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(68, 330);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tổng doanh thu:";
			// 
			// lblTotalBills
			// 
			this.lblTotalBills.AutoSize = true;
			this.lblTotalBills.Location = new System.Drawing.Point(179, 286);
			this.lblTotalBills.Name = "lblTotalBills";
			this.lblTotalBills.Size = new System.Drawing.Size(10, 13);
			this.lblTotalBills.TabIndex = 4;
			this.lblTotalBills.Text = ".";
			// 
			// lblTotalRevenue
			// 
			this.lblTotalRevenue.AutoSize = true;
			this.lblTotalRevenue.Location = new System.Drawing.Point(179, 330);
			this.lblTotalRevenue.Name = "lblTotalRevenue";
			this.lblTotalRevenue.Size = new System.Drawing.Size(10, 13);
			this.lblTotalRevenue.TabIndex = 5;
			this.lblTotalRevenue.Text = ".";
			// 
			// dgvDetails
			// 
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetails.Location = new System.Drawing.Point(247, 12);
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.Size = new System.Drawing.Size(210, 237);
			this.dgvDetails.TabIndex = 6;
			// 
			// ActivityLogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 365);
			this.Controls.Add(this.dgvDetails);
			this.Controls.Add(this.lblTotalRevenue);
			this.Controls.Add(this.lblTotalBills);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstBills);
			this.Name = "ActivityLogForm";
			this.Text = "ActivityLogForm";
			this.Load += new System.EventHandler(this.ActivityLogForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstBills;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTotalBills;
		private System.Windows.Forms.Label lblTotalRevenue;
		private System.Windows.Forms.DataGridView dgvDetails;
	}
}
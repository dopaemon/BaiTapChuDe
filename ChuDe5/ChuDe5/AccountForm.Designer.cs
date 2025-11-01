namespace _ChuDe5
{
	partial class AccountForm
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
			this.components = new System.ComponentModel.Container();
			this.dgvAccounts = new System.Windows.Forms.DataGridView();
			this.btnAddAccount = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnResetPwd = new System.Windows.Forms.Button();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.xemVaiTroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xemNhatKyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
			this.contextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvAccounts
			// 
			this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccounts.ContextMenuStrip = this.contextMenu;
			this.dgvAccounts.Location = new System.Drawing.Point(1, 7);
			this.dgvAccounts.Name = "dgvAccounts";
			this.dgvAccounts.Size = new System.Drawing.Size(456, 139);
			this.dgvAccounts.TabIndex = 0;
			this.dgvAccounts.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccounts_CellMouseDown);
			// 
			// btnAddAccount
			// 
			this.btnAddAccount.Location = new System.Drawing.Point(32, 171);
			this.btnAddAccount.Name = "btnAddAccount";
			this.btnAddAccount.Size = new System.Drawing.Size(107, 23);
			this.btnAddAccount.TabIndex = 1;
			this.btnAddAccount.Text = "Thêm tài khoản";
			this.btnAddAccount.UseVisualStyleBackColor = true;
			this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(192, 171);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnResetPwd
			// 
			this.btnResetPwd.Location = new System.Drawing.Point(324, 171);
			this.btnResetPwd.Name = "btnResetPwd";
			this.btnResetPwd.Size = new System.Drawing.Size(108, 23);
			this.btnResetPwd.TabIndex = 3;
			this.btnResetPwd.Text = "Đặt lại mật khẩu";
			this.btnResetPwd.UseVisualStyleBackColor = true;
			this.btnResetPwd.Click += new System.EventHandler(this.btnResetPwd_Click);
			// 
			// contextMenu
			// 
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemVaiTroToolStripMenuItem,
            this.xemNhatKyToolStripMenuItem});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new System.Drawing.Size(141, 48);
			// 
			// xemVaiTroToolStripMenuItem
			// 
			this.xemVaiTroToolStripMenuItem.Name = "xemVaiTroToolStripMenuItem";
			this.xemVaiTroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.xemVaiTroToolStripMenuItem.Text = "Xem vai trò";
			this.xemVaiTroToolStripMenuItem.Click += new System.EventHandler(this.xemVaiTroToolStripMenuItem_Click);
			// 
			// xemNhatKyToolStripMenuItem
			// 
			this.xemNhatKyToolStripMenuItem.Name = "xemNhatKyToolStripMenuItem";
			this.xemNhatKyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.xemNhatKyToolStripMenuItem.Text = "Xem nhật ký";
			this.xemNhatKyToolStripMenuItem.Click += new System.EventHandler(this.xemNhatKyToolStripMenuItem_Click);
			// 
			// AccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 209);
			this.Controls.Add(this.btnResetPwd);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAddAccount);
			this.Controls.Add(this.dgvAccounts);
			this.Name = "AccountForm";
			this.Text = "AccountForm";
			this.Load += new System.EventHandler(this.AccountForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
			this.contextMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAccounts;
		private System.Windows.Forms.Button btnAddAccount;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnResetPwd;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem xemVaiTroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xemNhatKyToolStripMenuItem;
	}
}
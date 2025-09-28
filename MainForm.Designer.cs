namespace StudentApp
{
    partial class MainForm
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
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtHoTenLot = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.cbLop = new System.Windows.Forms.ComboBox();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.btnThemMoi = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvDanhSachSV = new System.Windows.Forms.DataGridView();
			this.chklbMonHoc = new System.Windows.Forms.CheckedListBox();
			this.mtxtCMND = new System.Windows.Forms.MaskedTextBox();
			this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
			this.mtxtMSSV = new System.Windows.Forms.MaskedTextBox();
			this.btnXoaThongTin = new System.Windows.Forms.Button();
			this.txtLoadTT = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSV)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "MSSV:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Họ và tên lót:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ngày sinh:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Số CMND:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(30, 211);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Địa chỉ liên lạc:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(341, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Giới tính:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(341, 76);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Tên:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(341, 121);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(28, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Lớp:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(341, 167);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Số ĐT:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(30, 264);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Môn học đăng ký:";
			// 
			// txtHoTenLot
			// 
			this.txtHoTenLot.Location = new System.Drawing.Point(127, 73);
			this.txtHoTenLot.Name = "txtHoTenLot";
			this.txtHoTenLot.Size = new System.Drawing.Size(188, 20);
			this.txtHoTenLot.TabIndex = 11;
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(423, 73);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(202, 20);
			this.txtTen.TabIndex = 11;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgaySinh.Location = new System.Drawing.Point(127, 115);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(188, 20);
			this.dtpNgaySinh.TabIndex = 12;
			// 
			// cbLop
			// 
			this.cbLop.FormattingEnabled = true;
			this.cbLop.Location = new System.Drawing.Point(423, 114);
			this.cbLop.Name = "cbLop";
			this.cbLop.Size = new System.Drawing.Size(199, 21);
			this.cbLop.TabIndex = 13;
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Location = new System.Drawing.Point(423, 34);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(47, 17);
			this.rdNam.TabIndex = 14;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Location = new System.Drawing.Point(486, 34);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(39, 17);
			this.rdNu.TabIndex = 15;
			this.rdNu.TabStop = true;
			this.rdNu.Text = "Nữ";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(127, 204);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(495, 20);
			this.txtDiaChi.TabIndex = 16;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(259, 353);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimKiem.TabIndex = 18;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// btnThemMoi
			// 
			this.btnThemMoi.Location = new System.Drawing.Point(365, 353);
			this.btnThemMoi.Name = "btnThemMoi";
			this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
			this.btnThemMoi.TabIndex = 18;
			this.btnThemMoi.Text = "Thêm mới";
			this.btnThemMoi.UseVisualStyleBackColor = true;
			this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Location = new System.Drawing.Point(464, 353);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
			this.btnCapNhat.TabIndex = 18;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(565, 353);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 18;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvDanhSachSV);
			this.groupBox1.Location = new System.Drawing.Point(16, 389);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(609, 123);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách sinh viên";
			// 
			// dgvDanhSachSV
			// 
			this.dgvDanhSachSV.AllowUserToOrderColumns = true;
			this.dgvDanhSachSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSachSV.Location = new System.Drawing.Point(6, 16);
			this.dgvDanhSachSV.Name = "dgvDanhSachSV";
			this.dgvDanhSachSV.Size = new System.Drawing.Size(597, 101);
			this.dgvDanhSachSV.TabIndex = 0;
			this.dgvDanhSachSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSV_CellContentClick);
			// 
			// chklbMonHoc
			// 
			this.chklbMonHoc.FormattingEnabled = true;
			this.chklbMonHoc.Items.AddRange(new object[] {
            "Mạng máy tính",
            "Hệ điều hành",
            "Lập trình CSDL",
            "Lập trình mạng",
            "Đồ án cơ sở",
            "Phương pháp NCKH",
            "Lập trình trên thiết bị di động",
            "An toàn và bảo mật hệ thống"});
			this.chklbMonHoc.Location = new System.Drawing.Point(130, 253);
			this.chklbMonHoc.MultiColumn = true;
			this.chklbMonHoc.Name = "chklbMonHoc";
			this.chklbMonHoc.Size = new System.Drawing.Size(492, 64);
			this.chklbMonHoc.TabIndex = 21;
			// 
			// mtxtCMND
			// 
			this.mtxtCMND.Location = new System.Drawing.Point(127, 164);
			this.mtxtCMND.Mask = "000000000";
			this.mtxtCMND.Name = "mtxtCMND";
			this.mtxtCMND.Size = new System.Drawing.Size(188, 20);
			this.mtxtCMND.TabIndex = 22;
			// 
			// mtxtSDT
			// 
			this.mtxtSDT.Location = new System.Drawing.Point(423, 160);
			this.mtxtSDT.Mask = "9999.000.000";
			this.mtxtSDT.Name = "mtxtSDT";
			this.mtxtSDT.Size = new System.Drawing.Size(199, 20);
			this.mtxtSDT.TabIndex = 23;
			// 
			// mtxtMSSV
			// 
			this.mtxtMSSV.Location = new System.Drawing.Point(127, 32);
			this.mtxtMSSV.Mask = "0010000";
			this.mtxtMSSV.Name = "mtxtMSSV";
			this.mtxtMSSV.Size = new System.Drawing.Size(188, 20);
			this.mtxtMSSV.TabIndex = 24;
			this.mtxtMSSV.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtMSSV_MaskInputRejected);
			// 
			// btnXoaThongTin
			// 
			this.btnXoaThongTin.Location = new System.Drawing.Point(156, 353);
			this.btnXoaThongTin.Name = "btnXoaThongTin";
			this.btnXoaThongTin.Size = new System.Drawing.Size(75, 23);
			this.btnXoaThongTin.TabIndex = 25;
			this.btnXoaThongTin.Text = "Xoá TT";
			this.btnXoaThongTin.UseVisualStyleBackColor = true;
			this.btnXoaThongTin.Click += new System.EventHandler(this.btnXoaThongTin_Click);
			// 
			// txtLoadTT
			// 
			this.txtLoadTT.Location = new System.Drawing.Point(59, 353);
			this.txtLoadTT.Name = "txtLoadTT";
			this.txtLoadTT.Size = new System.Drawing.Size(75, 23);
			this.txtLoadTT.TabIndex = 26;
			this.txtLoadTT.Text = "Load TT";
			this.txtLoadTT.UseVisualStyleBackColor = true;
			this.txtLoadTT.Click += new System.EventHandler(this.txtLoadTT_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 539);
			this.Controls.Add(this.txtLoadTT);
			this.Controls.Add(this.btnXoaThongTin);
			this.Controls.Add(this.mtxtMSSV);
			this.Controls.Add(this.mtxtSDT);
			this.Controls.Add(this.mtxtCMND);
			this.Controls.Add(this.chklbMonHoc);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnThemMoi);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnCapNhat);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.txtDiaChi);
			this.Controls.Add(this.rdNu);
			this.Controls.Add(this.rdNam);
			this.Controls.Add(this.cbLop);
			this.Controls.Add(this.dtpNgaySinh);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.txtHoTenLot);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Nhập thông tin sinh viên";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHoTenLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.CheckedListBox chklbMonHoc;
		private System.Windows.Forms.DataGridView dgvDanhSachSV;
		private System.Windows.Forms.MaskedTextBox mtxtCMND;
		private System.Windows.Forms.MaskedTextBox mtxtSDT;
		private System.Windows.Forms.MaskedTextBox mtxtMSSV;
		private System.Windows.Forms.Button btnXoaThongTin;
		private System.Windows.Forms.Button txtLoadTT;
	}
}


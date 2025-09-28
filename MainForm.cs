using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace StudentApp
{
	public partial class MainForm : Form
	{
		private QLSinhVien qlSV;



		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			SetupGridView(); 

			string filePath = Path.Combine(Application.StartupPath, "SinhVien.txt"); 
			qlSV = new QLSinhVien(filePath); 
			string jsonPath = Path.Combine(Application.StartupPath, "SinhVienJ.json"); 
			qlSV.LoadFromJson(jsonPath); 
			string xmlPath = Path.Combine(Application.StartupPath, "SinhVien2.xml"); 
			qlSV.LoadFromXml(xmlPath); 
		
			LoadDataToGrid();
		}

		private void LoadDataToGrid()
		{
			dgvDanhSachSV.DataSource = null;
			dgvDanhSachSV.DataSource = qlSV.GetAll();
		}

		private void btnThemMoi_Click(object sender, EventArgs e)
		{
	
			if (string.IsNullOrWhiteSpace(txtHoTenLot.Text) ||
				string.IsNullOrWhiteSpace(txtTen.Text) ||
				string.IsNullOrWhiteSpace(cbLop.Text) ||
				string.IsNullOrWhiteSpace(mtxtCMND.Text) ||
				string.IsNullOrWhiteSpace(mtxtSDT.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
				return;
			}

	
			if (string.IsNullOrWhiteSpace(mtxtMSSV.Text))
			{
				mtxtMSSV.Text = qlSV.GenerateMSSV(cbLop.Text.Trim());
			}

			var monHoc = new List<string>();
			foreach (var item in chklbMonHoc.CheckedItems)
				monHoc.Add(item.ToString());

			var sv = new Student
			{
				MSSV = mtxtMSSV.Text.Trim(),
				GioiTinh = rdNam.Checked ? "Nam" : "Nữ",
				HoTenLot = txtHoTenLot.Text.Trim(),
				Ten = txtTen.Text.Trim(),
				NgaySinh = dtpNgaySinh.Value,
				Lop = cbLop.Text.Trim(),
				CMND = mtxtCMND.Text.Trim(),
				SoDT = mtxtSDT.Text.Trim(),
				DiaChi = txtDiaChi.Text.Trim(),
				MonDangKy = monHoc
			};

			qlSV.AddOrUpdate(sv);
			LoadDataToGrid();

			MessageBox.Show("Đã thêm/cập nhật sinh viên!", "Thông báo");
		}

		private void dgvDanhSachSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				var row = dgvDanhSachSV.Rows[e.RowIndex].DataBoundItem as Student;
				if (row != null)
				{
					mtxtMSSV.Text = row.MSSV;
					rdNam.Checked = row.GioiTinh == "Nam";
					rdNu.Checked = row.GioiTinh == "Nữ";
					txtHoTenLot.Text = row.HoTenLot;
					txtTen.Text = row.Ten;
					dtpNgaySinh.Value = row.NgaySinh;
					cbLop.Text = row.Lop;
					mtxtCMND.Text = row.CMND;
					mtxtSDT.Text = row.SoDT;
					txtDiaChi.Text = row.DiaChi;

					for (int i = 0; i < chklbMonHoc.Items.Count; i++)
						chklbMonHoc.SetItemChecked(i, row.MonDangKy.Contains(chklbMonHoc.Items[i].ToString()));
				}
			}
		}

		private void SetupGridView()
		{
			dgvDanhSachSV.AutoGenerateColumns = false;
			dgvDanhSachSV.ColumnCount = 10;

			dgvDanhSachSV.Columns[0].Name = "MSSV";
			dgvDanhSachSV.Columns[0].DataPropertyName = "MSSV";

			dgvDanhSachSV.Columns[1].Name = "Giới tính";
			dgvDanhSachSV.Columns[1].DataPropertyName = "GioiTinh";

			dgvDanhSachSV.Columns[2].Name = "Họ và tên lót";
			dgvDanhSachSV.Columns[2].DataPropertyName = "HoTenLot";

			dgvDanhSachSV.Columns[3].Name = "Tên";
			dgvDanhSachSV.Columns[3].DataPropertyName = "Ten";

			dgvDanhSachSV.Columns[4].Name = "Ngày sinh";
			dgvDanhSachSV.Columns[4].DataPropertyName = "NgaySinh";

			dgvDanhSachSV.Columns[5].Name = "Lớp";
			dgvDanhSachSV.Columns[5].DataPropertyName = "Lop";

			dgvDanhSachSV.Columns[6].Name = "Số CMND";
			dgvDanhSachSV.Columns[6].DataPropertyName = "CMND";

			dgvDanhSachSV.Columns[7].Name = "SĐT";
			dgvDanhSachSV.Columns[7].DataPropertyName = "SoDT";

			dgvDanhSachSV.Columns[8].Name = "Địa chỉ liên lạc";
			dgvDanhSachSV.Columns[8].DataPropertyName = "DiaChi";

			dgvDanhSachSV.Columns[9].Name = "Môn học đăng ký";
			dgvDanhSachSV.Columns[9].DataPropertyName = "MonDangKyText";
		}

		private void mtxtMSSV_Leave(object sender, EventArgs e)
		{
			string mssv = mtxtMSSV.Text.Replace("_", "").Trim();
			if (string.IsNullOrEmpty(mssv)) return;

			var sv = qlSV.GetAll().FirstOrDefault(s =>
						 s.MSSV.Equals(mssv, StringComparison.OrdinalIgnoreCase));

			if (sv != null)
			{
				rdNam.Checked = sv.GioiTinh == "Nam";
				rdNu.Checked = sv.GioiTinh == "Nữ";
				txtHoTenLot.Text = sv.HoTenLot;
				txtTen.Text = sv.Ten;
				dtpNgaySinh.Value = sv.NgaySinh;
				cbLop.Text = sv.Lop;
				mtxtCMND.Text = sv.CMND;
				mtxtSDT.Text = sv.SoDT;
				txtDiaChi.Text = sv.DiaChi;


				for (int i = 0; i < chklbMonHoc.Items.Count; i++)
				{
					string mon = chklbMonHoc.Items[i].ToString();
					chklbMonHoc.SetItemChecked(i, sv.MonDangKy.Contains(mon));
				}
			}
			else
			{
				MessageBox.Show("Không tìm thấy MSSV trong danh sách!");
			}
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			var list = qlSV.GetAll();
			List<Student> timSV = new List<Student>();
			timSV.Clear();

			if (!string.IsNullOrEmpty(mtxtMSSV.Text))
			{
					foreach (var item in list)
					{
						if (item.MSSV == mtxtMSSV.Text)
						{
							timSV.Add(item);
						}
					}
			}

			if (!string.IsNullOrEmpty(txtHoTenLot.Text))
			{
				foreach (var item in list)
				{
					if (item.HoTenLot == txtHoTenLot.Text)
					{
						if (!timSV.Any(s => s.MSSV == item.MSSV))
						{
							timSV.Add(item);
						}
					}
				}
			}

			if (!string.IsNullOrEmpty(txtTen.Text))
			{
				foreach (var item in list)
				{
					if (item.Ten == txtTen.Text)
					{
						if (!timSV.Any(s => s.MSSV == item.MSSV))
						{
							timSV.Add(item);
						}
					}
				}
			}

			if (!string.IsNullOrEmpty(cbLop.Text))
			{
				foreach (var item in list)
				{
					if (item.Lop == cbLop.Text)
					{
						if (!timSV.Any(s => s.MSSV == item.MSSV))
						{
							timSV.Add(item);
						}
					}
				}
			}


			if (!string.IsNullOrEmpty(mtxtCMND.Text))
			{
				foreach (var item in list)
				{
					if (item.CMND == mtxtCMND.Text)
					{
						if (!timSV.Any(s => s.MSSV == item.MSSV))
						{
							timSV.Add(item);
						}
					}
				}
			}


			if (!string.IsNullOrEmpty(mtxtSDT.Text))
			{
				string sdt = mtxtSDT.Text.Replace(".", "");

				foreach (var item in list)
				{
					if (item.SoDT == sdt)
					{
						if (!timSV.Any(s => s.MSSV == item.MSSV))
						{
							timSV.Add(item);
						}
					}
				}
			}

			if (!string.IsNullOrEmpty(txtDiaChi.Text))
			{
				foreach (var item in list)
				{
					if (item.DiaChi == txtDiaChi.Text)
					{
						if (!timSV.Any(s => s.MSSV == item.MSSV))
						{
							timSV.Add(item);
						}
					}
				}
			}

			if (dtpNgaySinh.Value != null)
			{
				DateTime searchDate = dtpNgaySinh.Value.Date;
				foreach (var item in list)
				{
					if (item.NgaySinh.Date == searchDate)
					{
						if (!timSV.Any(s => s.NgaySinh.Date == item.NgaySinh.Date))
						{
							timSV.Add(item);
						}
					}
				}
			}



			dgvDanhSachSV.DataSource = null;
			dgvDanhSachSV.DataSource = timSV;

			if (list.Count == 0)
				MessageBox.Show("Không tìm thấy sinh viên nào phù hợp!");

		}

		public static string RemoveUnicode(string text)
		{
			if (string.IsNullOrEmpty(text)) return text;
			string normalized = text.Normalize(NormalizationForm.FormD);
			StringBuilder sb = new StringBuilder();
			foreach (var c in normalized)
			{
				var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
				if (unicodeCategory != UnicodeCategory.NonSpacingMark)
					sb.Append(c);
			}
			return sb.ToString().Normalize(NormalizationForm.FormC).ToLower();
		}


		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			var sv = qlSV.GetAll().FirstOrDefault(s => s.MSSV == mtxtMSSV.Text.Trim()); 
			if (sv == null) 
			{ 
				MessageBox.Show("MSSV không tồn tại, không thể cập nhật!"); 
				return;
			}
			sv.HoTenLot = txtHoTenLot.Text.Trim();
			sv.Ten = txtTen.Text.Trim();
			sv.GioiTinh = rdNam.Checked ? "Nam" : "Nữ"; sv.NgaySinh = dtpNgaySinh.Value;
			sv.Lop = cbLop.Text.Trim(); 
			sv.CMND = mtxtCMND.Text.Trim();
			sv.SoDT = mtxtSDT.Text.Trim();
			sv.DiaChi = txtDiaChi.Text.Trim();
			sv.MonDangKy = chklbMonHoc.CheckedItems.Cast<string>().ToList(); 
			qlSV.AddOrUpdate(sv); 
			LoadDataToGrid(); 
			MessageBox.Show("Cập nhật sinh viên thành công!");
		}


		private void btnThoat_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnXoaThongTin_Click(object sender, EventArgs e)
		{
			mtxtMSSV.Clear();
			txtHoTenLot.Clear();
			txtTen.Clear();
			cbLop.SelectedIndex = -1;
			mtxtCMND.Clear();
			mtxtSDT.Clear();
			txtDiaChi.Clear();
	
			rdNam.Checked = false;
			rdNu.Checked = false;

			
			dtpNgaySinh.Value = DateTime.Now;

		
			for (int i = 0; i < chklbMonHoc.Items.Count; i++)
			{
				chklbMonHoc.SetItemChecked(i, false);
			}

			dgvDanhSachSV.ClearSelection();
		}

		private void mtxtMSSV_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void txtLoadTT_Click(object sender, EventArgs e)
		{
			LoadDataToGrid();
		}
	}
}

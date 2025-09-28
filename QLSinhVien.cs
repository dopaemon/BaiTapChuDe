using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
	public class QLSinhVien
	{
		private List<Student> students;
		private string filePath;

		public QLSinhVien(string path)
		{
			filePath = path;
			students = FileHelper.ReadFromFile(filePath);
		}

		public List<Student> Students => students;

		public List<Student> GetAll() => students;

		public void AddOrUpdate(Student sv)
		{
			bool found = false;

			for (int i = 0; i < students.Count; i++)
			{
				if (students[i].MSSV == sv.MSSV)
				{
					students[i].HoTenLot = sv.HoTenLot;
					students[i].Ten = sv.Ten;
					students[i].GioiTinh = sv.GioiTinh;
					students[i].NgaySinh = sv.NgaySinh;
					students[i].Lop = sv.Lop;
					students[i].CMND = sv.CMND;
					students[i].SoDT = sv.SoDT;
					students[i].DiaChi = sv.DiaChi;
					students[i].MonDangKy = sv.MonDangKy;

					found = true;
					break;
				}
			}

			if (!found)
			{
				students.Add(sv);
			}

			Save();
		}


		public void Delete(List<string> listMSSV)
		{
			students.RemoveAll(s => listMSSV.Contains(s.MSSV));
			Save();
		}

		public List<Student> Search(string keyword, string type)
		{
			keyword = keyword.ToLower();
			switch (type.ToLower())
			{
				case "mssv":
					return students.Where(s => s.MSSV.ToLower().Contains(keyword)).ToList();
				case "ten":
					return students.Where(s =>
						(s.HoTenLot + " " + s.Ten).ToLower().Contains(keyword)
					).ToList();
				case "lop":
					return students.Where(s => s.Lop.ToLower().Contains(keyword)).ToList();
				default:
					return new List<Student>();
			}
		}

		public void Save()
		{
			FileHelper.WriteToFile(filePath, students);
		}
		public void SaveJson(string jsonPath)
		{
			FileHelper.WriteToFile(jsonPath, students);
		}

		public void SaveXml(string xmlPath)
		{
			FileHelper.WriteToFile(xmlPath, students);
		}

		public string GenerateMSSV(string lop)
		{
			if (string.IsNullOrEmpty(lop) || lop.Length < 5)
				throw new ArgumentException("Lớp không hợp lệ!");

	
			string AA = lop.Substring(3, 2);

			string BB = "10";
			int maxCCC = 0;

		
			var list = students.Where(s => s.MSSV.StartsWith(AA + BB));
			if (list.Any())
			{
				maxCCC = list.Max(s => int.Parse(s.MSSV.Substring(4, 3)));
			}

			string CCC = (maxCCC + 1).ToString("D3");
			return AA + BB + CCC; 
		}

		public static Student Parse(string line)
		{
			var parts = line.Split('|');
			if (parts.Length < 10) throw new FormatException("Sai định dạng dòng dữ liệu");

			return new Student
			{
				MSSV = parts[0],
				GioiTinh = parts[1],
				HoTenLot = parts[2],
				Ten = parts[3],
				NgaySinh = DateTime.ParseExact(parts[4], "yyyy-MM-dd", null),
				Lop = parts[5],
				CMND = parts[6],
				SoDT = parts[7],
				DiaChi = parts[8],
				MonDangKy = parts[9].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
									.Select(m => m.Trim()).ToList()
			};
		}

		public void LoadFromJson(string jsonPath)
		{
			if (!File.Exists(jsonPath)) return;

			var listJson = FileHelper.ReadFromFile(jsonPath);
			foreach (var sv in listJson)
			{
				if (!students.Any(s => s.MSSV == sv.MSSV))
				{
					students.Add(sv);
				}
			}
		}

		public void LoadFromXml(string xmlPath)
		{
			if (!File.Exists(xmlPath)) return;

			var listXml = FileHelper.ReadFromFile(xmlPath);
			foreach (var sv in listXml)
			{
				if (!students.Any(s => s.MSSV == sv.MSSV))
				{
					students.Add(sv);
				}
			}
		}

	}
}

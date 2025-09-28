using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
	public class Student
	{
		public string MSSV { get; set; }
		public string GioiTinh { get; set; }
		public string HoTenLot { get; set; }
		public string Ten { get; set; }
		public DateTime NgaySinh { get; set; }
		public string Lop { get; set; }
		public string CMND { get; set; }
		public string SoDT { get; set; }
		public string DiaChi { get; set; }
		public List<string> MonDangKy { get; set; }

		public Student()
		{
			MonDangKy = new List<string>();
		}

		public override string ToString()
		{
			return $"{MSSV}|{GioiTinh}|{HoTenLot}|{Ten}|{NgaySinh:yyyy-MM-dd}|{Lop}|{CMND}|{SoDT}|{DiaChi}|{string.Join(", ", MonDangKy)}";
		}

		
	}
}

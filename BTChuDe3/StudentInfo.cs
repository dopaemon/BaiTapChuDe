using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTChuDe3
{
    public class StudentInfo
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public double Diem { get; set; }
        public bool tongiao { get; set; }

        public StudentInfo(string mssv, string hoten, int tuoi, double diem, bool tongiao)
        {
            MSSV = mssv;
            HoTen = hoten;
            Tuoi = tuoi;
            Diem = diem;
            this.tongiao = tongiao;
        }
    }
}

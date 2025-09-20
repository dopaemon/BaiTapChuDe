using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace BTChuDe3
{
    public partial class frmReadJSonFile : Form
    {
        public frmReadJSonFile()
        {
            InitializeComponent();
        }

        private List<StudentInfo> LoadJSON(string path)
        {
            List<StudentInfo> list = new List<StudentInfo>();
            StreamReader r = new StreamReader(path);
            string json = r.ReadToEnd();
            var array = (JObject)JsonConvert.DeserializeObject(json);
            var students = array["sinhvien"].Children();
            foreach (var item in students)
            {
                string mssv = item["MSSV"].ToString();
                string hoten = item["HoTen"].ToString();
                int tuoi = int.Parse(item["Tuoi"].ToString());
                double diem = double.Parse(item["Diem"].ToString());
                bool tongiao = bool.Parse(item["TonGiao"].ToString());
                StudentInfo sv = new StudentInfo(mssv, hoten, tuoi, diem, tongiao);
                list.Add(sv);
            }
            return list;
        }

        private void btnReadJSon_Click(object sender, EventArgs e)
        {
            string Str = "";
            string Path = @".\students.json";
            List<StudentInfo> list = LoadJSON(Path);
            for(int i = 0; i < list.Count; i++)
            {
                StudentInfo Info = list[i];
                Str += string.Format("Sinh Viên {0} có MSSV {1}, Họ Tên {2}," + " Điểm TB {3}\r\n", (i + 1), Info.MSSV, Info.HoTen, Info.Diem);
            }
            MessageBox.Show(Str, "Thông Tin Sinh Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

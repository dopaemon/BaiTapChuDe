using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StudentApp
{
	public static class FileHelper
	{
		public static List<Student> ReadFromFile(string path)
		{
			if (!File.Exists(path)) return new List<Student>();

			string ext = Path.GetExtension(path).ToLower();

			switch (ext)
			{
				case ".txt":
					return File.ReadAllLines(path)
							   .Where(line => !string.IsNullOrWhiteSpace(line))
							   .Select(QLSinhVien.Parse)
							   .ToList();
				case ".xml":
					var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Student>));
					using (var fs = new FileStream(path, FileMode.Open))
						return (List<Student>)serializer.Deserialize(fs);
				case ".json":
					string json = File.ReadAllText(path);
					return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student>>(json);
				default:
					throw new NotSupportedException("Định dạng file không hỗ trợ");
			}
		}

		public static void WriteToFile(string path, List<Student> students)
		{
			string ext = Path.GetExtension(path).ToLower();

			switch (ext)
			{
				case ".txt":
					File.WriteAllLines(path, students.Select(s => s.ToString()));
					break;
				case ".xml":
					var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Student>));
					using (var fs = new FileStream(path, FileMode.Create))
						serializer.Serialize(fs, students);
					break;
				case ".json":
					string json = Newtonsoft.Json.JsonConvert.SerializeObject(students, Newtonsoft.Json.Formatting.Indented);
					File.WriteAllText(path, json);
					break;
				default:
					throw new NotSupportedException("Định dạng file không hỗ trợ");
			}
		}
	}
}

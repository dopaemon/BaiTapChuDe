using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ChuDe5
{
	public partial class CategoryForm : Form
	{
		public CategoryForm()
		{
			InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void btnAddCategory_Click(object sender, EventArgs e)
		{
			string catName = txtCategoryName.Text.Trim();
			if (string.IsNullOrEmpty(catName))
			{
				MessageBox.Show("Vui lòng nhập tên nhóm món ăn!");
				return;
			}

			try
			{
				string connectionString = "Data Source=WIN-RQEM4QB5GFH;Initial Catalog=ChuDe5;Integrated Security=True;Encrypt=False";
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string sql = "INSERT INTO Category (Name) VALUES (@name)";
					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@name", catName);
						conn.Open();
						cmd.ExecuteNonQuery();
					}
				}

				MessageBox.Show("Thêm nhóm món ăn thành công!");
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}

		private void CategoryForm_Load(object sender, EventArgs e)
		{

		}


	}
}

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
	public partial class AddAccountForm : Form
	{
		string connectionString = "Data Source=WIN-RQEM4QB5GFH;Initial Catalog=ChuDe5;Integrated Security=True;Encrypt=False";

		public AddAccountForm()
		{
			InitializeComponent();
		}

		private void AddAccountForm_Load(object sender, EventArgs e)
		{
			LoadRoles();
		}

		private void LoadRoles()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = "SELECT ID, RoleName FROM Role";
				SqlDataAdapter da = new SqlDataAdapter(sql, conn);
				System.Data.DataTable dt = new System.Data.DataTable();
				da.Fill(dt);
				cbbRole.DisplayMember = "RoleName";
				cbbRole.ValueMember = "ID";
				cbbRole.DataSource = dt;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string username = txtUserName.Text.Trim();
			string displayName = txtDisplayName.Text.Trim();
			string password = txtPassword.Text.Trim();
			int roleID = (int)cbbRole.SelectedValue;

			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Username và Password không được để trống!");
				return;
			}

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string sql = "INSERT INTO Account (Username, DisplayName, PasswordHash, RoleID) " +
								 "VALUES (@u, @d, HASHBYTES('SHA2_256', @p), @r)";
					SqlCommand cmd = new SqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@u", username);
					cmd.Parameters.AddWithValue("@d", displayName);
					cmd.Parameters.AddWithValue("@p", password);
					cmd.Parameters.AddWithValue("@r", roleID);
					conn.Open();
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Thêm tài khoản thành công!");
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

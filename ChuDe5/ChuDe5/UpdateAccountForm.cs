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
	public partial class UpdateAccountForm : Form
	{
		int accountID;
		string connectionString = "Data Source=WIN-RQEM4QB5GFH;Initial Catalog=ChuDe5;Integrated Security=True;Encrypt=False";

		public UpdateAccountForm(int id)
		{
			InitializeComponent();
			accountID = id;
		}

		private void UpdateAccountForm_Load(object sender, EventArgs e)
		{
			LoadRoles();
			LoadAccountInfo();
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

		private void LoadAccountInfo()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = "SELECT DisplayName, RoleID FROM Account WHERE ID=@id";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id", accountID);
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					txtDisplayName.Text = reader["DisplayName"].ToString();
					cbbRole.SelectedValue = (int)reader["RoleID"];
				}
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string displayName = txtDisplayName.Text.Trim();
			int roleID = (int)cbbRole.SelectedValue;

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string sql = "UPDATE Account SET DisplayName=@d, RoleID=@r WHERE ID=@id";
					SqlCommand cmd = new SqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@d", displayName);
					cmd.Parameters.AddWithValue("@r", roleID);
					cmd.Parameters.AddWithValue("@id", accountID);
					conn.Open();
					cmd.ExecuteNonQuery();
				}
				MessageBox.Show("Cập nhật tài khoản thành công!");
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

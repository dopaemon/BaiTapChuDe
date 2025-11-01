using Microsoft.VisualBasic;
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
	public partial class RoleForm : Form
	{
		int accountID = -1;
		string connectionString = "Data Source=WIN-RQEM4QB5GFH;Initial Catalog=ChuDe5;Integrated Security=True;Encrypt=False";

		public RoleForm(int accID = -1)
		{
			InitializeComponent();
			accountID = accID;
		}

		private void RoleForm_Load(object sender, EventArgs e)
		{
			LoadRoles();
		}

		private void LoadRoles()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = @"
                    SELECT R.ID, R.RoleName,
                        CASE WHEN A.RoleID = R.ID THEN 1 ELSE 0 END AS Assigned
                    FROM Role R
                    LEFT JOIN Account A ON A.ID = @accID";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@accID", accountID);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dgvRoles.DataSource = dt;
			}
		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			string newRole = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên vai trò mới:", "Thêm vai trò");
			if (string.IsNullOrWhiteSpace(newRole)) return;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = "INSERT INTO Role (RoleName) VALUES (@name)";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@name", newRole);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
			LoadRoles();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (accountID == -1) return;
			int selectedRole = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells["ID"].Value);

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = "UPDATE Account SET RoleID = @role WHERE ID = @accID";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@role", selectedRole);
				cmd.Parameters.AddWithValue("@accID", accountID);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
			MessageBox.Show("Cập nhật vai trò thành công!");
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

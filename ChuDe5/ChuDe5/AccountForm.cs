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
	public partial class AccountForm : Form
	{
		string connectionString = "Data Source=WIN-RQEM4QB5GFH;Initial Catalog=ChuDe5;Integrated Security=True;Encrypt=False";
		public AccountForm()
		{
			InitializeComponent();
		}

		private void AccountForm_Load(object sender, EventArgs e)
		{
			LoadAccounts();
		}

		private void LoadAccounts()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = @"SELECT A.ID, A.Username, A.DisplayName, R.RoleName
                               FROM Account A
                               LEFT JOIN Role R ON A.RoleID = R.ID";
				SqlDataAdapter da = new SqlDataAdapter(sql, conn);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dgvAccounts.DataSource = dt;
			}
		}

		private void btnAddAccount_Click(object sender, EventArgs e)
		{
			AddAccountForm f = new AddAccountForm();
			if (f.ShowDialog() == DialogResult.OK)
				LoadAccounts();
		}

		private void btnAddRole_Click(object sender, EventArgs e)
		{
			RoleForm roleForm = new RoleForm();
			roleForm.ShowDialog();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (dgvAccounts.CurrentRow == null) return;
			int id = Convert.ToInt32(dgvAccounts.CurrentRow.Cells["ID"].Value);
			UpdateAccountForm f = new UpdateAccountForm(id);
			if (f.ShowDialog() == DialogResult.OK)
				LoadAccounts();
		}

		private void btnResetPwd_Click(object sender, EventArgs e)
		{
			if (dgvAccounts.CurrentRow == null) return;
			string username = dgvAccounts.CurrentRow.Cells["Username"].Value.ToString();

			if (MessageBox.Show($"Reset mật khẩu cho {username}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string sql = "UPDATE Account SET PasswordHash = HASHBYTES('SHA2_256', '123456') WHERE Username = @user";
					SqlCommand cmd = new SqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@user", username);
					conn.Open();
					cmd.ExecuteNonQuery();
				}
				MessageBox.Show("Đã reset mật khẩu về 123456");
			}
		}

		private void dgvAccounts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
			{
				dgvAccounts.ClearSelection();
				dgvAccounts.Rows[e.RowIndex].Selected = true;
				contextMenu.Show(Cursor.Position);
			}
		}

		private void xemVaiTroToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int accID = Convert.ToInt32(dgvAccounts.SelectedRows[0].Cells["ID"].Value);
			RoleForm rf = new RoleForm(accID);
			rf.ShowDialog();
		}

		private void xemNhatKyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int accID = Convert.ToInt32(dgvAccounts.SelectedRows[0].Cells["ID"].Value);
			ActivityLogForm lf = new ActivityLogForm(accID);
			lf.ShowDialog();
		}
	}
}

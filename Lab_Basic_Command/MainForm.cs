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

namespace Lab_Basic_Command
{
	public partial class MainForm : Form
	{
		string connectionString = "server=WIN-RQEM4QB5GFH; database=RestaurantManagement; Trusted_Connection=true;";
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadTables();

			if (!Session.IsAdmin)
			{
				btnAddTable.Visible = false;
				btnEditTable.Visible = false;
				btnDeleteTable.Visible = false;
				btnCategoryForm.Visible = false;
				btnAccountManager.Visible = false;
			}
		}

		private void LoadTables()
		{
			flpTables.Controls.Clear();

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "SELECT ID, Name, Status FROM TableFood";

				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Button btn = new Button();
					btn.Width = 120;
					btn.Height = 70;
					btn.Text = reader["Name"].ToString() + Environment.NewLine + reader["Status"].ToString();
					btn.Tag = reader["ID"];
					btn.BackColor = reader["Status"].ToString() == "Trống" ? Color.LightGreen : Color.LightCoral;
					btn.ContextMenuStrip = cmsTableMenu;
					btn.Click += Btn_Click;

					flpTables.Controls.Add(btn);
				}
				conn.Close();
			}
		}

		private void Btn_Click(object sender, EventArgs e)
		{
			Button tableButton = sender as Button;
			int tableID = (int)tableButton.Tag;

			BillsForm billForm = new BillsForm();
			billForm.Text = $"Hóa đơn bàn {tableButton.Text}";
			billForm.ShowDialog();
		}

		private void btnAddTable_Click(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "INSERT INTO TableFood (Name, Status) VALUES (@name, N'Trống')";
				cmd.Parameters.AddWithValue("@name", "Bàn mới");

				conn.Open();
				cmd.ExecuteNonQuery();
				conn.Close();
			}

			LoadTables();
		}

		private void btnEditTable_Click(object sender, EventArgs e)
		{
			if (flpTables.Controls.Count == 0) return;

			Button btn = (Button)flpTables.Controls[0];
			int id = (int)btn.Tag;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "UPDATE TableFood SET Name = @name WHERE ID = @id";
				cmd.Parameters.AddWithValue("@name", "Bàn VIP");
				cmd.Parameters.AddWithValue("@id", id);

				conn.Open();
				cmd.ExecuteNonQuery();
				conn.Close();
			}

			LoadTables();
		}

		private void btnDeleteTable_Click(object sender, EventArgs e)
		{
			if (flpTables.Controls.Count == 0) return;

			Button btn = (Button)flpTables.Controls[0];
			int id = (int)btn.Tag;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "DELETE FROM TableFood WHERE ID = @id";
				cmd.Parameters.AddWithValue("@id", id);

				conn.Open();
				cmd.ExecuteNonQuery();
				conn.Close();
			}

			LoadTables();
		}

		private void mnuDelete_Click(object sender, EventArgs e)
		{
			if (cmsTableMenu.SourceControl is Button btn)
			{
				int id = (int)btn.Tag;

				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					SqlCommand cmd = conn.CreateCommand();
					cmd.CommandText = "DELETE FROM TableFood WHERE ID = @id";
					cmd.Parameters.AddWithValue("@id", id);

					conn.Open();
					cmd.ExecuteNonQuery();
					conn.Close();
				}

				LoadTables();
			}
		}

		private void mnuViewBills_Click(object sender, EventArgs e)
		{
			BillsForm form = new BillsForm();
			form.ShowDialog();
		}

		private void mnuViewBillLog_Click(object sender, EventArgs e)
		{
			BillLogForm form = new BillLogForm();
			form.ShowDialog();
		}

		private void btnCategoryForm_Click(object sender, EventArgs e)
		{
			CategoryForm categoryForm = new CategoryForm();
			categoryForm.ShowDialog();
		}

		private void btnAccountManager_Click(object sender, EventArgs e)
		{
			AccountManager accountForm = new AccountManager();
			accountForm.ShowDialog();
		}
	}
}

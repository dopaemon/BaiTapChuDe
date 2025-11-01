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
	public partial class ActivityLogForm : Form
	{
		int accountID;
		string connectionString = "Data Source=WIN-RQEM4QB5GFH;Initial Catalog=ChuDe5;Integrated Security=True;Encrypt=False";

		public ActivityLogForm(int accID)
		{
			InitializeComponent();
			accountID = accID;
		}

		private void ActivityLogForm_Load(object sender, EventArgs e)
		{
			LoadBills();
		}

		private void LoadBills()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = @"SELECT B.ID, B.DateCreated FROM Bill B
                               JOIN AccountActivity A ON A.BillID = B.ID
                               WHERE A.AccountID = @id";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id", accountID);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				lstBills.DisplayMember = "DateCreated";
				lstBills.ValueMember = "ID";
				lstBills.DataSource = dt;

				lblTotalBills.Text = $"Số hóa đơn: {dt.Rows.Count}";
			}
		}

		private void lstBills_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstBills.SelectedValue == null) return;
			int billID = Convert.ToInt32(lstBills.SelectedValue);
			LoadBillDetails(billID);
		}

		private void LoadBillDetails(int billID)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = @"SELECT F.Name, F.Unit, BD.Quantity, F.Price, (BD.Quantity*F.Price) AS Total
                               FROM BillDetails BD
                               JOIN Food F ON BD.FoodID = F.ID
                               WHERE BD.BillID = @id";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id", billID);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dgvDetails.DataSource = dt;

				double total = 0;
				foreach (DataRow r in dt.Rows)
					total += Convert.ToDouble(r["Total"]);

				lblTotalRevenue.Text = $"Tổng doanh thu: {total:N0} VNĐ";
			}
		}
	}
}

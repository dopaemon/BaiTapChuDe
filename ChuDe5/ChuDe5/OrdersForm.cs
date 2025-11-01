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
	public partial class OrdersForm : Form
	{
		public OrdersForm()
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

		private void OrdersForm_Load(object sender, EventArgs e)
		{

		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			LoadOrders(dtpFrom.Value.Date, dtpTo.Value.Date);
		}

		private void LoadOrders(DateTime fromDate, DateTime toDate)
		{
			string connectionString = "Data Source=WIN-RQEM4QB5GFH;Initial Catalog=ChuDe5;Integrated Security=True;Encrypt=False";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = @"
                    SELECT B.ID, B.DateCreated, B.Discount,
                           SUM(F.Price * BD.Quantity) AS TotalBeforeDiscount,
                           SUM(F.Price * BD.Quantity) - B.Discount AS Revenue
                    FROM Bill B
                    JOIN BillDetails BD ON B.ID = BD.BillID
                    JOIN Food F ON BD.FoodID = F.ID
                    WHERE B.DateCreated BETWEEN @from AND @to
                    GROUP BY B.ID, B.DateCreated, B.Discount
                    ORDER BY B.DateCreated";

				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@from", fromDate);
					cmd.Parameters.AddWithValue("@to", toDate.AddDays(1).AddSeconds(-1)); // hết ngày cuối

					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					dgvOrders.DataSource = dt;
				}
			}
		}

		private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				int billID = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["ID"].Value);
				OrderDetailsForm detailsForm = new OrderDetailsForm(billID);
				detailsForm.ShowDialog();
			}
		}
	}
}

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
	public partial class OrderDetailsForm : Form
	{
		private int _billID;
		public OrderDetailsForm(int billID)
		{
			InitializeComponent();
			_billID = billID;
			LoadOrderDetails();
		}

		private void LoadOrderDetails()
		{
			string connectionString = "Data Source=WIN-RQEM4QB5GFH;Initial Catalog=ChuDe5;Integrated Security=True;Encrypt=False";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = @"
                    SELECT F.Name, F.Unit, F.Price, BD.Quantity, (F.Price*BD.Quantity) AS Total
                    FROM BillDetails BD
                    JOIN Food F ON BD.FoodID = F.ID
                    WHERE BD.BillID = @billID";

				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@billID", _billID);

					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					dgvOrderDetails.DataSource = dt;
				}
			}
		}
		private void OrderDetailsForm_Load(object sender, EventArgs e)
		{

		}
	}
}

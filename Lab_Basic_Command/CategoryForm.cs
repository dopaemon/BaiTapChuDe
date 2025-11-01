using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Basic_Command
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
			string connectionString = "server=WIN-RQEM4QB5GFH; database=RestaurantManagement; Trusted_Connection=true;";
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlCommand.CommandText =
					@"SELECT 
                c.ID AS CategoryID,
                c.Name AS CategoryName,
                COUNT(f.ID) AS TotalFoods
              FROM Category c
              LEFT JOIN Food f ON f.FoodCategoryID = c.ID
              GROUP BY c.ID, c.Name
              ORDER BY c.ID";

				sqlConnection.Open();
				SqlDataReader reader = sqlCommand.ExecuteReader();
				DisplayCategory(reader);
				sqlConnection.Close();
			}
		}

        private void DisplayCategory(SqlDataReader reader)
        {
            lvCategory.Items.Clear();

            while (reader.Read())
            {
				ListViewItem item = new ListViewItem(reader["CategoryID"].ToString());
				item.SubItems.Add(reader["CategoryName"].ToString());
				item.SubItems.Add(reader["TotalFoods"].ToString());
				lvCategory.Items.Add(item);
			}
            reader.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
			string connectionString = "server=WIN-RQEM4QB5GFH; database=RestaurantManagement; Trusted_Connection=true;";
			SqlConnection sqlConnection = new SqlConnection( connectionString );

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "INSERT INTO category(Name, [Type])" + "VALUES (N'" + txtName.Text + "', " + txtType.Text + ")";
            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if( numOfRowsEffected == 1 ) 
            {
                MessageBox.Show("Thêm nhóm món ăn thành công");

                btnLoad.PerformClick();
                txtName.Text = "";
                txtType.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại");
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvCategory.SelectedItems[0];
            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[1].Text == "0" ? "Thức uống" : "Đồ ăn";

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
			string connectionString = "server=WIN-RQEM4QB5GFH; database=RestaurantManagement; Trusted_Connection=true;";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "UPDATE Category SET Name = N'" + txtName.Text + "', [Type] = " + txtType.Text + "WHERE ID " + txtID.Text;
            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (numOfRowsEffected == 1) 
            {
                ListViewItem item = lvCategory.SelectedItems[0];

                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text = txtType.Text;

                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                MessageBox.Show("Cập nhật nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
			string connectionString = "server=WIN-RQEM4QB5GFH; database=RestaurantManagement; Trusted_Connection=true;";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "DELETE FROM Category " + "WHERE ID = " + txtID.Text;

            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                lvCategory.Items.Remove(item);

                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                MessageBox.Show("Xóa nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }    
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
            {
                btnDelete.PerformClick();
            }
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                FoodForm foodForm = new FoodForm();
                foodForm.Show(this);
                foodForm.LoadFood(Convert.ToInt32(txtID.Text));
            }
        }

		private void CategoryForm_Load(object sender, EventArgs e)
		{
			btnLoad.PerformClick();
		}
	}
}

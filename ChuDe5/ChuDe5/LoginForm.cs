using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ChuDe5
{
	public partial class LoginForm : Form
	{
		private string connectionString = "Data Source=WIN-RQEM4QB5GFH;Initial Catalog=ChuDe5;Integrated Security=True;Encrypt=False";

		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUserName.Text.Trim();
			string password = txtPassword.Text.Trim();

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand("SELECT PasswordHash FROM Account WHERE Username = @username", conn))
				{
					cmd.Parameters.AddWithValue("@username", username);
					object dbVal = cmd.ExecuteScalar();

					if (dbVal == null)
					{
						MessageBox.Show("Username không tồn tại!");
						return;
					}

					// storedHash là string từ DB
					string storedHash = dbVal.ToString();

					// Tạo SHA256 của mật khẩu nhập và chuyển sang HEX
					// Hash SHA256 input
					using (SHA256 sha = SHA256.Create())
					{
						byte[] hashBytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
						string inputHash = BitConverter.ToString(hashBytes).Replace("-", "");

						if (string.Equals(storedHash, inputHash, StringComparison.OrdinalIgnoreCase))
						{
							// login success
							Form1 main = new Form1();
							main.Show();
							this.Hide();
						}
						else
						{
							MessageBox.Show("Mật khẩu không đúng!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

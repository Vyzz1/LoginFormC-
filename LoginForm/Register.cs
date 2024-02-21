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

namespace LoginForm
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }



        private void login_btn_Click(object sender, EventArgs e)
        {
            if (user_name.Text == "" || user_pwd.Text == "" || pwd_again.Text == "" || user_id.Text == "")
            {
                MessageBox.Show("Thông tin bị thiếu");
                return;

            }
            else if (user_pwd.Text != pwd_again.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp");
            }
            else
            {
                SqlConnection conn = Connenction.GetSqlConnection();

                try
                {
                    conn.Open();
                    string checkUserQuery = "SELECT 1 FROM Users WHERE UserID = @UserID";
                    using (SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, conn))
                    {
                        checkUserCmd.Parameters.AddWithValue("@UserID", user_id.Text);
                        using (SqlDataReader reader = checkUserCmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Tài khoản đã tồn tại");
                                return;
                            }
                        }
                    }
                    string query = "insert into Users(UserID, Username, Pass_word) values(@UserID,@Username,@Pass_word)";
                    SqlCommand cmd = new(query, conn);
                    cmd.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = user_id.Text;
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = user_name.Text;
                    cmd.Parameters.Add("@Pass_word", SqlDbType.NVarChar).Value = PasswordHasher.HashPassword(user_pwd.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Tạo user {user_name.Text} thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);

                }
                finally
                {
                    Connenction.CloseConnection(conn);

                }

            }

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            user_id.Text = "";
            user_pwd.Text = "";
            pwd_again.Text = "";
            user_name.Text = "";
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}

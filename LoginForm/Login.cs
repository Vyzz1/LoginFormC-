
using System.Data;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class FormLogin : Form
    {
        SqlConnection sqlConnection = null;
        public FormLogin()
        {
            InitializeComponent();
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            if (id_Input.Text == "" || pwd_Input.Text == "")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu bị thiếu");
                return;
            }
            else
            {
                try
                {
                    sqlConnection ??= Connenction.GetSqlConnection();

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();

                    }
                    string user_id = id_Input.Text;
                    string query = "Select Users.Pass_word From Users where Users.UserID = @userId";

                    SqlCommand cmd = new(query, sqlConnection);
                    cmd.Parameters.AddWithValue("@userId", user_id);

                    // Lấy mật khẩu đã mã hóa từ database
                    string storedPassword = (string)cmd.ExecuteScalar();

                    if (storedPassword != null && PasswordHasher.VerifyPassword(pwd_Input.Text, storedPassword))
                    {
                        MessageBox.Show("Login successful!");
                    }
                    else
                    {
                        MessageBox.Show("Wrong id or password");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
    }   
            if(btn_rmb.Checked == true)
            {
                Properties.Settings.Default.Username = id_Input.Text;
                Properties.Settings.Default.PassWord = pwd_Input.Text;
                Properties.Settings.Default.Save();
            }
            else
            {

                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.PassWord = "";
                Properties.Settings.Default.Save();
            }
        }





        private void clear_button_Click(object sender, EventArgs e)
        {
            id_Input.Text = "";
            pwd_Input.Text = "";
        }



        private void Register_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Register register = new();
            register.Show();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                id_Input.Text = Properties.Settings.Default.Username;
                pwd_Input.Text = Properties.Settings.Default.PassWord;
            }
        }
    }
}

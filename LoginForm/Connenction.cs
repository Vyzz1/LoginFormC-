using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LoginForm
{
    static class Connenction
    {
        // thay chuỗi này để kết nối với SQL của ae
        public static string stringConnection = @"Data Source=LAPTOP-6RA92RMF;Initial Catalog=QuanLyTaiKhoan;Integrated Security=True;Encrypt=False";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
        public static void CloseConnection(SqlConnection conn)
        {
            conn.Close();
        }
    }
}

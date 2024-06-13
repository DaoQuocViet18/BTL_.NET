using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Sử Dụng có thuộc tính , kiểu của 1 winform

namespace WindowsFormsApp1
{
    internal static class DataAcessAdmin
    {
        public static SqlConnection mycon = new SqlConnection(); //ket noi den co so du lieu
        public static SqlCommand com = new SqlCommand();  //su dung connection de thuc hien select
        public static SqlDataAdapter ad = new SqlDataAdapter();// viet cac CRUD
        public static DataTable dt = new DataTable();
        private static string path = @"Data Source = localhost\sqlexpress; Initial Catalog = QLSV; User ID = sa; Password = 123456";

        public static SqlConnection ketnoi()
        {
            return new SqlConnection(path);
        }
        public static DataTable GetTable(String query)
        {
            SqlConnection con = ketnoi();
            con.Open();
            DataTable tb = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(tb);
            con.Close();
            adapter.Dispose();
            return tb;
        }
        public static void CRUD(string query)
        {
            SqlConnection con = ketnoi();
            int index = query.IndexOf(' ');
            string substring = query.Substring(0, index);

            // cắt chuỗi từ đầu tiên để xem nó làm gì rồi đưa ra thông báo
            string chuoi = null;
            if ("insert".Equals(substring, StringComparison.OrdinalIgnoreCase))
                chuoi = "thêm ";
            else if ("Update".Equals(substring, StringComparison.OrdinalIgnoreCase))
                chuoi = "sửa ";
            else
                chuoi = "xóa ";
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn " + chuoi + "không"
                , char.ToUpper(chuoi[0]) + chuoi.Substring(1) + "Dữ Liệu"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                com = new SqlCommand(query,con);
                com.ExecuteNonQuery();
                con.Close();
                com.Dispose();
            }
         
        }
     
    }

}

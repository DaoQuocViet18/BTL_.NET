using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLSV
{
    internal class DataAccess
    {
        private static string connetionString = @"Data Source = localhost\sqlexpress; Initial Catalog = QLSV; User ID = sa; Password = 123456";
        private static SqlConnection conn;
        private static string sql;
        private static DataTable dt;
        private static DataRow dtRow;
        private static SqlCommand cmd;
        private static SqlDataAdapter ad;

        public static int maSinhVien;
        public static int maNganh;


        public static DataRow GetDataRow(string sql)
        {
            try
            {
                conn = new SqlConnection(connetionString);
                conn.Open();
                ad = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                ad.Fill(dt);
                dtRow = dt.Rows[0];
                return dtRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi load dữ liệu của GetDataRow" + ex.Message);
                dtRow = null;
                return dtRow;
            }
            finally
            {
                conn.Close();
                ad.Dispose();
            }
        }

        public static DataTable GetDataTable(string sql)
        {
            try
            {
                conn = new SqlConnection(connetionString);
                conn.Open();
                ad = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi load dữ liệu của GetDataTable" + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
                ad.Dispose();
            }
        }

        public static void inSertEditDelete(string sql)
        {
            try
            {
                conn = new SqlConnection(connetionString);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi load dữ liệu " + ex.Message);
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
            }
        }

        public static void ThayDoiKichThuc_cua_DataGridView(DataGridView dgv)
        {
            int rowHeight = dgv.RowTemplate.Height;
            int numRowsToShow = Math.Min(dgv.RowCount, 10); // Giả sử maxRowsToShow là số dòng tối đa muốn hiển thị

            int newHeight = numRowsToShow * rowHeight + dgv.ColumnHeadersHeight;
            dgv.Height = newHeight;
        }

        public static void ThayDoiKT_Label_Button_cua_TableLayoutPanel(TableLayoutPanel tlp, float per)
        {
            // Tính toán kích thước phông chữ mới
            float newSize = (float)(Math.Min(tlp.Width, tlp.Height) * per);

            // Giới hạn kích thước phông chữ tối đa và tối thiểu
            newSize = Math.Max(newSize, 8);
            newSize = Math.Min(newSize, 20);

            // Duyệt qua tất cả các controls trên Form
            foreach (Control control in tlp.Controls)
            {
                // Kiểm tra nếu control là một Label
                if (control is Label || control is Button)
                {
                    int adjust;

                    if (newSize < 18)
                        adjust = control.Text.Count() / 20; // Cứ 20 ký tự thì kích thước front bé lại 1 số
                    else
                        adjust = control.Text.Count() / 6; // Cứ 6 ký tự thì kích thước front bé lại 1 số


                    // Đặt kích thước phông chữ mới cho Label
                    control.Font = new Font(control.Font.FontFamily, newSize - adjust);
                }
            }
        }
    }
}

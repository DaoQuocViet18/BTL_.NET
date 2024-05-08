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
    internal class Database
    {
        private string connetionString = @"Data Source = localhost\sqlexpress; Initial Catalog = QLSV; User ID = sa; Password = 123456";
        private SqlConnection conn;
        private string sql;
        private DataTable dt;
        private DataRow dtRow;
        private SqlCommand cmd;
        private SqlDataAdapter ad;

        private static Database instance;

        public int maSinhVien;
        public int maNganh;

        public Database()
        {
            try
            {
                conn = new SqlConnection(connetionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("connected failed" + ex.Message);
            }
        }

        public static Database getInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

        public DataRow testDataSV_DangNhap(string tbl, int maSinhVien, string matkhau)
        {
            try
            {
                conn.Open();
                sql = "SELECT sv.MaSinhVien,sv.MatKhau, lop.MaNganh " +
                    "FROM " + tbl + " AS sv " +
                    "JOIN tblLop AS lop ON lop.MaLop = sv.MaLop " +
                    "WHERE sv.MaSinhVien = " + maSinhVien + " AND sv.MatKhau = " + matkhau;
                ad = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                ad.Fill(dt);
                dtRow = dt.Rows[0];
                return dtRow;
            }
            catch (Exception ex)
            {
                dtRow = null;
                return dtRow;
            }
            finally
            {
                conn.Close();
                ad.Dispose();
            }
        }

        public DataRow selectDataSV()
        {
            try
            {
                conn.Open();
                sql = "SELECT sv.MaSinhVien, " +
                            "sv.TenSinhVien, " +
                            "sv.MaLop, " +
                            "sv.MaLopHocPhan, " +
                            "sv.Email, " +
                            "sv.SoDienThoai, " +
                            "sv.DiaChi, " +
                            "sv.NgaySinh, " +
                            "sv.GioiTinh, " +
                            "sv.NgayVaoTruong, " +
                            "lh.TenLop, " +
                            "ng.TenNganh " +
                    "FROM tblSinhVien AS sv " +
                    "JOIN tblLop AS lh ON sv.MaLop = lh.MaLop " +
                    "JOIN tblNganh AS ng ON lh.MaNganh = ng.MaNganh " +
                    "WHERE MaSinhVien = " + this.maSinhVien;
                ad = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                ad.Fill(dt);
                dtRow = dt.Rows[0];
                return dtRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi load dữ liệu của selectDataSV: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
                ad.Dispose();
            }
        }

        public DataTable selectDataHP_chuaDK()
        {
            try
            {
                conn.Open();
                sql = "SELECT * " +
                    "FROM tblHocPhan AS hp " +
                    "WHERE MaHocPhan NOT IN ( SELECT MaHocPhan " +
                                            "FROM tblLopHocPhan AS lhp " +
                                            "JOIN tblSinhVien AS sv ON lhp.MaSinhVien LIKE CONCAT('%', sv.MaSinhVien, '%') " +
                                            "WHERE CHARINDEX('" + this.maSinhVien + "', lhp.MaSinhVien ) > 0)" +
                          "AND MaNganh = " + this.maNganh;
                ad = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi load dữ liệu của selectDataHP_chuaDK: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
                ad.Dispose();
            }
        }

        public DataTable selectDataLopHP_daDK(string namKyHoc)
        {
            try
            {
                conn.Open();
                sql = "SELECT lhp.MaLopHocPhan, " +
                            "lhp.TenLopHocPhan, " +
                            "hp.SoTinChi , " +
                            "hp.SoDonViHocTrinh, " +
                            "lhp.TrangThaiLopHocPhan, " +
                            "hp.NamKyHoc " +
                    "FROM tblLopHocPhan AS lhp " +
                    "JOIN tblHocPhan AS hp ON hp.MaHocPhan = lhp.MaHocPhan " +
                    "WHERE hp.NamKyHoc LIKE N'%" + namKyHoc + "%' AND CHARINDEX('" + this.maSinhVien + "', lhp.MaSinhVien ) > 0";
                ad = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi load dữ liệu của selectDataLopHP_daDK: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
                ad.Dispose();
            }
        }

        public DataTable selectDataLopHP_chuaDK(int maHocPhan)
        {
            try
            {
                conn.Open();
                sql = "SELECT lhp.MaLopHocPhan, " +
                            "lhp.TenLopHocPhan, " +
                            "lh.ThuTietHoc, " +
                            "lh.PhongHoc, " +
                            "lh.GiangVien " +
                    "FROM tblLopHocPhan AS lhp " +
                    "JOIN tblLichHoc AS lh ON lh.MaLopHocPhan = lhp.MaLopHocPhan " +
                    "WHERE MaHocPhan = " + maHocPhan;
                ad = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi load dữ liệu của selectDataLopHP_chuaDK: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
                ad.Dispose();
            }
        }

        public void add_SV_vao_LHP(int maLopHocPhan)
        {
            try
            {
                conn.Open();
                string maSV = maSinhVien.ToString();
                sql = "UPDATE tblLopHocPhan " +
                    "SET MaSinhVien = MaSinhVien + '_" + maSV + "', SiSo = SiSo  + 1" +
                    "WHERE MaLopHocPhan = " + maLopHocPhan;
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                string maLHP = maLopHocPhan.ToString();
                sql = "UPDATE tblSinhVien " +
                    "SET MaLopHocPhan = MaLopHocPhan + '" + "_" + maLHP + "' " +
                    "WHERE MaSinhVien = " + maSinhVien;
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

            //UPDATE tblLopHocPhan
            //SET MaSinhVien = '4'
            //WHERE MaLopHocPhan = 3;

            //UPDATE tblSinhVien
            //SET MaLopHocPhan = '1'
            //WHERE MaSinhVien = 2;

            //SELECT* FROM tblLopHocPhan;
        }

        public DataTable selectDataLichHoc()
        {
            try
            {
                conn.Open();
                sql = "SELECT lhp.TenLopHocPhan, " +
                            "lh.ThuTietHoc, " +
                            "lh.PhongHoc, " +
                            "lh.GiangVien, " +
                            "lh.ThoiGianHoc, " +
                            "lh.ThoiGianThi " +
                    "FROM tblLichHoc AS lh " +
                    "JOIN[tblLopHocPhan] AS lhp ON CHARINDEX('" + this.maSinhVien + "', lhp.MaSinhVien ) > 0 " +
                    "WHERE lhp.MaLopHocPhan = lh.MaLopHocPhan";
                ad = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi load dữ liệu của selectDataLopHP_chuaDK: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
                ad.Dispose();
            }
        }

        public void ThayDoiKichThuc_cua_DataGridView(DataGridView dgv)
        {
            int rowHeight = dgv.RowTemplate.Height;
            int numRowsToShow = Math.Min(dgv.RowCount, 10); // Giả sử maxRowsToShow là số dòng tối đa muốn hiển thị

            int newHeight = numRowsToShow * rowHeight + dgv.ColumnHeadersHeight;
            dgv.Height = newHeight;
        }

        public void ThayDoiKT_Label_Button_cua_TableLayoutPanel(TableLayoutPanel tlp, float per)
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

        //public void ThayDoiKT_Front_cua_dataGridView(DataGridView dgv)
        //{
        //    // Tính toán kích thước font mới dựa trên kích thước DataGridView hiện tại
        //    float newSize = dgv.Width * 0.0125f;

        //    // Giới hạn kích thước phông chữ tối đa và tối thiểu
        //    newSize = Math.Max(newSize, 10);
        //    newSize = Math.Min(newSize, 20);

        //    // Duyệt qua tất cả các cột trong DataGridView
        //    foreach (DataGridViewColumn column in dgv.Columns)
        //    {
        //        // Thay đổi font cho cột hiện tại
        //        column.DefaultCellStyle.Font = new Font("Arial", newSize, FontStyle.Regular);
        //    }
        //}
    }
}

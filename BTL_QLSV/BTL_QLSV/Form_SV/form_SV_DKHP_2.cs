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

namespace BTL_QLSV
{
    public partial class form_SV_DKHP_2 : Form
    {
        private int maHocPhan;

        public form_SV_DKHP_2()
        {
            InitializeComponent();
        }
        private void form_SV_DKHP_2_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT lhp.MaLopHocPhan, " +
                                "lhp.TenLopHocPhan, " +
                                "lh.ThuTietHoc, " +
                                "lh.PhongHoc, " +
                                "lh.GiangVien, " +
                                "lhp.TrangThaiLopHocPhan " +
                        "FROM tblLopHocPhan AS lhp " +
                        "JOIN tblLichHoc AS lh ON lh.MaLopHocPhan = lhp.MaLopHocPhan " +
                        "WHERE MaHocPhan = " + maHocPhan;
            dgvLopHocPhan.DataSource = DataAccess.GetDataTable(sql);

            dgvLopHocPhan.Columns["MaLopHocPhan"].HeaderText = "Mã lớp học phần";
            dgvLopHocPhan.Columns["TenLopHocPhan"].HeaderText = "Tên lớp học phần";
            dgvLopHocPhan.Columns["ThuTietHoc"].HeaderText = "Thứ Tiết học";
            dgvLopHocPhan.Columns["PhongHoc"].HeaderText = "Phòng học";
            dgvLopHocPhan.Columns["GiangVien"].HeaderText = "Giảng viên";
            dgvLopHocPhan.Columns["TrangThaiLopHocPhan"].HeaderText = "Trạng thái lớp học phần";


            DataAccess.ThayDoiKichThuc_cua_DataGridView(dgvLopHocPhan);
        }

        public void SetData(int maHocPhan)
        {
            this.maHocPhan = maHocPhan;
        }

        private void dgvLopHocPhan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvLopHocPhan.Rows[e.RowIndex];
                string tenLopHocPhan = selectedRow.Cells["TenLopHocPhan"].Value.ToString();
                int maLopHocPhan = int.Parse(selectedRow.Cells["MaLopHocPhan"].Value.ToString());

                if (selectedRow.Cells["TrangThaiLopHocPhan"].ToString() == "đang mở")
                {
                    DialogResult kq = MessageBox.Show("Bạn có muốn đăng ký lớp học phần " + tenLopHocPhan + " ko",
                    "Thông báo!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (kq == DialogResult.Yes)
                    {
                        string sql = "UPDATE tblLopHocPhan " +
                                    "SET " +
                                        "MaSinhVien = " +
                                            "CASE " +
                                                "WHEN MaSinhVien IS NULL OR MaSinhVien = '' THEN '" + DataAccess.maSinhVien + "' " +
                                                "ELSE CONCAT(MaSinhVien, '_" + DataAccess.maSinhVien + "') " +
                                            "END " +
                                    "WHERE MaLopHocPhan = " + maLopHocPhan;
                        DataAccess.inSertEditDelete(sql);

                        sql = "UPDATE tblSinhVien " +
                                "SET " +
                                    "MaLopHocPhan = " +
                                        "CASE " +
                                            "WHEN MaLopHocPhan IS NULL OR MaLopHocPhan = '' THEN '" + maLopHocPhan + "' " +
                                            "ELSE CONCAT(MaLopHocPhan, '_" + maLopHocPhan + "') " +
                                        "END " +
                            "WHERE MaSinhVien = " + DataAccess.maSinhVien;
                        DataAccess.inSertEditDelete(sql);

                        this.Close();
                    }
                }
                else
                {
                    DialogResult kq = MessageBox.Show("Lớp học phần " + tenLopHocPhan + " đang ở trạng thái đã đóng không được phép đăng ký",
                    "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }    
            }
        }
    }
}

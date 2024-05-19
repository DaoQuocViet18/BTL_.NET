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
            string sql = "SELECT lhp.MaLopHocPhan, " +
                            "lhp.TenLopHocPhan, " +
                            "lh.ThuTietHoc, " +
                            "lh.PhongHoc, " +
                            "lh.GiangVien " +
                    "FROM tblLopHocPhan AS lhp " +
                    "JOIN tblLichHoc AS lh ON lh.MaLopHocPhan = lhp.MaLopHocPhan " +
                    "WHERE MaHocPhan = " + maHocPhan;
            dgvLopHocPhan.DataSource = DataAccess.GetDataTable(sql);

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


                DialogResult kq = MessageBox.Show("Bạn có muốn đăng ký lớp học môn " + tenLopHocPhan + " ko", 
                    "Thông báo!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (kq == DialogResult.Yes)
                {
                    string sql = "UPDATE tblLopHocPhan " +
                        "SET MaSinhVien = MaSinhVien + '_" + DataAccess.maSinhVien + "', SiSo = SiSo  + 1" +
                        "WHERE MaLopHocPhan = " + maLopHocPhan;
                    DataAccess.inSertEditDelete(sql);

                    sql = "UPDATE tblSinhVien " +
                        "SET MaLopHocPhan = MaLopHocPhan + '" + "_" + maLopHocPhan + "' " +
                        "WHERE MaSinhVien = " + DataAccess.maSinhVien;
                    DataAccess.inSertEditDelete(sql);

                    this.Close();
                }
            }
        }
    }
}

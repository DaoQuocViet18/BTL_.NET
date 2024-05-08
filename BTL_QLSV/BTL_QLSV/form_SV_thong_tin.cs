using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLSV
{
    public partial class form_SV_thong_tin : Form
    {
        Database db = Database.getInstance();
        DataRow dataSV;
        public form_SV_thong_tin()
        {
            InitializeComponent();
        }

        private void form_SV_thong_tin_Load(object sender, EventArgs e)
        {
            dataSV = db.selectDataSV();

            lbMaSinhVien.Text = "Mã sinh viên: " + Convert.ToInt32(dataSV["MaSinhVien"]).ToString("D5"); // Chuyển đổi sang dạng 00001
            lbTenSinhVien.Text = "Tên sinh viên: " + dataSV["TenSinhVien"].ToString();
            lbGioiTinh.Text = "Giới tính: " + dataSV["GioiTinh"].ToString();
            lbNgaySinh.Text = "Ngày sinh: " + ((DateTime)dataSV["NgaySinh"]).ToString("dd/MM/yyyy"); // Chuyển đổi sang dạng ngày/tháng/năm
            lbDiaChi.Text = "Địa chỉ: " + dataSV["DiaChi"].ToString();

            lbEmail.Text = "Email: " + dataSV["Email"].ToString();
            lbSoDienThoai.Text = "Số điện thoại: " + dataSV["SoDienThoai"].ToString();
            lbLopHoc.Text = "Lớp học: " + dataSV["TenLop"].ToString();
            lbNganh.Text = "Ngành: " + dataSV["TenNganh"].ToString();

            int ngayCap = Convert.ToInt32(((DateTime)dataSV["NgayVaoTruong"]).ToString("yyyy"));
            lbKhoaHoc.Text = "Khóa học: " + ngayCap + " - " + (ngayCap + 4);
        }

        private void form_SV_thong_tin_SizeChanged(object sender, EventArgs e)
        {
            db.ThayDoiKT_Label_Button_cua_TableLayoutPanel(tlpThongTin, 0.25f);
        }
    }
}

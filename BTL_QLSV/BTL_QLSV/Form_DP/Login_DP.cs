using BTL_QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login_DP : Form
    {
        private string tbl;
        private int maDangNhap;
        private string matkhau;

        public Login_DP()
        {
            InitializeComponent();
        }
        private Form currentChildForm;

        private void Form2_Load(object sender, EventArgs e)
        {
            //cbbPhanVung.Items.Add("Sinh Viên");
            //cbbPhanVung.Items.Add("Quản Trị Viên");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                while (true)
                {
                    if(KtraND())
                        break; // Nếu các điều kiện đều hợp lệ, thoát khỏi vòng lặp 
                }

                tbl = combLoaiTaiKhoan.SelectedItem.ToString() == "Sinh viên" ? "tblSinhVien" : "Admin";

                if (tbl == "tblSinhVien")
                {
                    if (KtraSV())
                    {
                        DangNhapSV();
                        break;
                    }                    
                }    
                else if (tbl == "Admin")
                {
                    if (KtraAdmin())
                    {
                        DangNhapAdmin();
                        break;
                    }
                }
                // MessageBox.Show("db.maSinhVien  = " + db.maSinhVien + "\ndb.maSinhVien = " + db.maNganh);
            }
            this.Hide();
        }

        private bool KtraND()
        {
            if (combLoaiTaiKhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Thoát khỏi vòng lặp nếu không hợp lệ
            }

            if (string.IsNullOrEmpty(txtMaDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Thoát khỏi vòng lặp nếu không hợp lệ
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Thoát khỏi vòng lặp nếu không hợp lệ
            }

            return true;
        }

        private bool KtraSV()
        {
            //   MessageBox.Show("tbl = " + tbl + "\nmaSinhVien = " + maSinhVien + "\nmatkhau = " + matkhau);
            maDangNhap = int.Parse(txtMaDangNhap.Text);
            matkhau = txtMatKhau.Text;

            string sql = "SELECT sv.MaSinhVien,sv.MatKhau, lop.MaNganh " +
                "FROM " + tbl + " AS sv " +
                "JOIN tblLop AS lop ON lop.MaLop = sv.MaLop " +
                "WHERE sv.MaSinhVien = " + maDangNhap + " AND sv.MatKhau = " + matkhau;
            DataRow dataSV = DataAccess.GetDataRow(sql);
            if (dataSV != null)
            {
                DataAccess.maSinhVien = int.Parse(dataSV["MaSinhVien"].ToString());
                DataAccess.maNganh = int.Parse(dataSV["MaNganh"].ToString());
                return true;
            }

            MessageBox.Show("Vui lòng Nhập lại", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            combLoaiTaiKhoan.SelectedIndex = -1;
            txtMaDangNhap.Clear();
            txtMatKhau.Clear();
            combLoaiTaiKhoan.Focus();
            return false;
        }

        private bool KtraAdmin()
        {
            if (txtMaDangNhap.Text == "Admin" && txtMatKhau.Text == "123456")
                return true;
            return false;
        }
        private void DangNhapSV()
        {
            form_SV_Main f_main = new form_SV_Main();
            f_main.Show();
        }

        private void DangNhapAdmin()
        {
            Admin f_Admin = new Admin();
            f_Admin.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

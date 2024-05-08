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
    public partial class form_DangNhap : Form
    {
        private string tbl;
        private int maSinhVien;
        private string matkhau;

        public form_DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            while (true)
            {
                while (true)
                {
                    if (combLoaiTaiKhoan.SelectedIndex < 0)
                    {
                        MessageBox.Show("Vui lòng chọn loại tài khoản", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Thoát khỏi vòng lặp nếu không hợp lệ
                    }

                    if (string.IsNullOrEmpty(txtMaSinhVien.Text))
                    {
                        MessageBox.Show("Vui lòng nhập mã sinh viên", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Thoát khỏi vòng lặp nếu không hợp lệ
                    }

                    if (string.IsNullOrEmpty(txtMatKhau.Text))
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Thoát khỏi vòng lặp nếu không hợp lệ
                    }

                    // Nếu các điều kiện đều hợp lệ, thoát khỏi vòng lặp
                    break;
                }
                tbl = combLoaiTaiKhoan.SelectedItem.ToString() == "Sinh viên" ? "tblSinhVien" : "Admin";

                maSinhVien = int.Parse(txtMaSinhVien.Text);
                matkhau = txtMatKhau.Text;

                //   MessageBox.Show("tbl = " + tbl + "\nmaSinhVien = " + maSinhVien + "\nmatkhau = " + matkhau);

                Database db = Database.getInstance();
                DataRow dataSV = db.testDataSV_DangNhap(tbl, maSinhVien, matkhau);
                if (dataSV != null)
                {
                    db.maSinhVien = int.Parse(dataSV["MaSinhVien"].ToString());
                    db.maNganh = int.Parse(dataSV["MaNganh"].ToString());

                }
                else
                {
                    MessageBox.Show("Vui lòng Nhập lại", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    combLoaiTaiKhoan.SelectedIndex = -1;
                    txtMaSinhVien.Clear();
                    txtMatKhau.Clear();
                    combLoaiTaiKhoan.Focus();
                    return;
                }

                // MessageBox.Show("db.maSinhVien  = " + db.maSinhVien + "\ndb.maSinhVien = " + db.maNganh);

                break;
            }

            form_SV_Main f_main = new form_SV_Main();
            f_main.Show();

            this.Hide();
        }
    }
}

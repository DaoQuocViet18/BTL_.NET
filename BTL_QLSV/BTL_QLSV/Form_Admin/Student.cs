using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Data.Common;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Student : Form

    {
        int ma = 0;

        public static void hienthi(DataGridView db1)
        {

            string str = "Select sv.MaSinhVien as 'Mã Sinh Viên' , sv.MatKhau as 'Mật Khẩu', sv.TenSinhVien as 'Tên Sinh Viên' ," +
                "Lop.TenLop as 'Tên Lớp ' , " +
                "MaLopHocPhan as 'Mã Lớp Học Phần' ," +
                "sv.Email as 'Email' ,sv.SoDienThoai as 'Số Điện Thoại', sv.DiaChi as 'Địa Chỉ',NgaySinh  as 'Ngày Sinh', sv.GioiTinh as 'Giới Tính',sv.NgayVaoTruong as 'Ngày Vào Trường' " +
                "from tblSinhVien AS sv " +
                " JOIN tblLop as Lop On sv.MaLop =  Lop.MaLop ";
           

            DataAcessAdmin.ketnoi();
            db1.DataSource = DataAcessAdmin.GetTable(str);
            for (int i = 0; i < 10; i++)
            {
                db1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            db1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public Student()
        {
            InitializeComponent();
            hienthi(db1);


        }
        void Form1_Load(object sender, EventArgs e)
        {
            // thêm tên ngành để người dùng lựa chọn trong combobox
            string query1 = "select MaNganh ,TenNganh from tblNganh";
            foreach (DataRow rows in DataAcessAdmin.GetTable(query1).Rows)
            {
                cbbmajor.Items.Add(rows["TenNganh"].ToString());
            }
            db1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            hienthi(db1);


        }
        private void db1_CellClick(object sender, DataGridViewCellEventArgs e)
        {  // lấy mã sinh viên làm điều kiện (update , delete)
            DataGridViewRow row = db1.Rows[e.RowIndex];
            string a = row.Cells[0].Value.ToString();
            ma = int.Parse(a);
            cbbTenLop.Text = row.Cells[3].Value.ToString();
            txtPassWord.Text = row.Cells[1].Value.ToString();
            txtName.Text = row.Cells[2].Value.ToString();
            txtGender.Text = row.Cells[9].Value.ToString();
            txtPOB.Text = row.Cells[7].Value.ToString();
            txtEmail.Text = row.Cells[5].Value.ToString();
            txtPhone.Text= row.Cells[6].Value.ToString();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            // xóa
            string query = "delete from tblSinhVien where MaSinhVien = " + ma;
            DataAcessAdmin.CRUD(query);
            clear();
            hienthi(db1);
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            //sửa
            string date = "" + dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-" + dtpDate.Value.Day;
            string query = "update tblSinhVien set MatKhau= '" + txtPassWord.Text + "'," +
                " TenSinhVien= '" + txtName.Text + "'," +
                " Email= '" + txtEmail.Text + "'," +
                " SoDienThoai= '" + txtPhone.Text + "'," +
                " DiaChi= '" + txtPOB.Text + "'," +
                " NgaySinh= '" + date + "'," +
                " GioiTinh= '" + txtGender.Text + "'where MaSinhVien = " + ma;
            DataAcessAdmin.CRUD(query);
            clear();
            hienthi(db1);

        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            string a = cbbTenLop.Text;
            string st = "select MaLop From tblLop where TenLop = '" + a + "'";

            //Lấy giá trị mã lớp khi đã chọn lớp 
            DataAcessAdmin.GetTable(st);
            int malop = int.Parse(DataAcessAdmin.GetTable(st).Rows[0]["MaLop"].ToString());

            // Lấy giá trị năm sinh vừa chọn
            string date = dtpDate.Value.Year.ToString()
                + "-" + dtpDate.Value.Month.ToString()
                + "-" + dtpDate.Value.Day.ToString();

            //Lấy giá trị ngày vào trường vừa chọn
            string datecome = dtDaycome.Value.Year.ToString()
                + "-" + dtDaycome.Value.Month.ToString()
                + "-" + dtDaycome.Value.Day.ToString();

            //thêm
            string query1 = "insert into tblSinhVien (MatKhau,TenSinhVien,MaLop,Email,SoDienThoai,DiaChi,NgaySinh,GioiTinh,NgayVaoTruong) values " +
                "('" + txtPassWord.Text + "'," +
                "N'" + txtName.Text + "'," +
                "N'" + malop + "'," +
                "N'" + txtEmail.Text + "' ," +
                "N'" + txtPhone.Text + "' ," +
                "N'" + txtPOB.Text + "' ," +
                "N'" + date + "' ," +
                "N'" + txtGender.Text + "'," +
                "N'" + datecome + "')";
            DataAcessAdmin.CRUD(query1);
            clear();
            hienthi(db1);

        }
        private void clear()
        {
            txtEmail.Clear();
            txtPhone.Clear();
            txtGender.Clear();
            txtName.Clear();
            txtPassWord.Clear();
            txtPhone.Clear();
            txtPOB.Clear();
            cbbmajor.Text = "";
            cbbTenLop.Text = "";
            dtpDate.Value = DateTime.Now;
            dtDaycome.Value = DateTime.Now;
        }
        private void cbbmajor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbmajor.SelectedIndex != -1) // kiểm tra cbb ngành đã được chọn chưa
            {
                string getMajors = cbbmajor.Text;
                string query2 = "select TenLop from tblLop where MaNganh IN(select MaNganh From tblNganh where TenNganh = N'" + getMajors + "' )";

                foreach (DataRow rowss in DataAcessAdmin.GetTable(query2).Rows)
                {
                    cbbTenLop.Items.Add(rowss["TenLop"].ToString());
                }
            }

        }

        private void lbGender_Click(object sender, EventArgs e)
        {

        }
        public void visiblenot_btAdd()
        {
            this.btAdd.Visible = true;
            this.btChange.Visible = false;
            this.btRemove.Visible = false;
        }
        public void visiblenot_btUpdate()
        {
            btChange.Visible = true;
            btAdd.Visible = false;
            btRemove.Visible = false;
        }
        public void visiblenot_btDelete()
        {
            btChange.Visible = false;
            btAdd.Visible = false;
            btRemove.Visible = true;
        }
    }

}

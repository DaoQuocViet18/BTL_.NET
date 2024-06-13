using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Department : Form
    {

        int ma = 0;
        public Department()
        {
            InitializeComponent();
            hienthi(dtgvDepartment);
        }
        public static void hienthi(DataGridView db1)
        {
            string str = "Select MaKhoa as 'Mã Khoa' " +
                ",TenKhoa as 'Tên Khoa' " +
                ",TenTruongKhoa as 'Tên Trưởng Khoa'" +
                " from tblKhoa";
            db1.DataSource = DataAcessAdmin.GetTable(str);
            db1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btAddDepartment_Click(object sender, EventArgs e)
        {
            //Thêm 
            string query = "insert into tblKhoa(TenKhoa, TenTruongKhoa) values ( '" + txtDepartmentName.Text + "'," +
                " '" + txtHeadDepartment.Text + "')";
            DataAcessAdmin.CRUD(query);
            clear();
            hienthi(dtgvDepartment);
        }

        private void dtgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy mã để làm điều kiện so sánh
            DataGridViewRow row = dtgvDepartment.Rows[e.RowIndex];

            if (e.RowIndex != 0)
            {
                string a = row.Cells[0].Value.ToString();
                ma = int.Parse(a);
            }
                txtDepartmentName.Text = row.Cells[1].Value.ToString();
                txtHeadDepartment.Text = row.Cells[2].Value.ToString();

        }
        private void btDeleteDepartment_Click(object sender, EventArgs e)
        {
            // Xóa
            string query = "delete from tblKhoa where MaKhoa= " + ma;
            if (ma != 0)
                DataAcessAdmin.CRUD(query);
            else MessageBox.Show("Bạn chưa chọn dòng cần sửa");
            clear();
            hienthi(dtgvDepartment);
        }
        private void btChangeDepartMent_Click(object sender, EventArgs e)
        {
            // Sửa
            string query = "update tblKhoa set TenKhoa= '" + txtDepartmentName.Text + "', TenTruongKhoa= '" + txtHeadDepartment.Text + "' where MaKhoa= " + ma;
            if (ma != 0)
                DataAcessAdmin.CRUD(query);
            else MessageBox.Show("Bạn chưa chọn dòng cần sửa");
            clear();
            hienthi(dtgvDepartment);
        }
        public void clear()
        {
            txtDepartmentName.Text = "";
            txtHeadDepartment.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void visible_notAdd()
        {
            btAddDepartment.Visible = true;
            btChangeDepartMent.Visible = false;
            btDeleteDepartment.Visible = false;
        }
        public void visible_notUpdate()
        {
            btAddDepartment.Visible = false;
            btChangeDepartMent.Visible = true;
            btDeleteDepartment.Visible = false;
        }
        public void visible_notDelete()
        {
            btAddDepartment.Visible = false;
            btChangeDepartMent.Visible = false;
            btDeleteDepartment.Visible = true;
        }
    }
}

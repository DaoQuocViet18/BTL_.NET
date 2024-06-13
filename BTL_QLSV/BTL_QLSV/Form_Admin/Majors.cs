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
    public partial class Majors : Form
    {
        int ma = 0;
        public Majors()
        {
            InitializeComponent();
            hienthi(dtgvMajors);
            dtgvMajors.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        }
        public static void hienthi(DataGridView db1)
        {
            // hiển thị  bảng cơ sở dữ liệu
            string query = "Select MaNganh as 'Mã Ngành' " +
                ", TenNganh as 'Tên Ngành' " +
                ", MaKhoa as  'Mã Khoa'  from tblNganh";
            db1.DataSource = DataAcessAdmin.GetTable(query);
            db1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Form4_Load(object sender, EventArgs e)
        {   // thêm mã khoa để người dùng chọn
            string query = "select MaKhoa from tblKhoa";
            foreach (DataRow row in DataAcessAdmin.GetTable(query).Rows)
                cbbDepartmentCode.Items.Add(row[0].ToString());
        }
        private void btAddMajors_Click(object sender, EventArgs e)
        {
            // thêm 
            string query = "insert into tblNganh (TenNganh,MaKhoa) values ('" + txtMajorsName.Text + "'" +
                ", '" + cbbDepartmentCode.Text + "')";
            DataAcessAdmin.CRUD(query);
            clear();
            hienthi(dtgvMajors);
        }

        private void btChangeMajors_Click(object sender, EventArgs e)
        {
            // sửa
            string query = "update tblNganh set " +
                "TenNganh = '" + txtMajorsName.Text + "' " +
                ", MaKhoa = '" + cbbDepartmentCode.Text + 
                "' where MaNganh= " + ma;
            DataAcessAdmin.CRUD(query);
            clear();
            hienthi(dtgvMajors);
           
        }

        private void dtgvMajors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy mã để so sánh 
            DataGridViewRow row = dtgvMajors.Rows[e.RowIndex];
            string a = row.Cells[0].Value.ToString();
            ma = int.Parse(a);
            txtMajorsName.Text = row.Cells[1].Value.ToString();
            cbbDepartmentCode.Text = row.Cells[2].Value.ToString();
        }

        private void btDeleteMajors_Click(object sender, EventArgs e)
        {
            //xóa 
            string query = "delete from tblNganh where MaNganh= " + ma;
            DataAcessAdmin.CRUD(query);
            clear();
            hienthi(dtgvMajors);
          
        }
        private void clear()
        {
            txtMajorsName.Text = " ";
            cbbDepartmentCode.Text = " ";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void visible_notAdd()
        {
            btAddMajors.Visible = true;
            btChangeMajors.Visible = false;
            btDeleteMajors.Visible = false;
        }
        public void visible_notUpdate()
        {
            btAddMajors.Visible = false;
            btChangeMajors.Visible = true;
            btDeleteMajors.Visible = false;
        }
        public void visible_notDelete()
        {
            btAddMajors.Visible = false;
            btChangeMajors.Visible = false;
            btDeleteMajors.Visible = true;
        }
    }
}

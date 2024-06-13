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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1
{
    public partial class Class : Form
    {
        int ma = 0;
        public Class()
        {
            InitializeComponent();
            hienthi(dtgvClass);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // bắt buộc phải lựa chọn những item trong combobox khoa 
            string query = "select MaKhoa from tblKhoa";
            foreach (DataRow row in DataAcessAdmin.GetTable(query).Rows)        
                cbbMajorsCode.Items.Add(row[0].ToString());       
            hienthi(dtgvClass);
            dtgvClass.Anchor = AnchorStyles.Left | AnchorStyles.Right;

        }
        public static void hienthi(DataGridView db1)
        {
            // hiển thị
            string query = "Select MaLop as 'Mã Lớp'," +
                " TenLop as 'Tên Lớp' ," +
                " Manganh as 'Mã Ngành' ," +
                " TenCoVanHocTap as 'Tên Cố Vấn Học Tập' from tblLop";
            db1.DataSource = DataAcessAdmin.GetTable(query);
            db1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btAddClass_Click(object sender, EventArgs e)
        {
            // Thêm
            string query = "insert into tblLop (TenLop,MaNganh,TenCoVanHocTap) values ('" + txtClassName.Text + "', '" + cbbMajorsCode.Text + "', '" + txtConsultants.Text + "' )";
            DataAcessAdmin.CRUD(query);
            clear();
            hienthi(dtgvClass);
        }
        private void clear()
        {
            txtClassName.Text = "";
            txtConsultants.Text = " ";
            txtConsultants.Text = " ";
        }
        private void btChangeClass_Click(object sender, EventArgs e)
        {
            // Sửa
            string query = "update tblLop set TenLop = '" + txtClassName.Text + "' " +
                ", MaNganh = '" + cbbMajorsCode.Text + "'," +
                " TenCoVanHocTap = '" + txtConsultants.Text + 
                "' where MaLop= " + ma;
            DataAcessAdmin.CRUD(query);
            clear();
            hienthi(dtgvClass);
        }

        private void dtgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy điều kiện so sánh giúp sửa xóa 
            DataGridViewRow row = dtgvClass.Rows[e.RowIndex];
            string a = row.Cells[0].Value.ToString();
            ma = int.Parse(a);
            cbbMajorsCode.Text = row.Cells[2].Value.ToString();
            txtClassName.Text= row.Cells[1].Value.ToString();
            txtConsultants.Text = row.Cells[3].Value.ToString();
        }

        private void btDeleteClass_Click(object sender, EventArgs e)
        {
            string query = "delete from tblLop where MaLop= " + ma;
            DataAcessAdmin.CRUD(query);
            clear();
            hienthi(dtgvClass);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void visiblenot_btAdd()
        {
            this.btAddClass.Visible = true;
            this.btChangeClass.Visible = false;
            this.btDeleteClass.Visible = false;
        }
        public void visiblenot_btUpdate()
        {
            btChangeClass.Visible = true;
            btAddClass.Visible = false;
            btDeleteClass.Visible = false;
        }
        public void visiblenot_btDelete()
        {
            btChangeClass.Visible = false;
            btAddClass.Visible = false;
            btDeleteClass.Visible = true;
        }
    }
}

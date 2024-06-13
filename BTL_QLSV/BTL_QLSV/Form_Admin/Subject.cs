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

namespace WindowsFormsApp1
{
    public partial class Subject : Form
    {
        int ma = 0;
        public Subject()
        {
            InitializeComponent();
            hienthi(dtgvSubjects);
        }

        private void Form6_Load(object sender, EventArgs e)
        {   //Bắt buộc người dùng chọn những item trong combobox đã thêm từ bảng khoa
            string query = "select MaKhoa from tblKhoa";
            foreach (DataRow row in DataAcessAdmin.GetTable(query).Rows)
                cbbMajorsCode.Items.Add(row[0].ToString());
        }
        public static void hienthi(DataGridView db1)
        {
         // hiển thị bảng dữ liệu  
                string str = "Select MaHocPhan as 'Mã Học Phần'" +
                ", TenHocPhan as 'Tên Học Phần'" +
                ", MaNganh as 'Mã Ngành'" +
                ", SoTinChi as 'Số Tín Chỉ'" +
                ", SoDonViHocTrinh as 'Số Đơn Vị Học Trình'" +
                ", NamKyHoc as 'Năm Kỳ Học'  " +
                "from tblHocPhan";
            db1.DataSource = DataAcessAdmin.GetTable(str);
            db1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btAddSubjects_Click(object sender, EventArgs e)
        {
            // Thêm
            string query = "insert into tblHocPhan (TenHocPhan,MaNganh,SoTinChi,SoDonViHocTrinh,NamKyHoc) values " +
                "('" + txtSubjectName.Text + "'," +
                " '" + cbbMajorsCode.Text + "' ," +
                " '" + txtNumberOfCredits.Text + "'," +
                " '" + txtUnitCreadits.Text + "'," +
                " '" + txtYearSchool.Text + "')";
            DataAcessAdmin.CRUD(query);
            clear();
        }

        private void btChangeSubjects_Click(object sender, EventArgs e)
        {
            // Sửa
            string query = "update tblHocPhan set TenHocPhan= '" + txtSubjectName.Text + "'," +
                " MaNganh= '" + cbbMajorsCode.Text + "'," +
                " SoTinChi= '" + txtNumberOfCredits.Text + "'," +
                " SoDonViHocTrinh= '" + txtUnitCreadits.Text + "'," +
                " NamKyHoc= '" + txtYearSchool.Text + "' where MaHocPhan = " + ma; 
            DataAcessAdmin.CRUD(query);
            hienthi(dtgvSubjects);
            clear();
        }

        private void dtgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy mã làm điều kiện cho sửa và xóa
            DataGridViewRow row = dtgvSubjects.Rows[e.RowIndex];
            string a = row.Cells[0].Value.ToString();
            ma = int.Parse(a);
            txtSubjectName.Text = row.Cells[1].Value.ToString();
            cbbMajorsCode.Text = row.Cells[2].Value.ToString();
            txtNumberOfCredits.Text = row.Cells[3].Value.ToString();
            txtUnitCreadits.Text = row.Cells[4].Value.ToString();
            txtYearSchool.Text  = row.Cells[5].Value.ToString();
        }

        private void btDeleteSubjects_Click(object sender, EventArgs e)
        {
            //Xóa
            string query = "delete from tblHocPhan where MaHocPhan= " + ma;
            DataAcessAdmin.CRUD(query);
            clear();
            hienthi(dtgvSubjects);
        }
        private void clear()
        {
            txtNumberOfCredits.Text = "";
            txtSubjectName.Text = "";
            txtUnitCreadits.Text = "";
            txtYearSchool.Text = "";
            cbbMajorsCode.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        public void visible_notAdd()
        {
            btAddSubjects.Visible = true;
            btChangeSubjects.Visible = false;
            btDeleteSubjects.Visible = false;
        }
        public void visible_notUpdate()
        {
            btChangeSubjects.Visible = true;
            btAddSubjects.Visible = false;
            btDeleteSubjects.Visible = false;
        }
        public void visible_notDelete()
        {
            btDeleteSubjects.Visible = true;
            btAddSubjects.Visible = false;
            btChangeSubjects.Visible = false;
        }
    }
}

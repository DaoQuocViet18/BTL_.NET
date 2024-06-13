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
    public partial class SubjectClassAdd_ChildForm : Form
    {
        ArrayList arr ;
        //SubjectClass frm = new SubjectClass ();
        string masinhvien = null;
        public SubjectClassAdd_ChildForm()
        {
            InitializeComponent();
        }
        public void ChangeTextLable (string text)
        {
            lbTitle.Text = text;
        }
        private void SubjectClassAdd_ChildForm_Load(object sender, EventArgs e)
        {
            foreach(int i in arr)
            {
                 cbbDelete.Items.Add(i.ToString());
            }
            hienthi(dtgvSubjectClassAdd_ChildForm);
           
        }
        public void hienthi(DataGridView db1)
        {
            
            string query = "Select MaSinhVien as 'Mã Sinh Viên' ," +
                " TenSinhVien as 'Tên Sinh Viên' ," +
                " Lop.TenLop as 'Tên Lớp' ," +
                " Email as 'Email' ," +
                " SoDienThoai as 'Số Điện Thoại'," +
                " DiaChi as 'Địa Chỉ'," +
                " NgaySinh  as 'Ngày Sinh'," +
                " GioiTinh as 'Giới Tính'," +
                " NgayVaoTruong as 'Ngày Vào Trường' " +
                " from tblSinhVien" +
                " JOIN tblLop as Lop On tblSinhVien.Malop = Lop.MaLop" +
                " where MaSinhVien IN (" +masinhvien+ ")";
            
            db1.DataSource = DataAcessAdmin.GetTable(query);
            for (int i = 0; i < 6; i++)
            {
                db1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            db1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        internal void setCombobox(string a)
        { 
            // nhận dữ liệu mã sinh viên để add vào cbb mã sinh viên
            cbbStudentID.Items.Add(a);
        }
        internal void setId(string a)
        {
            // lấy cái này làm điều kiện so sánh
            lbID.Text = a;
        }
        internal void setArrayList(ArrayList arr1)
        {
            // nhận arraylist để xử lý phần xóa sinh viên
            this.arr = arr1;
        }
        internal void getMaSv(string ma)
        {
            // lấy mã làm điều kiện
            this.masinhvien = ma;
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
           // thêm 1 sinh viên vào lớp học phần
            SubjectClass subjectClass = new SubjectClass();
            string query = "Update tblLopHocPhan " +
                "set SiSo = SiSo + 1, " +
                "MaSinhVien = " +
                "case " +
                "when  " +
                /*Theo cách hiển thị của 1 sinh viên trong lớp học phần ví 2 sv mã 2 và 3 
                 * thì hiển thị 2_3 
                 * => nếu  lớp đó chưa có sinh viên nào thì thì thêm mã vào
                 * => nếu  có rồi thì thêm _MaSinhVien vào sau mã sinh viên
                */ 
                "    MaSinhVien = Null OR  MaSinhVien = '' then CONCAT(MaSinhVien,'" + cbbStudentID.Text + "') " +
                "    else   CONCAT(MaSinhVien, '_" + cbbStudentID.Text + "')" +
                "End " +
                "where MaLopHocPhan = "+lbID.Text;
            DataAcessAdmin.CRUD(query);

            /* tương tự như LopHocphan cách hiển thị cũng như vậy
             * ==> cần update bảng sinh viên vì bảng sinh viên đó đã học lớp vừa thêm cũng sẽ hiển thị
             * 
            */


            string query1 = "Update tblSinhVien " +
                "set MaLopHocPhan = " +
                "case " +
                "   when MaLopHocPhan Is Null OR  MaLopHocPhan = '' then CONCAT(MaLopHocPhan,'" + lbID.Text + "') " +
                "    else   CONCAT(MaLopHocPhan, '_" + lbID.Text + "')" +
                "End " +
                "where MaSinhVien = " + cbbStudentID.Text;
           // không dùng dataacess.CRUD vì có sẽ hiển thị 2 lần messagebox gây thừa thãi
            SqlCommand cmd = new SqlCommand(query1, DataAcessAdmin.ketnoi());
            cbbDelete.Items.Add(cbbStudentID.Text);
            cbbStudentID.Items.Remove(cbbStudentID.Text);
            hienthi(dtgvSubjectClassAdd_ChildForm);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // xóa 1 sinh viên ra khỏi lớp
            arr.Remove(int.Parse(cbbDelete.Text));
            string text = arr[0].ToString();
            for (int i=1; i < arr.Count;i++)
            {
                text = text + "_" + arr[i].ToString();
            }
            
            string query = "update tblLopHocPhan set MaSinhVien = '" + text + "'" +
                ",SiSo = SiSo - 1 " +
                "where MaLopHocPhan= '" + lbID.Text + "'";
            DataAcessAdmin.CRUD(query);
            cbbStudentID.Items.Add(cbbDelete.Text);
            cbbDelete.Items.Remove(cbbDelete.Text);
            SubjectClass sb= new SubjectClass();
            hienthi(dtgvSubjectClassAdd_ChildForm);
        }

        private void SubjectClassAdd_ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbbDelete.Items.Clear();
        }

        private void SubjectClassAdd_ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
namespace WindowsFormsApp1
{
    public partial class SubjectClass : Form
    {
        ArrayList arr = new ArrayList();
        HashSet <int> set = new HashSet<int>();
        string ma = null;
        string str = null;
        string str1 = null;
        bool isCellClicked = false;
        SubjectClassAdd_ChildForm frm = new SubjectClassAdd_ChildForm();

        public SubjectClass()
        {
            InitializeComponent();
        }

        private void SubjectClass_Load(object sender, EventArgs e)
        {
            cbbSubjectStatus.Items.Add("Đang đóng");
            cbbSubjectStatus.Items.Add("Đang mở");


            // Lấy mã sinh viên tồn tại trong bảng sinh viên
            string query2 = "select TenHocPhan from tblHocPhan ";
            foreach (DataRow row in DataAcessAdmin.GetTable(query2).Rows)
            {
                cbbSubjectClass.Items.Add(row["TenHocPhan"].ToString());
            }
            hienthi(dtgvSubjectClass);

        }
        private void hienthi(DataGridView db1)
        {
            // hiển thị bảng dữ liệu Lớp học phần 
            string query = "select MaLopHocPhan as 'Mã Lớp Học Phần' " +
                ", TenLopHocPhan as 'Tên Lớp Học Phần' " +
                ", MaHocPhan as 'Mã Học Phần' " +
                ", MaSinhVien as 'Mã Sinh Viên'" +
                ", MaLichHoc as 'Mã Lịch Học'" +
                ", SiSo as 'Sĩ Số' " +
                ", TrangThaiLopHocPhan as 'Trạng Thái Lớp Học Phần'" +
                " from tblLopHocPhan ";
            db1.DataSource = DataAcessAdmin.GetTable(query);
          
            db1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            db1.Anchor = AnchorStyles.Left | AnchorStyles.Right;

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btAddSubjects_Click(object sender, EventArgs e)
        {

            // gọi form 2
            frm = new SubjectClassAdd_ChildForm();
            // nếu người dùng không click sẽ hiện thỉ bắt người dùng click vào lớp
            if (isCellClicked)
            {
                //
                frm.setId(ma);

                //lấy dữ liệu cho form 2
                frm.getMaSv(str1);

                //lấy mạng để tiến hành xóa 
                frm.setArrayList(arr);

                // lọc mã sinh viên chưa có trong lớp được chọn để thêm
                string query1 = "SELECT MaSinhVien " +
                "FROM tblSinhVien " +
                "WHERE (MaSinhVien IS NOT NULL AND MaSinhVien != '' AND MaSinhVien NOT IN (" + str1 + ")) " +
                "OR (MaSinhVien IS NULL OR MaSinhVien = '')";
                str1 = null;
                foreach (DataRow row in DataAcessAdmin.GetTable(query1).Rows)
                {
                    // thêm vào combobox form2 để người dùng dễ dàng lựa chọn
                    frm.setCombobox(row["MaSinhVien"].ToString());
                }
                frm.ChangeTextLable(str);
                frm.Show();

            }
            else MessageBox.Show("Bạn chưa chọn lớp học phần để thêm sinh viên");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvSubjectClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            #region  //xử lý mã
            isCellClicked = true;
            DataGridViewRow dt = dtgvSubjectClass.Rows[e.RowIndex];
            // lấy mã để người dùng xử lý phía dưới
            if (e.RowIndex >= 0)
            {
                str = dt.Cells[1].Value.ToString();
            }
            str1 = dtgvSubjectClass.Rows[e.RowIndex].Cells[3].Value.ToString();

            // cv1 : chuyển mã thành (ma,ma,ma) để làm điều kiện NOTIN ==> lọc các sinh viên đã đăng kí môn đó 
            // từ đó thêm sv vao combobox dễ chọn lựa để thêm
            // nếu chuỗi rỗng hoặc ký tự trắng thì sẽ chuyển thành mặc định 0 để notin không bị lỗi
            if (!string.IsNullOrEmpty(str1))
                str1 = str1.Replace('_', ',');
            else
                str1 = "0";
            // lấy vị trí người dùng click để thêm sinh viên vào lớp 
            ma = dtgvSubjectClass.Rows[e.RowIndex].Cells[0].Value.ToString();
            #endregion



            //tránh người dùng click nhiều lần làm rối loạn dữ liệu
            arr.Clear();

            // Lấy mã sinh viên ở dòng được chọn
            string text = dtgvSubjectClass.Rows[e.RowIndex].Cells[3].ToString();

            //cắt mã sinh viên thành 1 chuỗi đẩy vào 1 mảng chuỗi ký tự
            string[] strarray = str1.Split(',');

            //thêm vào array list để tiến hành sắp xếp
            foreach (string item in strarray)
            {
                arr.Add(int.Parse(item));
            }
            arr.Sort();

        }

        private void btAddClass_Click(object sender, EventArgs e)
        {
            // thêm 1 lớp học phần vào 
            string query1 = "select MaHocPhan from tblHocPhan where (TenHocPhan= N'" + cbbSubjectClass.Text + "')";
            DataTable dt = DataAcessAdmin.GetTable(query1);
            string ma = dt.Rows[0][0].ToString();
            string query2 = "insert into tblLopHocPhan (TenLopHocPhan,MaHocPhan,TrangThaiLopHocPhan) values(N'" + cbbSubjectClass.Text + "'" +
                ", N'" + ma + "' " +
                ", N'" + cbbSubjectStatus.Text + "')";
            DataAcessAdmin.CRUD(query2);
            hienthi(dtgvSubjectClass);
        }

        private void btDeleteSubjects_Click(object sender, EventArgs e)
        {
            // xoa 1 lop hoc phan
            string query = "delete from tblLopHocPhan where MaLopHocPhan ='" + ma + "'";
            DataAcessAdmin.CRUD(query);
            hienthi(dtgvSubjectClass);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
        public void clearArr()
        {
            this.arr.Clear();
        }

        private void dtgvSubjectClass_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btChangeSubjects_Click(object sender, EventArgs e)
        {
            // cập nhật trạng thái lớp học phần
            string query = "Update tblLopHocPhan set TrangThaiLopHocPhan = '"+cbbSubjectStatus.Text+"' " +
                " where MaLopHocPhan = '"+ma+"'";
            DataAcessAdmin.CRUD(query);
            hienthi(dtgvSubjectClass);
        }
        public  void visiblenot_btAdd()
        {
            this.btAddClass.Visible = true;
            btAddStudents.Visible = true;
            btChangeSubjects.Visible = false;
            btDeleteSubjects.Visible = false;
        }
        public void visiblenot_btUpdate()
        {
            this.btAddClass.Visible = false;
            btAddStudents.Visible = false;
            btChangeSubjects.Visible = true;
            btDeleteSubjects.Visible = false;
        }
        public void visiblenot_btDelete()
        {
            btAddClass.Visible = false;
            btAddStudents.Visible = false;
            btChangeSubjects.Visible = false;
            btDeleteSubjects.Visible = true;
        }

        private void dtgvSubjectClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

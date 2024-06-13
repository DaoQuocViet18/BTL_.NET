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

namespace BTL_QLSV
{
    public partial class form_SV_DKHP : Form
    {
        private string current_Comb_SelectedItem;

        public form_SV_DKHP()
        {
            InitializeComponent();
        }

        private void form_SV_DKHP_Load(object sender, EventArgs e)
        {
            DateTime ngayCap = new DateTime(2021, 9, 21);
            AddNamKy(ngayCap);          
                                
            dgvHocPhanDangChoDangKy.DataSource = SelectDataHP_chuaDK();

            dgvHocPhanDaDangKy.DataSource = SelectDataLopHP_daDK("//");


            dgvHocPhanDangChoDangKy.Columns["MaHocPhan"].Visible = false;
            dgvHocPhanDangChoDangKy.Columns["TenHocPhan"].HeaderText = "Tên học phần";
            dgvHocPhanDangChoDangKy.Columns["MaNganh"].Visible = false;
            dgvHocPhanDangChoDangKy.Columns["SoTinChi"].HeaderText = "Số tín chỉ";
            dgvHocPhanDangChoDangKy.Columns["SoDonViHocTrinh"].HeaderText = "Số đơn vị học trình";
            dgvHocPhanDangChoDangKy.Columns["NamKyHoc"].Visible = false;

            dgvHocPhanDaDangKy.Columns["MaLopHocPhan"].Visible = false;
            dgvHocPhanDaDangKy.Columns["TenLopHocPhan"].HeaderText = "Tên lớp HP";
            dgvHocPhanDaDangKy.Columns["SoTinChi"].HeaderText = "Số tín chỉ";
            dgvHocPhanDaDangKy.Columns["SoDonViHocTrinh"].HeaderText = "Số ĐV học trình";
            dgvHocPhanDaDangKy.Columns["TrangThaiLopHocPhan"].HeaderText = "TT lớp HP";
            dgvHocPhanDaDangKy.Columns["NamKyHoc"].Visible = false;

            DataAccess.ThayDoiKichThuc_cua_DataGridView(dgvHocPhanDangChoDangKy);
            DataAccess.ThayDoiKichThuc_cua_DataGridView(dgvHocPhanDaDangKy);

            Set_up_Cho_Form_SV_DKHP();

        }

        private void Set_up_Cho_Form_SV_DKHP()
        {
            int margin = 10;
            int bottomOfDataGridView = dgvHocPhanDangChoDangKy.Bottom;
            lbHPDaDK.Top = bottomOfDataGridView + margin;

            bottomOfDataGridView = lbHPDaDK.Bottom;
            dgvHocPhanDaDangKy.Top = bottomOfDataGridView;
        }

        private void AddNamKy(DateTime ngayCap)
        {
            
            DateTime ngayHienTai = DateTime.Now;
            TimeSpan khoangCach = ngayHienTai - ngayCap;
            float soNgay = ((float)khoangCach.TotalDays) / 365;         

            if (soNgay > 0)
            {               
                if (soNgay > 0.5f)
                {                   
                    if (soNgay > 1)
                    {                        
                        if (soNgay > 1.5f)
                        {                            
                            if (soNgay > 2)
                            {                               
                                if (soNgay > 2.5f)
                                {                                   
                                    if (soNgay > 3)
                                    {
                                        combNamKy.Items.Add("Năm 4 Kỳ 1");
                                        if (soNgay > 3.5f)
                                        {
                                            combNamKy.Items.Add("Năm 4 Kỳ 2");
                                        }
                                        combNamKy.Items.Add("Năm 4 Kỳ 1");
                                    }
                                    combNamKy.Items.Add("Năm 3 Kỳ 2");
                                }
                                combNamKy.Items.Add("Năm 3 Kỳ 1");
                            }
                            combNamKy.Items.Add("Năm 2 Kỳ 2");
                        }
                        combNamKy.Items.Add("Năm 2 Kỳ 1");
                    }
                    combNamKy.Items.Add("Năm 1 Kỳ 2");
                }
                combNamKy.Items.Add("Năm 1 Kỳ 1");
            }
        }

        private void combNamKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu chọn giống lựa chọn trước đó --> hàm sẽ kết thúc tại đây và ko có gì thay đổi
            if (combNamKy.SelectedItem.ToString() == current_Comb_SelectedItem)
            {
                return;
            }
            current_Comb_SelectedItem = combNamKy.SelectedItem.ToString();

            // load lại dữ liệu của bảng dgvHocPhanDaDangKy cho đúng với current_Comb_SelectedItem           
            dgvHocPhanDaDangKy.DataSource = SelectDataLopHP_daDK(current_Comb_SelectedItem);
            DataAccess.ThayDoiKichThuc_cua_DataGridView(dgvHocPhanDaDangKy);
        }

        private void dgvHocPhanDangChoDangKy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow selectedRow = dgvHocPhanDangChoDangKy.Rows[e.RowIndex];

                // Lấy giá trị từ mỗi ô trong dòng
                int maHocPhan = int.Parse(selectedRow.Cells["MaHocPhan"].Value.ToString());

                // Tạo form mới và truyền thông tin sang form đó
                form_SV_DKHP_2 form_SV_DKHP_2 = new form_SV_DKHP_2();
                form_SV_DKHP_2.SetData(maHocPhan);
                form_SV_DKHP_2.ShowDialog();

                 
                dgvHocPhanDangChoDangKy.DataSource = SelectDataHP_chuaDK();

                DataAccess.ThayDoiKichThuc_cua_DataGridView(dgvHocPhanDangChoDangKy);
                DataAccess.ThayDoiKichThuc_cua_DataGridView(dgvHocPhanDaDangKy);

                Set_up_Cho_Form_SV_DKHP();
            }
        }


        public DataTable SelectDataHP_chuaDK()
        {

                string sql = "SELECT * " +
                    "FROM tblHocPhan AS hp " +
                    "WHERE MaHocPhan NOT IN ( SELECT MaHocPhan " +
                                            "FROM tblLopHocPhan AS lhp " +
                                            "JOIN tblSinhVien AS sv ON lhp.MaSinhVien LIKE CONCAT('%', sv.MaSinhVien, '%') " +
                                            "WHERE CHARINDEX('" + DataAccess.maSinhVien + "', lhp.MaSinhVien ) > 0)" +
                          "AND MaNganh = " + DataAccess.maNganh;

                return DataAccess.GetDataTable(sql);

        }

        public DataTable SelectDataLopHP_daDK(string namKyHoc)
        {
            string sql = "SELECT lhp.MaLopHocPhan, " +
                            "lhp.TenLopHocPhan, " +
                            "hp.SoTinChi , " +
                            "hp.SoDonViHocTrinh, " +
                            "lhp.TrangThaiLopHocPhan, " +
                            "hp.NamKyHoc " +
                        "FROM tblLopHocPhan AS lhp " +
                        "JOIN tblHocPhan AS hp ON hp.MaHocPhan = lhp.MaHocPhan " +
                        "WHERE hp.NamKyHoc LIKE N'%" + namKyHoc + "%' AND CHARINDEX('" + DataAccess.maSinhVien + "', lhp.MaSinhVien ) > 0";
            return DataAccess.GetDataTable(sql);
        }
    }
}

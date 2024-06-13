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
    public partial class statistical : Form
    {
        public statistical()
        {
            InitializeComponent();
        }

        private void statistical_Load(object sender, EventArgs e)
        {
            cbbDepartment.Items.Clear();
            string query = "select TenKhoa from tblKhoa";
            DataTable db1 = DataAcessAdmin.GetTable(query);
            cbbClass.Items.Clear();
            foreach (DataRow row in db1.Rows)
            {
                cbbDepartment.Items.Add(row["TenKhoa"].ToString());
            }

        }

        private void cbbDepartment_MouseLeave(object sender, EventArgs e)
        {


        }

        private void cbbDepartment_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cbbMajors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbMajors_Click(object sender, EventArgs e)
        {


            if (cbbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn tên khoa trước");
            }
            else
            {
                cbbMajors.Items.Clear();
                string query = "select TenNganh from tblNganh where MaKhoa In (select MaKhoa from tblKhoa where TenKhoa= N'" + cbbDepartment.Text + "')";
                DataTable db1 = DataAcessAdmin.GetTable(query);
                foreach (DataRow row in db1.Rows)
                {
                    cbbMajors.Items.Add(row["TenNganh"].ToString());
                }


            }
        }
        public void clearItem(ComboBox cb)
        {
            string st = cb.Text;
            cb.Items.Clear();
            cb.Items.Add(st);
            cb.Text = st;
        }

        private void cbbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbClass_Click(object sender, EventArgs e)
        {

            if (cbbMajors.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn tên ngành trước");
            }
            else
            {
                cbbClass.Items.Clear();
                string query = "select TenLop from tblLop where MaNganh In (select MaNganh from tblNganh where TenNganh= N'" + cbbMajors.Text + "')";
                DataTable db1 = DataAcessAdmin.GetTable(query);
                foreach (DataRow row in db1.Rows)
                {
                    cbbClass.Items.Add(row["TenLop"].ToString());

                }

            }

        }

        private void btShow_Click(object sender, EventArgs e)
        {
            if (cbbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn tên Lớp trước");
            }
            #region
            else
            {
                lbLop.Text= cbbClass.Text;
                string query = "select MaSinhVien as 'Mã Sinh Viên', TenSinhVien as 'TenSinhvien'," +
                    "NgayVaoTruong  " +
                    "from tblSinhVien where MaLop In(select Malop from tblLop where TenLop= N'" + cbbClass.Text + "')";
                DataTable tb = DataAcessAdmin.GetTable(query);
                dtgvStudent.DataSource = tb;
                if (tb.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có sinh viên nào trong lớp này!! Mời chọn lớp khác hoặc ngành khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtgvstatistical.DataSource = new DataTable();
                }
                else
                {
                    int yearNumber = 0;
                    string xacdinh = null;
                    foreach (DataRow row in tb.Rows)
                    {
                        if (row.IsNull("NgayVaoTruong") || string.IsNullOrWhiteSpace(row["NgayVaoTruong"].ToString()))
                            continue;
                        else
                        {
                            DateTime dtime;
                            DateTime.TryParse(row["NgayVaoTruong"].ToString(), out dtime);
                            TimeSpan ts = DateTime.Now - dtime;
                            yearNumber = (int)ts.TotalDays;
                            if (yearNumber / 365 == 0)
                            {
                                xacdinh += "'Năm 1";
                            }
                            else
                                xacdinh += "'Năm " + yearNumber / 365;
                            if (yearNumber / 182 >= 2)
                                xacdinh += " Kỳ 2',";
                            else
                                xacdinh += " Kỳ 1',";
                        }
                    }


                    string query3 = "select MaNganh from tblNganh where TenNganh= N'" + cbbMajors.Text + "'";
                    tb = DataAcessAdmin.GetTable(query3);
                    int ma = int.Parse(tb.Rows[0][0].ToString());


                    if (xacdinh != null || string.IsNullOrWhiteSpace(xacdinh) == false)
                    {
                        xacdinh.Trim();
                        xacdinh = xacdinh.Remove(xacdinh.Length - 1);

                        string query4 = "select TenHocPhan from tblHocPhan where NamKyHoc In(N" + xacdinh + ") AND MaNganh = " + ma;
                        tb = DataAcessAdmin.GetTable(query4);
                    }
                    else
                    {
                        string str = "select TenHocPhan from tblHocPhan where  MaNganh = " + ma;
                        tb = DataAcessAdmin.GetTable(str);

                    }

                    string hocphan = null;
                    foreach (DataRow row in tb.Rows)
                    {
                        hocphan += "'" + row["TenHocPhan"].ToString() + "' , ";
                    }
                    if (hocphan != null || string.IsNullOrWhiteSpace(hocphan) == false)
                    {
                        #region
                        hocphan = hocphan.Remove(hocphan.Length - 1);
                        hocphan = hocphan.Remove(hocphan.Length - 1);
                        // MessageBox.Show(hocphan);
                        string query5 = "select MaLopHocPhan as 'Mã Lớp Học Phần', TenLopHocPhan as 'Tên Lớp Học Phần', MaSinhVien as 'Mã Sinh Viên' from tblLopHocPhan where TenLopHocPhan In (N" + hocphan + ") ";
                        tb = DataAcessAdmin.GetTable(query5);
                        if (tb.Rows.Count == 0)
                            MessageBox.Show("Ngành này hiện tại chưa có lớp học phần vào kì này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {

                            dtgvStudent.DataSource = tb;
                         

                            dtgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            string masinhvien2 = "";
                            foreach (DataRow row in tb.Rows)
                            {
                                if (row["Mã Sinh Viên"].ToString() == null || string.IsNullOrWhiteSpace(row["Mã Sinh Viên"].ToString()))
                                    continue;

                                masinhvien2 += row["Mã Sinh Viên"].ToString() + "_";
                            }

                            if (masinhvien2 != null  && string.IsNullOrWhiteSpace(masinhvien2) == false)
                            {
                                masinhvien2 = masinhvien2.Remove(masinhvien2.Length - 1);
                                masinhvien2 = masinhvien2.Replace('_', ',');
                            }


                            if (masinhvien2 == null || string.IsNullOrWhiteSpace(masinhvien2))
                            {
                                string query6 = "select MaSinhVien as 'Mã Sinh Viên', TenSinhVien as 'TenSinhvien'," +
                                "NgayVaoTruong as 'Ngày Vào Trường' " +
                                "from tblSinhVien where MaLop In(select Malop from tblLop where TenLop= N'" + cbbClass.Text + "')";
                                dtgvstatistical.DataSource = DataAcessAdmin.GetTable(query6);

                                dtgvstatistical.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                dtgvstatistical.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                            }
                            else
                            {
                                string query7 = "select MaSinhVien as 'Mã Sinh Viên', TenSinhVien as 'TenSinhvien'," +
                                                            "NgayVaoTruong as 'Ngày Vào Trường' " +
                                                            "from tblSinhVien where MaLop In(select Malop from tblLop where TenLop= N'" + cbbClass.Text + "')  AND MaSinhVien Not In(" + masinhvien2 + ")";
                                dtgvstatistical.DataSource = DataAcessAdmin.GetTable(query7);
                                dtgvstatistical.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                dtgvstatistical.Anchor   = AnchorStyles.Left | AnchorStyles.Right;
                            }
                            #endregion
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngành này hiện tại chưa có học phần vào kì này");

                    }
                }

            }
            #endregion
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

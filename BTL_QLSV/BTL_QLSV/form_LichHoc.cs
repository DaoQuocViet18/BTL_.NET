using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace BTL_QLSV
{
    public partial class form_LichHoc : Form
    {
        DataTable dt;

        Label[] arr_lbThu = new Label[7];

        // Ánh xạ từ DayOfWeek sang tên ngày trong tiếng Việt
        Dictionary<DayOfWeek, string> thuTiengViet = new Dictionary<DayOfWeek, string>()
        {
            { DayOfWeek.Monday, "Thứ Hai" },
            { DayOfWeek.Tuesday, "Thứ Ba" },
            { DayOfWeek.Wednesday, "Thứ Tư" },
            { DayOfWeek.Thursday, "Thứ Năm" },
            { DayOfWeek.Friday, "Thứ Sáu" },
            { DayOfWeek.Saturday, "Thứ Bảy" },
            { DayOfWeek.Sunday, "Chủ Nhật" }
        };

        Dictionary<string, Color> mauLichHoc = new Dictionary<string, Color>()
        {
            {"BuoiHoc", Color.Silver},
            {"BuoiThi", Color.Yellow}
        };

        DateTime ngayXemXet;

        public form_LichHoc()
        {
            InitializeComponent();
        }
        
        private void form_LichHoc_Load(object sender, EventArgs e)
        {
            // db.maSinhVien = 2;

            dtpLichHoc.CustomFormat = "dd/MM/yyyy";

            arr_lbThu[0] = lbChuNhat;
            arr_lbThu[1] = lbThu2;
            arr_lbThu[2] = lbThu3;
            arr_lbThu[3] = lbThu4;
            arr_lbThu[4] = lbThu5;
            arr_lbThu[5] = lbThu6;
            arr_lbThu[6] = lbThu7;


            tlpLichHoc.SetRowSpan(lbSang, 2);
            tlpLichHoc.SetColumnSpan(lbSang, 1);
            tlpLichHoc.SetRowSpan(lbChieu, 2);
            tlpLichHoc.SetColumnSpan(lbChieu, 1);
            tlpLichHoc.SetRowSpan(lbToi, 2);
            tlpLichHoc.SetColumnSpan(lbToi, 1);

            // Lấy ngày hiện tại
            ngayXemXet = DateTime.Now;
            HienThiLichHoc();
        }

        private void form_LichHoc_SizeChanged(object sender, EventArgs e)
        {
            DataAccess.ThayDoiKT_Label_Button_cua_TableLayoutPanel(tlpChucNang, 0.5f);
            DataAccess.ThayDoiKT_Label_Button_cua_TableLayoutPanel(tlpLichHoc, 0.045f);
        }


        private void dtpLichHoc_ValueChanged(object sender, EventArgs e)
        {
            ngayXemXet = dtpLichHoc.Value;
            HienThiLichHoc();
        }

        private void btnHienTai_Click(object sender, EventArgs e)
        {
            ngayXemXet = DateTime.Now;
            dtpLichHoc.Value = ngayXemXet;
            HienThiLichHoc();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            ngayXemXet = ngayXemXet.AddDays(-7);
            dtpLichHoc.Value = ngayXemXet;
            HienThiLichHoc();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            ngayXemXet = ngayXemXet.AddDays(7);
            dtpLichHoc.Value = ngayXemXet;
            HienThiLichHoc();
        }

        private void HienThiLichHoc ()
        {                      

            DayOfWeek thu = DayOfWeek.Sunday;
            foreach (Label lbThu in arr_lbThu)
            {
                DateTime ngayTrongTuan = ngayXemXet.AddDays(-(int)ngayXemXet.DayOfWeek).AddDays((int)thu);
                lbThu.Text = thuTiengViet[thu] + " " + ngayTrongTuan.ToString("dd/MM/yyyy");
                thu++;
            }

            string sql = "SELECT lhp.TenLopHocPhan, " +
                            "lh.ThuTietHoc, " +
                            "lh.PhongHoc, " +
                            "lh.GiangVien, " +
                            "lh.ThoiGianHoc, " +
                            "lh.ThoiGianThi " +
                    "FROM tblLichHoc AS lh " +
                    "JOIN[tblLopHocPhan] AS lhp ON CHARINDEX('" + DataAccess.maSinhVien + "', lhp.MaSinhVien ) > 0 " +
                    "WHERE lhp.MaLopHocPhan = lh.MaLopHocPhan";
            dt = DataAccess.GetDataTable(sql);

            foreach (DataRow dtrow in dt.Rows)
            {
                string thuTietHoc = dtrow["ThuTietHoc"].ToString();
                string thoiGianHoc = dtrow["ThoiGianHoc"].ToString();
                string thoigianthi = dtrow["ThoiGianThi"].ToString();

                bool xacNhanNgayHoc = XacNhanNgayHoc(thuTietHoc, thoiGianHoc);
                bool xacNhanNgayThi = XacNhanNgayThi(thoigianthi);
                
                // hết lịch học --> hủy buổi học
                if (!xacNhanNgayHoc)
                {
                    int thuHoc = getThu(thuTietHoc, mauLichHoc["BuoiHoc"]);
                    int buoiHoc = getBuoi(thuTietHoc, mauLichHoc["BuoiHoc"]);

                    HuyLabel(thuHoc, buoiHoc);                  
                }

                // hết lịch thi --> hủy buổi thi
                if (!xacNhanNgayThi)
                {
                    int thuThi = getThu(thoigianthi, mauLichHoc["BuoiThi"]);
                    int buoiThi = getBuoi(thoigianthi, mauLichHoc["BuoiThi"]);

                    HuyLabel(thuThi, buoiThi);
                }

                if (xacNhanNgayThi)
                {                   
                    string tietHoc = thoigianthi.Substring(19);
                    int thuThi = getThu(thoigianthi, mauLichHoc["BuoiThi"]);
                    int buoiThi = getBuoi(thoigianthi, mauLichHoc["BuoiThi"]);
                    TaoLabel(dtrow, tietHoc, mauLichHoc["BuoiThi"], thuThi, buoiThi);
                }
                else if (xacNhanNgayHoc)
                {                   
                    string tietHoc = thuTietHoc.Substring(5);
                    int thuHoc = getThu(thuTietHoc, mauLichHoc["BuoiHoc"]);
                    int buoiHoc = getBuoi(thuTietHoc, mauLichHoc["BuoiHoc"]);
                    TaoLabel(dtrow, tietHoc, mauLichHoc["BuoiHoc"], thuHoc, buoiHoc);
                }               
            }
        }

        private int getThu(string thu_LH, Color mauLH)
        {
            if (mauLH == mauLichHoc["BuoiHoc"])
                return int.Parse(thu_LH[0].ToString());
            else if (mauLH == mauLichHoc["BuoiThi"])
                return int.Parse(thu_LH[14].ToString());
            else
                return 0;
        }

        private int getBuoi(string buoi_LH, Color mauLH)
        {
            int tietHoc = 0;
            if (mauLH == mauLichHoc["BuoiHoc"])
                tietHoc = int.Parse(buoi_LH[5].ToString());
            else if (mauLH == mauLichHoc["BuoiThi"])
                tietHoc = int.Parse(buoi_LH[19].ToString());

            if (tietHoc >= 1 && tietHoc <= 6)
                return 1;
            else if (tietHoc >= 7 && tietHoc <= 13)
                return 3;
            else if (tietHoc >= 14 && tietHoc <= 17)
                return 5;
            return 0;
        }

        private void TaoLabel (DataRow dtrow, string tietHoc, Color mauLH, int thuHoc, int buoiHoc)
        {
            
            // Tạo một Label mới
            Label newLabel = new Label();
            newLabel.Text = dtrow["TenLopHocPhan"].ToString() + "\n" +
                            "Tiết: " + tietHoc + "\n" +
                            dtrow["PhongHoc"].ToString();

            if (mauLH == mauLichHoc["BuoiHoc"])           
                newLabel.Text += "\n" + dtrow["GiangVien"].ToString();
            

            newLabel.AutoSize = true; // Cho phép Label tự động điều chỉnh kích thước dựa trên nội dung
            newLabel.BackColor = mauLH;
            newLabel.BorderStyle = BorderStyle.FixedSingle;           

            // Thêm Label vào Controls của TableLayoutPanel
            Control cellControl = tlpLichHoc.GetControlFromPosition(thuHoc, buoiHoc);
            if (cellControl != null && cellControl is Label)
            {
                Label label = (Label)cellControl;
                if (label.Text != newLabel.Text)
                    tlpLichHoc.Controls.Add(newLabel, thuHoc, buoiHoc + 1);
            }
            else
            {
                tlpLichHoc.Controls.Add(newLabel, thuHoc, buoiHoc);
            }
        }

        private void HuyLabel(int thu, int buoi)
        {
            Control cellControl = tlpLichHoc.GetControlFromPosition(thu, buoi);
            if (cellControl != null && cellControl is Label)
            {
                Label label = (Label)cellControl;
                if (label.BackColor != mauLichHoc["BuoiHoc"] || label.BackColor != mauLichHoc["BuoiThi"])
                {
                    tlpLichHoc.Controls.Remove(label);
                }
            }
        }

        private bool XacNhanNgayHoc (string thuTietHoc, string thoiGianHoc)
        {
            int thuHoc = getThu(thuTietHoc, mauLichHoc["BuoiHoc"]);
            string str_ngay = arr_lbThu[thuHoc - 1].Text.ToString();
            string[] arr_str_ngay = str_ngay.Split(' ');
            str_ngay = arr_str_ngay[2];
            DateTime date_ngay;
            DateTime.TryParseExact(str_ngay, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date_ngay);

            string str_ngayBatDau = thoiGianHoc;
            str_ngayBatDau = str_ngayBatDau.Substring(0, 10);
            DateTime date_ngayBatDau;
            DateTime.TryParseExact(str_ngayBatDau, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date_ngayBatDau);

            //Label newLabel_1 = new Label();
            //newLabel_1.Text = date_ngayBatDau.ToString();
            //newLabel_1.AutoSize = true; // Cho phép Label tự động điều chỉnh kích thước dựa trên nội dung
            //newLabel_1.BackColor = Color.Green;
            //newLabel_1.BorderStyle = BorderStyle.FixedSingle;
            //tlpLichHoc.Controls.Add(newLabel_1, 1, 5);


            string str_ngayKetThuc = thoiGianHoc;
            str_ngayKetThuc = str_ngayKetThuc.Substring(13, 10);
            DateTime date_ngayKetThuc;
            DateTime.TryParseExact(str_ngayKetThuc, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date_ngayKetThuc);

            //Label newLabel_2 = new Label();
            //newLabel_2.Text = date_ngayKetThuc.ToString();
            //newLabel_2.AutoSize = true; // Cho phép Label tự động điều chỉnh kích thước dựa trên nội dung
            //newLabel_2.BackColor = Color.Green;
            //newLabel_2.BorderStyle = BorderStyle.FixedSingle;
            //tlpLichHoc.Controls.Add(newLabel_2, 1, 6);

            int result_1 = DateTime.Compare(date_ngay, date_ngayBatDau);
            int result_2 = DateTime.Compare(date_ngay, date_ngayKetThuc);

            if (result_1 >= 0 && result_2 <= 0)
                return true;
            return false;
        }

        private bool XacNhanNgayThi(string thoiGianTHi)
        {
            // lấy thứ thi
            string[] arr_str_ngayThi = thoiGianTHi.Split(' ');
            int thuHoc = int.Parse(arr_str_ngayThi[2]);

            // lấy ngay thi dự kiến thi
            string str_ngayThi = arr_lbThu[thuHoc - 1].Text.ToString();
            string[] arr_str_ngay = str_ngayThi.Split(' ');
            str_ngayThi = arr_str_ngay[2];
            DateTime date_ngayThi;
            DateTime.TryParseExact(str_ngayThi, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date_ngayThi);

            // lấy ngay thi trên CSDL thi
            string str_ngayThiAnDinh = arr_str_ngayThi[0];
            DateTime date_ngayThiAnDinh;
            DateTime.TryParseExact(str_ngayThiAnDinh, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date_ngayThiAnDinh);


            int result_1 = DateTime.Compare(date_ngayThi, date_ngayThiAnDinh);

            if (result_1 == 0)
                return true;
            return false;
        }
    }
}

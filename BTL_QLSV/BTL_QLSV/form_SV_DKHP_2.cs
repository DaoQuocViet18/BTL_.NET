using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLSV
{
    public partial class form_SV_DKHP_2 : Form
    {
        private int maLopHocPhan;

        public form_SV_DKHP_2()
        {
            InitializeComponent();
        }
        private void form_SV_DKHP_2_Load(object sender, EventArgs e)
        {
            Database db = Database.getInstance();
            dgvLopHocPhan.DataSource = db.selectDataLopHP_chuaDK(maLopHocPhan);

            db.ThayDoiKichThuc_cua_DataGridView(dgvLopHocPhan);
        }

        public void SetData(int maLopHocPhan)
        {
            this.maLopHocPhan = maLopHocPhan;
        }

        private void dgvLopHocPhan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvLopHocPhan.Rows[e.RowIndex];
                string tenLopHocPhan = selectedRow.Cells["TenLopHocPhan"].Value.ToString();
                int maLopHocPhan = int.Parse(selectedRow.Cells["MaLopHocPhan"].Value.ToString());


                DialogResult kq = MessageBox.Show("Bạn có muốn đăng ký lớp học môn " + tenLopHocPhan + " ko", 
                    "Thông báo!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (kq == DialogResult.Yes)
                {
                    Database db = Database.getInstance();
                    db.add_SV_vao_LHP(maLopHocPhan);
                    this.Close();
                }
            }
        }
    }
}

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
    public partial class form_SV_Main : Form
    {
        public form_SV_Main()
        {
            InitializeComponent();
        }

        private void form_SV_Main_Load(object sender, EventArgs e)
        {          
            form_SV_thong_tin f = new form_SV_thong_tin();
            Add(f);
        }

        private void trangChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_SV_thong_tin f = new form_SV_thong_tin();
            Add(f);
        }

        private void dangKyHocPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_SV_DKHP f = new form_SV_DKHP();
            Add(f);
        }

        private void form_SV_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lichhocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_LichHoc f = new form_LichHoc();
            Add(f);
        }

        private void Add(Form f)
        {
            this.panelContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.panelContent.Controls.Add(f);
            f.Show();
        }
    }
}

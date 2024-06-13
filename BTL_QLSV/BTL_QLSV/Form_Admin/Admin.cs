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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            this.MaximumSize = new Size(0, 0);
        }
        private Form currentFormChild;
        private void OpenchildForm (Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle =  FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childform);
            panel_body.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }

   

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

       

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void upDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            OpenchildForm(student);
            student.visiblenot_btUpdate();
        }

        private void bt1_MouseUp(object sender, MouseEventArgs e)
        {
                if(e.Button == MouseButtons.Left)
            {
                MenuSv.Show(btSinhVien, e.Location);
            }
        }

        private void bt1_MouseEnter(object sender, EventArgs e)
        {

        }
       

        private void MenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void bt2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MenuLop.Show(btLop, e.Location);
            }
        }

        private void MenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btHocPhan_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MenuHocPhan.Show(btHocPhan, e.Location);
            }
        }

        private void btQuanLyHocPhan_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MenuLopHocPhan.Show(btQuanLyLopHocPhan, e.Location);
            }
        }

        private void btQuanLyKhoa_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MenuKhoa.Show(btQuanLyKhoa, e.Location);
            }

        }

        private void btQuanLyNganh_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MenuQuanLyNganh.Show(btQuanLyKhoa, e.Location);
            }
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            OpenchildForm(student);
            student.visiblenot_btAdd();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            OpenchildForm(student);
            student.visiblenot_btDelete();
        }

        private void AddClass_Click(object sender, EventArgs e)
        {
            Class cl = new Class();
            OpenchildForm(cl);
            cl.visiblenot_btAdd();
        }

        private void btUpdateClass_Click(object sender, EventArgs e)
        {
            Class cl = new Class();
            OpenchildForm(cl);
            cl.visiblenot_btUpdate();
        }

        private void btDeleteClass_Click(object sender, EventArgs e)
        {
            Class cl = new Class();
            OpenchildForm(cl);
            cl.visiblenot_btDelete();
        }

        private void btAddSubject_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            OpenchildForm(subject);
            subject.visible_notAdd();
        }

        private void btUpdateSubject_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            OpenchildForm(subject);
            subject.visible_notUpdate();
        }

        private void btDeleteSubject_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            OpenchildForm(subject);
            subject.visible_notDelete();
        }

        private void btAddSubjectClass_Click(object sender, EventArgs e)
        {
            SubjectClass sc = new SubjectClass();
            OpenchildForm (sc);
            sc.visiblenot_btAdd();
        }

        private void btUpdateSubjectClass_Click(object sender, EventArgs e)
        {
            SubjectClass sc = new SubjectClass();
            OpenchildForm(sc);
            sc.visiblenot_btUpdate();
        }

        private void btDeleteSubjectClass_Click(object sender, EventArgs e)
        {
            SubjectClass sc = new SubjectClass();
            OpenchildForm(sc);
            sc.visiblenot_btDelete();
        }

        private void btAddDepartment_Click(object sender, EventArgs e)
        {
            Department dp = new Department();
            OpenchildForm(dp);
            dp.visible_notAdd();
        }

        private void btUpdateDepartment_Click(object sender, EventArgs e)
        {
            Department dp = new Department();
            OpenchildForm(dp);
            dp.visible_notUpdate();
        }

        private void btDeleteDepartMent_Click(object sender, EventArgs e)
        {
            Department dp = new Department();
            OpenchildForm(dp);
            dp.visible_notDelete();
        }

        private void btAddMajors_Click(object sender, EventArgs e)
        {
            Majors mj  = new Majors();
            OpenchildForm(mj);
            mj.visible_notAdd();
        }

        private void btUpdateMajors_Click(object sender, EventArgs e)
        {
            Majors mj = new Majors();
            OpenchildForm(mj);
            mj.visible_notUpdate();
        }

        private void btDeleteMajors_Click(object sender, EventArgs e)
        {
            Majors mj = new Majors();
            OpenchildForm(mj);
            mj.visible_notDelete();
        }

        private void btStatistical_Click(object sender, EventArgs e)
        {
            statistical st = new statistical();
            OpenchildForm(st);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

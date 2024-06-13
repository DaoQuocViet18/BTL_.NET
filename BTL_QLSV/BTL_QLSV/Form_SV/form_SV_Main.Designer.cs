namespace BTL_QLSV
{
    partial class form_SV_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_SV_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangKyHocPhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lichhocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContent = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChuToolStripMenuItem,
            this.dangKyHocPhanToolStripMenuItem,
            this.lichhocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1582, 46);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChuToolStripMenuItem
            // 
            this.trangChuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.trangChuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trangChuToolStripMenuItem.Image")));
            this.trangChuToolStripMenuItem.Name = "trangChuToolStripMenuItem";
            this.trangChuToolStripMenuItem.Size = new System.Drawing.Size(173, 42);
            this.trangChuToolStripMenuItem.Text = "Trang chủ";
            this.trangChuToolStripMenuItem.Click += new System.EventHandler(this.trangChuToolStripMenuItem_Click);
            // 
            // dangKyHocPhanToolStripMenuItem
            // 
            this.dangKyHocPhanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.dangKyHocPhanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dangKyHocPhanToolStripMenuItem.Image")));
            this.dangKyHocPhanToolStripMenuItem.Name = "dangKyHocPhanToolStripMenuItem";
            this.dangKyHocPhanToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.dangKyHocPhanToolStripMenuItem.Text = "Đăng ký học phần";
            this.dangKyHocPhanToolStripMenuItem.Click += new System.EventHandler(this.dangKyHocPhanToolStripMenuItem_Click);
            // 
            // lichhocToolStripMenuItem
            // 
            this.lichhocToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.lichhocToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lichhocToolStripMenuItem.Image")));
            this.lichhocToolStripMenuItem.Name = "lichhocToolStripMenuItem";
            this.lichhocToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.lichhocToolStripMenuItem.Text = "Lịch học";
            this.lichhocToolStripMenuItem.Click += new System.EventHandler(this.lichhocToolStripMenuItem_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 46);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1582, 507);
            this.panelContent.TabIndex = 15;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.menuStrip1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1508, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(50, 46);
            this.guna2ControlBox1.TabIndex = 16;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1406, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(56, 44);
            this.guna2ControlBox3.TabIndex = 18;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1457, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(54, 44);
            this.guna2ControlBox2.TabIndex = 19;
            // 
            // form_SV_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 553);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_SV_Main";
            this.Text = "Quản lý sinh viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_SV_Main_FormClosed);
            this.Load += new System.EventHandler(this.form_SV_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangKyHocPhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lichhocToolStripMenuItem;
        private System.Windows.Forms.Panel panelContent;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_SV_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangKyHocPhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lichhocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChuToolStripMenuItem,
            this.dangKyHocPhanToolStripMenuItem,
            this.lichhocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1582, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChuToolStripMenuItem
            // 
            this.trangChuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.trangChuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trangChuToolStripMenuItem.Image")));
            this.trangChuToolStripMenuItem.Name = "trangChuToolStripMenuItem";
            this.trangChuToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
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
            this.panelContent.Location = new System.Drawing.Point(0, 28);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1582, 525);
            this.panelContent.TabIndex = 15;
            // 
            // form_SV_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 553);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.menuStrip1);
            this.Name = "form_SV_Main";
            this.Text = "form_SV_Main";
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
    }
}
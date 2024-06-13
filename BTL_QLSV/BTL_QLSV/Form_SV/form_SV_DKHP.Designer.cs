namespace BTL_QLSV
{
    partial class form_SV_DKHP
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
            this.dgvHocPhanDaDangKy = new System.Windows.Forms.DataGridView();
            this.combNamKy = new System.Windows.Forms.ComboBox();
            this.lbHPDaDK = new System.Windows.Forms.Label();
            this.lbHPChoDK = new System.Windows.Forms.Label();
            this.dgvHocPhanDangChoDangKy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhanDaDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhanDangChoDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHocPhanDaDangKy
            // 
            this.dgvHocPhanDaDangKy.AllowUserToAddRows = false;
            this.dgvHocPhanDaDangKy.AllowUserToDeleteRows = false;
            this.dgvHocPhanDaDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocPhanDaDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocPhanDaDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhanDaDangKy.Location = new System.Drawing.Point(0, 318);
            this.dgvHocPhanDaDangKy.Name = "dgvHocPhanDaDangKy";
            this.dgvHocPhanDaDangKy.ReadOnly = true;
            this.dgvHocPhanDaDangKy.RowHeadersWidth = 51;
            this.dgvHocPhanDaDangKy.RowTemplate.Height = 24;
            this.dgvHocPhanDaDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocPhanDaDangKy.Size = new System.Drawing.Size(934, 158);
            this.dgvHocPhanDaDangKy.TabIndex = 0;
            // 
            // combNamKy
            // 
            this.combNamKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combNamKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combNamKy.FormattingEnabled = true;
            this.combNamKy.Location = new System.Drawing.Point(266, 49);
            this.combNamKy.Name = "combNamKy";
            this.combNamKy.Size = new System.Drawing.Size(387, 39);
            this.combNamKy.TabIndex = 1;
            this.combNamKy.SelectedIndexChanged += new System.EventHandler(this.combNamKy_SelectedIndexChanged);
            // 
            // lbHPDaDK
            // 
            this.lbHPDaDK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHPDaDK.AutoSize = true;
            this.lbHPDaDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHPDaDK.Location = new System.Drawing.Point(0, 289);
            this.lbHPDaDK.Name = "lbHPDaDK";
            this.lbHPDaDK.Size = new System.Drawing.Size(393, 29);
            this.lbHPDaDK.TabIndex = 2;
            this.lbHPDaDK.Text = "Lớp HP đã đăng ký trong học kỳ này";
            // 
            // lbHPChoDK
            // 
            this.lbHPChoDK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHPChoDK.AutoSize = true;
            this.lbHPChoDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHPChoDK.Location = new System.Drawing.Point(0, 110);
            this.lbHPChoDK.Name = "lbHPChoDK";
            this.lbHPChoDK.Size = new System.Drawing.Size(404, 29);
            this.lbHPChoDK.TabIndex = 4;
            this.lbHPChoDK.Text = "Môn học/học phần đang chờ đăng ký";
            // 
            // dgvHocPhanDangChoDangKy
            // 
            this.dgvHocPhanDangChoDangKy.AllowUserToAddRows = false;
            this.dgvHocPhanDangChoDangKy.AllowUserToDeleteRows = false;
            this.dgvHocPhanDangChoDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocPhanDangChoDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocPhanDangChoDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhanDangChoDangKy.Location = new System.Drawing.Point(0, 139);
            this.dgvHocPhanDangChoDangKy.Name = "dgvHocPhanDangChoDangKy";
            this.dgvHocPhanDangChoDangKy.ReadOnly = true;
            this.dgvHocPhanDangChoDangKy.RowHeadersWidth = 51;
            this.dgvHocPhanDangChoDangKy.RowTemplate.Height = 24;
            this.dgvHocPhanDangChoDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocPhanDangChoDangKy.Size = new System.Drawing.Size(934, 150);
            this.dgvHocPhanDangChoDangKy.TabIndex = 0;
            this.dgvHocPhanDangChoDangKy.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocPhanDangChoDangKy_CellDoubleClick);
            // 
            // form_SV_DKHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 475);
            this.Controls.Add(this.lbHPChoDK);
            this.Controls.Add(this.dgvHocPhanDangChoDangKy);
            this.Controls.Add(this.lbHPDaDK);
            this.Controls.Add(this.combNamKy);
            this.Controls.Add(this.dgvHocPhanDaDangKy);
            this.Name = "form_SV_DKHP";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.form_SV_DKHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhanDaDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhanDangChoDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHocPhanDaDangKy;
        private System.Windows.Forms.ComboBox combNamKy;
        private System.Windows.Forms.Label lbHPDaDK;
        private System.Windows.Forms.Label lbHPChoDK;
        private System.Windows.Forms.DataGridView dgvHocPhanDangChoDangKy;
    }
}
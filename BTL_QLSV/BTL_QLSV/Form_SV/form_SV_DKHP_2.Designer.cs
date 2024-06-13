namespace BTL_QLSV
{
    partial class form_SV_DKHP_2
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
            this.dgvLopHocPhan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLopHocPhan
            // 
            this.dgvLopHocPhan.AllowUserToAddRows = false;
            this.dgvLopHocPhan.AllowUserToDeleteRows = false;
            this.dgvLopHocPhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLopHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHocPhan.Location = new System.Drawing.Point(-2, 83);
            this.dgvLopHocPhan.MultiSelect = false;
            this.dgvLopHocPhan.Name = "dgvLopHocPhan";
            this.dgvLopHocPhan.ReadOnly = true;
            this.dgvLopHocPhan.RowHeadersWidth = 51;
            this.dgvLopHocPhan.RowTemplate.Height = 24;
            this.dgvLopHocPhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopHocPhan.Size = new System.Drawing.Size(1467, 247);
            this.dgvLopHocPhan.TabIndex = 0;
            this.dgvLopHocPhan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHocPhan_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết lớp học phần";
            // 
            // form_SV_DKHP_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLopHocPhan);
            this.Name = "form_SV_DKHP_2";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.form_SV_DKHP_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLopHocPhan;
        private System.Windows.Forms.Label label1;
    }
}
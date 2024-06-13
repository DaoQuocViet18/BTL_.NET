namespace WindowsFormsApp1
{
    partial class Majors
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMajorsName = new System.Windows.Forms.TextBox();
            this.btAddMajors = new System.Windows.Forms.Button();
            this.btChangeMajors = new System.Windows.Forms.Button();
            this.btDeleteMajors = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbDepartmentCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvMajors = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMajors)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(495, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quản Lý Ngành";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên Ngành";
            // 
            // txtMajorsName
            // 
            this.txtMajorsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMajorsName.Location = new System.Drawing.Point(501, 183);
            this.txtMajorsName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMajorsName.Name = "txtMajorsName";
            this.txtMajorsName.Size = new System.Drawing.Size(347, 30);
            this.txtMajorsName.TabIndex = 3;
            // 
            // btAddMajors
            // 
            this.btAddMajors.Location = new System.Drawing.Point(572, 327);
            this.btAddMajors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddMajors.Name = "btAddMajors";
            this.btAddMajors.Size = new System.Drawing.Size(101, 57);
            this.btAddMajors.TabIndex = 5;
            this.btAddMajors.Text = "Thêm";
            this.btAddMajors.UseVisualStyleBackColor = true;
            this.btAddMajors.Click += new System.EventHandler(this.btAddMajors_Click);
            // 
            // btChangeMajors
            // 
            this.btChangeMajors.Location = new System.Drawing.Point(572, 327);
            this.btChangeMajors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btChangeMajors.Name = "btChangeMajors";
            this.btChangeMajors.Size = new System.Drawing.Size(101, 57);
            this.btChangeMajors.TabIndex = 6;
            this.btChangeMajors.Text = "Sửa";
            this.btChangeMajors.UseVisualStyleBackColor = true;
            this.btChangeMajors.Click += new System.EventHandler(this.btChangeMajors_Click);
            // 
            // btDeleteMajors
            // 
            this.btDeleteMajors.Location = new System.Drawing.Point(572, 327);
            this.btDeleteMajors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeleteMajors.Name = "btDeleteMajors";
            this.btDeleteMajors.Size = new System.Drawing.Size(101, 57);
            this.btDeleteMajors.TabIndex = 7;
            this.btDeleteMajors.Text = "Xóa";
            this.btDeleteMajors.UseVisualStyleBackColor = true;
            this.btDeleteMajors.Click += new System.EventHandler(this.btDeleteMajors_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbDepartmentCode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtgvMajors);
            this.panel2.Controls.Add(this.btDeleteMajors);
            this.panel2.Controls.Add(this.btChangeMajors);
            this.panel2.Controls.Add(this.btAddMajors);
            this.panel2.Controls.Add(this.txtMajorsName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-11, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1352, 727);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbbDepartmentCode
            // 
            this.cbbDepartmentCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDepartmentCode.FormattingEnabled = true;
            this.cbbDepartmentCode.Location = new System.Drawing.Point(501, 262);
            this.cbbDepartmentCode.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDepartmentCode.Name = "cbbDepartmentCode";
            this.cbbDepartmentCode.Size = new System.Drawing.Size(347, 33);
            this.cbbDepartmentCode.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Khoa ";
            // 
            // dtgvMajors
            // 
            this.dtgvMajors.AllowUserToAddRows = false;
            this.dtgvMajors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvMajors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMajors.Location = new System.Drawing.Point(37, 407);
            this.dtgvMajors.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvMajors.Name = "dtgvMajors";
            this.dtgvMajors.RowHeadersWidth = 51;
            this.dtgvMajors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMajors.Size = new System.Drawing.Size(1243, 302);
            this.dtgvMajors.TabIndex = 8;
            this.dtgvMajors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMajors_CellClick);
            // 
            // Majors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 754);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Majors";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMajors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMajorsName;
        private System.Windows.Forms.Button btAddMajors;
        private System.Windows.Forms.Button btChangeMajors;
        private System.Windows.Forms.Button btDeleteMajors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvMajors;
        private System.Windows.Forms.ComboBox cbbDepartmentCode;
        private System.Windows.Forms.Label label1;
    }
}
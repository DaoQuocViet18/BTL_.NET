namespace WindowsFormsApp1
{
    partial class Class
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
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtConsultants = new System.Windows.Forms.TextBox();
            this.btAddClass = new System.Windows.Forms.Button();
            this.btChangeClass = new System.Windows.Forms.Button();
            this.btDeleteClass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMajorsCode = new System.Windows.Forms.ComboBox();
            this.dtgvClass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SeaShell;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(382, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(394, 61);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quản Lý Lớp";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên Lớp";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên Cố Vấn Học Tập";
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(442, 379);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(439, 38);
            this.txtClassName.TabIndex = 3;
            // 
            // txtConsultants
            // 
            this.txtConsultants.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultants.Location = new System.Drawing.Point(442, 466);
            this.txtConsultants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultants.Name = "txtConsultants";
            this.txtConsultants.Size = new System.Drawing.Size(439, 38);
            this.txtConsultants.TabIndex = 4;
            // 
            // btAddClass
            // 
            this.btAddClass.Location = new System.Drawing.Point(559, 532);
            this.btAddClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddClass.Name = "btAddClass";
            this.btAddClass.Size = new System.Drawing.Size(177, 79);
            this.btAddClass.TabIndex = 5;
            this.btAddClass.Text = "Thêm";
            this.btAddClass.UseVisualStyleBackColor = true;
            this.btAddClass.Click += new System.EventHandler(this.btAddClass_Click);
            // 
            // btChangeClass
            // 
            this.btChangeClass.Location = new System.Drawing.Point(566, 532);
            this.btChangeClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btChangeClass.Name = "btChangeClass";
            this.btChangeClass.Size = new System.Drawing.Size(170, 77);
            this.btChangeClass.TabIndex = 6;
            this.btChangeClass.Text = "Sửa";
            this.btChangeClass.UseVisualStyleBackColor = true;
            this.btChangeClass.Click += new System.EventHandler(this.btChangeClass_Click);
            // 
            // btDeleteClass
            // 
            this.btDeleteClass.Location = new System.Drawing.Point(559, 534);
            this.btDeleteClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeleteClass.Name = "btDeleteClass";
            this.btDeleteClass.Size = new System.Drawing.Size(213, 75);
            this.btDeleteClass.TabIndex = 7;
            this.btDeleteClass.Text = "Xóa";
            this.btDeleteClass.UseVisualStyleBackColor = true;
            this.btDeleteClass.Click += new System.EventHandler(this.btDeleteClass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 309);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Ngành";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbMajorsCode
            // 
            this.cbbMajorsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMajorsCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMajorsCode.FormattingEnabled = true;
            this.cbbMajorsCode.Location = new System.Drawing.Point(442, 292);
            this.cbbMajorsCode.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMajorsCode.Name = "cbbMajorsCode";
            this.cbbMajorsCode.Size = new System.Drawing.Size(439, 39);
            this.cbbMajorsCode.TabIndex = 9;
            // 
            // dtgvClass
            // 
            this.dtgvClass.AllowUserToAddRows = false;
            this.dtgvClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClass.Location = new System.Drawing.Point(4, 648);
            this.dtgvClass.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvClass.Name = "dtgvClass";
            this.dtgvClass.RowHeadersWidth = 51;
            this.dtgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvClass.Size = new System.Drawing.Size(1400, 287);
            this.dtgvClass.TabIndex = 10;
            this.dtgvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvClass_CellClick);
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 1055);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbMajorsCode);
            this.Controls.Add(this.txtConsultants);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgvClass);
            this.Controls.Add(this.btDeleteClass);
            this.Controls.Add(this.btAddClass);
            this.Controls.Add(this.btChangeClass);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Class";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtConsultants;
        private System.Windows.Forms.Button btAddClass;
        private System.Windows.Forms.Button btChangeClass;
        private System.Windows.Forms.Button btDeleteClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMajorsCode;
        private System.Windows.Forms.DataGridView dtgvClass;
    }
}
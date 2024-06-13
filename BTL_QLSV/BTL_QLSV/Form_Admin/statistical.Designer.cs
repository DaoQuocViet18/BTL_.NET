namespace WindowsFormsApp1
{
    partial class statistical
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
            this.cbbDepartment = new System.Windows.Forms.ComboBox();
            this.cbbMajors = new System.Windows.Forms.ComboBox();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btShow = new System.Windows.Forms.Button();
            this.dtgvstatistical = new System.Windows.Forms.DataGridView();
            this.dtgvStudent = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvstatistical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbDepartment
            // 
            this.cbbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDepartment.FormattingEnabled = true;
            this.cbbDepartment.Location = new System.Drawing.Point(411, 310);
            this.cbbDepartment.Name = "cbbDepartment";
            this.cbbDepartment.Size = new System.Drawing.Size(342, 33);
            this.cbbDepartment.TabIndex = 0;
            this.cbbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbbDepartment_SelectedIndexChanged);
            this.cbbDepartment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbDepartment_MouseClick);
            this.cbbDepartment.MouseLeave += new System.EventHandler(this.cbbDepartment_MouseLeave);
            // 
            // cbbMajors
            // 
            this.cbbMajors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMajors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMajors.FormattingEnabled = true;
            this.cbbMajors.Location = new System.Drawing.Point(411, 365);
            this.cbbMajors.Name = "cbbMajors";
            this.cbbMajors.Size = new System.Drawing.Size(342, 33);
            this.cbbMajors.TabIndex = 1;
            this.cbbMajors.SelectedIndexChanged += new System.EventHandler(this.cbbMajors_SelectedIndexChanged);
            this.cbbMajors.Click += new System.EventHandler(this.cbbMajors_Click);
            // 
            // cbbClass
            // 
            this.cbbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(411, 418);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(342, 33);
            this.cbbClass.TabIndex = 3;
            this.cbbClass.Click += new System.EventHandler(this.cbbClass_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khoa:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngành:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(389, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 95);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thống kê";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btShow
            // 
            this.btShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow.Location = new System.Drawing.Point(411, 526);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(307, 90);
            this.btShow.TabIndex = 10;
            this.btShow.Text = "Hiển Thị";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // dtgvstatistical
            // 
            this.dtgvstatistical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvstatistical.Location = new System.Drawing.Point(24, 717);
            this.dtgvstatistical.Name = "dtgvstatistical";
            this.dtgvstatistical.RowHeadersWidth = 51;
            this.dtgvstatistical.RowTemplate.Height = 24;
            this.dtgvstatistical.Size = new System.Drawing.Size(1229, 370);
            this.dtgvstatistical.TabIndex = 13;
            // 
            // dtgvStudent
            // 
            this.dtgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStudent.Location = new System.Drawing.Point(856, 310);
            this.dtgvStudent.Name = "dtgvStudent";
            this.dtgvStudent.RowHeadersWidth = 51;
            this.dtgvStudent.RowTemplate.Height = 24;
            this.dtgvStudent.Size = new System.Drawing.Size(397, 303);
            this.dtgvStudent.TabIndex = 14;
            this.dtgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(43, 619);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1210, 95);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sinh Viên Chưa Đăng Ký";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLop
            // 
            this.lbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.ForeColor = System.Drawing.Color.Red;
            this.lbLop.Location = new System.Drawing.Point(827, 193);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(405, 78);
            this.lbLop.TabIndex = 16;
            // 
            // statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 1055);
            this.Controls.Add(this.lbLop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgvStudent);
            this.Controls.Add(this.dtgvstatistical);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.cbbMajors);
            this.Controls.Add(this.cbbDepartment);
            this.Name = "statistical";
            this.Text = "statistical";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.statistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvstatistical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbDepartment;
        private System.Windows.Forms.ComboBox cbbMajors;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.DataGridView dtgvstatistical;
        private System.Windows.Forms.DataGridView dtgvStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbLop;
    }
}
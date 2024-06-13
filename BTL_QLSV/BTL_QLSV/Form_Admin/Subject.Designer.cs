namespace WindowsFormsApp1
{
    partial class Subject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbMajorsCode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYearSchool = new System.Windows.Forms.TextBox();
            this.txtNumberOfCredits = new System.Windows.Forms.TextBox();
            this.txtUnitCreadits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAddSubjects = new System.Windows.Forms.Button();
            this.dtgvSubjects = new System.Windows.Forms.DataGridView();
            this.btDeleteSubjects = new System.Windows.Forms.Button();
            this.btChangeSubjects = new System.Windows.Forms.Button();
            this.btAddDepartment = new System.Windows.Forms.Button();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 730);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbMajorsCode);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtYearSchool);
            this.panel2.Controls.Add(this.txtNumberOfCredits);
            this.panel2.Controls.Add(this.txtUnitCreadits);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btAddSubjects);
            this.panel2.Controls.Add(this.dtgvSubjects);
            this.panel2.Controls.Add(this.btDeleteSubjects);
            this.panel2.Controls.Add(this.btChangeSubjects);
            this.panel2.Controls.Add(this.btAddDepartment);
            this.panel2.Controls.Add(this.txtSubjectName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-215, -40);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1416, 748);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbbMajorsCode
            // 
            this.cbbMajorsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMajorsCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMajorsCode.FormattingEnabled = true;
            this.cbbMajorsCode.Location = new System.Drawing.Point(646, 240);
            this.cbbMajorsCode.Name = "cbbMajorsCode";
            this.cbbMajorsCode.Size = new System.Drawing.Size(347, 33);
            this.cbbMajorsCode.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(464, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Năm học";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(464, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số đơn vị học trình";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(464, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số Tín Chỉ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(464, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã Ngành ";
            // 
            // txtYearSchool
            // 
            this.txtYearSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearSchool.Location = new System.Drawing.Point(646, 408);
            this.txtYearSchool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYearSchool.Name = "txtYearSchool";
            this.txtYearSchool.Size = new System.Drawing.Size(347, 30);
            this.txtYearSchool.TabIndex = 12;
            // 
            // txtNumberOfCredits
            // 
            this.txtNumberOfCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfCredits.Location = new System.Drawing.Point(646, 295);
            this.txtNumberOfCredits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumberOfCredits.Name = "txtNumberOfCredits";
            this.txtNumberOfCredits.Size = new System.Drawing.Size(347, 30);
            this.txtNumberOfCredits.TabIndex = 11;
            // 
            // txtUnitCreadits
            // 
            this.txtUnitCreadits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitCreadits.Location = new System.Drawing.Point(646, 350);
            this.txtUnitCreadits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitCreadits.Name = "txtUnitCreadits";
            this.txtUnitCreadits.Size = new System.Drawing.Size(347, 30);
            this.txtUnitCreadits.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(464, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên Học Phần";
            // 
            // btAddSubjects
            // 
            this.btAddSubjects.Location = new System.Drawing.Point(744, 446);
            this.btAddSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddSubjects.Name = "btAddSubjects";
            this.btAddSubjects.Size = new System.Drawing.Size(101, 57);
            this.btAddSubjects.TabIndex = 8;
            this.btAddSubjects.Text = "Thêm";
            this.btAddSubjects.UseVisualStyleBackColor = true;
            this.btAddSubjects.Click += new System.EventHandler(this.btAddSubjects_Click);
            // 
            // dtgvSubjects
            // 
            this.dtgvSubjects.AllowUserToAddRows = false;
            this.dtgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSubjects.Location = new System.Drawing.Point(215, 509);
            this.dtgvSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvSubjects.Name = "dtgvSubjects";
            this.dtgvSubjects.RowHeadersWidth = 51;
            this.dtgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSubjects.Size = new System.Drawing.Size(1177, 282);
            this.dtgvSubjects.TabIndex = 1;
            this.dtgvSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSubjects_CellClick);
            // 
            // btDeleteSubjects
            // 
            this.btDeleteSubjects.Location = new System.Drawing.Point(744, 446);
            this.btDeleteSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeleteSubjects.Name = "btDeleteSubjects";
            this.btDeleteSubjects.Size = new System.Drawing.Size(101, 57);
            this.btDeleteSubjects.TabIndex = 7;
            this.btDeleteSubjects.Text = "Xóa";
            this.btDeleteSubjects.UseVisualStyleBackColor = true;
            this.btDeleteSubjects.Click += new System.EventHandler(this.btDeleteSubjects_Click);
            // 
            // btChangeSubjects
            // 
            this.btChangeSubjects.Location = new System.Drawing.Point(744, 446);
            this.btChangeSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btChangeSubjects.Name = "btChangeSubjects";
            this.btChangeSubjects.Size = new System.Drawing.Size(101, 57);
            this.btChangeSubjects.TabIndex = 6;
            this.btChangeSubjects.Text = "Sửa";
            this.btChangeSubjects.UseVisualStyleBackColor = true;
            this.btChangeSubjects.Click += new System.EventHandler(this.btChangeSubjects_Click);
            // 
            // btAddDepartment
            // 
            this.btAddDepartment.Location = new System.Drawing.Point(53, 427);
            this.btAddDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddDepartment.Name = "btAddDepartment";
            this.btAddDepartment.Size = new System.Drawing.Size(101, 57);
            this.btAddDepartment.TabIndex = 5;
            this.btAddDepartment.Text = "Thêm";
            this.btAddDepartment.UseVisualStyleBackColor = true;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.Location = new System.Drawing.Point(646, 174);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(347, 30);
            this.txtSubjectName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trưởng Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản Lý Học Phần";
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 1055);
            this.Controls.Add(this.panel1);
            this.Name = "Subject";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvSubjects;
        private System.Windows.Forms.Button btDeleteSubjects;
        private System.Windows.Forms.Button btChangeSubjects;
        private System.Windows.Forms.Button btAddDepartment;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAddSubjects;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYearSchool;
        private System.Windows.Forms.TextBox txtNumberOfCredits;
        private System.Windows.Forms.TextBox txtUnitCreadits;
        private System.Windows.Forms.ComboBox cbbMajorsCode;
    }
}
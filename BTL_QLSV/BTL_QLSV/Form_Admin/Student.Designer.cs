namespace WindowsFormsApp1
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPassw = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtPOB = new System.Windows.Forms.TextBox();
            this.lbMajors = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbPOB = new System.Windows.Forms.Label();
            this.db1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbNgay = new System.Windows.Forms.Label();
            this.cbbTenLop = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtDaycome = new System.Windows.Forms.DateTimePicker();
            this.cbbmajor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.db1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(294, 298);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 34);
            this.txtName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(179, 309);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(115, 21);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Họ Và Tên:";
            // 
            // lbPassw
            // 
            this.lbPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassw.Location = new System.Drawing.Point(179, 258);
            this.lbPassw.Name = "lbPassw";
            this.lbPassw.Size = new System.Drawing.Size(106, 23);
            this.lbPassw.TabIndex = 3;
            this.lbPassw.Text = "Mật Khẩu: ";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(294, 247);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(200, 34);
            this.txtPassWord.TabIndex = 4;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(294, 337);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(200, 34);
            this.txtGender.TabIndex = 6;
            // 
            // txtPOB
            // 
            this.txtPOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOB.Location = new System.Drawing.Point(294, 420);
            this.txtPOB.Name = "txtPOB";
            this.txtPOB.Size = new System.Drawing.Size(200, 34);
            this.txtPOB.TabIndex = 10;
            // 
            // lbMajors
            // 
            this.lbMajors.AutoSize = true;
            this.lbMajors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMajors.Location = new System.Drawing.Point(551, 264);
            this.lbMajors.Name = "lbMajors";
            this.lbMajors.Size = new System.Drawing.Size(98, 20);
            this.lbMajors.TabIndex = 15;
            this.lbMajors.Text = "Ngành Học:";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(548, 300);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(78, 20);
            this.lbClass.TabIndex = 16;
            this.lbClass.Text = "Lớp Học:";
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(179, 389);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(100, 23);
            this.lbDate.TabIndex = 19;
            this.lbDate.Text = "Ngày sinh:";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(179, 347);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(81, 20);
            this.lbGender.TabIndex = 20;
            this.lbGender.Text = "Giới Tính:";
            this.lbGender.Click += new System.EventHandler(this.lbGender_Click);
            // 
            // lbPOB
            // 
            this.lbPOB.AutoSize = true;
            this.lbPOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPOB.Location = new System.Drawing.Point(179, 434);
            this.lbPOB.Name = "lbPOB";
            this.lbPOB.Size = new System.Drawing.Size(77, 20);
            this.lbPOB.TabIndex = 21;
            this.lbPOB.Text = "Nơi Sinh:";
            // 
            // db1
            // 
            this.db1.AllowUserToAddRows = false;
            this.db1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db1.Location = new System.Drawing.Point(2, 591);
            this.db1.Name = "db1";
            this.db1.RowHeadersWidth = 51;
            this.db1.RowTemplate.Height = 24;
            this.db1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.db1.Size = new System.Drawing.Size(2009, 317);
            this.db1.TabIndex = 22;
            this.db1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(495, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(528, 481);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(164, 88);
            this.btAdd.TabIndex = 24;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(528, 497);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(164, 88);
            this.btChange.TabIndex = 25;
            this.btChange.Text = "Sửa";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(528, 497);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(164, 88);
            this.btRemove.TabIndex = 26;
            this.btRemove.Text = "Xóa";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(551, 344);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(100, 23);
            this.lbEmail.TabIndex = 27;
            this.lbEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(687, 337);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 34);
            this.txtEmail.TabIndex = 28;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(551, 377);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(48, 20);
            this.lbPhone.TabIndex = 29;
            this.lbPhone.Text = "SDT:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(687, 377);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(275, 34);
            this.txtPhone.TabIndex = 30;
            // 
            // lbNgay
            // 
            this.lbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(549, 434);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(100, 23);
            this.lbNgay.TabIndex = 31;
            this.lbNgay.Text = "Ngày vào trường:";
            // 
            // cbbTenLop
            // 
            this.cbbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenLop.FormattingEnabled = true;
            this.cbbTenLop.Location = new System.Drawing.Point(687, 293);
            this.cbbTenLop.Name = "cbbTenLop";
            this.cbbTenLop.Size = new System.Drawing.Size(275, 37);
            this.cbbTenLop.TabIndex = 33;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(294, 377);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 34);
            this.dtpDate.TabIndex = 35;
            // 
            // dtDaycome
            // 
            this.dtDaycome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDaycome.Location = new System.Drawing.Point(686, 423);
            this.dtDaycome.Name = "dtDaycome";
            this.dtDaycome.Size = new System.Drawing.Size(276, 34);
            this.dtDaycome.TabIndex = 36;
            // 
            // cbbmajor
            // 
            this.cbbmajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmajor.FormattingEnabled = true;
            this.cbbmajor.Location = new System.Drawing.Point(688, 247);
            this.cbbmajor.Name = "cbbmajor";
            this.cbbmajor.Size = new System.Drawing.Size(276, 37);
            this.cbbmajor.TabIndex = 37;
            this.cbbmajor.SelectedIndexChanged += new System.EventHandler(this.cbbmajor_SelectedIndexChanged_1);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 920);
            this.Controls.Add(this.cbbmajor);
            this.Controls.Add(this.dtDaycome);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbbTenLop);
            this.Controls.Add(this.lbNgay);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.db1);
            this.Controls.Add(this.lbPOB);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.lbMajors);
            this.Controls.Add(this.txtPOB);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.lbPassw);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student";
            this.Text = "Thông Tin Cá Nhân";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPassw;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtPOB;
        private System.Windows.Forms.Label lbMajors;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbPOB;
        private System.Windows.Forms.DataGridView db1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.ComboBox cbbTenLop;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtDaycome;
        private System.Windows.Forms.ComboBox cbbmajor;
    }
}


namespace WindowsFormsApp1
{
    partial class SubjectClassAdd_ChildForm
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
            this.dtgvSubjectClassAdd_ChildForm = new System.Windows.Forms.DataGridView();
            this.Max = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.cbbStudentID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDelete = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubjectClassAdd_ChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvSubjectClassAdd_ChildForm
            // 
            this.dtgvSubjectClassAdd_ChildForm.AllowUserToAddRows = false;
            this.dtgvSubjectClassAdd_ChildForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSubjectClassAdd_ChildForm.Location = new System.Drawing.Point(12, 296);
            this.dtgvSubjectClassAdd_ChildForm.Name = "dtgvSubjectClassAdd_ChildForm";
            this.dtgvSubjectClassAdd_ChildForm.RowHeadersWidth = 51;
            this.dtgvSubjectClassAdd_ChildForm.RowTemplate.Height = 24;
            this.dtgvSubjectClassAdd_ChildForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSubjectClassAdd_ChildForm.Size = new System.Drawing.Size(1167, 297);
            this.dtgvSubjectClassAdd_ChildForm.TabIndex = 0;
            this.dtgvSubjectClassAdd_ChildForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Max
            // 
            this.Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max.Location = new System.Drawing.Point(135, 161);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(170, 23);
            this.Max.TabIndex = 1;
            this.Max.Text = "Thêm Mã Sinh Viên";
            this.Max.Click += new System.EventHandler(this.label1_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(314, 230);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(135, 51);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.SystemColors.Info;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(318, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(405, 47);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbStudentID
            // 
            this.cbbStudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStudentID.FormattingEnabled = true;
            this.cbbStudentID.Location = new System.Drawing.Point(359, 151);
            this.cbbStudentID.Name = "cbbStudentID";
            this.cbbStudentID.Size = new System.Drawing.Size(284, 33);
            this.cbbStudentID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Lớp Học Phần";
            // 
            // lbID
            // 
            this.lbID.BackColor = System.Drawing.SystemColors.Info;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbID.Location = new System.Drawing.Point(318, 86);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(405, 36);
            this.lbID.TabIndex = 7;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(674, 230);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(135, 51);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(680, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Xóa Mã Sinh Viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbDelete
            // 
            this.cbbDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDelete.FormattingEnabled = true;
            this.cbbDelete.Location = new System.Drawing.Point(873, 151);
            this.cbbDelete.Name = "cbbDelete";
            this.cbbDelete.Size = new System.Drawing.Size(284, 33);
            this.cbbDelete.TabIndex = 10;
            // 
            // SubjectClassAdd_ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 782);
            this.Controls.Add(this.cbbDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbStudentID);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.dtgvSubjectClassAdd_ChildForm);
            this.Name = "SubjectClassAdd_ChildForm";
            this.Text = "SubjectClassAdd_ChildForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubjectClassAdd_ChildForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubjectClassAdd_ChildForm_FormClosed);
            this.Load += new System.EventHandler(this.SubjectClassAdd_ChildForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubjectClassAdd_ChildForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSubjectClassAdd_ChildForm;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox cbbStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDelete;
    }
}
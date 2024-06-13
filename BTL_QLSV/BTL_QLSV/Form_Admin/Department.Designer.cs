namespace WindowsFormsApp1
{
    partial class Department
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
            this.dtgvDepartment = new System.Windows.Forms.DataGridView();
            this.btDeleteDepartment = new System.Windows.Forms.Button();
            this.btChangeDepartMent = new System.Windows.Forms.Button();
            this.btAddDepartment = new System.Windows.Forms.Button();
            this.txtHeadDepartment = new System.Windows.Forms.TextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvDepartment);
            this.panel1.Controls.Add(this.btDeleteDepartment);
            this.panel1.Controls.Add(this.btChangeDepartMent);
            this.panel1.Controls.Add(this.btAddDepartment);
            this.panel1.Controls.Add(this.txtHeadDepartment);
            this.panel1.Controls.Add(this.txtDepartmentName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1607, 811);
            this.panel1.TabIndex = 0;
            // 
            // dtgvDepartment
            // 
            this.dtgvDepartment.AllowUserToAddRows = false;
            this.dtgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDepartment.Location = new System.Drawing.Point(15, 526);
            this.dtgvDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDepartment.Name = "dtgvDepartment";
            this.dtgvDepartment.RowHeadersWidth = 51;
            this.dtgvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDepartment.Size = new System.Drawing.Size(1185, 282);
            this.dtgvDepartment.TabIndex = 1;
            this.dtgvDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDepartment_CellClick);
            // 
            // btDeleteDepartment
            // 
            this.btDeleteDepartment.Location = new System.Drawing.Point(603, 463);
            this.btDeleteDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeleteDepartment.Name = "btDeleteDepartment";
            this.btDeleteDepartment.Size = new System.Drawing.Size(101, 57);
            this.btDeleteDepartment.TabIndex = 7;
            this.btDeleteDepartment.Text = "Xóa";
            this.btDeleteDepartment.UseVisualStyleBackColor = true;
            this.btDeleteDepartment.Click += new System.EventHandler(this.btDeleteDepartment_Click);
            // 
            // btChangeDepartMent
            // 
            this.btChangeDepartMent.Location = new System.Drawing.Point(603, 463);
            this.btChangeDepartMent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btChangeDepartMent.Name = "btChangeDepartMent";
            this.btChangeDepartMent.Size = new System.Drawing.Size(101, 57);
            this.btChangeDepartMent.TabIndex = 6;
            this.btChangeDepartMent.Text = "Sửa";
            this.btChangeDepartMent.UseVisualStyleBackColor = true;
            this.btChangeDepartMent.Click += new System.EventHandler(this.btChangeDepartMent_Click);
            // 
            // btAddDepartment
            // 
            this.btAddDepartment.Location = new System.Drawing.Point(603, 463);
            this.btAddDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddDepartment.Name = "btAddDepartment";
            this.btAddDepartment.Size = new System.Drawing.Size(101, 57);
            this.btAddDepartment.TabIndex = 5;
            this.btAddDepartment.Text = "Thêm";
            this.btAddDepartment.UseVisualStyleBackColor = true;
            this.btAddDepartment.Click += new System.EventHandler(this.btAddDepartment_Click);
            // 
            // txtHeadDepartment
            // 
            this.txtHeadDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadDepartment.Location = new System.Drawing.Point(501, 371);
            this.txtHeadDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeadDepartment.Name = "txtHeadDepartment";
            this.txtHeadDepartment.Size = new System.Drawing.Size(347, 30);
            this.txtHeadDepartment.TabIndex = 4;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.Location = new System.Drawing.Point(501, 309);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(347, 30);
            this.txtDepartmentName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trưởng Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khoa";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(495, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Khoa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 859);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Department";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeadDepartment;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAddDepartment;
        private System.Windows.Forms.Button btDeleteDepartment;
        private System.Windows.Forms.Button btChangeDepartMent;
        private System.Windows.Forms.DataGridView dtgvDepartment;
    }
}
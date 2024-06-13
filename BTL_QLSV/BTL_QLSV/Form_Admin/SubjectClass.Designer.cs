namespace WindowsFormsApp1
{
    partial class SubjectClass
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
            this.components = new System.ComponentModel.Container();
            this.miniToolStrip = new System.Windows.Forms.BindingNavigator(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btChangeSubjects = new System.Windows.Forms.Button();
            this.btDeleteSubjects = new System.Windows.Forms.Button();
            this.btAddStudents = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbSubjectClass = new System.Windows.Forms.ComboBox();
            this.cbbSubjectStatus = new System.Windows.Forms.ComboBox();
            this.btAddClass = new System.Windows.Forms.Button();
            this.dtgvSubjectClass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubjectClass)).BeginInit();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AddNewItem = null;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.CountItem = null;
            this.miniToolStrip.DeleteItem = null;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.MoveFirstItem = null;
            this.miniToolStrip.MoveLastItem = null;
            this.miniToolStrip.MoveNextItem = null;
            this.miniToolStrip.MovePreviousItem = null;
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.PositionItem = null;
            this.miniToolStrip.Size = new System.Drawing.Size(1830, 27);
            this.miniToolStrip.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(518, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Lớp Học Phần ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btChangeSubjects
            // 
            this.btChangeSubjects.Location = new System.Drawing.Point(633, 465);
            this.btChangeSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btChangeSubjects.Name = "btChangeSubjects";
            this.btChangeSubjects.Size = new System.Drawing.Size(125, 76);
            this.btChangeSubjects.TabIndex = 6;
            this.btChangeSubjects.Text = "Sửa";
            this.btChangeSubjects.UseVisualStyleBackColor = true;
            this.btChangeSubjects.Click += new System.EventHandler(this.btChangeSubjects_Click);
            // 
            // btDeleteSubjects
            // 
            this.btDeleteSubjects.Location = new System.Drawing.Point(443, 465);
            this.btDeleteSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeleteSubjects.Name = "btDeleteSubjects";
            this.btDeleteSubjects.Size = new System.Drawing.Size(125, 76);
            this.btDeleteSubjects.TabIndex = 7;
            this.btDeleteSubjects.Text = "Xóa";
            this.btDeleteSubjects.UseVisualStyleBackColor = true;
            this.btDeleteSubjects.Click += new System.EventHandler(this.btDeleteSubjects_Click);
            // 
            // btAddStudents
            // 
            this.btAddStudents.Location = new System.Drawing.Point(443, 465);
            this.btAddStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddStudents.Name = "btAddStudents";
            this.btAddStudents.Size = new System.Drawing.Size(125, 76);
            this.btAddStudents.TabIndex = 8;
            this.btAddStudents.Text = "Thêm Hoặc Xóa Sinh Viên Vào Lớp";
            this.btAddStudents.UseVisualStyleBackColor = true;
            this.btAddStudents.Click += new System.EventHandler(this.btAddSubjects_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tên Lớp Học Phần";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(228, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Trạng Thái Học Phần:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbSubjectClass
            // 
            this.cbbSubjectClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubjectClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSubjectClass.Location = new System.Drawing.Point(537, 242);
            this.cbbSubjectClass.Name = "cbbSubjectClass";
            this.cbbSubjectClass.Size = new System.Drawing.Size(360, 33);
            this.cbbSubjectClass.TabIndex = 17;
            // 
            // cbbSubjectStatus
            // 
            this.cbbSubjectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubjectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSubjectStatus.FormattingEnabled = true;
            this.cbbSubjectStatus.Location = new System.Drawing.Point(537, 349);
            this.cbbSubjectStatus.Name = "cbbSubjectStatus";
            this.cbbSubjectStatus.Size = new System.Drawing.Size(360, 33);
            this.cbbSubjectStatus.TabIndex = 18;
            // 
            // btAddClass
            // 
            this.btAddClass.Location = new System.Drawing.Point(633, 465);
            this.btAddClass.Name = "btAddClass";
            this.btAddClass.Size = new System.Drawing.Size(125, 76);
            this.btAddClass.TabIndex = 20;
            this.btAddClass.Text = "Thêm Lớp Học Phần";
            this.btAddClass.UseVisualStyleBackColor = true;
            this.btAddClass.Click += new System.EventHandler(this.btAddClass_Click);
            // 
            // dtgvSubjectClass
            // 
            this.dtgvSubjectClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSubjectClass.Location = new System.Drawing.Point(149, 620);
            this.dtgvSubjectClass.Name = "dtgvSubjectClass";
            this.dtgvSubjectClass.RowHeadersWidth = 51;
            this.dtgvSubjectClass.RowTemplate.Height = 24;
            this.dtgvSubjectClass.Size = new System.Drawing.Size(1640, 150);
            this.dtgvSubjectClass.TabIndex = 21;
            // 
            // SubjectClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 797);
            this.Controls.Add(this.dtgvSubjectClass);
            this.Controls.Add(this.btAddClass);
            this.Controls.Add(this.btChangeSubjects);
            this.Controls.Add(this.btDeleteSubjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddStudents);
            this.Controls.Add(this.cbbSubjectStatus);
            this.Controls.Add(this.cbbSubjectClass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "SubjectClass";
            this.Text = "Form7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SubjectClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubjectClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator miniToolStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChangeSubjects;
        private System.Windows.Forms.Button btDeleteSubjects;
        private System.Windows.Forms.Button btAddStudents;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbSubjectClass;
        private System.Windows.Forms.ComboBox cbbSubjectStatus;
        private System.Windows.Forms.Button btAddClass;
        private System.Windows.Forms.DataGridView dtgvSubjectClass;
    }
}
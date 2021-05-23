namespace Lab04_1712534
{
    partial class frmManage
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTenDN = new System.Windows.Forms.Label();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.textBoxTenDN = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLuong = new System.Windows.Forms.TextBox();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.labelLuong = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxThongTinNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(11, 80);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email";
            // 
            // labelTenDN
            // 
            this.labelTenDN.AutoSize = true;
            this.labelTenDN.Location = new System.Drawing.Point(11, 125);
            this.labelTenDN.Name = "labelTenDN";
            this.labelTenDN.Size = new System.Drawing.Size(105, 17);
            this.labelTenDN.TabIndex = 2;
            this.labelTenDN.Text = "Tên đăng nhập";
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(122, 37);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(205, 22);
            this.textBoxMaNV.TabIndex = 0;
            // 
            // textBoxTenDN
            // 
            this.textBoxTenDN.Location = new System.Drawing.Point(122, 125);
            this.textBoxTenDN.Name = "textBoxTenDN";
            this.textBoxTenDN.Size = new System.Drawing.Size(205, 22);
            this.textBoxTenDN.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(122, 80);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(205, 22);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxLuong
            // 
            this.textBoxLuong.Location = new System.Drawing.Point(447, 80);
            this.textBoxLuong.Name = "textBoxLuong";
            this.textBoxLuong.Size = new System.Drawing.Size(314, 22);
            this.textBoxLuong.TabIndex = 4;
            this.textBoxLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLuong_KeyPress);
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(447, 122);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(314, 22);
            this.textBoxMatKhau.TabIndex = 5;
            this.textBoxMatKhau.UseSystemPasswordChar = true;
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(447, 37);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(314, 22);
            this.textBoxHoTen.TabIndex = 3;
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Location = new System.Drawing.Point(333, 125);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(66, 17);
            this.labelMatKhau.TabIndex = 8;
            this.labelMatKhau.Text = "Mật khẩu";
            // 
            // labelLuong
            // 
            this.labelLuong.AutoSize = true;
            this.labelLuong.Location = new System.Drawing.Point(333, 80);
            this.labelLuong.Name = "labelLuong";
            this.labelLuong.Size = new System.Drawing.Size(48, 17);
            this.labelLuong.TabIndex = 7;
            this.labelLuong.Text = "Lương";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new System.Drawing.Point(333, 37);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(50, 17);
            this.labelHoTen.TabIndex = 6;
            this.labelHoTen.Text = "Họ tên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.EMAIL,
            this.LUONG});
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 200;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 213);
            this.dataGridView1.TabIndex = 12;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            // 
            // LUONG
            // 
            this.LUONG.DataPropertyName = "LUONG";
            this.LUONG.HeaderText = "Lương";
            this.LUONG.MinimumWidth = 6;
            this.LUONG.Name = "LUONG";
            // 
            // groupBoxThongTinNhanVien
            // 
            this.groupBoxThongTinNhanVien.Controls.Add(this.label1);
            this.groupBoxThongTinNhanVien.Controls.Add(this.textBoxLuong);
            this.groupBoxThongTinNhanVien.Controls.Add(this.labelEmail);
            this.groupBoxThongTinNhanVien.Controls.Add(this.textBoxMatKhau);
            this.groupBoxThongTinNhanVien.Controls.Add(this.labelTenDN);
            this.groupBoxThongTinNhanVien.Controls.Add(this.textBoxHoTen);
            this.groupBoxThongTinNhanVien.Controls.Add(this.textBoxMaNV);
            this.groupBoxThongTinNhanVien.Controls.Add(this.labelMatKhau);
            this.groupBoxThongTinNhanVien.Controls.Add(this.textBoxTenDN);
            this.groupBoxThongTinNhanVien.Controls.Add(this.labelLuong);
            this.groupBoxThongTinNhanVien.Controls.Add(this.textBoxEmail);
            this.groupBoxThongTinNhanVien.Controls.Add(this.labelHoTen);
            this.groupBoxThongTinNhanVien.Location = new System.Drawing.Point(12, 27);
            this.groupBoxThongTinNhanVien.Name = "groupBoxThongTinNhanVien";
            this.groupBoxThongTinNhanVien.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxThongTinNhanVien.Size = new System.Drawing.Size(776, 169);
            this.groupBoxThongTinNhanVien.TabIndex = 13;
            this.groupBoxThongTinNhanVien.TabStop = false;
            this.groupBoxThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxThongTinNhanVien);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel2.Controls.Add(this.buttonExit);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel2.Controls.Add(this.buttonUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDelete);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAdd);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 522);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.TabIndex = 14;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(546, 235);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(111, 36);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Không";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(677, 235);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(111, 36);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(416, 235);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 36);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Ghi/Lưu";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(279, 235);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(111, 36);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(146, 235);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(111, 36);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 235);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(111, 36);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(818, 569);
            this.Name = "frmManage";
            this.Text = "frmManage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxThongTinNhanVien.ResumeLayout(false);
            this.groupBoxThongTinNhanVien.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.TextBox textBoxTenDN;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLuong;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.Label labelLuong;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxThongTinNhanVien;
        private System.Windows.Forms.Label labelTenDN;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUONG;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
    }
}
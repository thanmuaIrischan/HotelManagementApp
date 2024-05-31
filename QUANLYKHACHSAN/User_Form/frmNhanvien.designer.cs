namespace QUANLYKHACHSAN.User_Form
{
    partial class frmNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgShow2 = new System.Windows.Forms.DataGridView();
            this.Manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMaTK = new System.Windows.Forms.ComboBox();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.btnXemMaCV = new System.Windows.Forms.Button();
            this.cbChucvu = new System.Windows.Forms.ComboBox();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.tbTennv = new System.Windows.Forms.TextBox();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.tbManv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.tbnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dtgShow2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 213);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1160, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbnDelete
            // 
            this.tbnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnDelete.Location = new System.Drawing.Point(1029, 300);
            this.tbnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbnDelete.Name = "tbnDelete";
            this.tbnDelete.Size = new System.Drawing.Size(118, 42);
            this.tbnDelete.TabIndex = 1;
            this.tbnDelete.Text = "Xóa";
            this.tbnDelete.UseVisualStyleBackColor = true;
            this.tbnDelete.Click += new System.EventHandler(this.tbnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1029, 129);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 42);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1029, 213);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgShow2
            // 
            this.dtgShow2.AllowUserToAddRows = false;
            this.dtgShow2.AllowUserToDeleteRows = false;
            this.dtgShow2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgShow2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgShow2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgShow2.ColumnHeadersHeight = 35;
            this.dtgShow2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgShow2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manv,
            this.TenNV,
            this.Gioitinh,
            this.Ngaysinh,
            this.Diachi,
            this.Sdt,
            this.Chucvu,
            this.Taikhoan});
            this.dtgShow2.Location = new System.Drawing.Point(8, 41);
            this.dtgShow2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgShow2.Name = "dtgShow2";
            this.dtgShow2.ReadOnly = true;
            this.dtgShow2.RowHeadersVisible = false;
            this.dtgShow2.RowHeadersWidth = 43;
            this.dtgShow2.Size = new System.Drawing.Size(1000, 333);
            this.dtgShow2.TabIndex = 0;
            this.dtgShow2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgShow2_CellContentClick);
            this.dtgShow2.DoubleClick += new System.EventHandler(this.dtgShow2_DoubleClick);
            // 
            // Manv
            // 
            this.Manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manv.DataPropertyName = "MaNV";
            this.Manv.HeaderText = "Mã NV";
            this.Manv.MinimumWidth = 6;
            this.Manv.Name = "Manv";
            this.Manv.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "HoTen";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 140;
            // 
            // Gioitinh
            // 
            this.Gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gioitinh.DataPropertyName = "GioiTinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.MinimumWidth = 6;
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.ReadOnly = true;
            this.Gioitinh.Width = 105;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "NgaySinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.MinimumWidth = 6;
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.ReadOnly = true;
            this.Ngaysinh.Width = 101;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "DiaChi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.ReadOnly = true;
            this.Diachi.Width = 150;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "SĐT";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            this.Sdt.Width = 101;
            // 
            // Chucvu
            // 
            this.Chucvu.DataPropertyName = "MaCV";
            this.Chucvu.HeaderText = "Mã chức vụ";
            this.Chucvu.MinimumWidth = 6;
            this.Chucvu.Name = "Chucvu";
            this.Chucvu.ReadOnly = true;
            this.Chucvu.Width = 110;
            // 
            // Taikhoan
            // 
            this.Taikhoan.DataPropertyName = "MaTK";
            this.Taikhoan.HeaderText = "Mã tài khoản";
            this.Taikhoan.MinimumWidth = 6;
            this.Taikhoan.Name = "Taikhoan";
            this.Taikhoan.ReadOnly = true;
            this.Taikhoan.Width = 130;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(914, 140);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(233, 49);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "LOAD";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 630);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Controls.Add(this.cbMaTK);
            this.groupBox2.Controls.Add(this.btnThemTK);
            this.groupBox2.Controls.Add(this.btnXemMaCV);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.cbChucvu);
            this.groupBox2.Controls.Add(this.dtNgaysinh);
            this.groupBox2.Controls.Add(this.cbGioitinh);
            this.groupBox2.Controls.Add(this.tbTennv);
            this.groupBox2.Controls.Add(this.tbSdt);
            this.groupBox2.Controls.Add(this.tbDiachi);
            this.groupBox2.Controls.Add(this.tbManv);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1160, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbMaTK
            // 
            this.cbMaTK.FormattingEnabled = true;
            this.cbMaTK.Location = new System.Drawing.Point(914, 36);
            this.cbMaTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbMaTK.Name = "cbMaTK";
            this.cbMaTK.Size = new System.Drawing.Size(236, 36);
            this.cbMaTK.TabIndex = 9;
            // 
            // btnThemTK
            // 
            this.btnThemTK.Location = new System.Drawing.Point(914, 79);
            this.btnThemTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(236, 42);
            this.btnThemTK.TabIndex = 8;
            this.btnThemTK.Text = "Thêm tài khoản";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // btnXemMaCV
            // 
            this.btnXemMaCV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemMaCV.Location = new System.Drawing.Point(607, 155);
            this.btnXemMaCV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXemMaCV.Name = "btnXemMaCV";
            this.btnXemMaCV.Size = new System.Drawing.Size(174, 38);
            this.btnXemMaCV.TabIndex = 7;
            this.btnXemMaCV.Text = "Thêm chức vụ";
            this.btnXemMaCV.UseVisualStyleBackColor = true;
            this.btnXemMaCV.Click += new System.EventHandler(this.btnXemMaCV_Click);
            // 
            // cbChucvu
            // 
            this.cbChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucvu.FormattingEnabled = true;
            this.cbChucvu.Location = new System.Drawing.Point(550, 111);
            this.cbChucvu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbChucvu.Name = "cbChucvu";
            this.cbChucvu.Size = new System.Drawing.Size(231, 36);
            this.cbChucvu.TabIndex = 5;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaysinh.Location = new System.Drawing.Point(176, 149);
            this.dtNgaysinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(227, 34);
            this.dtNgaysinh.TabIndex = 3;
            this.dtNgaysinh.ValueChanged += new System.EventHandler(this.dtNgaysinh_ValueChanged);
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Location = new System.Drawing.Point(176, 106);
            this.cbGioitinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(227, 36);
            this.cbGioitinh.TabIndex = 2;
            // 
            // tbTennv
            // 
            this.tbTennv.Location = new System.Drawing.Point(176, 71);
            this.tbTennv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTennv.MaxLength = 50;
            this.tbTennv.Name = "tbTennv";
            this.tbTennv.Size = new System.Drawing.Size(227, 34);
            this.tbTennv.TabIndex = 1;
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(550, 72);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSdt.MaxLength = 15;
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(231, 34);
            this.tbSdt.TabIndex = 1;
            this.tbSdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSdt_KeyPress);
            // 
            // tbDiachi
            // 
            this.tbDiachi.Location = new System.Drawing.Point(550, 29);
            this.tbDiachi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDiachi.MaxLength = 100;
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(231, 34);
            this.tbDiachi.TabIndex = 1;
            // 
            // tbManv
            // 
            this.tbManv.Location = new System.Drawing.Point(176, 28);
            this.tbManv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbManv.MaxLength = 5;
            this.tbManv.Name = "tbManv";
            this.tbManv.Size = new System.Drawing.Size(227, 34);
            this.tbManv.TabIndex = 1;
            this.tbManv.Click += new System.EventHandler(this.tbManv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã chức vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "SĐT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(794, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã tài khoản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV:";
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1173, 635);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanvien_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgShow2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tbnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbChucvu;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.TextBox tbTennv;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.TextBox tbDiachi;
        private System.Windows.Forms.TextBox tbManv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemMaCV;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.ComboBox cbMaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taikhoan;
    }
}
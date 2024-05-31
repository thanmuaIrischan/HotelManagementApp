namespace QUANLYKHACHSAN.User_Control
{
    partial class UserControlPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlChuthich = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tabPageLoaiphong = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtgLoaiphong = new System.Windows.Forms.DataGridView();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoiToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageDSPhong = new System.Windows.Forms.TabPage();
            this.pnlSodo = new System.Windows.Forms.Panel();
            this.dtgPhong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaP_LP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlPhong = new System.Windows.Forms.TabControl();
            this.tabPageBanggia = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgBanggia = new System.Windows.Forms.DataGridView();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlChuthich.SuspendLayout();
            this.tabPageLoaiphong.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoaiphong)).BeginInit();
            this.tabPageDSPhong.SuspendLayout();
            this.pnlSodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).BeginInit();
            this.tabControlPhong.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBanggia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 40);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(0, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 36);
            this.label3.TabIndex = 29;
            this.label3.Text = "  Quản lý phòng";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(0, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(717, 3);
            this.panel5.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 16);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(37, 389);
            this.panel4.TabIndex = 36;
            // 
            // pnlChuthich
            // 
            this.pnlChuthich.Controls.Add(this.btnSua);
            this.pnlChuthich.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChuthich.Location = new System.Drawing.Point(37, 399);
            this.pnlChuthich.Name = "pnlChuthich";
            this.pnlChuthich.Size = new System.Drawing.Size(680, 46);
            this.pnlChuthich.TabIndex = 37;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(507, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 24);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(401, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 24);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(593, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 24);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tabPageLoaiphong
            // 
            this.tabPageLoaiphong.Controls.Add(this.panel8);
            this.tabPageLoaiphong.Location = new System.Drawing.Point(4, 27);
            this.tabPageLoaiphong.Name = "tabPageLoaiphong";
            this.tabPageLoaiphong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoaiphong.Size = new System.Drawing.Size(672, 312);
            this.tabPageLoaiphong.TabIndex = 1;
            this.tabPageLoaiphong.Text = "Loại phòng";
            this.tabPageLoaiphong.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtgLoaiphong);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(666, 306);
            this.panel8.TabIndex = 0;
            // 
            // dtgLoaiphong
            // 
            this.dtgLoaiphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLoaiphong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgLoaiphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLoaiphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiPhong,
            this.TenLoaiPhong,
            this.SoLuongPhong,
            this.GiaPhong,
            this.SoNguoiToiDa});
            this.dtgLoaiphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLoaiphong.Location = new System.Drawing.Point(0, 0);
            this.dtgLoaiphong.Name = "dtgLoaiphong";
            this.dtgLoaiphong.RowHeadersWidth = 62;
            this.dtgLoaiphong.Size = new System.Drawing.Size(666, 306);
            this.dtgLoaiphong.TabIndex = 32;
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.MaLoaiPhong.HeaderText = "Mã loại phòng";
            this.MaLoaiPhong.MinimumWidth = 8;
            this.MaLoaiPhong.Name = "MaLoaiPhong";
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.DataPropertyName = "TenLoaiPhong";
            this.TenLoaiPhong.FillWeight = 110F;
            this.TenLoaiPhong.HeaderText = "Tên loại phòng";
            this.TenLoaiPhong.MinimumWidth = 8;
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            // 
            // SoLuongPhong
            // 
            this.SoLuongPhong.DataPropertyName = "SoLuong";
            this.SoLuongPhong.FillWeight = 80F;
            this.SoLuongPhong.HeaderText = "Số lượng";
            this.SoLuongPhong.MinimumWidth = 8;
            this.SoLuongPhong.Name = "SoLuongPhong";
            // 
            // GiaPhong
            // 
            this.GiaPhong.DataPropertyName = "Gia";
            this.GiaPhong.HeaderText = "Giá niêm yết";
            this.GiaPhong.MinimumWidth = 8;
            this.GiaPhong.Name = "GiaPhong";
            // 
            // SoNguoiToiDa
            // 
            this.SoNguoiToiDa.DataPropertyName = "SoNguoiToiDa";
            this.SoNguoiToiDa.FillWeight = 110F;
            this.SoNguoiToiDa.HeaderText = "Số người tối đa";
            this.SoNguoiToiDa.MinimumWidth = 8;
            this.SoNguoiToiDa.Name = "SoNguoiToiDa";
            // 
            // tabPageDSPhong
            // 
            this.tabPageDSPhong.Controls.Add(this.pnlSodo);
            this.tabPageDSPhong.Location = new System.Drawing.Point(4, 27);
            this.tabPageDSPhong.Name = "tabPageDSPhong";
            this.tabPageDSPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDSPhong.Size = new System.Drawing.Size(672, 312);
            this.tabPageDSPhong.TabIndex = 0;
            this.tabPageDSPhong.Text = "Danh sách phòng";
            this.tabPageDSPhong.UseVisualStyleBackColor = true;
            // 
            // pnlSodo
            // 
            this.pnlSodo.Controls.Add(this.dtgPhong);
            this.pnlSodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSodo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSodo.Location = new System.Drawing.Point(3, 3);
            this.pnlSodo.Name = "pnlSodo";
            this.pnlSodo.Size = new System.Drawing.Size(666, 306);
            this.pnlSodo.TabIndex = 0;
            // 
            // dtgPhong
            // 
            this.dtgPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.MaP_LP,
            this.TrangThai});
            this.dtgPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPhong.Location = new System.Drawing.Point(0, 0);
            this.dtgPhong.Name = "dtgPhong";
            this.dtgPhong.RowHeadersWidth = 62;
            this.dtgPhong.Size = new System.Drawing.Size(666, 306);
            this.dtgPhong.TabIndex = 34;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 8;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // MaP_LP
            // 
            this.MaP_LP.DataPropertyName = "TenLoaiPhong";
            this.MaP_LP.HeaderText = "Loại phòng";
            this.MaP_LP.MinimumWidth = 8;
            this.MaP_LP.Name = "MaP_LP";
            this.MaP_LP.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // tabControlPhong
            // 
            this.tabControlPhong.Controls.Add(this.tabPageDSPhong);
            this.tabControlPhong.Controls.Add(this.tabPageLoaiphong);
            this.tabControlPhong.Controls.Add(this.tabPageBanggia);
            this.tabControlPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPhong.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPhong.Location = new System.Drawing.Point(37, 56);
            this.tabControlPhong.Multiline = true;
            this.tabControlPhong.Name = "tabControlPhong";
            this.tabControlPhong.SelectedIndex = 0;
            this.tabControlPhong.Size = new System.Drawing.Size(680, 343);
            this.tabControlPhong.TabIndex = 38;
            // 
            // tabPageBanggia
            // 
            this.tabPageBanggia.Location = new System.Drawing.Point(4, 27);
            this.tabPageBanggia.Name = "tabPageBanggia";
            this.tabPageBanggia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBanggia.Size = new System.Drawing.Size(672, 312);
            this.tabPageBanggia.TabIndex = 2;
            this.tabPageBanggia.Text = "Bảng giá";
            this.tabPageBanggia.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgBanggia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 306);
            this.panel2.TabIndex = 0;
            // 
            // dtgBanggia
            // 
            this.dtgBanggia.AllowUserToAddRows = false;
            this.dtgBanggia.AllowUserToDeleteRows = false;
            this.dtgBanggia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBanggia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgBanggia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBanggia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiPhong,
            this.LoaiKH,
            this.Giatien});
            this.dtgBanggia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgBanggia.Location = new System.Drawing.Point(0, 0);
            this.dtgBanggia.Name = "dtgBanggia";
            this.dtgBanggia.ReadOnly = true;
            this.dtgBanggia.RowHeadersWidth = 62;
            this.dtgBanggia.Size = new System.Drawing.Size(666, 306);
            this.dtgBanggia.TabIndex = 33;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.LoaiPhong.FillWeight = 200F;
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.MinimumWidth = 8;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.ReadOnly = true;
            // 
            // LoaiKH
            // 
            this.LoaiKH.DataPropertyName = "LoaiKH";
            this.LoaiKH.FillWeight = 300F;
            this.LoaiKH.HeaderText = "Loại khách hàng";
            this.LoaiKH.MinimumWidth = 8;
            this.LoaiKH.Name = "LoaiKH";
            this.LoaiKH.ReadOnly = true;
            // 
            // Giatien
            // 
            this.Giatien.DataPropertyName = "GiaPhong";
            this.Giatien.FillWeight = 200F;
            this.Giatien.HeaderText = "Giá phòng";
            this.Giatien.MinimumWidth = 8;
            this.Giatien.Name = "Giatien";
            this.Giatien.ReadOnly = true;
            // 
            // UserControlPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlPhong);
            this.Controls.Add(this.pnlChuthich);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserControlPhong";
            this.Size = new System.Drawing.Size(717, 445);
            this.Load += new System.EventHandler(this.UserControlPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlChuthich.ResumeLayout(false);
            this.tabPageLoaiphong.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoaiphong)).EndInit();
            this.tabPageDSPhong.ResumeLayout(false);
            this.pnlSodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).EndInit();
            this.tabControlPhong.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBanggia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlChuthich;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TabPage tabPageLoaiphong;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dtgLoaiphong;
        private System.Windows.Forms.TabPage tabPageDSPhong;
        private System.Windows.Forms.Panel pnlSodo;
        private System.Windows.Forms.DataGridView dtgPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaP_LP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.TabControl tabControlPhong;
        private System.Windows.Forms.TabPage tabPageBanggia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgBanggia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoiToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giatien;
    }
}

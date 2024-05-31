namespace QUANLYKHACHSAN.User_Control
{
    partial class UserControlKhachhang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControlPhong = new System.Windows.Forms.TabControl();
            this.tabPageQuanlyKH = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgKhachhang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD_Passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gboxTienich = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.btnXemDSDangthue = new System.Windows.Forms.Button();
            this.btnDSDattruoc = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gboxTimkiem = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.tabPageQuanlyLoaiKH = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThemLoaiKH = new System.Windows.Forms.Button();
            this.btnCapnhatKH = new System.Windows.Forms.Button();
            this.btnXoaLoaiKH = new System.Windows.Forms.Button();
            this.dtgLoaiKH = new System.Windows.Forms.DataGridView();
            this.LoaiKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlPhong.SuspendLayout();
            this.tabPageQuanlyKH.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gboxTienich.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gboxTimkiem.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPageQuanlyLoaiKH.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoaiKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnReload);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(37, 389);
            this.panel4.TabIndex = 46;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Image = global::QUANLYKHACHSAN.Properties.Resources.reload;
            this.btnReload.Location = new System.Drawing.Point(12, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(25, 25);
            this.btnReload.TabIndex = 0;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 16);
            this.panel3.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(0, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 36);
            this.label3.TabIndex = 29;
            this.label3.Text = "  Quản lý khách hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 40);
            this.panel1.TabIndex = 44;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // tabControlPhong
            // 
            this.tabControlPhong.Controls.Add(this.tabPageQuanlyKH);
            this.tabControlPhong.Controls.Add(this.tabPageQuanlyLoaiKH);
            this.tabControlPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPhong.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPhong.Location = new System.Drawing.Point(37, 56);
            this.tabControlPhong.Multiline = true;
            this.tabControlPhong.Name = "tabControlPhong";
            this.tabControlPhong.SelectedIndex = 0;
            this.tabControlPhong.Size = new System.Drawing.Size(680, 389);
            this.tabControlPhong.TabIndex = 51;
            // 
            // tabPageQuanlyKH
            // 
            this.tabPageQuanlyKH.Controls.Add(this.tableLayoutPanel2);
            this.tabPageQuanlyKH.Location = new System.Drawing.Point(4, 27);
            this.tabPageQuanlyKH.Name = "tabPageQuanlyKH";
            this.tabPageQuanlyKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuanlyKH.Size = new System.Drawing.Size(672, 358);
            this.tabPageQuanlyKH.TabIndex = 0;
            this.tabPageQuanlyKH.Text = "Quản lý khách hàng";
            this.tabPageQuanlyKH.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.dtgKhachhang, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(666, 352);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dtgKhachhang
            // 
            this.dtgKhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgKhachhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgKhachhang.ColumnHeadersHeight = 56;
            this.dtgKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgKhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.SDT,
            this.QuocTich,
            this.CCCD_Passport,
            this.LoaiKH});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgKhachhang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgKhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgKhachhang.Location = new System.Drawing.Point(202, 3);
            this.dtgKhachhang.Name = "dtgKhachhang";
            this.dtgKhachhang.RowHeadersWidth = 40;
            this.dtgKhachhang.Size = new System.Drawing.Size(461, 346);
            this.dtgKhachhang.TabIndex = 45;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.FillWeight = 500F;
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.FillWeight = 550F;
            this.TenKH.HeaderText = "Họ tên KH";
            this.TenKH.MinimumWidth = 8;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.FillWeight = 350F;
            this.SDT.HeaderText = "Điện thoại";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // QuocTich
            // 
            this.QuocTich.DataPropertyName = "QuocTich";
            this.QuocTich.FillWeight = 350F;
            this.QuocTich.HeaderText = "Quốc tịch";
            this.QuocTich.MinimumWidth = 8;
            this.QuocTich.Name = "QuocTich";
            this.QuocTich.ReadOnly = true;
            // 
            // CCCD_Passport
            // 
            this.CCCD_Passport.DataPropertyName = "CCCD_Passport";
            this.CCCD_Passport.FillWeight = 550F;
            this.CCCD_Passport.HeaderText = "CCCD/Passport";
            this.CCCD_Passport.MinimumWidth = 8;
            this.CCCD_Passport.Name = "CCCD_Passport";
            this.CCCD_Passport.ReadOnly = true;
            // 
            // LoaiKH
            // 
            this.LoaiKH.DataPropertyName = "TenLoaiKH";
            this.LoaiKH.FillWeight = 400F;
            this.LoaiKH.HeaderText = "Loại khách hàng";
            this.LoaiKH.MinimumWidth = 8;
            this.LoaiKH.Name = "LoaiKH";
            this.LoaiKH.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gboxTienich);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gboxTimkiem);
            this.splitContainer1.Size = new System.Drawing.Size(160, 346);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 46;
            // 
            // gboxTienich
            // 
            this.gboxTienich.Controls.Add(this.tableLayoutPanel3);
            this.gboxTienich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxTienich.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxTienich.ForeColor = System.Drawing.Color.DarkCyan;
            this.gboxTienich.Location = new System.Drawing.Point(0, 0);
            this.gboxTienich.Name = "gboxTienich";
            this.gboxTienich.Size = new System.Drawing.Size(160, 217);
            this.gboxTienich.TabIndex = 46;
            this.gboxTienich.TabStop = false;
            this.gboxTienich.Text = "Tiện ích";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnXemDS, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnXemDSDangthue, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnDSDattruoc, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnTimkiem, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnCapnhat, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.btnXoa, 0, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(154, 182);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnXemDS
            // 
            this.btnXemDS.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXemDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXemDS.FlatAppearance.BorderSize = 0;
            this.btnXemDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDS.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDS.ForeColor = System.Drawing.Color.White;
            this.btnXemDS.Location = new System.Drawing.Point(3, 13);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(148, 17);
            this.btnXemDS.TabIndex = 3;
            this.btnXemDS.Text = "Danh sách khách hàng";
            this.btnXemDS.UseVisualStyleBackColor = false;
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // btnXemDSDangthue
            // 
            this.btnXemDSDangthue.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXemDSDangthue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXemDSDangthue.FlatAppearance.BorderSize = 0;
            this.btnXemDSDangthue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDSDangthue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDSDangthue.ForeColor = System.Drawing.Color.White;
            this.btnXemDSDangthue.Location = new System.Drawing.Point(3, 36);
            this.btnXemDSDangthue.Name = "btnXemDSDangthue";
            this.btnXemDSDangthue.Size = new System.Drawing.Size(148, 17);
            this.btnXemDSDangthue.TabIndex = 4;
            this.btnXemDSDangthue.Text = "Danh sách đang thuê";
            this.btnXemDSDangthue.UseVisualStyleBackColor = false;
            this.btnXemDSDangthue.Click += new System.EventHandler(this.btnXemDSDangthue_Click);
            // 
            // btnDSDattruoc
            // 
            this.btnDSDattruoc.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDSDattruoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDSDattruoc.FlatAppearance.BorderSize = 0;
            this.btnDSDattruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSDattruoc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSDattruoc.ForeColor = System.Drawing.Color.White;
            this.btnDSDattruoc.Location = new System.Drawing.Point(3, 59);
            this.btnDSDattruoc.Name = "btnDSDattruoc";
            this.btnDSDattruoc.Size = new System.Drawing.Size(148, 17);
            this.btnDSDattruoc.TabIndex = 5;
            this.btnDSDattruoc.Text = "Danh sách đặt trước";
            this.btnDSDattruoc.UseVisualStyleBackColor = false;
            this.btnDSDattruoc.Click += new System.EventHandler(this.btnDSDattruoc_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.Location = new System.Drawing.Point(3, 82);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(148, 17);
            this.btnTimkiem.TabIndex = 6;
            this.btnTimkiem.Text = "Tìm kiếm thông tin";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCapnhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCapnhat.FlatAppearance.BorderSize = 0;
            this.btnCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapnhat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.White;
            this.btnCapnhat.Location = new System.Drawing.Point(3, 105);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(148, 17);
            this.btnCapnhat.TabIndex = 7;
            this.btnCapnhat.Text = "Cập nhật thông tin ";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(3, 128);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(148, 17);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa khỏi danh sách";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gboxTimkiem
            // 
            this.gboxTimkiem.Controls.Add(this.tableLayoutPanel5);
            this.gboxTimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxTimkiem.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxTimkiem.ForeColor = System.Drawing.Color.DarkCyan;
            this.gboxTimkiem.Location = new System.Drawing.Point(0, 0);
            this.gboxTimkiem.Name = "gboxTimkiem";
            this.gboxTimkiem.Size = new System.Drawing.Size(160, 125);
            this.gboxTimkiem.TabIndex = 46;
            this.gboxTimkiem.TabStop = false;
            this.gboxTimkiem.Text = "Nhập thông tin";
            this.gboxTimkiem.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.txtTimkiem, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 7;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(154, 90);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimkiem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(3, 13);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(148, 30);
            this.txtTimkiem.TabIndex = 9;
            this.txtTimkiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimkiem_KeyUp);
            // 
            // tabPageQuanlyLoaiKH
            // 
            this.tabPageQuanlyLoaiKH.Controls.Add(this.tableLayoutPanel1);
            this.tabPageQuanlyLoaiKH.Location = new System.Drawing.Point(4, 27);
            this.tabPageQuanlyLoaiKH.Name = "tabPageQuanlyLoaiKH";
            this.tabPageQuanlyLoaiKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuanlyLoaiKH.Size = new System.Drawing.Size(672, 358);
            this.tabPageQuanlyLoaiKH.TabIndex = 1;
            this.tabPageQuanlyLoaiKH.Text = "Phân loại khách hàng";
            this.tabPageQuanlyLoaiKH.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtgLoaiKH, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 352);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 346);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiện ích";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnThemLoaiKH, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnCapnhatKH, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnXoaLoaiKH, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 15;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(154, 311);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnThemLoaiKH
            // 
            this.btnThemLoaiKH.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThemLoaiKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemLoaiKH.FlatAppearance.BorderSize = 0;
            this.btnThemLoaiKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoaiKH.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiKH.ForeColor = System.Drawing.Color.White;
            this.btnThemLoaiKH.Location = new System.Drawing.Point(3, 13);
            this.btnThemLoaiKH.Name = "btnThemLoaiKH";
            this.btnThemLoaiKH.Size = new System.Drawing.Size(148, 16);
            this.btnThemLoaiKH.TabIndex = 3;
            this.btnThemLoaiKH.Text = "Thêm loại khách hàng";
            this.btnThemLoaiKH.UseVisualStyleBackColor = false;
            this.btnThemLoaiKH.Click += new System.EventHandler(this.btnThemLoaiKH_Click);
            // 
            // btnCapnhatKH
            // 
            this.btnCapnhatKH.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCapnhatKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCapnhatKH.FlatAppearance.BorderSize = 0;
            this.btnCapnhatKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapnhatKH.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhatKH.ForeColor = System.Drawing.Color.White;
            this.btnCapnhatKH.Location = new System.Drawing.Point(3, 35);
            this.btnCapnhatKH.Name = "btnCapnhatKH";
            this.btnCapnhatKH.Size = new System.Drawing.Size(148, 16);
            this.btnCapnhatKH.TabIndex = 4;
            this.btnCapnhatKH.Text = "Cập nhật thông tin";
            this.btnCapnhatKH.UseVisualStyleBackColor = false;
            this.btnCapnhatKH.Click += new System.EventHandler(this.btnCapnhatKH_Click);
            // 
            // btnXoaLoaiKH
            // 
            this.btnXoaLoaiKH.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXoaLoaiKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaLoaiKH.FlatAppearance.BorderSize = 0;
            this.btnXoaLoaiKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLoaiKH.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiKH.ForeColor = System.Drawing.Color.White;
            this.btnXoaLoaiKH.Location = new System.Drawing.Point(3, 57);
            this.btnXoaLoaiKH.Name = "btnXoaLoaiKH";
            this.btnXoaLoaiKH.Size = new System.Drawing.Size(148, 16);
            this.btnXoaLoaiKH.TabIndex = 5;
            this.btnXoaLoaiKH.Text = "Xóa khỏi danh sách";
            this.btnXoaLoaiKH.UseVisualStyleBackColor = false;
            this.btnXoaLoaiKH.Click += new System.EventHandler(this.btnXoaLoaiKH_Click);
            // 
            // dtgLoaiKH
            // 
            this.dtgLoaiKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgLoaiKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgLoaiKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgLoaiKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLoaiKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiKhachHang,
            this.TenLoaiKH});
            this.dtgLoaiKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLoaiKH.Location = new System.Drawing.Point(202, 3);
            this.dtgLoaiKH.Name = "dtgLoaiKH";
            this.dtgLoaiKH.RowHeadersWidth = 62;
            this.dtgLoaiKH.Size = new System.Drawing.Size(461, 346);
            this.dtgLoaiKH.TabIndex = 47;
            // 
            // LoaiKhachHang
            // 
            this.LoaiKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiKhachHang.DataPropertyName = "LoaiKH";
            this.LoaiKhachHang.FillWeight = 200F;
            this.LoaiKhachHang.HeaderText = "Loại khách hàng";
            this.LoaiKhachHang.MinimumWidth = 8;
            this.LoaiKhachHang.Name = "LoaiKhachHang";
            // 
            // TenLoaiKH
            // 
            this.TenLoaiKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiKH.DataPropertyName = "TenLoaiKH";
            this.TenLoaiKH.FillWeight = 300F;
            this.TenLoaiKH.HeaderText = "Tên loại khách hàng";
            this.TenLoaiKH.MinimumWidth = 8;
            this.TenLoaiKH.Name = "TenLoaiKH";
            // 
            // UserControlKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlPhong);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlKhachhang";
            this.Size = new System.Drawing.Size(717, 445);
            this.Load += new System.EventHandler(this.UserControlKhachhang_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlPhong.ResumeLayout(false);
            this.tabPageQuanlyKH.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachhang)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gboxTienich.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.gboxTimkiem.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPageQuanlyLoaiKH.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoaiKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabControl tabControlPhong;
        private System.Windows.Forms.TabPage tabPageQuanlyKH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dtgKhachhang;
        private System.Windows.Forms.TabPage tabPageQuanlyLoaiKH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnThemLoaiKH;
        private System.Windows.Forms.Button btnCapnhatKH;
        private System.Windows.Forms.Button btnXoaLoaiKH;
        private System.Windows.Forms.DataGridView dtgLoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiKH;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gboxTienich;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.Button btnXemDSDangthue;
        private System.Windows.Forms.Button btnDSDattruoc;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox gboxTimkiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD_Passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKH;
    }
}

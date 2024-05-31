namespace QUANLYKHACHSAN.User_Form
{
    partial class frmChucVu
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
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.macv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNCC = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaCV = new System.Windows.Forms.Label();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.gbNCC.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.AllowUserToAddRows = false;
            this.dgvChucVu.AllowUserToDeleteRows = false;
            this.dgvChucVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChucVu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChucVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChucVu.ColumnHeadersHeight = 30;
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macv,
            this.tencv});
            this.dgvChucVu.Location = new System.Drawing.Point(8, 37);
            this.dgvChucVu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.RowHeadersVisible = false;
            this.dgvChucVu.RowHeadersWidth = 43;
            this.dgvChucVu.Size = new System.Drawing.Size(336, 289);
            this.dgvChucVu.TabIndex = 0;
            this.dgvChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellContentClick);
            this.dgvChucVu.DoubleClick += new System.EventHandler(this.dgvChucVu_DoubleClick);
            // 
            // macv
            // 
            this.macv.DataPropertyName = "MaCV";
            this.macv.HeaderText = "Mã chức vụ";
            this.macv.MinimumWidth = 6;
            this.macv.Name = "macv";
            this.macv.Width = 105;
            // 
            // tencv
            // 
            this.tencv.DataPropertyName = "TenCV";
            this.tencv.HeaderText = "Tên chức vụ";
            this.tencv.MinimumWidth = 6;
            this.tencv.Name = "tencv";
            this.tencv.Width = 200;
            // 
            // gbNCC
            // 
            this.gbNCC.BackColor = System.Drawing.Color.DarkCyan;
            this.gbNCC.Controls.Add(this.btnXoa);
            this.gbNCC.Controls.Add(this.btnSua);
            this.gbNCC.Controls.Add(this.btnThem);
            this.gbNCC.Controls.Add(this.dgvChucVu);
            this.gbNCC.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gbNCC.Location = new System.Drawing.Point(21, 181);
            this.gbNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNCC.Name = "gbNCC";
            this.gbNCC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNCC.Size = new System.Drawing.Size(564, 338);
            this.gbNCC.TabIndex = 1;
            this.gbNCC.TabStop = false;
            this.gbNCC.Text = "Danh sách chức vụ ";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(367, 173);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(183, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(367, 105);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(183, 40);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(367, 38);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(183, 40);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTaiLai.Location = new System.Drawing.Point(369, 81);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(183, 40);
            this.btnTaiLai.TabIndex = 1;
            this.btnTaiLai.Text = "Load";
            this.btnTaiLai.UseVisualStyleBackColor = false;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // gbThongTin
            // 
            this.gbThongTin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.lbMaCV);
            this.gbThongTin.Controls.Add(this.txtTenCV);
            this.gbThongTin.Controls.Add(this.btnTaiLai);
            this.gbThongTin.Controls.Add(this.txtMaCV);
            this.gbThongTin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gbThongTin.Location = new System.Drawing.Point(19, 21);
            this.gbThongTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbThongTin.Size = new System.Drawing.Size(566, 150);
            this.gbThongTin.TabIndex = 2;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên chức vụ:";
            // 
            // lbMaCV
            // 
            this.lbMaCV.AutoSize = true;
            this.lbMaCV.Location = new System.Drawing.Point(41, 44);
            this.lbMaCV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaCV.Name = "lbMaCV";
            this.lbMaCV.Size = new System.Drawing.Size(127, 28);
            this.lbMaCV.TabIndex = 3;
            this.lbMaCV.Text = "Mã chức vụ:";
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(193, 96);
            this.txtTenCV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(153, 34);
            this.txtTenCV.TabIndex = 1;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(193, 38);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(153, 34);
            this.txtMaCV.TabIndex = 0;
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 525);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.gbNCC);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChucVu";
            this.Text = "frmChucVu";
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.gbNCC.ResumeLayout(false);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.GroupBox gbNCC;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn macv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencv;
    }
}
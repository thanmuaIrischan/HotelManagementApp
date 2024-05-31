namespace QUANLYKHACHSAN.User_Form
{
    partial class ThongtinP_TB
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
            this.gboxPhong_ThietBi = new System.Windows.Forms.GroupBox();
            this.cbbMaTB = new System.Windows.Forms.ComboBox();
            this.cbbMaLoaiTB = new System.Windows.Forms.ComboBox();
            this.cbbTenLoaiTB = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaphong = new System.Windows.Forms.Label();
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.gboxPhong_ThietBi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxPhong_ThietBi
            // 
            this.gboxPhong_ThietBi.Controls.Add(this.cbbMaPhong);
            this.gboxPhong_ThietBi.Controls.Add(this.cbbMaTB);
            this.gboxPhong_ThietBi.Controls.Add(this.cbbMaLoaiTB);
            this.gboxPhong_ThietBi.Controls.Add(this.cbbTenLoaiTB);
            this.gboxPhong_ThietBi.Controls.Add(this.btnHuy);
            this.gboxPhong_ThietBi.Controls.Add(this.btnCapNhat);
            this.gboxPhong_ThietBi.Controls.Add(this.btnThem);
            this.gboxPhong_ThietBi.Controls.Add(this.label1);
            this.gboxPhong_ThietBi.Controls.Add(this.label24);
            this.gboxPhong_ThietBi.Controls.Add(this.label25);
            this.gboxPhong_ThietBi.Controls.Add(this.txtGiatien);
            this.gboxPhong_ThietBi.Controls.Add(this.label5);
            this.gboxPhong_ThietBi.Controls.Add(this.lblMaphong);
            this.gboxPhong_ThietBi.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPhong_ThietBi.ForeColor = System.Drawing.Color.DarkCyan;
            this.gboxPhong_ThietBi.Location = new System.Drawing.Point(22, 19);
            this.gboxPhong_ThietBi.Name = "gboxPhong_ThietBi";
            this.gboxPhong_ThietBi.Size = new System.Drawing.Size(308, 250);
            this.gboxPhong_ThietBi.TabIndex = 17;
            this.gboxPhong_ThietBi.TabStop = false;
            this.gboxPhong_ThietBi.Text = "Quản lý thiết bị - phòng";
            // 
            // cbbMaTB
            // 
            this.cbbMaTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaTB.FormattingEnabled = true;
            this.cbbMaTB.Location = new System.Drawing.Point(121, 66);
            this.cbbMaTB.Name = "cbbMaTB";
            this.cbbMaTB.Size = new System.Drawing.Size(174, 24);
            this.cbbMaTB.TabIndex = 29;
            this.cbbMaTB.SelectedIndexChanged += new System.EventHandler(this.cbbMaTB_SelectedIndexChanged);
            // 
            // cbbMaLoaiTB
            // 
            this.cbbMaLoaiTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaLoaiTB.FormattingEnabled = true;
            this.cbbMaLoaiTB.Location = new System.Drawing.Point(121, 96);
            this.cbbMaLoaiTB.Name = "cbbMaLoaiTB";
            this.cbbMaLoaiTB.Size = new System.Drawing.Size(174, 24);
            this.cbbMaLoaiTB.TabIndex = 29;
            // 
            // cbbTenLoaiTB
            // 
            this.cbbTenLoaiTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenLoaiTB.FormattingEnabled = true;
            this.cbbTenLoaiTB.Location = new System.Drawing.Point(122, 126);
            this.cbbTenLoaiTB.Name = "cbbTenLoaiTB";
            this.cbbTenLoaiTB.Size = new System.Drawing.Size(173, 24);
            this.cbbTenLoaiTB.TabIndex = 29;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.BackColor = System.Drawing.Color.Firebrick;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(42, 204);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 24);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCapNhat.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(210, 204);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 24);
            this.btnCapNhat.TabIndex = 15;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(124, 204);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 24);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại thiết bị:";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(11, 130);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 14);
            this.label24.TabIndex = 0;
            this.label24.Text = "Tên thiết bị:";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(11, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 14);
            this.label25.TabIndex = 0;
            this.label25.Text = "Mã thiết bị:";
            // 
            // txtGiatien
            // 
            this.txtGiatien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGiatien.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiatien.Location = new System.Drawing.Point(122, 156);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(173, 23);
            this.txtGiatien.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá tiền:";
            // 
            // lblMaphong
            // 
            this.lblMaphong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaphong.AutoSize = true;
            this.lblMaphong.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaphong.Location = new System.Drawing.Point(11, 39);
            this.lblMaphong.Name = "lblMaphong";
            this.lblMaphong.Size = new System.Drawing.Size(74, 14);
            this.lblMaphong.TabIndex = 0;
            this.lblMaphong.Text = "Mã phòng:";
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(121, 35);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(174, 24);
            this.cbbMaPhong.TabIndex = 29;
            this.cbbMaPhong.SelectedIndexChanged += new System.EventHandler(this.cbbMaTB_SelectedIndexChanged);
            // 
            // ThongtinP_TB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 288);
            this.Controls.Add(this.gboxPhong_ThietBi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongtinP_TB";
            this.Text = "ThongtinP_TB";
            this.Load += new System.EventHandler(this.ThongtinP_TB_Load);
            this.gboxPhong_ThietBi.ResumeLayout(false);
            this.gboxPhong_ThietBi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxPhong_ThietBi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtGiatien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaphong;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbbMaTB;
        private System.Windows.Forms.ComboBox cbbMaLoaiTB;
        private System.Windows.Forms.ComboBox cbbTenLoaiTB;
        private System.Windows.Forms.ComboBox cbbMaPhong;
    }
}
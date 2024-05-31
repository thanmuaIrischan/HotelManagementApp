namespace QUANLYKHACHSAN.User_Form
{
    partial class LoaiPhong
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbDienTTLoaiphong = new System.Windows.Forms.GroupBox();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.txtGiaphong = new System.Windows.Forms.TextBox();
            this.txtTenLP = new System.Windows.Forms.TextBox();
            this.txtMaLP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.numSonguoitoida = new System.Windows.Forms.NumericUpDown();
            this.label65 = new System.Windows.Forms.Label();
            this.numSoluongphong = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbDienTTLoaiphong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSonguoitoida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluongphong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 49);
            this.panel1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 36);
            this.label3.TabIndex = 29;
            this.label3.Text = "  Loại phòng";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 4);
            this.panel5.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 385);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 58);
            this.panel3.TabIndex = 33;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(159, 15);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 30);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.BackColor = System.Drawing.Color.Firebrick;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(273, 15);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 30);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 17);
            this.panel2.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gbDienTTLoaiphong);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 66);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 319);
            this.panel4.TabIndex = 35;
            // 
            // gbDienTTLoaiphong
            // 
            this.gbDienTTLoaiphong.Controls.Add(this.lblSoluong);
            this.gbDienTTLoaiphong.Controls.Add(this.txtGiaphong);
            this.gbDienTTLoaiphong.Controls.Add(this.txtTenLP);
            this.gbDienTTLoaiphong.Controls.Add(this.txtMaLP);
            this.gbDienTTLoaiphong.Controls.Add(this.label1);
            this.gbDienTTLoaiphong.Controls.Add(this.label66);
            this.gbDienTTLoaiphong.Controls.Add(this.label62);
            this.gbDienTTLoaiphong.Controls.Add(this.numSonguoitoida);
            this.gbDienTTLoaiphong.Controls.Add(this.label65);
            this.gbDienTTLoaiphong.Controls.Add(this.numSoluongphong);
            this.gbDienTTLoaiphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDienTTLoaiphong.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDienTTLoaiphong.ForeColor = System.Drawing.Color.DarkCyan;
            this.gbDienTTLoaiphong.Location = new System.Drawing.Point(0, 0);
            this.gbDienTTLoaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.gbDienTTLoaiphong.Name = "gbDienTTLoaiphong";
            this.gbDienTTLoaiphong.Padding = new System.Windows.Forms.Padding(4);
            this.gbDienTTLoaiphong.Size = new System.Drawing.Size(400, 319);
            this.gbDienTTLoaiphong.TabIndex = 28;
            this.gbDienTTLoaiphong.TabStop = false;
            this.gbDienTTLoaiphong.Text = "Điền thông tin";
            // 
            // lblSoluong
            // 
            this.lblSoluong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.Location = new System.Drawing.Point(49, 201);
            this.lblSoluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(90, 18);
            this.lblSoluong.TabIndex = 26;
            this.lblSoluong.Text = "Giá phòng:";
            // 
            // txtGiaphong
            // 
            this.txtGiaphong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGiaphong.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaphong.Location = new System.Drawing.Point(51, 220);
            this.txtGiaphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaphong.Name = "txtGiaphong";
            this.txtGiaphong.Size = new System.Drawing.Size(300, 26);
            this.txtGiaphong.TabIndex = 2;
            // 
            // txtTenLP
            // 
            this.txtTenLP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenLP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLP.Location = new System.Drawing.Point(51, 111);
            this.txtTenLP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLP.Name = "txtTenLP";
            this.txtTenLP.Size = new System.Drawing.Size(300, 26);
            this.txtTenLP.TabIndex = 2;
            // 
            // txtMaLP
            // 
            this.txtMaLP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaLP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLP.Location = new System.Drawing.Point(51, 55);
            this.txtMaLP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLP.Name = "txtMaLP";
            this.txtMaLP.Size = new System.Drawing.Size(300, 26);
            this.txtMaLP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số người tối đa:";
            // 
            // label66
            // 
            this.label66.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(47, 146);
            this.label66.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(132, 18);
            this.label66.TabIndex = 0;
            this.label66.Text = "Số lượng phòng:";
            // 
            // label62
            // 
            this.label62.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(47, 34);
            this.label62.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(118, 18);
            this.label62.TabIndex = 0;
            this.label62.Text = "Mã loại phòng:";
            // 
            // numSonguoitoida
            // 
            this.numSonguoitoida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSonguoitoida.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSonguoitoida.Location = new System.Drawing.Point(51, 272);
            this.numSonguoitoida.Margin = new System.Windows.Forms.Padding(4);
            this.numSonguoitoida.Name = "numSonguoitoida";
            this.numSonguoitoida.Size = new System.Drawing.Size(301, 27);
            this.numSonguoitoida.TabIndex = 27;
            // 
            // label65
            // 
            this.label65.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(47, 90);
            this.label65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(123, 18);
            this.label65.TabIndex = 0;
            this.label65.Text = "Tên loại phòng:";
            // 
            // numSoluongphong
            // 
            this.numSoluongphong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSoluongphong.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoluongphong.Location = new System.Drawing.Point(51, 167);
            this.numSoluongphong.Margin = new System.Windows.Forms.Padding(4);
            this.numSoluongphong.Name = "numSoluongphong";
            this.numSoluongphong.Size = new System.Drawing.Size(301, 27);
            this.numSoluongphong.TabIndex = 27;
            // 
            // LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 443);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoaiPhong";
            this.Text = "LoaiPhong";
            this.Load += new System.EventHandler(this.LoaiPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gbDienTTLoaiphong.ResumeLayout(false);
            this.gbDienTTLoaiphong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSonguoitoida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluongphong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gbDienTTLoaiphong;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.TextBox txtGiaphong;
        private System.Windows.Forms.TextBox txtTenLP;
        private System.Windows.Forms.TextBox txtMaLP;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.NumericUpDown numSoluongphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSonguoitoida;
    }
}
namespace QUANLYKHACHSAN.User_Form
{
    partial class ThongtinLoaiKH
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
            this.gboxThongtinLoaiKH = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtLoaiKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtTenLoaiKH = new System.Windows.Forms.TextBox();
            this.gboxThongtinLoaiKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxThongtinLoaiKH
            // 
            this.gboxThongtinLoaiKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboxThongtinLoaiKH.Controls.Add(this.txtTenLoaiKH);
            this.gboxThongtinLoaiKH.Controls.Add(this.btnHuy);
            this.gboxThongtinLoaiKH.Controls.Add(this.btnLuu);
            this.gboxThongtinLoaiKH.Controls.Add(this.txtLoaiKH);
            this.gboxThongtinLoaiKH.Controls.Add(this.label1);
            this.gboxThongtinLoaiKH.Controls.Add(this.label26);
            this.gboxThongtinLoaiKH.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxThongtinLoaiKH.ForeColor = System.Drawing.Color.DarkCyan;
            this.gboxThongtinLoaiKH.Location = new System.Drawing.Point(21, 18);
            this.gboxThongtinLoaiKH.Name = "gboxThongtinLoaiKH";
            this.gboxThongtinLoaiKH.Size = new System.Drawing.Size(392, 171);
            this.gboxThongtinLoaiKH.TabIndex = 10;
            this.gboxThongtinLoaiKH.TabStop = false;
            this.gboxThongtinLoaiKH.Text = "Thông tin loại khách hàng";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.BackColor = System.Drawing.Color.Firebrick;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(156, 119);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 24);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(242, 119);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 24);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtLoaiKH
            // 
            this.txtLoaiKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoaiKH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiKH.Location = new System.Drawing.Point(121, 34);
            this.txtLoaiKH.Name = "txtLoaiKH";
            this.txtLoaiKH.Size = new System.Drawing.Size(224, 22);
            this.txtLoaiKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại KH:";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(35, 75);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 14);
            this.label26.TabIndex = 0;
            this.label26.Text = "Tên loại KH:";
            // 
            // txtTenLoaiKH
            // 
            this.txtTenLoaiKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenLoaiKH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiKH.Location = new System.Drawing.Point(121, 70);
            this.txtTenLoaiKH.Name = "txtTenLoaiKH";
            this.txtTenLoaiKH.Size = new System.Drawing.Size(224, 22);
            this.txtTenLoaiKH.TabIndex = 28;
            // 
            // ThongtinLoaiKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 209);
            this.Controls.Add(this.gboxThongtinLoaiKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongtinLoaiKH";
            this.Text = "ThongtinLoaiKH";
            this.Load += new System.EventHandler(this.ThongtinLoaiKH_Load);
            this.gboxThongtinLoaiKH.ResumeLayout(false);
            this.gboxThongtinLoaiKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxThongtinLoaiKH;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtLoaiKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtTenLoaiKH;
    }
}
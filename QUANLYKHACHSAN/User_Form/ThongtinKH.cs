using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYKHACHSAN.BS_Layer;

namespace QUANLYKHACHSAN.User_Form
{
    public partial class ThongtinKH : Form
    {
        BLKhachHang blKH = new BLKhachHang();
        public string MaKH;

        public ThongtinKH()
        {
            InitializeComponent();
        }

        void LoadComboBox()
        {
            try
            {
                this.cbbLoaiKH.DataSource = blKH.LayDanhSachLoaiKH();
                this.cbbLoaiKH.DisplayMember = "TenLoaiKH";
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table LOAIKHACHHANG. Lỗi!!!");
            }
        }

        private void ThongtinKH_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            DataTable dtThongtinKH = blKH.LayThongTinKH(MaKH);

            this.txtMaKH.Text = dtThongtinKH.Rows[0]["MaKH"].ToString();
            this.txtHoten.Text = dtThongtinKH.Rows[0]["TenKH"].ToString();
            this.txtDienthoai.Text = dtThongtinKH.Rows[0]["SDT"].ToString();
            this.txtSoCCCD.Text = dtThongtinKH.Rows[0]["CCCD_Passport"].ToString();
            this.cbbQuoctich.Text = dtThongtinKH.Rows[0]["QuocTich"].ToString();
            this.cbbLoaiKH.Text = dtThongtinKH.Rows[0]["TenLoaiKH"].ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                BLKhachHang blKH = new BLKhachHang();
                blKH.CapnhatKH(txtMaKH.Text, txtHoten.Text, txtDienthoai.Text, cbbQuoctich.Text, txtSoCCCD.Text, cbbLoaiKH.Text);
                /*if (update)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                } 
                */
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ! - Thông tin lỗi :" + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QUANLYKHACHSAN.BS_Layer;

namespace QUANLYKHACHSAN.User_Form
{
    public partial class SuaDatPhong : Form
    {
        public SuaDatPhong()
        {
            InitializeComponent();
        }
        BLPhong dbPhong = new BLPhong();
        DataTable dtPhong = null;
        public string Makh = "";
        void Clear()
        {
          
        }

        void LoadCombobox1()
        {

        }

        void LoadCbbLoaiphong()
        {
           
        }
        void LoadCbbMaphong()
        {
            
        }
        public void LayThongTinPhong(string MaKH)
        {
            dtPhong = new DataTable();
            dtPhong.Clear();
            dtPhong = dbPhong.LayThongTinSuaPhong(MaKH);
            if (dtPhong.Rows.Count > 0)
            {
                var row = dtPhong.Rows[0];
                this.txtMaKH.Text = MaKH;
                this.txtHoten.Text = row["TenKH"].ToString();
                this.cbbQuoctich.Text = row["QuocTich"].ToString();
                this.txtSoCCCD.Text = row["CCCD_Passport"].ToString();
                this.txtDienthoai.Text = row["SDT"].ToString();
                this.txtLoaiKH.Text = row["TenLoaiKH"].ToString();
                this.numSoluongPhong.Value = int.Parse(row["SoLuongPhong"].ToString());
                this.cbbLoaiphong.Text = row["TenLoaiPhong"].ToString();
                this.cbbMaphong.Text = row["MaPhong"].ToString();
                this.txtGiaphong.Text = row["GiaPhong"].ToString();
                this.dtpNgaydatphong.Value = DateTime.Parse(row["NgayDatPhong"].ToString());
                this.dtpNgayden.Value = DateTime.Parse(row["Ngayden"].ToString());
                this.dtpNgaydi.Value = DateTime.Parse(row["Ngaydi"].ToString());
                this.numSonguoio.Value = int.Parse(row["SoNguoiO"].ToString());
                this.txtTratruoc.Text = row["TraTruoc"].ToString();
                this.txtGhichu.Text = row["GhiChu"].ToString();
            }
        }
        private void SuaDatPhong_Load(object sender, EventArgs e)
        {
            LayThongTinPhong(Makh);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                dbPhong.CapnhatDanhSachDatPhongTruoc(txtMaKH.Text, txtHoten.Text,
                                                     cbbQuoctich.Text,
                                                     txtSoCCCD.Text,
                                                     txtDienthoai.Text,
                                                     dbPhong.LayMaKH(txtLoaiKH.Text),
                                                     dtpNgaydatphong.Value,
                                                     int.Parse(numSoluongPhong.Value.ToString()),
                                                     cbbMaphong.Text,
                                                     dtpNgayden.Value,
                                                     dtpNgaydi.Value,
                                                     int.Parse(numSonguoio.Value.ToString()),
                                                     float.Parse(txtTratruoc.Text),
                                                     float.Parse(txtGiaphong.Text),
                                                     txtGhichu.Text
                                                       );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Thông tin: " + ex.Message);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbbHangphong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbbLoaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

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
    public partial class TraPhong : Form
    {
        public TraPhong()
        {
            InitializeComponent();
        }

        BLPhong dbPhong =  new BLPhong();
        public string MaPhong ;
        void LoadData()
        {
           
        }

        private void TraPhong_Load(object sender, EventArgs e)
        {           
            LayThongTinPhong(MaPhong);
        }
        public void LayThongTinPhong(string maphong)
        {
            DataTable dtBG = dbPhong.LayThongTinTraPhongKhachHang(maphong);
            dtgKhachhang.DataSource = dtBG;
            dtgKhachhang.AutoResizeColumns();

            DataTable dtPDK = dbPhong.LayThongTinTraPhongPhieuDangKy(maphong);
            dtgPhong.DataSource = dtPDK;
            dtgPhong.AutoResizeColumns();
            DataTable dtDV = dbPhong.LayThongTinTraPhongDichVu(maphong);
            dtgDichvu.DataSource = dtDV;
            dtgDichvu.AutoResizeColumns();

            DataTable dtPPS = dbPhong.LayThongTinTraPhongPhiPhatSinh(maphong);
            dtgThietbi.DataSource = dtPPS;
            dtgThietbi.AutoResizeColumns();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {

            HoaDon hoaDon = new HoaDon(MaPhong);
            hoaDon.Show();
            BLHoaDon dbhoadon = new BLHoaDon();
            dbhoadon.ThanhToan(MaPhong);
            dbhoadon.XoaKhachHang(MaPhong);
        }
    }
}

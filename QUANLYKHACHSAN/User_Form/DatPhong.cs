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
    public partial class DatPhong : Form
    {
        public DatPhong()
        {
            InitializeComponent();
        }
        BLPhong dbPhong = new BLPhong();
        DataTable dtPhong = null;
        string err;
        public string MaPhong;
        public string GiaPhong;
        public bool CapNhat = false;

        void LoadCbbLoaiKH()
        {
            BindingList<string> bindingList = new BindingList<string>(dbPhong.LayLoaiKhachHang());
            this.cbbTenLoaiKH.DataSource = bindingList;
        }

        void Clear()
        {
            this.txtHoten.Clear();
            this.txtDienthoai.Clear();
            this.cbbQuoctich.ResetText();
            this.txtSoCCCD.Clear();
            this.cbbTenLoaiKH.ResetText();
            this.numSoluongPhong.ResetText();
            this.cbbLoaiphong.ResetText();
            this.txtGiaphong.Clear();
            this.dtpNgaydatphong.Value = DateTime.Today;
            this.dtpNgayden.Value = DateTime.Today;
            this.dtpNgaydi.Value = DateTime.Today;
            this.numSonguoio.ResetText();
            this.txtGhichu.Clear();
            this.txtTratruoc.Clear();
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            dtPhong = new DataTable();
            dtPhong.Clear();
            this.cbbMaphong.Text = MaPhong;
            LayThongTinPhong(MaPhong);
            LoadCbbLoaiKH();
        }

        public void LayThongTinPhong(string maPhong)
        {
            dtPhong = new DataTable();
            dtPhong.Clear();
            dtPhong = dbPhong.LayLoaiPhong(maPhong);
            if (dtPhong.Rows.Count > 0)
            {
                var row = dtPhong.Rows[0];
                string MaPhong = row["MaPhong"].ToString();
                this.cbbLoaiphong.Text = row["TenLoaiPhong"].ToString();
                this.txtGiaphong.Text = row["Gia"].ToString();
                this.GiaPhong = row["Gia"].ToString();
            }
            this.numSoluongPhong.Value = 1;
        }
        private void btnNhanphong_Click(object sender, EventArgs e)
        {
            try
            {
                bool datruoc = dbPhong.NhanPhong(txtHoten.Text, cbbQuoctich.Text, txtSoCCCD.Text, txtDienthoai.Text, dbPhong.LayMaKH(cbbTenLoaiKH.Text), dtpNgaydatphong.Value,
                    Convert.ToInt32(numSoluongPhong.Value), cbbMaphong.Text, dtpNgayden.Value, dtpNgaydi.Value, Convert.ToInt32(numSonguoio.Value), float.Parse(txtTratruoc.Text), float.Parse(txtGiaphong.Text), txtGhichu.Text, ref err);
                if (datruoc)
                {
                    MessageBox.Show("Nhận Phòng Thành Công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nhận Phòng Thất Bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ! - thông tin lỗi :" + ex.Message);
            }
        }

        private void btnDattruoc_Click(object sender, EventArgs e)
        {
            try
            {
                bool datruoc = dbPhong.DatPhong(txtHoten.Text, cbbQuoctich.Text, txtSoCCCD.Text, txtDienthoai.Text, dbPhong.LayMaKH(cbbTenLoaiKH.Text), dtpNgaydatphong.Value,
                    Convert.ToInt32(numSoluongPhong.Value), cbbMaphong.Text, dtpNgayden.Value, dtpNgaydi.Value, Convert.ToInt32(numSonguoio.Value), float.Parse(txtTratruoc.Text), float.Parse(txtGiaphong.Text), txtGhichu.Text, ref err);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ! - thông tin lỗi :" + ex.Message);

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void HienThiGiaPhongTheoLoaiKH(string tenLoaiKH)
        {
            string maLoaiKH = dbPhong.LayMaKH(tenLoaiKH);
            float phanTram = dbPhong.PhamTramGiamGia(maLoaiKH);
            float giaPhong = float.Parse(this.GiaPhong);
            float giaSauGiam = giaPhong * phanTram;
            this.txtGiaphong.Text = giaSauGiam.ToString();
        }

        private void cbbTenLoaiKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenLoaiKH = cbbTenLoaiKH.SelectedItem.ToString();
            HienThiGiaPhongTheoLoaiKH(tenLoaiKH);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

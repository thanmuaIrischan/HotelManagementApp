using QUANLYKHACHSAN.BS_Layer;
using QUANLYKHACHSAN.User_Form;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUANLYKHACHSAN.User_Control
{
    public partial class UserControlDichvu : System.Windows.Forms.UserControl
    {
        public UserControlDichvu()
        {
            InitializeComponent();
        }

        BLDichVu dbDichvu = new BLDichVu();
        DataTable dtDV = null;
        string err;

        public void ClearDSDV()
        {
            this.cbbDSPhong.SelectedItem = null;
            this.cbbLoaiDV.SelectedItem = null;
            this.txtDonvitinh.Clear();
            this.txtGiaDV.Clear();
            this.numSoluong.ResetText();
            this.txtTongtien.Clear();
        }

        void LoadData()
        {
            dtDV = new DataTable();
            dtDV = dbDichvu.LayDanhSachDV();
            dtgDichvu.DataSource = dtDV;
            dtgDichvu.AutoResizeColumns();
        }

        void LoadDataHD(string MaPhong)
        {
            dtDV = new DataTable();
            dtDV = dbDichvu.LayDanhSachHD(MaPhong);
            dtgHoadonDV.DataSource = dtDV;
            dtgHoadonDV.AutoResizeColumns();
        }

        void LoadComboBox()
        {
            try
            {
                this.cbbLoaiDV.DataSource = dbDichvu.LayDanhSachDV();
                this.cbbLoaiDV.DisplayMember = "TenDichVu";

                this.cbbDSPhong.DataSource = dbDichvu.LayDanhSachPhongDKDV();
                this.cbbDSPhong.DisplayMember = "MaPhong";
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi!!!");
            }
        }

        private void UserControlDichvu_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            ClearDSDV();
            LoadData();

            this.btnXoaDangkyDV.Visible = false;
        }

        private void cbbLoaiDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnXoaDangkyDV.Visible = false;

            if (this.cbbLoaiDV.SelectedItem == null)
            {
                this.txtDonvitinh.Text = "";
                this.txtGiaDV.Text = "";
            }
            else
            {
                dtDV = new DataTable();
                dtDV = dbDichvu.LayDanhSachDV();
                this.txtDonvitinh.Text = dtDV.Rows[cbbLoaiDV.SelectedIndex]["DonViTinh"].ToString();
                this.txtGiaDV.Text = dtDV.Rows[cbbLoaiDV.SelectedIndex]["Gia"].ToString();
            }
        }

        private void numSoluong_ValueChanged(object sender, EventArgs e)
        {
            this.btnXoaDangkyDV.Visible = false;

            int giaDV = Convert.ToInt32(this.txtGiaDV.Text);
            int soLuong = Convert.ToInt32(this.numSoluong.Value);
            this.txtTongtien.Text = (giaDV * soLuong).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThongtinDV ttdv = new ThongtinDV();
            ttdv.Show();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (tabControlThietbi.SelectedTab == tabPageQuanlyDichvu)
            {
                int row = dtgDichvu.CurrentCell.RowIndex;
                ThongtinDV frmTTDichVu = new ThongtinDV();
                frmTTDichVu.Them = false;
                frmTTDichVu.MaDV = Convert.ToString(dtgDichvu.Rows[row].Cells[0].Value);
                frmTTDichVu.TenDV = Convert.ToString(dtgDichvu.Rows[row].Cells[1].Value);
                frmTTDichVu.DonViTinh = Convert.ToString(dtgDichvu.Rows[row].Cells[2].Value);
                frmTTDichVu.Gia = Convert.ToInt32(dtgDichvu.Rows[row].Cells[3].Value);
                frmTTDichVu.Show();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dtgDichvu.CurrentCell.RowIndex;

                string MaDV = dtgDichvu.Rows[row].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc chắn xóa user này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    dbDichvu.XoaDV(MaDV, ref err);

                    ClearDSDV();
                    LoadData();

                    MessageBox.Show("Đã xóa xong!");
                }
                else
                    MessageBox.Show("Không thực hiện thao tác xóa user!");
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }

            ClearDSDV();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnXoaDangkyDV.Visible = false;

                BLDichVu bLDichVu = new BLDichVu();
                dtDV = new DataTable();
                dtDV = dbDichvu.LayDanhSachDV();
                string MaDV = dtDV.Rows[cbbLoaiDV.SelectedIndex]["MaDichVu"].ToString();
                string MaPhong = this.cbbDSPhong.Text;
                bLDichVu.ThemDV_Phong(this.cbbDSPhong.Text, MaDV, int.Parse(this.numSoluong.Value.ToString()), float.Parse(this.txtTongtien.Text));

                
                ClearDSDV();
                LoadDataHD(MaPhong);
                this.TongtienHoadonDV.Text = double.Parse(dbDichvu.TongTienDichVu(MaPhong).ToString()).ToString();
                this.cbbDSPhong.Text = MaPhong;
                double TongChiPhi = double.Parse(this.TongtienHoadonDV.Text);
                bLDichVu.HoaDonChiPhi(MaPhong, float.Parse(TongChiPhi.ToString()));
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Lỗi ! : Thông tin lỗi :"+ ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadData();
            ClearDSDV();

            this.btnXoaDangkyDV.Visible = false;
        }

        private void cbbDSPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnXoaDangkyDV.Visible = false;

            if (this.cbbDSPhong.SelectedItem == null)
                this.TongtienHoadonDV.Text = "0";
            else
            {
                try
                {
                    LoadDataHD(this.cbbDSPhong.Text);
                    this.TongtienHoadonDV.Text = double.Parse(dbDichvu.TongTienDichVu(this.cbbDSPhong.Text).ToString()).ToString();
                }
                catch { }
            }
        }

        private void dtgHoadonDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnXoaDangkyDV.Visible = true;
        }

        private void btnXoaDangkyDV_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dtgHoadonDV.CurrentCell.RowIndex;
                string TenLoaiDV = Convert.ToString(dtgHoadonDV.Rows[row].Cells[0].Value);

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc chắn xóa?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    dbDichvu.XoaDangkyDV(TenLoaiDV);
                    MessageBox.Show("Đã xóa xong!");
                    LoadDataHD(this.cbbDSPhong.Text);
                    this.TongtienHoadonDV.Text = double.Parse(dbDichvu.TongTienDichVu(this.cbbDSPhong.Text).ToString()).ToString();
                }
                else
                    MessageBox.Show("Không thực hiện thao tác xóa!");
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void dtgDichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

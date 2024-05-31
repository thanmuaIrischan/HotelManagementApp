using QUANLYKHACHSAN.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN.User_Control
{
    public partial class UserControlPhatsinh : System.Windows.Forms.UserControl
    {
        public UserControlPhatsinh()
        {
            InitializeComponent();
        }

        BLPhatSinh bLPhatsinh = new BLPhatSinh();
        DataTable dtPS = new DataTable();

        void Clear()
        {
            cbbDSPhong.SelectedItem = null;
            txtLoaiPhatsinh.Clear();
            txtLydo.Clear();
            txtTongchiphi.Clear();
        }

        void LoadComboBox()
        {
            try
            {
                BLDichVu dbDichvu = new BLDichVu();
                //this.cbbDSPhong.DataSource = dbDichvu.LayDanhSachPhongDKDV();
                this.cbbDSPhong.DisplayMember = "MaPhong";
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi!!!");
            }
        }

        void LoadDataHD(string MaPhong)
        {
            dtPS = new DataTable();
            dtPS = bLPhatsinh.LayDanhSachHD(MaPhong);
            dtgPhatsinh.DataSource = dtPS;
            dtgPhatsinh.AutoResizeColumns();
        }

        void LoadDSPhatSinh()
        {
            dtPS = new DataTable();
            dtPS = bLPhatsinh.DanhsachPhatsinh();
            dtgDSPhatsinh.DataSource = dtPS;
            dtgDSPhatsinh.AutoResizeColumns();
        }

        private void ControlPhatsinh_Load(object sender, EventArgs e)
        {
            try

            {
                this.dtgPhatsinh.Visible = false;
                LoadComboBox();
                Clear();
                LoadDSPhatSinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                dtPS = new DataTable();
                bool Them = bLPhatsinh.ThemPhatsinh(this.cbbDSPhong.Text, this.txtLoaiPhatsinh.Text, this.txtLydo.Text, float.Parse(this.txtTongchiphi.Text));
                string MaPhong = this.cbbDSPhong.Text;
                Clear();
                this.cbbDSPhong.Text = MaPhong;
                /*
                if (Them)
                    MessageBox.Show("Nhập thành công!");
                else
                    MessageBox.Show("Nhập thất bại!");
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void cbbDSPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbDSPhong.SelectedItem == null)
            {
                this.dtgPhatsinh.Visible = false;
            }    
            else
            {
                this.dtgPhatsinh.Visible = true;
                LoadDataHD(this.cbbDSPhong.Text);
                LoadDSPhatSinh();
            }
        }

        private void dtgDSPhatsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

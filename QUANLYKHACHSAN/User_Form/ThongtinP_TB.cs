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

namespace QUANLYKHACHSAN.User_Form
{
    public partial class ThongtinP_TB : Form
    {
        BLThietBi bLthietbi = new BLThietBi();
        public bool Them;
        public string MaPhong;
        public string MaThietBi;

        public ThongtinP_TB()
        {
            InitializeComponent();
        }

        void Clear()
        {
            this.cbbMaPhong.SelectedItem = null;
            this.cbbMaTB.SelectedItem = null;
            this.cbbMaLoaiTB.SelectedItem = null;
            this.cbbTenLoaiTB.SelectedItem = null;
            this.txtGiatien.Clear();
        }

        void LoadCombobox()
        {
            BLThietBi bLthietbi = new BLThietBi();
            cbbMaTB.DataSource = bLthietbi.DSTB();
            cbbMaTB.DisplayMember = "MaThietBi";

            cbbTenLoaiTB.DataSource = bLthietbi.LayDanhSachLoaiThietBi();
            cbbTenLoaiTB.DisplayMember = "TenLoaiThietBi";

            cbbMaLoaiTB.DataSource = bLthietbi.LayDanhSachLoaiThietBi();
            cbbMaLoaiTB.DisplayMember = "MaLoaiThietBi";

            BLPhong bLPhong = new BLPhong();
            cbbMaPhong.DataSource = bLPhong.LayDanhSachP();
            cbbMaPhong.DisplayMember = "MaPhong";
        }

        private void ThongtinP_TB_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            Clear();

            if (Them == false)
            {
                Clear();
                BLThietBi bLthietbi = new BLThietBi();
                DataTable dtThietBi = bLthietbi.ThongTinPTB(MaPhong, MaThietBi);
                this.cbbMaPhong.Text = dtThietBi.Rows[0]["MaPhong"].ToString();
                this.cbbMaTB.Text = dtThietBi.Rows[0]["MaThietBi"].ToString();
                this.cbbMaLoaiTB.Text = dtThietBi.Rows[0]["MaLoaiThietBi"].ToString();
                this.cbbTenLoaiTB.Text = dtThietBi.Rows[0]["TenLoaiThietBi"].ToString();
                this.txtGiatien.Text = dtThietBi.Rows[0]["Gia"].ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BLThietBi bLthietbi = new BLThietBi();
                bLthietbi.ThemPhong_ThietBi(this.cbbMaPhong.Text, this.cbbMaTB.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Thông tin: " + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                BLThietBi bLthietbi = new BLThietBi();
                bLthietbi.CapnhatPhong_ThietBi(this.cbbMaPhong.Text, this.cbbMaTB.Text, MaThietBi);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Thông tin: " + ex.Message);
            }
        }

        private void cbbMaTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbMaTB.SelectedItem == null)
            {
                this.cbbMaLoaiTB.Text = "";
                this.cbbTenLoaiTB.Text = "";
                this.txtGiatien.Text = "";
            }
            else
            {
                DataTable dtTB = new DataTable();
                dtTB = bLthietbi.LayDanhSachThietBi();
                this.cbbMaLoaiTB.Text = dtTB.Rows[cbbMaTB.SelectedIndex]["MaLoaiThietBi"].ToString();
                this.cbbTenLoaiTB.Text = dtTB.Rows[cbbMaTB.SelectedIndex]["TenLoaiThietBi"].ToString();
                this.txtGiatien.Text = dtTB.Rows[cbbMaTB.SelectedIndex]["Gia"].ToString();
            }
        }
    }
}

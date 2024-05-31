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
    public partial class ThongtinTB : Form
    {
        public string MaTB;
        public bool Them;

        public ThongtinTB()
        {
            InitializeComponent();
        }

        void Clear()
        {
            this.txtMaTB.Clear();
            this.cbbTenLoaiTB.SelectedItem = null;
        }

        void LoadCombobox()
        {
            BLThietBi bLthietbi = new BLThietBi();
            cbbTenLoaiTB.DataSource = bLthietbi.LayDanhSachLoaiThietBi();
            cbbTenLoaiTB.DisplayMember = "TenLoaiThietBi";
        }

        private void ThongtinTB_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            Clear();

            if (Them == false)
            {
                BLThietBi bLthietbi = new BLThietBi();
                DataTable dtThietBi = bLthietbi.ThongTinTB(MaTB);
                this.txtMaTB.Text = MaTB;
                this.cbbTenLoaiTB.Text = dtThietBi.Rows[0]["TenLoaiThietBi"].ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                BLThietBi bLthietbi = new BLThietBi();
                bLthietbi.CapnhatThietBi(this.txtMaTB.Text, this.cbbTenLoaiTB.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Thông tin: " + ex.Message);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BLThietBi bLthietbi = new BLThietBi();
                bLthietbi.ThemThietBi(this.txtMaTB.Text, this.cbbTenLoaiTB.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Thông tin: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

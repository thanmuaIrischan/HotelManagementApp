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
using QUANLYKHACHSAN.User_Form;

namespace QUANLYKHACHSAN
{
    public partial class ThongTinLoaiThietBi : Form
    {
        public bool Them;
        public string MaLoaiTB;

        public ThongTinLoaiThietBi()
        {
            InitializeComponent();
        }

        void Clear()
        {
            this.txtMaLoaiTB.Clear();
            this.txtTenLoaiTB.Clear();
            this.numSoluong.ResetText();
            this.txtGia.Clear();
        }

        private void ThongTinLoaiThietBi_Load(object sender, EventArgs e)
        {
            Clear();

            if (Them == false)
            {
                BLThietBi bLthietbi = new BLThietBi();
                DataTable dtThietBi = bLthietbi.ThongTinLoaiTB(MaLoaiTB);
                this.txtMaLoaiTB.Text = MaLoaiTB;
                this.txtTenLoaiTB.Text = dtThietBi.Rows[0]["TenLoaiThietBi"].ToString();
                this.numSoluong.Value = int.Parse(dtThietBi.Rows[0]["SoLuong"].ToString());
                this.txtGia.Text = dtThietBi.Rows[0]["Gia"].ToString();
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
                bLthietbi.ThemLoaiThietBi(this.txtMaLoaiTB.Text, this.txtTenLoaiTB.Text, int.Parse(this.numSoluong.Value.ToString()), float.Parse(this.txtGia.Text));
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
                bLthietbi.CapNhatLoaiThietBi(this.txtMaLoaiTB.Text, this.txtTenLoaiTB.Text, int.Parse(this.numSoluong.Value.ToString()), float.Parse(this.txtGia.Text));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Thông tin: " + ex.Message);
            }
        }
    }
}

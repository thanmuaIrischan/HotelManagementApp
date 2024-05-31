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
    public partial class ThongtinDV : Form
    {
        public ThongtinDV()
        {
            InitializeComponent();
        }

        BLDichVu dbDichvu = new BLDichVu();
        string err;
        public bool Them = true;
        public string MaDV;
        public string TenDV;
        public string DonViTinh;
        public float Gia;

        void LoadData()
        {
            this.txtMaDV.Text = MaDV;
            this.txtTenDV.Text = TenDV;
            this.txtDonvi.Text = DonViTinh;
            this.txtGiatienDV.Text = Gia.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
                BLDichVu bLDichVu = new BLDichVu();
                if (Them == true)
                {
                    try
                    {
                         bLDichVu.ThemDV(this.txtMaDV.Text, this.txtTenDV.Text, this.txtDonvi.Text, float.Parse(this.txtGiatienDV.Text), ref err);
                    }
                    catch(Exception ex)
                    {
                         MessageBox.Show("Lỗi ! - Thông tin lỗi :" + ex.Message);
                    }    
                }
                else
                {
                    try
                    {
                         bLDichVu.CapNhatDV(this.txtMaDV.Text, this.txtTenDV.Text, this.txtDonvi.Text, float.Parse(this.txtGiatienDV.Text));
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Lỗi ! - Thông tin lỗi :" + ex.Message);
                    }
                }
                this.Close();
            
        }

        private void ThongtinDV_Load(object sender, EventArgs e)
        {
            if (Them == false)
            {
                LoadData();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

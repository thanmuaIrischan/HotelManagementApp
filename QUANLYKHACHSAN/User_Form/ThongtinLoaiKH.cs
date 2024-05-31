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
    public partial class ThongtinLoaiKH : Form
    {
        BLKhachHang blKH = new BLKhachHang();
        public string MaLoaiKH;
        public bool Them;

        public ThongtinLoaiKH()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                BLKhachHang blKH = new BLKhachHang();
                if (Them)
                {
                    try
                    {

                        blKH.ThemLoaiKH(txtLoaiKH.Text, txtTenLoaiKH.Text);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi : thông tin lỗi :" + ex.Message);
                    }
                    /*
                    if (Them)
                    {
                        MessageBox.Show("Thêm thành công!", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    */
                }
                else
                {
                    try
                    {
                        blKH.CapnhatLoaiKH(txtLoaiKH.Text, txtTenLoaiKH.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi : thông tin lỗi :" + ex.Message);
                    }
                    /*
                    if (update)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                    */
                }
                this.Close();
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongtinLoaiKH_Load(object sender, EventArgs e)
        {
            if (Them == false)
            {
                DataTable dtThongtinLoaiKH = blKH.LayThongTinLoaiKH(MaLoaiKH);
                this.txtLoaiKH.Text = dtThongtinLoaiKH.Rows[0]["LoaiKH"].ToString();
                this.txtTenLoaiKH.Text = dtThongtinLoaiKH.Rows[0]["TenLoaiKH"].ToString();
            }   
        }
    }
}

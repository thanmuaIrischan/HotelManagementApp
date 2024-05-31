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
using QUANLYKHACHSAN.DB_Layer;

namespace QUANLYKHACHSAN.User_Form
{
    public partial class LoaiPhong : Form
    {
        public LoaiPhong()
        {
            InitializeComponent();
        }

        DBMain db = new DBMain();

        public bool Them;
        public string MaLoaiPhong;
        public string TenLoaiPhong;
        public int SoLuong;
        public float GiaPhong;
        public int Songuoiotoida;

        void Clear()
        {
            this.txtMaLP.Clear();
            this.txtTenLP.Clear();
            this.numSoluongphong.ResetText();
            this.txtGiaphong.Clear();
        }

        private void LoaiPhong_Load(object sender, EventArgs e)
        {
            if (Them)
                Clear();
            else
            {
                this.txtMaLP.Text = MaLoaiPhong.ToString();
                this.txtTenLP.Text = TenLoaiPhong.ToString();
                this.numSoluongphong.Value = Convert.ToDecimal(SoLuong);
                this.txtGiaphong.Text = GiaPhong.ToString();
                this.numSonguoitoida.Value = Convert.ToDecimal(Songuoiotoida);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // delay this function //////-> due to lose way to add  //
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string MaLP = txtMaLP.Text;
                string TenLP = txtTenLP.Text;
                int SoLuong = Convert.ToInt16(numSoluongphong.Value);
                float GiaPhong = float.Parse(txtGiaphong.Text);
                int Songuoitoida = Convert.ToUInt16(numSonguoitoida.Value);
                BLPhong phong = new BLPhong();

                if (string.IsNullOrEmpty(MaLP))
                {
                    MessageBox.Show("Vui lòng điền giá trị!");
                    return;
                }
                if (Them)
                {
                    try
                    {
                        phong.ThemLoaiPhong(MaLP, TenLP, SoLuong, GiaPhong, Songuoitoida);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ! Thông tin lỗi : " + ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        phong.SuaLoaiPhong(MaLP, TenLP, SoLuong, GiaPhong, Songuoitoida);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ! Thông tin lỗi : " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                     MessageBox.Show("Lỗi ! Thông tin lỗi : " + ex.Message);
            }
        }

        }
    }

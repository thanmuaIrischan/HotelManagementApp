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
    public partial class Phong : Form
    {
        public Phong()
        {
            InitializeComponent();
        }

        DBMain db = new DBMain();
        BLPhong dbPhong = new BLPhong();
        public bool Them;
        public string MaPhong;
        public string LoaiPhong;
        public string Trangthai;

        void Clear()
        {
            this.txtMaphong.Clear();
            this.txtMaLP.Clear();
            this.cbbTrangThai.SelectedItem = null;
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            if (Them)
                Clear();
            else
            {
                this.txtMaphong.Text = MaPhong.ToString();
                this.txtMaLP.Text = LoaiPhong.ToString();
                this.cbbTrangThai.Text = Trangthai.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
                string MaP = txtMaphong.Text;
                string MaLP = txtMaLP.Text;
                BLPhong phong = new BLPhong();
            
                if (string.IsNullOrEmpty(MaP))
                {
                    MessageBox.Show("Vui lòng điền giá trị!");
                    return;
                }
            
                if (Them)
                {
                try
                {
                    
                    //BLPhong bLPhong = new BLPhong();
                    //bLPhong.ThemPhong(this.txtMaphong.Text, this.txtMaLP.Text);
                    
                    bool ThemP = dbPhong.ThemPhong(txtMaphong.Text, txtMaLP.Text);
                    
                    if (ThemP)
                    {
                        MessageBox.Show("Thêm thành công!", "Thêm Phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thêm Phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ! - thông tin lỗi : " + ex.Message);
                }
                    
                }
                else
                {
                    try
                    {

                        dbPhong.CapnhatP(txtMaphong.Text, dbPhong.LayMaLoaiPhong(txtMaLP.Text), cbbTrangThai.Text);
                        this.Close();
                    }
                     catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra! Thông tin: " + ex.Message);
                    }

            }
            }
           
        }
    }


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
using QUANLYKHACHSAN.User_Form;

namespace QUANLYKHACHSAN.User_Control
{
    public partial class UserControlKhachhang : System.Windows.Forms.UserControl
    {
        public UserControlKhachhang()
        {
            InitializeComponent();
        }

        BLKhachHang dbKH = new BLKhachHang();

        void LoadDSKH()
        {
            DataTable dtKH = dbKH.LayDanhSachKH();
            dtgKhachhang.DataSource = dtKH;
            dtgKhachhang.AutoResizeColumns();
        }

        void LoadDSKHDatTruoc()
        {
            DataTable dtKHDatTruoc = dbKH.LayDanhSachKHDatTruoc();
            dtgKhachhang.DataSource = dtKHDatTruoc;
            dtgKhachhang.AutoResizeColumns();
        }

        void LoadDSKHDangThue()
        {
            DataTable dtKHDangThue = dbKH.LayDanhSachKHDangThue();
            dtgKhachhang.DataSource = dtKHDangThue;
            dtgKhachhang.AutoResizeColumns();
        }

        public void LoadLoaiKH()
        {
            DataTable dtLoaiKH = dbKH.LayDanhSachLoaiKH();
            dtgLoaiKH.DataSource = dtLoaiKH;
            dtgLoaiKH.AutoResizeColumns();
        }

        private void UserControlKhachhang_Load(object sender, EventArgs e)
        {
            gboxTimkiem.Visible = false;
            LoadDSKH();
            LoadLoaiKH();
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            gboxTimkiem.Visible = false;
            LoadDSKH();
        }

        private void btnXemDSDangthue_Click(object sender, EventArgs e)
        {
            gboxTimkiem.Visible = false;
            LoadDSKHDangThue();
        }

        private void btnDSDattruoc_Click(object sender, EventArgs e)
        {
            gboxTimkiem.Visible = false;
            LoadDSKHDatTruoc();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            gboxTimkiem.Visible = true;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            gboxTimkiem.Visible = false;

            int row = dtgKhachhang.CurrentCell.RowIndex;
            string MaKH = Convert.ToString(dtgKhachhang.Rows[row].Cells[0].Value);
            ThongtinKH frmThongtinKH = new ThongtinKH();
            frmThongtinKH.MaKH = MaKH;
            frmThongtinKH.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            gboxTimkiem.Visible = false;

            int row = dtgKhachhang.CurrentCell.RowIndex;
            bool Xoa = dbKH.XoaKH(Convert.ToString(dtgKhachhang.Rows[row].Cells[0].Value));
            if (Xoa)
            {
                MessageBox.Show("Xóa thành công!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDSKH();
        }

        private void txtTimkiem_KeyUp(object sender, KeyEventArgs e)
        {
            dtgKhachhang.DataSource = dbKH.TimkiemKH(txtTimkiem.Text);
        }

        private void btnThemLoaiKH_Click(object sender, EventArgs e)
        {
            ThongtinLoaiKH frmThongtinLoaiKH = new ThongtinLoaiKH();
            frmThongtinLoaiKH.Them = true;
            frmThongtinLoaiKH.Show();
        }

        private void btnCapnhatKH_Click(object sender, EventArgs e)
        {
            int row = dtgLoaiKH.CurrentCell.RowIndex;
            string MaLoaiKH = Convert.ToString(dtgLoaiKH.Rows[row].Cells[0].Value);
            ThongtinLoaiKH frmThongtinLoaiKH = new ThongtinLoaiKH();
            frmThongtinLoaiKH.Them = false;
            frmThongtinLoaiKH.MaLoaiKH = MaLoaiKH;
            frmThongtinLoaiKH.Show();
        }

        private void btnXoaLoaiKH_Click(object sender, EventArgs e)
        {
            gboxTimkiem.Visible = false;

            int row = dtgLoaiKH.CurrentCell.RowIndex;
            bool Xoa = dbKH.XoaLoaiKH(Convert.ToString(dtgLoaiKH.Rows[row].Cells[0].Value));
            if (Xoa)
            {
                MessageBox.Show("Xóa thành công!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadLoaiKH();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDSKH();
            LoadLoaiKH();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

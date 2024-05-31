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
    public partial class UserControlPhong : UserControl
    {
        //System.Windows.Forms.
        public UserControlPhong()
        {
            InitializeComponent();
        }

        BLPhong dbPhong = new BLPhong();
        string err;

        void LoadData()
        {
            // Tạo DataTable cho dữ liệu phòng
            DataTable dtPhong = dbPhong.LayDanhSachP();
            dtgPhong.DataSource = dtPhong;
            dtgPhong.AutoResizeColumns();

            // Tạo DataTable cho dữ liệu loại phòng
            DataTable dtLoaiPhong = dbPhong.LayDanhSachLP();
            dtgLoaiphong.DataSource = dtLoaiPhong;
            dtgLoaiphong.AutoResizeColumns();

            DataTable dtBG = dbPhong.LayDanhSachBangGia();
            dtgBanggia.DataSource = dtBG;
            dtgBanggia.AutoResizeColumns();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tabControlPhong.SelectedTab == tabPageDSPhong)
            {
                int row = dtgPhong.CurrentCell.RowIndex;
                Phong frmPhong = new Phong();
                frmPhong.Them = false;
                frmPhong.MaPhong = Convert.ToString(dtgPhong.Rows[row].Cells[0].Value);
                frmPhong.LoaiPhong = Convert.ToString(dtgPhong.Rows[row].Cells[1].Value);
                frmPhong.Trangthai = Convert.ToString(dtgPhong.Rows[row].Cells[2].Value);
                frmPhong.ShowDialog();
                LoadData();
            }

            if (tabControlPhong.SelectedTab == tabPageLoaiphong)
            {
                int row = dtgLoaiphong.CurrentCell.RowIndex;

                LoaiPhong frmLPhong = new LoaiPhong();
                frmLPhong.Them = false;
                frmLPhong.MaLoaiPhong = Convert.ToString(dtgLoaiphong.Rows[row].Cells[0].Value);
                frmLPhong.TenLoaiPhong = Convert.ToString(dtgLoaiphong.Rows[row].Cells[1].Value);
                frmLPhong.SoLuong = Convert.ToInt32(dtgLoaiphong.Rows[row].Cells[2].Value);
                frmLPhong.GiaPhong = float.Parse(dtgLoaiphong.Rows[row].Cells[3].Value.ToString());
                frmLPhong.Songuoiotoida = Convert.ToInt32(dtgLoaiphong.Rows[row].Cells[4].Value);
                frmLPhong.ShowDialog();
                LoadData();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tabControlPhong.SelectedTab == tabPageDSPhong)
            {
                Phong frmPhong = new Phong();
                frmPhong.Them = true;
                frmPhong.ShowDialog();
                LoadData();
            }

            if (tabControlPhong.SelectedTab == tabPageLoaiphong)
            {
                LoaiPhong frmLPhong = new LoaiPhong();
                frmLPhong.Them = true;
                frmLPhong.ShowDialog();
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tabControlPhong.SelectedTab == tabPageDSPhong)
            {
                this.btnSua.Enabled = true;
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                int row = dtgPhong.CurrentCell.RowIndex;
                bool Xoa = dbPhong.XoaP(Convert.ToString(dtgPhong.Rows[row].Cells[1].Value), ref err);
                if (Xoa)
                {
                    MessageBox.Show("Xóa phòng thành công!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa phòng thất bại!", "Xóa", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }

            if (tabControlPhong.SelectedTab == tabPageLoaiphong)
            {
                this.btnSua.Enabled = true;
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                int row = dtgLoaiphong.CurrentCell.RowIndex;
                bool Xoa = dbPhong.XoaLP(Convert.ToString(dtgLoaiphong.Rows[row].Cells[0].Value), ref err);
                if (Xoa)
                {
                    MessageBox.Show("Xóa loại phòng thành công!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa loại phòng thất bại!", "Xóa", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            else
            {
                this.btnSua.Enabled = false;
                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
            }
        }

        private void UserControlPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

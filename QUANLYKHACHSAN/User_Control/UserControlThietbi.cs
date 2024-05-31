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
    public partial class UserControlThietbi : System.Windows.Forms.UserControl
    {
        bool TimTB;

        public UserControlThietbi()
        {
            InitializeComponent();
        }

        BLThietBi dbThietbi = new BLThietBi();
        BLThietBi dbphong_thietbi = new BLThietBi();

        bool visiable;

        void Visiable()
        {
            if (visiable == true)
            {
                this.dtgThietbi.Visible = true;
                this.btnTimkiemThietbi.Visible = true;
                this.btnThemThietbi.Visible = true;
                this.btnCapnhatThietbi.Visible = true;
                this.btnXoaThietbi.Visible = true;

                this.dtgLoaiThietbi.Visible = false;
                this.btnTimkiemLoaiTB.Visible = false;
                this.btnThemLoaiTB.Visible = false;
                this.btnCapnhatLoaiTB.Visible = false;
                this.btnXoaLoaiTB.Visible = false;
            }
            else
            {
                this.dtgThietbi.Visible = false;
                this.btnTimkiemThietbi.Visible = false;
                this.btnThemThietbi.Visible = false;
                this.btnCapnhatThietbi.Visible = false;
                this.btnXoaThietbi.Visible = false;

                this.dtgLoaiThietbi.Visible = true;
                this.btnTimkiemLoaiTB.Visible = true;
                this.btnThemLoaiTB.Visible = true;
                this.btnCapnhatLoaiTB.Visible = true;
                this.btnXoaLoaiTB.Visible = true;
            }            
        }

        public void LoadDataThietBi()
        {
            DataTable dtThietbi = dbThietbi.LayDanhSachThietBi();
            dtgThietbi.DataSource = dtThietbi;
            dtgThietbi.AutoResizeColumns();
        }

        public void LoadDataLoaiThietBi()
        {
            DataTable dtThietbi = dbThietbi.LayDanhSachLoaiThietBi();
            dtgLoaiThietbi.DataSource = dtThietbi;
            dtgLoaiThietbi.AutoResizeColumns();
        }

        void LoadDataPhong_ThietBi()
        {
            DataTable dtphong_thietbi = dbphong_thietbi.LayDanhSachPhong_ThietBi();
            dtgPhong_Thietbi.DataSource = dtphong_thietbi;
            dtgPhong_Thietbi.AutoResizeColumns();
        }

        private void UserControlThietbi_Load(object sender, EventArgs e)
        {
            LoadDataThietBi();
            LoadDataLoaiThietBi();
            LoadDataPhong_ThietBi();
            this.dtgThietbi.Visible = false;
            this.dtgLoaiThietbi.Visible = false;
            this.gboxTimkiem.Visible = false;
            this.gboxTimkiemPTB.Visible = false;
        }

        private void btnThemThietbi_Click(object sender, EventArgs e)
        {
            this.gboxTimkiem.Visible = false;

            ThongtinTB formNhapThietBi = new ThongtinTB();
            formNhapThietBi.Them = true;
            formNhapThietBi.ShowDialog();
            LoadDataThietBi();
        }

        private void btnCapnhatThietbi_Click(object sender, EventArgs e)
        {
            this.gboxTimkiem.Visible = false;

            try
            {
                int row = dtgThietbi.CurrentCell.RowIndex;
                string MaTB = Convert.ToString(dtgThietbi.Rows[row].Cells[0].Value);
                string TenLoaiTB = Convert.ToString(dtgThietbi.Rows[row].Cells[2].Value);
                ThongtinTB thongtinTB = new ThongtinTB();
                thongtinTB.Them = false;
                thongtinTB.MaTB = MaTB;
                thongtinTB.ShowDialog();
                LoadDataThietBi();
            }
            catch
            {
                MessageBox.Show("Không cập nhập được do không tìm thấy thiết bị !");
            }
        }

        private void btnXoaThietbi_Click(object sender, EventArgs e)
        {
            this.gboxTimkiem.Visible = false;

            try
            {
                int row = dtgThietbi.CurrentCell.RowIndex;

                string MaTB = dtgThietbi.Rows[row].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc chắn xóa user này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    dbThietbi.XoaThietBi(MaTB);
                    LoadDataThietBi();

                    MessageBox.Show("Đã xóa xong!");
                }
                else
                    MessageBox.Show("Không thực hiện thao tác xóa user!");
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnTimkiemThietbi_Click(object sender, EventArgs e)
        {
            TimTB = true;
            this.gboxTimkiem.Visible = true;
        }

        private void txtTimThietBi_KeyUp(object sender, KeyEventArgs e)
        {
            if (TimTB == true)
                dtgThietbi.DataSource = dbThietbi.TimkiemTB(txtTimkiem.Text);
            else
                dtgLoaiThietbi.DataSource = dbThietbi.TimkiemLoaiTB(txtTimkiem.Text);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDSThietbi_Click(object sender, EventArgs e)
        {
            visiable = true;
            this.gboxTimkiem.Visible = false;
            LoadDataThietBi();
            Visiable();
        }

        private void btnDSLoaiThietbi_Click(object sender, EventArgs e)
        {
            visiable = false;
            this.gboxTimkiem.Visible = false;
            LoadDataLoaiThietBi();
            Visiable();
        }

        private void btnXoaLoaiTB_Click(object sender, EventArgs e)
        {
            this.gboxTimkiem.Visible = false;

            try
            {
                int row = dtgLoaiThietbi.CurrentCell.RowIndex;

                string MaLoaiTB = dtgLoaiThietbi.Rows[row].Cells[0].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc chắn xóa?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    dbThietbi.XoaLoaiThietBi(MaLoaiTB);
                    LoadDataLoaiThietBi();

                    MessageBox.Show("Đã xóa xong!");
                }
                else
                    MessageBox.Show("Không thực hiện thao tác xóa!");
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnThemLoaiTB_Click(object sender, EventArgs e)
        {
            this.gboxTimkiem.Visible = false;

            ThongTinLoaiThietBi formNhapLoaiThietBi = new ThongTinLoaiThietBi();
            formNhapLoaiThietBi.Them = true;
            formNhapLoaiThietBi.ShowDialog();
            LoadDataLoaiThietBi();
        }

        private void btnCapnhatLoaiTB_Click(object sender, EventArgs e)
        {
            this.gboxTimkiem.Visible = false;

            try
            {
                int row = dtgLoaiThietbi.CurrentCell.RowIndex;
                string MaLoaiTB = Convert.ToString(dtgLoaiThietbi.Rows[row].Cells[0].Value);
                ThongTinLoaiThietBi thongtinLoaiTB = new ThongTinLoaiThietBi();
                thongtinLoaiTB.Them = false;
                thongtinLoaiTB.MaLoaiTB = MaLoaiTB;
                thongtinLoaiTB.ShowDialog();
                LoadDataThietBi();
            }
            catch
            {
                MessageBox.Show("Không cập nhập được do không tìm thấy thiết bị !");
            }
        }

        private void btnTimkiemLoaiTB_Click(object sender, EventArgs e)
        {
            TimTB = false;
            this.gboxTimkiem.Visible = true;
        }

        private void btnTimTBtrongphong_Click(object sender, EventArgs e)
        {
            this.gboxTimkiemPTB.Visible = true;
        }

        private void btnThemTBvaophong_Click(object sender, EventArgs e)
        {
            this.gboxTimkiemPTB.Visible = false;
            ThongtinP_TB frmThongtinPTB = new ThongtinP_TB();
            frmThongtinPTB.Them = true;
            frmThongtinPTB.ShowDialog();
            LoadDataPhong_ThietBi();
        }

        private void btnCapnhatPhong_TB_Click(object sender, EventArgs e)
        {
            this.gboxTimkiemPTB.Visible = false;

            try
            {
                int row = dtgPhong_Thietbi.CurrentCell.RowIndex;
                string MaPhong = Convert.ToString(dtgPhong_Thietbi.Rows[row].Cells[0].Value);
                string MaTB = Convert.ToString(dtgPhong_Thietbi.Rows[row].Cells[1].Value);
                ThongtinP_TB frmThongtinPTB = new ThongtinP_TB();
                frmThongtinPTB.Them = false;
                frmThongtinPTB.MaPhong = MaPhong;
                frmThongtinPTB.MaThietBi = MaTB;
                frmThongtinPTB.ShowDialog();
                LoadDataPhong_ThietBi();
            }
            catch
            {
                MessageBox.Show("Không cập nhập được do không tìm thấy thiết bị !");
            }
        }

        private void btnXoaTBkhoiphong_Click(object sender, EventArgs e)
        {
            this.gboxTimkiemPTB.Visible = false;

            try
            {
                int row = dtgPhong_Thietbi.CurrentCell.RowIndex;

                string MaTB = dtgPhong_Thietbi.Rows[row].Cells[1].Value.ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Chắc chắn xóa?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (traloi == DialogResult.Yes)
                {
                    dbThietbi.XoaPhong_ThietBi(MaTB);
                    LoadDataPhong_ThietBi();

                    MessageBox.Show("Đã xóa xong!");
                }
                else
                    MessageBox.Show("Không thực hiện thao tác xóa!");
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void txtTimkiemPTB_KeyUp(object sender, KeyEventArgs e)
        {
            dtgPhong_Thietbi.DataSource = dbThietbi.TimkiemPTB(this.txtTimkiemPTB.Text);
        }

        private void dtgLoaiThietbi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

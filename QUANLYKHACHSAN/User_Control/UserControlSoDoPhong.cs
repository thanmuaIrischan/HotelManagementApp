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
    public partial class UserControlSoDoPhong : System.Windows.Forms.UserControl
    {
        public UserControlSoDoPhong()
        {
            InitializeComponent();
            tabControlPhong.SelectedIndexChanged += new EventHandler(tabControlPhong_SelectedIndexChanged);
        }

        TableLayoutPanel tbpnl = new TableLayoutPanel();
        BLPhong dbPhong = new BLPhong();
        DataTable dtPhong = null;
        DataTable dtSoDoPhong = null;
        string Maphong;
        public string txtmaphong;
        BLHoaDon hoadon = new BLHoaDon();
        void LoadData()
        {
            dtPhong = new DataTable();
            dtPhong.Clear();
            dtPhong = dbPhong.DanhSachDatPhong();
            dtgDSDatphong.DataSource = dtPhong;
            dtgDSDatphong.AutoResizeColumns();

            dtPhong = new DataTable();
            dtPhong.Clear();
            dtPhong = dbPhong.DanhSachDangThue();
            dtgDangThue.DataSource = dtPhong;
            dtgDangThue.AutoResizeColumns();

            dtSoDoPhong = new DataTable();
            dtSoDoPhong.Clear();
            dtSoDoPhong = dbPhong.DanhSachTaoSoDoPhong();
            dataGridView1.DataSource = dtSoDoPhong;
            dataGridView1.AutoResizeColumns();
        }

        private void UserControlSoDoPhong_Load(object sender, EventArgs e)
        {
            LoadData();
            tbpnl = new TableLayoutPanel(); 
            tbpnl.Dock = DockStyle.Fill;
            TaoSoDoPhong();
            tabControlPhong.SelectedTab = tabPageSodophong;
        }

        public void TaoSoDoPhong()
        {
            dtSoDoPhong = new DataTable();
            dtSoDoPhong.Clear();
            dtSoDoPhong = dbPhong.DanhSachTaoSoDoPhong();

            int maxtang = 0;
            for (int t = 0; t < dtSoDoPhong.Rows.Count; t++)
            {
                int tang = Convert.ToInt32(dtSoDoPhong.Rows[t]["Tang"]);
                if (tang > maxtang)
                    maxtang = tang;
            }

            int i, j;
            tbpnl.Location = new Point(0, 0);
            tbpnl.Size = new Size(pnlSodo.Width +250 , pnlSodo.Height);
          
            tbpnl.MaximumSize = new Size(pnlSodo.Width + 250 , pnlSodo.Height *3 - pnlSodo.Height / 3);
            tbpnl.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            tbpnl.AutoScroll = true;
            tbpnl.ColumnCount = 6;
            tbpnl.RowCount = 0;
            pnlSodo.Controls.Add(tbpnl);

            tbpnl.ColumnStyles.Clear();
            for (i = 0; i < 6; i++)
            {
                tbpnl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, (float)(tbpnl.MaximumSize.Width - 2 * SystemInformation.VerticalScrollBarWidth) / 6));
            }

            tbpnl.RowStyles.Clear();
            for (i = 0; i < maxtang; i++)
            {
                tbpnl.RowStyles.Add(new RowStyle(SizeType.Absolute, (float)tbpnl.MaximumSize.Height / maxtang));
            }

            for (i = 0; i < maxtang; i++)
            {
                tbpnl.RowCount++;
                for (j = 0; j < 6; j++)
                {
                    if (j == 0)
                    {
                        Panel Tang = new Panel();
                        Tang.BackColor = Color.White;
                        Tang.Dock = DockStyle.Fill;
                        Label lblTang = new Label();
                        lblTang.Text = "Tầng " + (i + 1);
                        lblTang.Font = new Font("Verdana", 10, FontStyle.Bold);
                        lblTang.Anchor = (AnchorStyles.Left & AnchorStyles.Right);
                        lblTang.AutoSize = false;
                        lblTang.TextAlign = ContentAlignment.MiddleCenter;
                        lblTang.Location = new Point((Tang.Size.Width - lblTang.Size.Width) / 2, (Tang.Size.Height - lblTang.Size.Height) / 2);
                        lblTang.ForeColor = Color.DarkCyan;
                        Tang.Controls.Add(lblTang);
                        tbpnl.Controls.Add(Tang, j, i);
                    }
                    else
                    {
                        Panel panel = new Panel();
                        panel.BackColor = Color.LightGray;
                        panel.Dock = DockStyle.Fill;

                        Label lblPhong = new Label();
                        lblPhong.Text = (i + 1) + "0" + (j);
                        lblPhong.Font = new Font("Verdana", 15, FontStyle.Bold);
                        lblPhong.Anchor = (AnchorStyles.Left & AnchorStyles.Right);
                        lblPhong.AutoSize = false;
                        lblPhong.Location = new Point((panel.Size.Width - lblPhong.Size.Width) / 2, 10);
                        lblPhong.TextAlign = ContentAlignment.MiddleCenter;
                        lblPhong.ForeColor = Color.White;
                        panel.Controls.Add(lblPhong);

                        int x;
                        string Sophong;
                        for (x = 0; x < dtSoDoPhong.Rows.Count; x++)
                        {
                            Maphong = dtSoDoPhong.Rows[x]["MaPhong"].ToString();
                            Sophong = Maphong.Substring(Maphong.Length - 4, 3);
                            
                            if (lblPhong.Text == Sophong)
                            {
                                Label lblLoaiPhong = new Label();
                                lblLoaiPhong.Text = dtSoDoPhong.Rows[x]["TenLoaiPhong"].ToString();
                                lblLoaiPhong.Font = new Font("Verdana", 10);
                                lblLoaiPhong.Location = new Point(10, lblPhong.Height + 20);
                                lblLoaiPhong.AutoSize = true;
                                panel.Controls.Add(lblLoaiPhong);

                                if (dtSoDoPhong.Rows[x]["TrangThai"].ToString() == "DangThue")
                                    panel.BackColor = Color.DimGray;
                                if (dtSoDoPhong.Rows[x]["TrangThai"].ToString() == "DaDatTruoc")
                                    panel.BackColor = Color.Brown;
                                if (dtSoDoPhong.Rows[x]["TrangThai"].ToString() == "Trong")
                                    panel.BackColor = Color.MediumSeaGreen;

                                panel.Tag = Maphong;
                                panel.ContextMenuStrip = CreateContextMenu();
                            }
                        }
                        tbpnl.Controls.Add(panel, j, i);
                    }
                }
            }
        }

        private ContextMenuStrip CreateContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            ToolStripMenuItem Datphong = new ToolStripMenuItem("Đặt phòng");
            ToolStripMenuItem Nhanphong = new ToolStripMenuItem("Nhận phòng");
            ToolStripMenuItem Traphong = new ToolStripMenuItem("Trả phòng");

            contextMenu.Items.Add(Datphong);
            contextMenu.Items.Add(Nhanphong);
            contextMenu.Items.Add(Traphong);

            Datphong.Click += Datphong_Click;
            Nhanphong.Click += Nhanphong_Click;
            Traphong.Click += Traphong_Click;

            return contextMenu;
        }

        public void Datphong_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                if (menuItem.Owner is ContextMenuStrip contextMenu)
                {
                    Control sourceControl = contextMenu.SourceControl;
                    if (sourceControl is Panel clickedPanel)
                        txtmaphong = clickedPanel.Tag?.ToString();
                }
            }
            DatPhong frmDatPhong = new DatPhong();
            frmDatPhong.MaPhong = txtmaphong;
            frmDatPhong.Show();

            LoadData();
            tbpnl = new TableLayoutPanel();
            TaoSoDoPhong();
            tabControlPhong.SelectedTab = tabPageSodophong;
        }

        public void Traphong_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                if (menuItem.Owner is ContextMenuStrip contextMenu)
                {
                    Control sourceControl = contextMenu.SourceControl;
                    if (sourceControl is Panel clickedPanel)
                        txtmaphong = clickedPanel.Tag?.ToString();
                }
            }
            TraPhong frmTraphong = new TraPhong();
            frmTraphong.MaPhong = txtmaphong;
            HoaDon hoa = new HoaDon(txtmaphong);
            
            hoadon.ThemChiTietHoaDon(txtmaphong);
            frmTraphong.Show();
        }

        public void Nhanphong_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                if (menuItem.Owner is ContextMenuStrip contextMenu)
                {
                    Control sourceControl = contextMenu.SourceControl;
                    if (sourceControl is Panel clickedPanel)
                        txtmaphong = clickedPanel.Tag?.ToString();
                }
            }
            bool nhanphong = dbPhong.CapNhatTrangThaiPhong(txtmaphong, "DangThue");
            if (nhanphong)
            {
                MessageBox.Show("Nhan TC");
            }
            else
            {
                MessageBox.Show("NhanTB");
            }
        }

        private void tabControlPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPhong.SelectedTab == tabPageSodophong)
            {
                pnlChuthich.Visible = true;
                btnReload.Visible = true;
            }
            else
            {
                pnlChuthich.Visible = false;
                btnReload.Visible = false;
            }
            if (tabControlPhong.SelectedTab == tabPageDanhsachDatphongtruoc)
            {
                this.btnNhanphong.Enabled = true;
                this.btnTraphong.Enabled = false;
                this.btnHuydat.Enabled = true;
            }
            if (tabControlPhong.SelectedTab == tabPageDanhsachDangthuephong)
            {
                this.btnNhanphong.Enabled = false;
                this.btnTraphong.Enabled = true;
                this.btnHuydat.Enabled = false;
            }
        }

        private void btnNhanphong_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is ToolStripMenuItem menuItem)
                {
                    if (menuItem.Owner is ContextMenuStrip contextMenu)
                    {
                        Control sourceControl = contextMenu.SourceControl;
                        if (sourceControl is Panel clickedPanel)
                            txtmaphong = clickedPanel.Tag?.ToString();
                    }
                }
                bool nhanphong = dbPhong.CapNhatTrangThaiPhong(txtmaphong, "DangThue");
                if (nhanphong)
                {
                    MessageBox.Show("Nhan TC");
                }
                else
                {
                    MessageBox.Show("NhanTB");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ! - Thông tin lỗi :" + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
                SuaDatPhong suadatphong = new SuaDatPhong();
                if (tabControlPhong.SelectedTab == tabPageDanhsachDatphongtruoc)
                {
                    int row = dtgDSDatphong.CurrentCell.RowIndex;
                    suadatphong.Makh = dtgDSDatphong.Rows[row].Cells[0].Value.ToString();
                }
                if (tabControlPhong.SelectedTab == tabPageDanhsachDangthuephong)
                {
                    int row = dtgDangThue.CurrentCell.RowIndex;
                    suadatphong.Makh = dtgDangThue.Rows[row].Cells[0].Value.ToString();
                }
                suadatphong.ShowDialog();
            
        }

        private void btnHuydat_Click(object sender, EventArgs e)
        {
            string Makh;
            BLKhachHang dbKH = new BLKhachHang();
            if (tabControlPhong.SelectedTab == tabPageDanhsachDatphongtruoc)
            {
                int row = dtgDSDatphong.CurrentCell.RowIndex;
                Makh = dtgDSDatphong.Rows[row].Cells[0].Value.ToString();
                bool Xoa = dbKH.XoaKH(Convert.ToString(dtgDSDatphong.Rows[row].Cells[0].Value));
                if (Xoa)
                {
                    MessageBox.Show("Hủy đặt thành công!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hủy đặt thất bại!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (tabControlPhong.SelectedTab == tabPageDanhsachDangthuephong)
            {
                int row = dtgDangThue.CurrentCell.RowIndex;
                Makh = dtgDangThue.Rows[row].Cells[0].Value.ToString();
                bool Xoa = dbKH.XoaKH(Convert.ToString(dtgDangThue.Rows[row].Cells[0].Value));
                if (Xoa)
                {
                    MessageBox.Show("Hủy đặt thành công!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hủy đặt thất bại!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            tbpnl = new TableLayoutPanel();
            TaoSoDoPhong();
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            tbpnl = new TableLayoutPanel();
            TaoSoDoPhong();
            LoadData();
        }

        private void pnlSodo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

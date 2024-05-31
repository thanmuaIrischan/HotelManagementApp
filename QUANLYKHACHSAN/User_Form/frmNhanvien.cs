using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Collections;
using QUANLYKHACHSAN.DB_Layer;
using QUANLYKHACHSAN;

namespace QUANLYKHACHSAN.User_Form 
{
    public partial class frmNhanvien : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        public string ra = "";

        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            

            string maTK = "SELECT MaTK, TaiKhoan from vw_TaiKhoan";
            cbMaTK.DataSource = DBMain.Docdulieu(maTK);
            cbMaTK.DisplayMember = "TaiKhoan";
            cbMaTK.ValueMember = "MaTK";

            //Add giới tính

            cbGioitinh.Items.Add("Nam");
            cbGioitinh.Items.Add("Nu");
            this.cbGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //Add chức vụ
            string laymacv = "Select MaCV, TenCV From vw_ChucVu";
            cbChucvu.DataSource = DBMain.Docdulieu(laymacv);
            cbChucvu.ValueMember = "MaCV";
            cbChucvu.DisplayMember = "TenCV";

            this.cbChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //Format datetimepicked

            dtNgaysinh.Format = DateTimePickerFormat.Custom;
            dtNgaysinh.CustomFormat = "dd/MM/yyyy";

           ;

            //Format hiển thị time

            dtgShow2.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgShow2.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";

            dtgShow2.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgShow2.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            string chuoi = "SELECT * FROM vw_NhanVien";
            dtgShow2.DataSource = DBMain.Docdulieu(chuoi);
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            string chuoi = "Select * From vw_NhanVien";
            dtgShow2.DataSource = DBMain.Docdulieu(chuoi);
            resettext();
            tbManv.Enabled = true;
            btnAdd.Enabled = true;
            tbnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    

                    // Gọi thủ tục lưu trữ "ThemNhanVien" trên cơ sở dữ liệu
                    using (SqlConnection con = new SqlConnection(DBMain.chuoiketnoi()))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("ThemNhanVien", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = tbManv.Text;
                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = tbTennv.Text;
                        cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = cbGioitinh.Text;
                        cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtNgaysinh.Value;
                        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = tbDiachi.Text;
                        cmd.Parameters.Add("@Sdt", SqlDbType.VarChar).Value = tbSdt.Text;
                        cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = cbChucvu.SelectedValue;
                        cmd.Parameters.Add("@MaTK", SqlDbType.VarChar).Value = cbMaTK.SelectedValue;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");

                            string chuoi2 = "Select * From NhanVien";
                            dtgShow2.DataSource = DBMain.Docdulieu(chuoi2);

                            resettext();

                            btnEdit.Enabled = true;
                            tbnDelete.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Thông tin: " + ex.Message);
            }
        }

        private void resettext()
        {

            tbManv.ResetText();
            tbTennv.ResetText();
            cbGioitinh.ResetText();
            tbDiachi.ResetText();
            tbSdt.ResetText();
            cbChucvu.ResetText();
            cbMaTK.ResetText();
            
        }

        private void tbMucluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbMucluong_TextChanged(object sender, EventArgs e)
        {
           // dbmain.tiente(tbMucluong);
        }

        private void dtgShow2_DoubleClick(object sender, EventArgs e)
        {

            tbManv.Enabled = false;
            btnAdd.Enabled = false;
            tbnDelete.Enabled = false;
            btnEdit.Enabled = true;
            tbManv.Text = dtgShow2.CurrentRow.Cells[0].Value.ToString();
            tbTennv.Text = dtgShow2.CurrentRow.Cells[1].Value.ToString();
            cbGioitinh.Text = dtgShow2.CurrentRow.Cells[2].Value.ToString();
            dtNgaysinh.Text = dtgShow2.CurrentRow.Cells[3].Value.ToString();
            tbDiachi.Text = dtgShow2.CurrentRow.Cells[4].Value.ToString();
            tbSdt.Text = dtgShow2.CurrentRow.Cells[5].Value.ToString();
            cbChucvu.Text = dtgShow2.CurrentRow.Cells[6].Value.ToString();
            cbMaTK.Text = dtgShow2.CurrentRow.Cells[7].Value.ToString();

            string chuoi = "Select Quyen From NhanVien where MaNV='" + tbManv.Text + "'";
            //ra = truyxuat.laychuoi(chuoi, ra).Trim();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //int tuoi = dtNgaylam.Value.Year - dtNgaysinh.Value.Year;
                string sl = "Select * From NhanVien where MaNV='" + tbManv.Text + "'";
                string select = "Select * From NhanVien where MaTK='" + cbMaTK.SelectedValue + "' and MaNV='" + tbManv.Text + "'";

                {
                    DialogResult check = MessageBox.Show("Bạn có sửa thông tin nhân viên hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (check == DialogResult.OK)
                    {
                        
                        using (SqlConnection con = new SqlConnection(DBMain.chuoiketnoi()))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("SuaNhanVien", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = tbManv.Text;
                            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = tbTennv.Text;
                            cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = cbGioitinh.Text;
                            cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = dtNgaysinh.Value;
                            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = tbDiachi.Text;
                            cmd.Parameters.Add("@Sdt", SqlDbType.VarChar).Value = tbSdt.Text;
                            cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = cbChucvu.SelectedValue;
                            cmd.Parameters.Add("@MaTK", SqlDbType.VarChar).Value = cbMaTK.SelectedValue;
                            

                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Sửa nhân viên thành công!", "Thông báo");

                                string chuoi2 = "Select * From NhanVien";
                                dtgShow2.DataSource = DBMain.Docdulieu(chuoi2);
                                tbManv.Enabled = true;
                                btnAdd.Enabled = true;
                                tbnDelete.Enabled = true;
                                btnEdit.Enabled = true;
                                resettext();
                            }
                            else
                            {
                                MessageBox.Show("Sửa nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Thông tin: " + ex.Message);
            }
        }

        private void tbnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult check = MessageBox.Show("Bạn có xóa thông tin nhân viên hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (check == DialogResult.OK)
                {
                    string MaNVToDelete = dtgShow2.CurrentRow.Cells["MaNV"].Value.ToString();

                    using (SqlConnection con = new SqlConnection(DBMain.chuoiketnoi()))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("XoaNhanVien", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = MaNVToDelete;

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa Thông tin thành công!", "Thông báo");

                            string load = "Select * From NhanVien";
                            dtgShow2.DataSource = DBMain.Docdulieu(load);
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa thông tin chức vụ.", "Thông báo");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void tbTimten_TextChanged(object sender, EventArgs e)
        {
            /*
            string chuoi = tbTimten.Text;

            if (rbTimTheoTen.Checked)
            {
                TimTheoTen(chuoi);
            }
            else if (rbTimTheoQuyen.Checked)
            {
                TimTheoQuyen(chuoi);
            }
            else if (rbTimTheoChucVu.Checked)
            {
                TimTheoChucVu(chuoi);
            }
            else if (rbTimTheoMaNV.Checked)
            {
                TimTheoMaNV(chuoi);
            }
            else
            {
                // Handle the case when no search criteria is selected
                MessageBox.Show("Hãy chọn loại thông tin cần tim!");
            }
            */

        }
       

        private void tbManv_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            tbnDelete.Enabled = false;
        }

        private void tbMatkhau_Click(object sender, EventArgs e)
        {
            string sl1 = "Select * From NhanVien where MaTK='" + cbMaTK.SelectedValue + "'";
            
            if (DBMain.kiemtratext(sl1) == 1)
            {
                MessageBox.Show("Tên tài khoản đăng nhập này đã tồn tại! " + cbMaTK.SelectedValue, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaTK.ResetText();
                cbMaTK.Focus();
            }
            
        }

        private void btnXemMaCV_Click(object sender, EventArgs e)
        {
            frmChucVu fCV = new frmChucVu();
            fCV.ShowDialog();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            frmTaiKhoan fTK = new frmTaiKhoan();
            fTK.ShowDialog();
            string maTK = "SELECT MaTK, TaiKhoan from vw_TaiKhoan";
            cbMaTK.DataSource = DBMain.Docdulieu(maTK);
            cbMaTK.DisplayMember = "TaiKhoan";
            cbMaTK.ValueMember = "MaTK";
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtgShow2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

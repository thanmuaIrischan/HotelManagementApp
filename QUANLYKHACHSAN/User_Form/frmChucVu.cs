using QUANLYKHACHSAN.DB_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYKHACHSAN;
using System.Linq.Expressions;

namespace QUANLYKHACHSAN.User_Form
{
    public partial class frmChucVu : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        public string ra = "";
        public frmChucVu()
        {
            InitializeComponent();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            /*
            string query = "SELECT * FROM vw_ChucVu";
            dgvChucVu.DataSource = DBMain.Docdulieu(query);
            */
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                string chuoi = "exec LayChucVu";
                dgvChucVu.DataSource = DBMain.Docdulieu(chuoi);
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string select = "Select * From ChucVu where MaCV='" + txtMaCV.Text + "'";

                
                {
                    string MaCV = txtMaCV.Text;
                    string TenCV = txtTenCV.Text;
                    
                    SqlConnection con = new SqlConnection(DBMain.chuoiketnoi());
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ThemChucVu", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = MaCV;
                    cmd.Parameters.Add("@TenCV", SqlDbType.VarChar).Value = TenCV;
                   

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thêm chức vụ", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        con.Close();
                        txtMaCV.ResetText();
                        txtTenCV.ResetText();
                    
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thêm chức vụ", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        con.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Thông tin: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Bạn có xóa thông tin chức vụ hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (check == DialogResult.OK)
            {
                try
                {
                    string MaCVToDelete = dgvChucVu.CurrentRow.Cells["MaCV"].Value.ToString();



                    using (SqlConnection con = new SqlConnection(DBMain.chuoiketnoi()))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("XoaChucVu", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = MaCVToDelete;
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa Thông tin thành công!", "Thông báo");
                            string load = "Select * From ChucVu";
                            dgvChucVu.DataSource = DBMain.Docdulieu(load);
                        }
                    }
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa thông tin chức vụ.", "Thông báo");
                }
        }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           try 
            {
                DialogResult check = MessageBox.Show("Bạn có sửa thông tin chức vụ hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (check == DialogResult.OK)
                {
                    string MaCV = txtMaCV.Text;
                    string TenCV = txtTenCV.Text;
                    

                    SqlConnection con = new SqlConnection(DBMain.chuoiketnoi());
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SuaChucVu", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = MaCV;
                    cmd.Parameters.Add("@TenCV", SqlDbType.VarChar).Value = TenCV;
                   
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                        txtMaCV.ResetText();
                        txtTenCV.ResetText();
                        
                        con.Close();

                        txtMaCV.ResetText();
                        txtTenCV.ResetText();
                        

                        string load = "Select * From ChucVu";
                        dgvChucVu.DataSource = DBMain.Docdulieu(load);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể sửa thông tin chức vụ.", "Thông báo");
            }
        }

        private void dgvChucVu_DoubleClick(object sender, EventArgs e)
        {
            txtMaCV.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            txtMaCV.Text = dgvChucVu.CurrentRow.Cells[0].Value.ToString();
            txtTenCV.Text = dgvChucVu.CurrentRow.Cells[1].Value.ToString();
            //txtMucLuong.Text = dgvChucVu.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

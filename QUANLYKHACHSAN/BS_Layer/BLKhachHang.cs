using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using QUANLYKHACHSAN.DB_Layer;
using System.Windows.Forms;

namespace QUANLYKHACHSAN.BS_Layer
{
    public class BLKhachHang
    {
        DBMain db = null;
        public BLKhachHang()
        {
            db = new DBMain();
        }

        public DataTable LayDanhSachKH()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM V_dsKhachHang", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;            
        }

        public DataTable LayDanhSachLoaiKH()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAIKHACHHANG", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable LayDanhSachKHDangThue()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM V_dsKhachHangDangThue", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable LayDanhSachKHDatTruoc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM V_dsKhachHangDatTruoc", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable LayThongTinKH(string MaKH)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThongTinKhachHang(@MaKH)", db.getConnection);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable LayThongTinLoaiKH(string LoaiKH)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThongTinLoaiKH(@LoaiKH)", db.getConnection);
            cmd.Parameters.AddWithValue("@LoaiKH", LoaiKH);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public bool XoaKH(string MaKH)
        {
            SqlCommand command = new SqlCommand("proc_xoaKH", db.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKH", SqlDbType.NChar).Value = MaKH;
            db.openConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool XoaLoaiKH(string LoaiKH)
        {
            
         
                SqlCommand command = new SqlCommand("proc_xoaLoaiKH", db.getConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@LoaiKH", SqlDbType.NChar).Value = LoaiKH;
                db.openConnection();
                if (command.ExecuteNonQuery() > 0)
                {
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            
        }

        public bool CapnhatKH(string MaKH, string TenKH, string SDT, string QuocTich, string CCCD_Passport, string TenLoaiKH)
        {
            SqlCommand cmd = new SqlCommand("proc_CapnhatThongtinKH", db.getConnection);
            db.openConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = MaKH;
            cmd.Parameters.Add("@TenKH", SqlDbType.NChar).Value = TenKH;
            cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = SDT;
            cmd.Parameters.Add("@QuocTich", SqlDbType.NVarChar).Value = QuocTich;
            cmd.Parameters.Add("@CCCD_Passport", SqlDbType.NVarChar).Value = CCCD_Passport;
            cmd.Parameters.Add("@TenLoaiKH", SqlDbType.NVarChar).Value = TenLoaiKH;
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.closeConnection();
                return false;
            }
            
        }

        public bool CapnhatLoaiKH(string LoaiKH, string TenLoaiKH)
        {

            SqlCommand cmd = new SqlCommand("proc_CapnhatThongtinLoaiKH", db.getConnection);
            db.openConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@LoaiKH", SqlDbType.NChar).Value = LoaiKH;
            cmd.Parameters.Add("@TenLoaiKH", SqlDbType.NVarChar).Value = TenLoaiKH;
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Cập nhật loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Cập nhật loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.closeConnection();
                return false;
            }
        }

        public DataTable TimkiemKH(string SearchText)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM func_TimkiemKH(@SearchText)", db.getConnection);
            cmd.Parameters.AddWithValue("@SearchText", SearchText);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public bool ThemLoaiKH(string LoaiKH, string TenLoaiKH)
        {

            SqlCommand cmd = new SqlCommand("proc_ThemLoaiKH", db.getConnection);
            db.openConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@LoaiKH", SqlDbType.NChar).Value = LoaiKH;
            cmd.Parameters.Add("@TenLoaiKH", SqlDbType.NChar).Value = TenLoaiKH;
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm thành công!", "Thêm loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.closeConnection();
                return true;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thêm loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection();
                return false;
            }
        }
    }
}
